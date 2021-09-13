import datetime
import hashlib
from tkinter import *
import tkinter.messagebox as message
import PIL.Image
import PIL.ImageTk
import cv2
import pyodbc


mahp = sys.argv[1]
magv = sys.argv[2]


class Camera:

    def __init__(self, mahp, magv):
        '''
            Khởi tạo các đối tượng của Form, Khởi tạo Camera, nhận input,...
        :param mahp:
        :param magv:
        '''
        self.ngayDD = datetime.datetime.now().strftime('%Y-%m-%d %H:%M:%S')
        self.mahp = mahp
        self.magv = magv
        self.listInsert = []
        self.listDD = []

        '''
            Tạo Chuỗi Connect
        '''
        self.conn = pyodbc.connect(
            "Driver={SQL Server Native Client 11.0};"
            "Server=DESKTOP-18V51P3;"
            "Database=db_DDSV;"
            "Trusted_Connection=yes;", autocommit=True)
        '''
            Khởi Tạo Form Main
        '''
        self.win = Tk()
        self.lb_titel = Label(self.win)
        self.lb_datetime = Label(self.win)
        self.lb_MaHP = Label(self.win, text='Mã Học Phần:')
        self.txt_MaHP = Entry(self.win, width=25)
        self.btn_Accept = Button(self.win, text="Điểm Danh", width=15)
        self.btn_Exit = Button(self.win, text="Kết Thúc Điểm Danh", width=15)
        self.can_Camera = Canvas(self.win, width=1000, height=750)
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
            config Form Main
        '''
        self.win.title("Camera")
        self.win.geometry('1002x835+%d+%d' % (self.win.winfo_screenwidth() / 2 - 501,
                                              self.win.winfo_screenheight() / 2 - 400))
        '''
            config Label Titel
        '''
        self.lb_titel.configure(text='Điểm Danh Sinh Viên')
        self.lb_titel.grid(row=0, columnspan=4)
        '''
            config Label DateTime
        '''
        self.lb_datetime.grid(row=1, columnspan=4)
        self.update_date()
        '''
            config Label Mã Học Phần
        '''
        self.lb_MaHP.grid(row=2, column=0)
        '''
            config Textbox Mã Học Phần
        '''
        self.txt_MaHP.grid(row=2, column=1)
        self.txt_MaHP.insert(0, self.mahp)
        self.txt_MaHP.configure(state=DISABLED)
        '''
            config Button Điểm Danh
        '''
        # self.btn_Accept.configure(command=)
        self.btn_Accept.configure(command=self.btn_Accept_click)
        self.btn_Accept.grid(row=2, column=2)
        '''
            config Button Thoát
        '''
        self.btn_Exit.configure(command=self.btn_Exit_click)
        self.btn_Exit.grid(row=2, column=3)
        '''
            config Canvas Camera
        '''
        self.can_Camera.configure(bg='Lavender')
        self.can_Camera.grid(row=3, columnspan=4)

    def btn_Accept_click(self):

        now = datetime.datetime.now().strftime('%Y-%m-%d %H:%M:%S')
        masv = "SV15335665"
        query = "SELECT * FROM tab_DKHP WHERE col_MaHP = ? and col_maSV = ?"
        cursor = self.conn.cursor()
        cursor.execute(query, (self.mahp, masv))
        result = cursor.fetchall()

        if len(result) == 0:
            message.showwarning("Lỗi", "Sinh Viên Không Thuộc Lớp Này")
        else:
            if masv not in self.listDD:
                self.listDD.append(masv)
                data = (self.ngayDD, self.mahp, masv, 'Có Mặt', now)
                self.listInsert.append(data)
                message.showinfo("Thành Công", "Sinh Viên {} Đã Điểm Danh Thành Công".format(masv))
            else:
                message.showwarning("Lỗi", "Sinh Viên {} Đã Điểm Danh".format(masv))

    def btn_Exit_click(self):

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
            self.win2.geometry('350x150+%d+%d' % (self.win2.winfo_screenwidth() / 2 - 175,
                                                  self.win2.winfo_screenheight() / 2 - 75))
            self.lb_InputPass = Label(self.win2, text='Nhập Mật Khẩu').grid(row=0, column=0)
            self.txt_inputPass = Entry(self.win2, show='*', width=35)
            self.txt_inputPass.grid(row=1, column=0, pady=5, padx=33)
            self.btn_Ok = Button(self.win2, width=15, height=2, text='Ok', command=self.btn_Ok_click)
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
        self.lb_datetime.configure(text=self.now.strftime('%Y-%m-%d %H:%M:%S'))
        self.win.after(1000, self.update_date)

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
                                   (255, 255, 0), 2)
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
            if (len(face) >= 300 and len(face) <= 400):
                cv2.rectangle(self.image,
                              (x + int(self.width / 7), y + int(self.height / 10)),
                              (x + width + int(self.width / 7), y + height + int(self.height / 10)),
                              (255, 0, 0), 2)
        self.image = PIL.ImageTk.PhotoImage(image=PIL.Image.fromarray(self.image))
        return self.image


d = Camera(mahp, magv)
