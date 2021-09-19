import cv2
import pyodbc
import hashlib
import datetime
import PIL.Image
import PIL.ImageTk
import tkinter.messagebox as message
from tkinter import *

mahp = sys.argv[1]
tenhp = sys.argv[2]
magv = sys.argv[3]
date = sys.argv[4]


class Camera:

    def __init__(self, mahp, tenhp, magv, date):
        '''
            Khởi tạo các đối tượng của Form, Khởi tạo Camera, nhận input,...
        :param mahp:
        :param magv:
        '''
        self.ngayDD = date
        self.mahp = mahp
        self.tenhp = tenhp
        self.magv = magv
        self.listInsert = []
        self.listDD = []
        self.classList = []

        '''
            Tạo Chuỗi Connect
        '''
        self.conn = pyodbc.connect(
            "Driver={SQL Server Native Client 11.0};"
            "Server=DESKTOP-KV5JDU2;"
            "Database=db_DDSV;"
            "Trusted_Connection=yes;", autocommit=True)
        '''
            Khởi Tạo Form Main
        '''
        self.win = Tk()
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
        '''
            Khởi Tạo Camera, Load Model Phát Hiện Gương Mặt
        '''
        self.camera = cv2.VideoCapture(0, cv2.CAP_DSHOW)
        self.cascade = cv2.CascadeClassifier("haarcascade_frontalface_alt_tree.xml")
        '''
            Các Hàm Xử Lý Giao Diện
        '''
        self.config_window()
        self.update_frame()
        self.win.mainloop()

    def config_window(self):
        """
            Tùy chỉnh giao diện WINDOW
        :return: None
        """

        '''
            config FormMain
        '''
        self.win.title("Camera")
        self.win.geometry('1400x850+%d+%d' % (self.win.winfo_screenwidth() / 2 - 700,
                                              self.win.winfo_screenheight() / 2 - 400))
        self.update_date()
        self.txt_TenHP.insert(END, self.tenhp)
        self.txt_TenHP.configure(state=DISABLED)
        '''
            config Color
        '''
        self.win.configure(bg='Lavender')
        self.lb_title.configure(bg='Lavender', fg='MediumBlue')
        self.lb_message.configure(bg='Lavender', fg='MediumBlue')
        self.lb_sumData.configure(bg='Lavender')
        self.lb_countData.configure(bg='Lavender')
        self.lb_dateTitle.configure(bg='Lavender')
        self.lb_date.configure(bg='Lavender')
        self.lb_timeTitle.configure(bg='Lavender')
        self.lb_time.configure(bg='Lavender')
        self.lb_TenHP.configure(bg='Lavender')
        self.btn_Accept.configure(fg='MediumBlue')
        self.btn_Summary.configure(fg='MediumBlue')
        '''
            config Text
        '''
        self.lb_title.configure(text='Module\nĐiểm Danh Sinh Viên')
        self.lb_date.configure(text=self.ngayDD)
        self.lb_dateTitle.configure(text='Mở Điểm Danh Lúc:')
        self.lb_timeTitle.configure(text='Giờ Hiện Tại:')
        self.lb_TenHP.configure(text='Tên Học Phần:')
        self.btn_Accept.configure(text='Điểm Danh')
        self.btn_Summary.configure(text='Tổng Kết\nĐiểm Danh')
        self.lb_message.configure(text='Hãy Cho Gương Mặt Vào Khung Màu Xanh Để Nhận Diện')
        '''
            config Width - Height
        '''
        self.txt_TenHP.configure(width=23, height=3)
        self.btn_Accept.configure(width=20, height=2)
        self.btn_Summary.configure(width=20, height=2)
        self.can_Camera.configure(width=1000, height=750)
        '''
            config Font
        '''
        self.lb_title.configure(font=('Constantia', 28, 'bold'))
        self.lb_sumData.configure(font=('Consolas', 20, 'bold'))
        self.lb_countData.configure(font=('Consolas', 20, 'bold'))
        self.lb_dateTitle.configure(font=('Consolas', 13))
        self.lb_date.configure(font=('Consolas', 20, 'bold italic'))
        self.lb_timeTitle.configure(font=('Consolas', 13))
        self.lb_time.configure(font=('Consolas', 40, 'bold'))
        self.lb_TenHP.configure(font=('Constantia', 13))
        self.txt_TenHP.configure(font=('Consolas', 18), wrap=WORD)
        self.btn_Accept.configure(font=('Constantia', 15, 'bold'))
        self.btn_Summary.configure(font=('Constantia', 15, 'bold'))
        self.lb_message.configure(font=('Book', 17))
        '''
            config Grid
        '''
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
        self.txt_TenHP.grid(row=10, column=2, padx=15)
        self.btn_Accept.grid(row=16, column=2)
        self.btn_Summary.grid(row=18, column=2)
        '''
            config Command
        '''
        self.btn_Accept.configure(command=self.btn_Accept_click)
        self.btn_Summary.configure(command=self.btn_Summary_click)
        self.loadData()

    def loadData(self):
        query = "SELECT col_MaSV FROM tab_DKHP WHERE col_MaHP = ?"
        cursor = self.conn.cursor()
        cursor.execute(query, self.mahp)
        result = cursor.fetchall()
        for item in result:
            self.classList.append(item[0])
            self.listDD.append(item[0])

    def btn_Accept_click(self):

        now = datetime.datetime.now().strftime('%H:%M:%S')
        masv = "SV15335665"

        if masv not in self.classList:
            message.showwarning("Lỗi", "Sinh Viên Không Thuộc Lớp Này")
        else:
            if masv in self.listDD:
                data = (self.ngayDD, self.mahp, masv, 'Có Mặt', now)
                self.listDD.remove(masv)
                self.listInsert.append(data)
                message.showinfo("Thành Công", "Sinh Viên {} Đã Điểm Danh Thành Công Lúc {}".format(masv, now))
            else:
                message.showwarning("Lỗi", "Sinh Viên {} Đã Điểm Danh Rồi".format(masv))

    def btn_Summary_click(self):

        if len(self.listInsert) == 0:
            result = message.askokcancel("Lỗi", "Không Có Sinh Viên Nào Được Điểm Danh\n"
                                                "Đồng Ý Thoát Phiên Điểm Danh Này")
            if result == 1:
                self.camera.release()
                cv2.destroyAllWindows()
                self.win.destroy()
        else:
            self.win2 = Tk()
            self.win2.title('Xác Nhận Mật Khẩu')
            self.win2.geometry('350x170+%d+%d' % (self.win2.winfo_screenwidth() / 2 - 175,
                                                  self.win2.winfo_screenheight() / 2 - 75))
            self.lb_InputPass = Label(self.win2, text='Nhập Mật Khẩu', font=('Constantia', 20, 'bold')).grid(row=0,
                                                                                                             column=0,
                                                                                                             pady=5)
            self.txt_inputPass = Entry(self.win2, show='*', width=35, font=('Constantia', 13))
            self.txt_inputPass.grid(row=1, column=0, pady=5, padx=15)
            self.btn_Ok = Button(self.win2, width=15, height=2, text='Ok', font=('Constantia', 15, 'bold'),
                                 command=self.btn_Ok_click)
            self.btn_Ok.grid(row=2, column=0, pady=5)
            self.win2.mainloop()

    def btn_Ok_click(self):

        if self.txt_inputPass.get() == "":
            message.showwarning('Lỗi', 'Chưa Nhập Mật Khẩu')
            self.win2.destroy()
        else:
            decode = hashlib.md5(self.txt_inputPass.get().encode('utf-8')).hexdigest()
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
                            data = (self.ngayDD, self.mahp, item, 'Vắng', '')
                            self.listInsert.append(data)

                    insert = "INSERT INTO tab_DiemDanh VALUES(?,?,?,?,?)"
                    cursor.executemany(insert, self.listInsert)
                    message.showinfo("Thành Công", "Dữ Liệu Đã Được Lưu")
                    self.win2.destroy()
                    self.win.destroy()
                except:
                    message.showerror("Lỗi", "Xảy Ra Lỗi Trong Quá Trình Điểm Danh")
                    self.win2.destroy()

    def update_date(self):
        self.now = datetime.datetime.now()
        self.lb_time.configure(text=self.now.strftime('%H:%M:%S'))
        self.lb_sumData.configure(text='Sĩ Số: {}'.format(len(self.classList)))
        self.lb_countData.configure(text='Điểm Danh: {}'.format(len(self.classList)-len(self.listDD)))
        self.win.after(500, self.update_date)

    def update_frame(self):

        self.width = 1000
        self.height = 750
        self.ret, self.frame = self.camera.read()
        self.frame = cv2.cvtColor(self.frame, cv2.COLOR_BGR2RGB)
        self.frame = cv2.resize(self.frame, (self.width, self.height))
        self.frame = cv2.flip(self.frame, 1)
        self.frame = cv2.rectangle(self.frame,
                                   (int(self.width / 7), int(self.height / 10)),
                                   (int(self.width * 6 / 7), int(self.height * 9 / 10)),
                                   (0, 0, 180), 2)
        self.can_Camera.create_image(0, 0, image=self.detec(self.frame), anchor=NW)
        self.win.after(10, self.update_frame)

    def detec(self, image):

        self.image = image
        self.gray = cv2.cvtColor(self.image, cv2.COLOR_BGR2GRAY)
        self.box = self.gray[
                   int(self.height / 10):int(self.height * 9 / 10),
                   int(self.width / 7):int(self.width * 6 / 7)]
        self.faces = self.cascade.detectMultiScale(self.box)
        for (x, y, width, height) in self.faces:
            face = self.box[x:x + width, y:y + height]
            cv2.rectangle(self.image,
                          (x + int(self.width / 7), y + int(self.height / 10)),
                          (x + width + int(self.width / 7), y + height + int(self.height / 10)),
                          (255, 0, 0), 2)
        self.image = PIL.ImageTk.PhotoImage(image=PIL.Image.fromarray(self.image))
        return self.image


d = Camera(mahp, tenhp, magv, date)
