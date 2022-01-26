import cv2
import sys
import pickle
import pyodbc
import datetime
import PIL.Image
import PIL.ImageTk
import numpy as np
from mediapipe.python.solutions import face_detection
from hashlib import md5
from tkinter import *
from tkinter import messagebox as message
from tensorflow.keras.models import load_model

mahp = sys.argv[1]
tenhp = sys.argv[2]
magv = sys.argv[3]
date = sys.argv[4]
database = sys.argv[5] #'db_DDSV;'
server = sys.argv[6] #'DESKTOP-J3P25DG;'


class Camera:

    def __init__(self, mahp, tenhp, magv, date, database, server):
        self.faces = []
        self.list_insert = []
        self.mahp = mahp
        self.magv = magv
        self.camera = cv2.VideoCapture(0, cv2.CAP_DSHOW)
        self.connect_db(server, database)
        self.load_data_db()
        self.load_data_model()
        self.my_model = load_model('model.h5')
        self.win = Tk()
        self.construct_win()
        self.config_win(tenhp, date)
        self.update_frame()
        self.win.protocol("WM_DELETE_WINDOW", self.on_closing)
        self.win.mainloop()

    def on_closing(self):
        if message.askokcancel("Xác Nhận", "Xác nhận thoát\nDữ liệu điểm danh sẽ không được lưu vào CSDL?"):
            self.camera.release()
            cv2.destroyAllWindows()
            self.win.destroy()

    def construct_win(self):
        self.lb_title = Label(self.win)
        self.lb_message = Label(self.win)
        self.lb_dateTitle = Label(self.win)
        self.lb_date = Label(self.win)
        self.lb_timeTitle = Label(self.win)
        self.lb_time = Label(self.win)
        self.lb_sumData = Label(self.win)
        self.lb_countData = Label(self.win)
        self.lb_TenHP = Label(self.win)
        self.txt_TenHP = Text(self.win)
        self.btn_Accept = Button(self.win)
        self.btn_Summary = Button(self.win)
        self.can_Camera = Canvas(self.win)

    def connect_db(self, server, database):
        self.connectString = ''.join([
            "Driver={SQL Server Native Client 11.0};","Server=", server,
            "Database=", database, "Trusted_Connection=yes;"
        ])
        self.conn = pyodbc.connect(self.connectString, autocommit=True)

    def config_win(self, tenhp, date):
        self.config_text(date, tenhp)
        self.config_color()
        self.config_font()
        self.config_size()
        self.config_gird()
        self.config_command()
        self.update_date()
        self.txt_TenHP.configure(state=DISABLED)

    def config_color(self):
        self.win.configure(bg='Lavender')
        self.lb_title.configure(bg='Lavender', fg='MediumBlue')
        self.lb_message.configure(bg='Lavender', fg='Brown')
        self.lb_sumData.configure(bg='Lavender', fg='Brown')
        self.lb_countData.configure(bg='Lavender', fg='Brown')
        self.lb_dateTitle.configure(bg='Lavender', fg='Brown')
        self.lb_date.configure(bg='Lavender', fg='MediumBlue')
        self.lb_timeTitle.configure(bg='Lavender', fg='Brown')
        self.lb_time.configure(bg='Lavender', fg='MediumBlue')
        self.lb_TenHP.configure(bg='Lavender', fg='Brown')
        self.txt_TenHP.configure(bg='Lavender')
        self.btn_Accept.configure(fg='MediumBlue')
        self.btn_Summary.configure(fg='MediumBlue')

    def config_gird(self):
        self.lb_message.grid(row=0, columnspan=2, pady=5)
        self.can_Camera.grid(rowspan=22, columnspan=2, pady=5, sticky='NW')
        self.lb_sumData.grid(row=23, column=0)
        self.lb_countData.grid(row=23, column=1)
        self.lb_title.grid(row=2, column=2)
        self.lb_dateTitle.grid(row=3, column=2)
        self.lb_date.grid(row=4, column=2)
        self.lb_timeTitle.grid(row=6, column=2)
        self.lb_time.grid(row=7, column=2)
        self.lb_TenHP.grid(row=9, column=2)
        self.txt_TenHP.grid(row=10, column=2, padx=18)
        self.btn_Accept.grid(row=16, column=2)
        self.btn_Summary.grid(row=18, column=2)

    def config_command(self):
        self.btn_Accept.configure(command=self.btn_accept_click)
        self.btn_Summary.configure(command=self.btn_summary_click)

    def config_font(self):
        self.lb_title.configure(font=('Constantia', 28, 'bold'))
        self.lb_sumData.configure(font=('Consolas', 20, 'bold'))
        self.lb_countData.configure(font=('Consolas', 20, 'bold'))
        self.lb_dateTitle.configure(font=('Constantia', 13, 'bold'))
        self.lb_date.configure(font=('Consolas', 25, 'bold'))
        self.lb_timeTitle.configure(font=('Constantia', 13, 'bold'))
        self.lb_time.configure(font=('Consolas', 50, 'bold'))
        self.lb_TenHP.configure(font=('Constantia', 13, 'bold'))
        self.txt_TenHP.configure(font=('Constantia', 16), wrap=WORD)
        self.btn_Accept.configure(font=('Constantia', 20, 'bold'))
        self.btn_Summary.configure(font=('Constantia', 20, 'bold'))
        self.lb_message.configure(font=('Constantia', 13, 'italic'))

    def config_size(self):
        self.width = 1000
        self.height = 750
        self.win.geometry('1400x850+%d+%d'
                          %(self.win.winfo_screenwidth() / 2 - 700,
                            self.win.winfo_screenheight() / 2 - 425))
        self.txt_TenHP.configure(width=32, height=3)
        self.btn_Accept.configure(width=12, height=2)
        self.btn_Summary.configure(width=12, height=2)
        self.can_Camera.configure(width=self.width, height=self.height)

    def config_text(self, date, tenhp):
        self.win.title("Camera")
        self.lb_title.configure(text='Module\nĐiểm Danh Sinh Viên')
        self.lb_date.configure(text=date)
        self.lb_dateTitle.configure(text='Mở Điểm Danh Lúc:')
        self.lb_timeTitle.configure(text='Giờ Hiện Tại:')
        self.lb_TenHP.configure(text='Tên Học Phần:')
        self.btn_Accept.configure(text='Điểm Danh')
        self.btn_Summary.configure(text='Tổng Kết\nĐiểm Danh')
        self.lb_message.configure(text='Hãy Cho Gương Mặt Vào Khung Màu Xanh Để Nhận Diện')
        self.txt_TenHP.insert(END, tenhp)

    def load_data_db(self):
        self.classList = []
        self.listDD = []
        query = "SELECT col_MaSV FROM tab_DKHP WHERE col_MaHP = ?"
        cursor = self.conn.cursor()
        cursor.execute(query, self.mahp)
        result = cursor.fetchall()
        for item in result:
            self.classList.append(item[0])
            self.listDD.append(item[0])

    def load_data_model(self):
        with open('train112.data', 'rb') as file:
            (labels, pixles) = pickle.load(file)
            file.close()
        self.list_label = sorted(set(labels), key=labels.index)

    def btn_accept_click(self):
        masv = self.masv
        accurancy = self.accurancy
        now = datetime.datetime.now().strftime('%H:%M:%S')
        if accurancy < 80:
            message.showwarning("Lỗi", "Xin lỗi, Không nhận diện được")
        else:
            if masv not in self.classList:
                message.showwarning("Lỗi", "MSSV: {} Không Thuộc Lớp Này".format(masv))
            else:
                if masv in self.listDD:
                    data = (self.lb_date['text'], self.mahp, masv, 'Có Mặt', now)
                    self.listDD.remove(masv)
                    self.list_insert.append(data)
                    message.showinfo("Thành Công", "MSSV: {} Đã Điểm Danh Thành Công Lúc {}".format(masv, now))
                else:
                    message.showwarning("Lỗi", "MSSV: {} Đã Điểm Danh Rồi".format(masv))

    def btn_summary_click(self):
        if len(self.list_insert) == 0:
            result = message.askokcancel("Lỗi", "Không Có Sinh Viên Nào Được Điểm Danh\n"
                                                "Đồng Ý Thoát Phiên Điểm Danh Này")
            if result == 1:
                self.camera.release()
                cv2.destroyAllWindows()
                self.win.destroy()
        else:
            self.win2 = Tk()
            self.win2.title('Xác Nhận Mật Khẩu')
            self.win2.configure(bg='lavender')
            self.win2.geometry('350x170+%d+%d'
                               % (self.win2.winfo_screenwidth() / 2 - 175,
                                  self.win2.winfo_screenheight() / 2 - 75))

            self.lb_InputPass = Label(self.win2)
            self.lb_InputPass.configure(
                text='Nhập Mật Khẩu',
                font=('Constantia', 20, 'bold'),
                bg='lavender', fg= 'mediumblue')
            self.lb_InputPass.grid(row=0, column=0, pady=5)

            self.txt_inputPass = Entry(self.win2)
            self.txt_inputPass.configure(
                show='*', width=35, font=('Constantia', 13))
            self.txt_inputPass.grid(row=1, column=0, pady=5, padx=15)

            self.btn_Ok = Button(self.win2, width=15, height=2, text='Ok')
            self.btn_Ok.configure(
                font=('Constantia', 15, 'bold'),
                bg='lavender', fg='mediumblue',
                command=self.btn_ok_click)
            self.btn_Ok.grid(row=2, column=0, pady=5)

            self.win2.mainloop()

    def btn_ok_click(self):
        if self.txt_inputPass.get() == "":
            message.showwarning('Lỗi', 'Chưa Nhập Mật Khẩu')
            self.win2.destroy()
        else:
            decode = md5(self.txt_inputPass.get().encode('utf-8')).hexdigest()
            select = "SELECT * FROM tab_Login WHERE col_Password=? and col_User=?"
            cursor = self.conn.cursor()
            cursor.execute(select, (decode, self.magv))
            result = cursor.fetchall()
            if len(result) == 0:
                message.showwarning("Lỗi", "Sai Mật Khẩu")
                self.win2.destroy()
            else:
                try:
                    if len(self.listDD) > 0:
                        for item in self.listDD:
                            data = (self.lb_date['text'], self.mahp, item, 'Vắng', '')
                            self.list_insert.append(data)

                    insert = "INSERT INTO tab_DiemDanh VALUES(?,?,?,?,?)"
                    cursor.executemany(insert, self.list_insert)
                    message.showinfo("Thành Công", "Dữ Liệu Đã Được Lưu")
                    self.win2.destroy()
                    self.camera.release()
                    cv2.destroyAllWindows()
                    self.win.destroy()
                except:
                    message.showerror("Lỗi", "Xảy Ra Lỗi Trong Quá Trình Điểm Danh")
                    self.camera.release()
                    cv2.destroyAllWindows()
                    self.win2.destroy()

    def update_date(self):
        self.now = datetime.datetime.now()
        self.lb_time.configure(text=self.now.strftime('%H:%M:%S'))
        self.lb_sumData.configure(text='Sĩ Số: {}'.format(len(self.classList)))
        self.lb_countData.configure(text='Điểm Danh: {}'.format(len(self.classList) - len(self.listDD)))
        self.win.after(100, self.update_date)

    def update_frame(self):
        self.ret, self.frame = self.camera.read()
        self.frame = cv2.flip(self.frame, 1)
        self.frame = cv2.resize(self.frame, (self.width, self.height))
        self.frame = cv2.cvtColor(self.frame, cv2.COLOR_BGR2RGB)
        h, w, c = self.frame.shape
        detec = face_detection.FaceDetection()
        self.detecFace = detec.process(self.frame)
        if self.detecFace.detections:
            if len(self.detecFace.detections) == 1:
                self.faces = self.detecFace.detections[0]
                if self.faces.score[0] > 0.9:
                    box = self.faces.location_data.relative_bounding_box
                    b_box = int(box.xmin*w), int(box.ymin*h),\
                        int(box.width*w), int(box.height*h)
                    if (b_box[0] >= 0) and (b_box[1] >= 0):
                        cv2.rectangle(self.frame, b_box, (0, 255, 0), 1)
                        self.face = self.frame[b_box[1]:b_box[1] + b_box[3], b_box[0]:b_box[0] + b_box[2]]
                        self.face = cv2.resize(self.face, dsize=(112, 112))
                        self.face = self.face.astype('float') * 1./255
                        self.face = np.expand_dims(self.face, axis=0)
                        predict = self.my_model.predict(self.face)
                        self.masv = self.list_label[np.argmax(predict[0])]
                        self.accurancy = np.max(predict[0]*100, axis=0)
                    if self.accurancy > 80:
                        self.lb_message.configure(text='Đang nhận diện gương mặt')
                        cv2.putText(self.frame, 'MSSV: '+self.masv, (20,40),\
                            cv2.FONT_HERSHEY_PLAIN, 2, (255, 0, 255), 2)
                        cv2.putText(self.frame, 'Accuracy: {}%'.format('%.2f'%self.accurancy), (20,70),\
                            cv2.FONT_HERSHEY_PLAIN, 2, (255, 0, 255), 2)
                    else:
                        self.lb_message.configure(text='Không Nhận diện được')
                        cv2.putText(self.frame, 'MSSV: ???', (20,30),\
                            cv2.FONT_HERSHEY_PLAIN, 2, (255, 0, 0), 2)
                        cv2.putText(self.frame, 'Accuracy: ???', (20,60),\
                            cv2.FONT_HERSHEY_PLAIN, 2, (255, 0, 0), 2)
        self.image = PIL.ImageTk.PhotoImage(image=PIL.Image.fromarray(self.frame))
        self.can_Camera.create_image(0, 0, image=self.image, anchor=NW)
        self.win.after(50, self.update_frame)


Camera(mahp, tenhp, magv, date, database, server)
