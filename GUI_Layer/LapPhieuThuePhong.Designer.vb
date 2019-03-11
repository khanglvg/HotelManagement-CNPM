<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LapPhieuThuePhong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me._dtpNgayBatDauThue = New System.Windows.Forms.DateTimePicker()
        Me._btnTroVe = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._cbPhong = New System.Windows.Forms.ComboBox()
        Me._lbLapPhieuThuePhong = New System.Windows.Forms.Label()
        Me._lbPhong = New System.Windows.Forms.Label()
        Me._lbNgayBatDauThue = New System.Windows.Forms.Label()
        Me._lbKhachHang = New System.Windows.Forms.Label()
        Me._tbKhachHang = New System.Windows.Forms.TextBox()
        Me._lbLoaiKhach = New System.Windows.Forms.Label()
        Me._cbLoaiKhach = New System.Windows.Forms.ComboBox()
        Me._lbCMND = New System.Windows.Forms.Label()
        Me._tbCMND = New System.Windows.Forms.TextBox()
        Me._lbDiaChi = New System.Windows.Forms.Label()
        Me._tbDiaChi = New System.Windows.Forms.TextBox()
        Me._btnThem = New System.Windows.Forms.Button()
        Me._lbLoaiPhong = New System.Windows.Forms.Label()
        Me._tbLoaiPhong = New System.Windows.Forms.TextBox()
        Me._lbDonGia = New System.Windows.Forms.Label()
        Me._tbDonGia = New System.Windows.Forms.TextBox()
        Me._btnLapPhieuThuePhong = New System.Windows.Forms.Button()
        Me._btnCapNhat = New System.Windows.Forms.Button()
        Me._tbMaKhachHang = New System.Windows.Forms.TextBox()
        Me._lbMaKhachHang = New System.Windows.Forms.Label()
        Me._lbMaLoaiKhach = New System.Windows.Forms.Label()
        Me._tbMaLoaiKhachHang = New System.Windows.Forms.TextBox()
        Me._tbMaPhieuThue = New System.Windows.Forms.TextBox()
        Me._lbMaPhieuThue = New System.Windows.Forms.Label()
        Me._btnXong = New System.Windows.Forms.Button()
        Me._rtbGhiChu = New System.Windows.Forms.RichTextBox()
        Me._lbGhiChu = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_dtpNgayBatDauThue
        '
        Me._dtpNgayBatDauThue.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._dtpNgayBatDauThue.Location = New System.Drawing.Point(1147, 21)
        Me._dtpNgayBatDauThue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._dtpNgayBatDauThue.Name = "_dtpNgayBatDauThue"
        Me._dtpNgayBatDauThue.Size = New System.Drawing.Size(353, 34)
        Me._dtpNgayBatDauThue.TabIndex = 4
        '
        '_btnTroVe
        '
        Me._btnTroVe.BackColor = System.Drawing.Color.DarkRed
        Me._btnTroVe.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTroVe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me._btnTroVe.Location = New System.Drawing.Point(943, 781)
        Me._btnTroVe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._btnTroVe.Name = "_btnTroVe"
        Me._btnTroVe.Size = New System.Drawing.Size(125, 70)
        Me._btnTroVe.TabIndex = 15
        Me._btnTroVe.Text = "Trở Về"
        Me._btnTroVe.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(52, 455)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1016, 319)
        Me.DataGridView1.TabIndex = 24
        '
        '_cbPhong
        '
        Me._cbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cbPhong.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cbPhong.FormattingEnabled = True
        Me._cbPhong.Location = New System.Drawing.Point(296, 71)
        Me._cbPhong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._cbPhong.Name = "_cbPhong"
        Me._cbPhong.Size = New System.Drawing.Size(166, 37)
        Me._cbPhong.TabIndex = 0
        '
        '_lbLapPhieuThuePhong
        '
        Me._lbLapPhieuThuePhong.AutoSize = True
        Me._lbLapPhieuThuePhong.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbLapPhieuThuePhong.Location = New System.Drawing.Point(352, 3)
        Me._lbLapPhieuThuePhong.Name = "_lbLapPhieuThuePhong"
        Me._lbLapPhieuThuePhong.Size = New System.Drawing.Size(408, 45)
        Me._lbLapPhieuThuePhong.TabIndex = 1
        Me._lbLapPhieuThuePhong.Text = "Lập Phiếu Thuê Phòng"
        '
        '_lbPhong
        '
        Me._lbPhong.AutoSize = True
        Me._lbPhong.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbPhong.Location = New System.Drawing.Point(46, 74)
        Me._lbPhong.Name = "_lbPhong"
        Me._lbPhong.Size = New System.Drawing.Size(83, 29)
        Me._lbPhong.TabIndex = 2
        Me._lbPhong.Text = "Phòng"
        '
        '_lbNgayBatDauThue
        '
        Me._lbNgayBatDauThue.AutoSize = True
        Me._lbNgayBatDauThue.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbNgayBatDauThue.Location = New System.Drawing.Point(875, 21)
        Me._lbNgayBatDauThue.Name = "_lbNgayBatDauThue"
        Me._lbNgayBatDauThue.Size = New System.Drawing.Size(266, 35)
        Me._lbNgayBatDauThue.TabIndex = 3
        Me._lbNgayBatDauThue.Text = "Ngày Bắt Đầu Thuê"
        '
        '_lbKhachHang
        '
        Me._lbKhachHang.AutoSize = True
        Me._lbKhachHang.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbKhachHang.Location = New System.Drawing.Point(505, 147)
        Me._lbKhachHang.Name = "_lbKhachHang"
        Me._lbKhachHang.Size = New System.Drawing.Size(196, 29)
        Me._lbKhachHang.TabIndex = 6
        Me._lbKhachHang.Text = "Tên Khách Hàng"
        '
        '_tbKhachHang
        '
        Me._tbKhachHang.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbKhachHang.Location = New System.Drawing.Point(721, 145)
        Me._tbKhachHang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._tbKhachHang.Name = "_tbKhachHang"
        Me._tbKhachHang.Size = New System.Drawing.Size(347, 36)
        Me._tbKhachHang.TabIndex = 7
        '
        '_lbLoaiKhach
        '
        Me._lbLoaiKhach.AutoSize = True
        Me._lbLoaiKhach.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbLoaiKhach.Location = New System.Drawing.Point(505, 206)
        Me._lbLoaiKhach.Name = "_lbLoaiKhach"
        Me._lbLoaiKhach.Size = New System.Drawing.Size(139, 29)
        Me._lbLoaiKhach.TabIndex = 8
        Me._lbLoaiKhach.Text = "Loại Khách"
        '
        '_cbLoaiKhach
        '
        Me._cbLoaiKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cbLoaiKhach.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cbLoaiKhach.FormattingEnabled = True
        Me._cbLoaiKhach.Location = New System.Drawing.Point(721, 204)
        Me._cbLoaiKhach.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._cbLoaiKhach.Name = "_cbLoaiKhach"
        Me._cbLoaiKhach.Size = New System.Drawing.Size(347, 37)
        Me._cbLoaiKhach.TabIndex = 9
        '
        '_lbCMND
        '
        Me._lbCMND.AutoSize = True
        Me._lbCMND.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbCMND.Location = New System.Drawing.Point(505, 266)
        Me._lbCMND.Name = "_lbCMND"
        Me._lbCMND.Size = New System.Drawing.Size(90, 29)
        Me._lbCMND.TabIndex = 10
        Me._lbCMND.Text = "CMND"
        '
        '_tbCMND
        '
        Me._tbCMND.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbCMND.Location = New System.Drawing.Point(721, 263)
        Me._tbCMND.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._tbCMND.Name = "_tbCMND"
        Me._tbCMND.Size = New System.Drawing.Size(347, 36)
        Me._tbCMND.TabIndex = 11
        '
        '_lbDiaChi
        '
        Me._lbDiaChi.AutoSize = True
        Me._lbDiaChi.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbDiaChi.Location = New System.Drawing.Point(505, 316)
        Me._lbDiaChi.Name = "_lbDiaChi"
        Me._lbDiaChi.Size = New System.Drawing.Size(94, 29)
        Me._lbDiaChi.TabIndex = 12
        Me._lbDiaChi.Text = "Địa Chỉ"
        '
        '_tbDiaChi
        '
        Me._tbDiaChi.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbDiaChi.Location = New System.Drawing.Point(721, 313)
        Me._tbDiaChi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._tbDiaChi.Name = "_tbDiaChi"
        Me._tbDiaChi.Size = New System.Drawing.Size(347, 36)
        Me._tbDiaChi.TabIndex = 13
        '
        '_btnThem
        '
        Me._btnThem.Enabled = False
        Me._btnThem.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnThem.Location = New System.Drawing.Point(578, 372)
        Me._btnThem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._btnThem.Name = "_btnThem"
        Me._btnThem.Size = New System.Drawing.Size(210, 76)
        Me._btnThem.TabIndex = 14
        Me._btnThem.Text = "Thêm Khách Hàng"
        Me._btnThem.UseVisualStyleBackColor = True
        '
        '_lbLoaiPhong
        '
        Me._lbLoaiPhong.AutoSize = True
        Me._lbLoaiPhong.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbLoaiPhong.Location = New System.Drawing.Point(505, 74)
        Me._lbLoaiPhong.Name = "_lbLoaiPhong"
        Me._lbLoaiPhong.Size = New System.Drawing.Size(137, 29)
        Me._lbLoaiPhong.TabIndex = 18
        Me._lbLoaiPhong.Text = "Loại Phòng"
        '
        '_tbLoaiPhong
        '
        Me._tbLoaiPhong.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbLoaiPhong.Location = New System.Drawing.Point(721, 71)
        Me._tbLoaiPhong.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._tbLoaiPhong.Name = "_tbLoaiPhong"
        Me._tbLoaiPhong.ReadOnly = True
        Me._tbLoaiPhong.Size = New System.Drawing.Size(88, 36)
        Me._tbLoaiPhong.TabIndex = 19
        Me._tbLoaiPhong.Text = "A"
        Me._tbLoaiPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_lbDonGia
        '
        Me._lbDonGia.AutoSize = True
        Me._lbDonGia.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbDonGia.Location = New System.Drawing.Point(856, 74)
        Me._lbDonGia.Name = "_lbDonGia"
        Me._lbDonGia.Size = New System.Drawing.Size(104, 29)
        Me._lbDonGia.TabIndex = 20
        Me._lbDonGia.Text = "Đơn Giá"
        '
        '_tbDonGia
        '
        Me._tbDonGia.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbDonGia.Location = New System.Drawing.Point(966, 71)
        Me._tbDonGia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._tbDonGia.Name = "_tbDonGia"
        Me._tbDonGia.ReadOnly = True
        Me._tbDonGia.Size = New System.Drawing.Size(102, 36)
        Me._tbDonGia.TabIndex = 21
        Me._tbDonGia.Text = "150000"
        '
        '_btnLapPhieuThuePhong
        '
        Me._btnLapPhieuThuePhong.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnLapPhieuThuePhong.Location = New System.Drawing.Point(52, 372)
        Me._btnLapPhieuThuePhong.Name = "_btnLapPhieuThuePhong"
        Me._btnLapPhieuThuePhong.Size = New System.Drawing.Size(211, 76)
        Me._btnLapPhieuThuePhong.TabIndex = 22
        Me._btnLapPhieuThuePhong.Text = "Lập Phiếu Thuê Phòng"
        Me._btnLapPhieuThuePhong.UseVisualStyleBackColor = True
        '
        '_btnCapNhat
        '
        Me._btnCapNhat.Enabled = False
        Me._btnCapNhat.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnCapNhat.Location = New System.Drawing.Point(794, 372)
        Me._btnCapNhat.Name = "_btnCapNhat"
        Me._btnCapNhat.Size = New System.Drawing.Size(274, 76)
        Me._btnCapNhat.TabIndex = 23
        Me._btnCapNhat.Text = "Cập Nhật Thông Tin Khách Hàng"
        Me._btnCapNhat.UseVisualStyleBackColor = True
        '
        '_tbMaKhachHang
        '
        Me._tbMaKhachHang.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaKhachHang.Location = New System.Drawing.Point(296, 144)
        Me._tbMaKhachHang.Name = "_tbMaKhachHang"
        Me._tbMaKhachHang.ReadOnly = True
        Me._tbMaKhachHang.Size = New System.Drawing.Size(160, 36)
        Me._tbMaKhachHang.TabIndex = 25
        Me._tbMaKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_lbMaKhachHang
        '
        Me._lbMaKhachHang.AutoSize = True
        Me._lbMaKhachHang.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaKhachHang.Location = New System.Drawing.Point(46, 148)
        Me._lbMaKhachHang.Name = "_lbMaKhachHang"
        Me._lbMaKhachHang.Size = New System.Drawing.Size(192, 29)
        Me._lbMaKhachHang.TabIndex = 26
        Me._lbMaKhachHang.Text = "Mã Khách Hàng"
        '
        '_lbMaLoaiKhach
        '
        Me._lbMaLoaiKhach.AutoSize = True
        Me._lbMaLoaiKhach.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaLoaiKhach.Location = New System.Drawing.Point(46, 207)
        Me._lbMaLoaiKhach.Name = "_lbMaLoaiKhach"
        Me._lbMaLoaiKhach.Size = New System.Drawing.Size(246, 29)
        Me._lbMaLoaiKhach.TabIndex = 27
        Me._lbMaLoaiKhach.Text = "Mã Loại Khách Hàng"
        '
        '_tbMaLoaiKhachHang
        '
        Me._tbMaLoaiKhachHang.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaLoaiKhachHang.Location = New System.Drawing.Point(296, 203)
        Me._tbMaLoaiKhachHang.Name = "_tbMaLoaiKhachHang"
        Me._tbMaLoaiKhachHang.ReadOnly = True
        Me._tbMaLoaiKhachHang.Size = New System.Drawing.Size(160, 36)
        Me._tbMaLoaiKhachHang.TabIndex = 28
        Me._tbMaLoaiKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_tbMaPhieuThue
        '
        Me._tbMaPhieuThue.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaPhieuThue.Location = New System.Drawing.Point(296, 269)
        Me._tbMaPhieuThue.Name = "_tbMaPhieuThue"
        Me._tbMaPhieuThue.ReadOnly = True
        Me._tbMaPhieuThue.Size = New System.Drawing.Size(160, 36)
        Me._tbMaPhieuThue.TabIndex = 29
        Me._tbMaPhieuThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_lbMaPhieuThue
        '
        Me._lbMaPhieuThue.AutoSize = True
        Me._lbMaPhieuThue.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaPhieuThue.Location = New System.Drawing.Point(46, 272)
        Me._lbMaPhieuThue.Name = "_lbMaPhieuThue"
        Me._lbMaPhieuThue.Size = New System.Drawing.Size(179, 29)
        Me._lbMaPhieuThue.TabIndex = 30
        Me._lbMaPhieuThue.Text = "Mã Phiếu Thuê"
        '
        '_btnXong
        '
        Me._btnXong.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnXong.Location = New System.Drawing.Point(296, 372)
        Me._btnXong.Name = "_btnXong"
        Me._btnXong.Size = New System.Drawing.Size(119, 76)
        Me._btnXong.TabIndex = 31
        Me._btnXong.Text = "Xong"
        Me._btnXong.UseVisualStyleBackColor = True
        '
        '_rtbGhiChu
        '
        Me._rtbGhiChu.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._rtbGhiChu.Location = New System.Drawing.Point(1147, 182)
        Me._rtbGhiChu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._rtbGhiChu.Name = "_rtbGhiChu"
        Me._rtbGhiChu.Size = New System.Drawing.Size(353, 669)
        Me._rtbGhiChu.TabIndex = 16
        Me._rtbGhiChu.Text = "Khách Hàng có yêu cầu hoặc thông tin gì thêm, Vui lòng Ghi Chú lại vào ĐÂY!" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "// c" &
    "hưa phát triển thêm, chưa có chức năng này"
        '
        '_lbGhiChu
        '
        Me._lbGhiChu.AutoSize = True
        Me._lbGhiChu.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbGhiChu.Location = New System.Drawing.Point(1259, 141)
        Me._lbGhiChu.Name = "_lbGhiChu"
        Me._lbGhiChu.Size = New System.Drawing.Size(125, 35)
        Me._lbGhiChu.TabIndex = 17
        Me._lbGhiChu.Text = "Ghi Chú"
        '
        'LapPhieuThuePhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1702, 950)
        Me.Controls.Add(Me._btnXong)
        Me.Controls.Add(Me._lbMaPhieuThue)
        Me.Controls.Add(Me._tbMaPhieuThue)
        Me.Controls.Add(Me._tbMaLoaiKhachHang)
        Me.Controls.Add(Me._lbMaLoaiKhach)
        Me.Controls.Add(Me._lbMaKhachHang)
        Me.Controls.Add(Me._tbMaKhachHang)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me._btnCapNhat)
        Me.Controls.Add(Me._btnLapPhieuThuePhong)
        Me.Controls.Add(Me._tbDonGia)
        Me.Controls.Add(Me._lbDonGia)
        Me.Controls.Add(Me._tbLoaiPhong)
        Me.Controls.Add(Me._lbLoaiPhong)
        Me.Controls.Add(Me._lbGhiChu)
        Me.Controls.Add(Me._rtbGhiChu)
        Me.Controls.Add(Me._btnTroVe)
        Me.Controls.Add(Me._btnThem)
        Me.Controls.Add(Me._tbDiaChi)
        Me.Controls.Add(Me._lbDiaChi)
        Me.Controls.Add(Me._tbCMND)
        Me.Controls.Add(Me._lbCMND)
        Me.Controls.Add(Me._cbLoaiKhach)
        Me.Controls.Add(Me._lbLoaiKhach)
        Me.Controls.Add(Me._tbKhachHang)
        Me.Controls.Add(Me._lbKhachHang)
        Me.Controls.Add(Me._dtpNgayBatDauThue)
        Me.Controls.Add(Me._lbNgayBatDauThue)
        Me.Controls.Add(Me._lbPhong)
        Me.Controls.Add(Me._lbLapPhieuThuePhong)
        Me.Controls.Add(Me._cbPhong)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "LapPhieuThuePhong"
        Me.Text = "LapPhieuThuePhong"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _dtpNgayBatDauThue As DateTimePicker
    Friend WithEvents _btnTroVe As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _cbPhong As ComboBox
    Friend WithEvents _lbLapPhieuThuePhong As Label
    Friend WithEvents _lbPhong As Label
    Friend WithEvents _lbNgayBatDauThue As Label
    Friend WithEvents _lbKhachHang As Label
    Friend WithEvents _tbKhachHang As TextBox
    Friend WithEvents _lbLoaiKhach As Label
    Friend WithEvents _cbLoaiKhach As ComboBox
    Friend WithEvents _lbCMND As Label
    Friend WithEvents _tbCMND As TextBox
    Friend WithEvents _lbDiaChi As Label
    Friend WithEvents _tbDiaChi As TextBox
    Friend WithEvents _btnThem As Button
    Friend WithEvents _lbLoaiPhong As Label
    Friend WithEvents _tbLoaiPhong As TextBox
    Friend WithEvents _lbDonGia As Label
    Friend WithEvents _tbDonGia As TextBox
    Friend WithEvents _btnLapPhieuThuePhong As Button
    Friend WithEvents _btnCapNhat As Button
    Friend WithEvents _tbMaKhachHang As TextBox
    Friend WithEvents _lbMaKhachHang As Label
    Friend WithEvents _lbMaLoaiKhach As Label
    Friend WithEvents _tbMaLoaiKhachHang As TextBox
    Friend WithEvents _tbMaPhieuThue As TextBox
    Friend WithEvents _lbMaPhieuThue As Label
    Friend WithEvents _btnXong As Button
    Friend WithEvents _rtbGhiChu As RichTextBox
    Friend WithEvents _lbGhiChu As Label
End Class
