<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class TraCuuPhong
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
    Public Sub InitializeComponent()
        Me._lbTraCuuPhong = New System.Windows.Forms.Label()
        Me._lbMaPhong = New System.Windows.Forms.Label()
        Me._lbTenPhong = New System.Windows.Forms.Label()
        Me._btnPhongDuocThue = New System.Windows.Forms.Button()
        Me._btnPhongConTrong = New System.Windows.Forms.Button()
        Me._tbMaPhong = New System.Windows.Forms.TextBox()
        Me._tbTenPhong = New System.Windows.Forms.TextBox()
        Me._lbLoaiPhong = New System.Windows.Forms.Label()
        Me._cbLoaiPhong = New System.Windows.Forms.ComboBox()
        Me._btnTraCuuTheoMaPhong = New System.Windows.Forms.Button()
        Me._lbDonGia = New System.Windows.Forms.Label()
        Me._cbDonGia = New System.Windows.Forms.ComboBox()
        Me._lbHuongDan = New System.Windows.Forms.Label()
        Me._lbSoLuongKhach = New System.Windows.Forms.Label()
        Me._cbSoLuongKhach = New System.Windows.Forms.ComboBox()
        Me._btnTroVe = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._btnTraCuuTheoTenPhong = New System.Windows.Forms.Button()
        Me._btnTraCuuTheoLoaiPhong = New System.Windows.Forms.Button()
        Me._btnTraCuuTheoDonGia = New System.Windows.Forms.Button()
        Me._btnTraCuuTheoSoKhach = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_lbTraCuuPhong
        '
        Me._lbTraCuuPhong.AutoSize = True
        Me._lbTraCuuPhong.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbTraCuuPhong.Location = New System.Drawing.Point(784, 18)
        Me._lbTraCuuPhong.Name = "_lbTraCuuPhong"
        Me._lbTraCuuPhong.Size = New System.Drawing.Size(280, 46)
        Me._lbTraCuuPhong.TabIndex = 0
        Me._lbTraCuuPhong.Text = "Tra Cứu Phòng"
        '
        '_lbMaPhong
        '
        Me._lbMaPhong.AutoSize = True
        Me._lbMaPhong.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaPhong.Location = New System.Drawing.Point(52, 186)
        Me._lbMaPhong.Name = "_lbMaPhong"
        Me._lbMaPhong.Size = New System.Drawing.Size(171, 34)
        Me._lbMaPhong.TabIndex = 1
        Me._lbMaPhong.Text = "Mã Phòng"
        '
        '_lbTenPhong
        '
        Me._lbTenPhong.AutoSize = True
        Me._lbTenPhong.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbTenPhong.Location = New System.Drawing.Point(52, 260)
        Me._lbTenPhong.Name = "_lbTenPhong"
        Me._lbTenPhong.Size = New System.Drawing.Size(183, 34)
        Me._lbTenPhong.TabIndex = 2
        Me._lbTenPhong.Text = "Tên Phòng"
        '
        '_btnPhongDuocThue
        '
        Me._btnPhongDuocThue.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._btnPhongDuocThue.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnPhongDuocThue.Location = New System.Drawing.Point(58, 567)
        Me._btnPhongDuocThue.Name = "_btnPhongDuocThue"
        Me._btnPhongDuocThue.Size = New System.Drawing.Size(526, 76)
        Me._btnPhongDuocThue.TabIndex = 3
        Me._btnPhongDuocThue.Text = "Tra Cứu Phòng Đã Được Thuê"
        Me._btnPhongDuocThue.UseVisualStyleBackColor = True
        '
        '_btnPhongConTrong
        '
        Me._btnPhongConTrong.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnPhongConTrong.Location = New System.Drawing.Point(635, 567)
        Me._btnPhongConTrong.Name = "_btnPhongConTrong"
        Me._btnPhongConTrong.Size = New System.Drawing.Size(459, 76)
        Me._btnPhongConTrong.TabIndex = 4
        Me._btnPhongConTrong.Text = "Tra Cứu Phòng Còn Trống"
        Me._btnPhongConTrong.UseVisualStyleBackColor = True
        '
        '_tbMaPhong
        '
        Me._tbMaPhong.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaPhong.Location = New System.Drawing.Point(548, 186)
        Me._tbMaPhong.Name = "_tbMaPhong"
        Me._tbMaPhong.Size = New System.Drawing.Size(240, 40)
        Me._tbMaPhong.TabIndex = 5
        Me._tbMaPhong.Text = "MS05"
        '
        '_tbTenPhong
        '
        Me._tbTenPhong.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbTenPhong.Location = New System.Drawing.Point(548, 254)
        Me._tbTenPhong.Name = "_tbTenPhong"
        Me._tbTenPhong.Size = New System.Drawing.Size(240, 40)
        Me._tbTenPhong.TabIndex = 6
        Me._tbTenPhong.Text = "407"
        '
        '_lbLoaiPhong
        '
        Me._lbLoaiPhong.AutoSize = True
        Me._lbLoaiPhong.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbLoaiPhong.Location = New System.Drawing.Point(52, 336)
        Me._lbLoaiPhong.Name = "_lbLoaiPhong"
        Me._lbLoaiPhong.Size = New System.Drawing.Size(191, 34)
        Me._lbLoaiPhong.TabIndex = 7
        Me._lbLoaiPhong.Text = "Loại Phòng"
        '
        '_cbLoaiPhong
        '
        Me._cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cbLoaiPhong.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cbLoaiPhong.FormattingEnabled = True
        Me._cbLoaiPhong.Items.AddRange(New Object() {"A", "B", "C"})
        Me._cbLoaiPhong.Location = New System.Drawing.Point(548, 330)
        Me._cbLoaiPhong.Name = "_cbLoaiPhong"
        Me._cbLoaiPhong.Size = New System.Drawing.Size(240, 40)
        Me._cbLoaiPhong.TabIndex = 8
        '
        '_btnTraCuuTheoMaPhong
        '
        Me._btnTraCuuTheoMaPhong.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTraCuuTheoMaPhong.Location = New System.Drawing.Point(829, 181)
        Me._btnTraCuuTheoMaPhong.Name = "_btnTraCuuTheoMaPhong"
        Me._btnTraCuuTheoMaPhong.Size = New System.Drawing.Size(453, 48)
        Me._btnTraCuuTheoMaPhong.TabIndex = 9
        Me._btnTraCuuTheoMaPhong.Text = "Tra Cứu Theo Mã Phòng"
        Me._btnTraCuuTheoMaPhong.UseVisualStyleBackColor = True
        '
        '_lbDonGia
        '
        Me._lbDonGia.AutoSize = True
        Me._lbDonGia.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbDonGia.Location = New System.Drawing.Point(52, 406)
        Me._lbDonGia.Name = "_lbDonGia"
        Me._lbDonGia.Size = New System.Drawing.Size(139, 34)
        Me._lbDonGia.TabIndex = 10
        Me._lbDonGia.Text = "Đơn Giá"
        '
        '_cbDonGia
        '
        Me._cbDonGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cbDonGia.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cbDonGia.FormattingEnabled = True
        Me._cbDonGia.Items.AddRange(New Object() {"150000", "170000", "200000"})
        Me._cbDonGia.Location = New System.Drawing.Point(548, 403)
        Me._cbDonGia.Name = "_cbDonGia"
        Me._cbDonGia.Size = New System.Drawing.Size(240, 40)
        Me._cbDonGia.TabIndex = 11
        '
        '_lbHuongDan
        '
        Me._lbHuongDan.AutoSize = True
        Me._lbHuongDan.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbHuongDan.Location = New System.Drawing.Point(426, 81)
        Me._lbHuongDan.Name = "_lbHuongDan"
        Me._lbHuongDan.Size = New System.Drawing.Size(856, 34)
        Me._lbHuongDan.TabIndex = 12
        Me._lbHuongDan.Text = "Tra Cứu Phòng, cần ít nhất 1 trong các thông tin sau."
        '
        '_lbSoLuongKhach
        '
        Me._lbSoLuongKhach.AutoSize = True
        Me._lbSoLuongKhach.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbSoLuongKhach.Location = New System.Drawing.Point(52, 484)
        Me._lbSoLuongKhach.Name = "_lbSoLuongKhach"
        Me._lbSoLuongKhach.Size = New System.Drawing.Size(373, 34)
        Me._lbSoLuongKhach.TabIndex = 13
        Me._lbSoLuongKhach.Text = "Số Khách Trong Phòng"
        '
        '_cbSoLuongKhach
        '
        Me._cbSoLuongKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cbSoLuongKhach.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cbSoLuongKhach.FormattingEnabled = True
        Me._cbSoLuongKhach.Items.AddRange(New Object() {"1", "2", "3"})
        Me._cbSoLuongKhach.Location = New System.Drawing.Point(548, 478)
        Me._cbSoLuongKhach.Name = "_cbSoLuongKhach"
        Me._cbSoLuongKhach.Size = New System.Drawing.Size(161, 40)
        Me._cbSoLuongKhach.TabIndex = 14
        '
        '_btnTroVe
        '
        Me._btnTroVe.BackColor = System.Drawing.Color.DarkRed
        Me._btnTroVe.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTroVe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me._btnTroVe.Location = New System.Drawing.Point(1543, 567)
        Me._btnTroVe.Name = "_btnTroVe"
        Me._btnTroVe.Size = New System.Drawing.Size(222, 76)
        Me._btnTroVe.TabIndex = 15
        Me._btnTroVe.Text = "Trở Về"
        Me._btnTroVe.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(58, 676)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1707, 347)
        Me.DataGridView1.TabIndex = 16
        '
        '_btnTraCuuTheoTenPhong
        '
        Me._btnTraCuuTheoTenPhong.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTraCuuTheoTenPhong.Location = New System.Drawing.Point(829, 249)
        Me._btnTraCuuTheoTenPhong.Name = "_btnTraCuuTheoTenPhong"
        Me._btnTraCuuTheoTenPhong.Size = New System.Drawing.Size(453, 48)
        Me._btnTraCuuTheoTenPhong.TabIndex = 17
        Me._btnTraCuuTheoTenPhong.Text = "Tra Cứu Theo Tên Phòng"
        Me._btnTraCuuTheoTenPhong.UseVisualStyleBackColor = True
        '
        '_btnTraCuuTheoLoaiPhong
        '
        Me._btnTraCuuTheoLoaiPhong.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTraCuuTheoLoaiPhong.Location = New System.Drawing.Point(829, 330)
        Me._btnTraCuuTheoLoaiPhong.Name = "_btnTraCuuTheoLoaiPhong"
        Me._btnTraCuuTheoLoaiPhong.Size = New System.Drawing.Size(453, 48)
        Me._btnTraCuuTheoLoaiPhong.TabIndex = 18
        Me._btnTraCuuTheoLoaiPhong.Text = "Tra Cứu Theo Loại Phòng"
        Me._btnTraCuuTheoLoaiPhong.UseVisualStyleBackColor = True
        '
        '_btnTraCuuTheoDonGia
        '
        Me._btnTraCuuTheoDonGia.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTraCuuTheoDonGia.Location = New System.Drawing.Point(829, 406)
        Me._btnTraCuuTheoDonGia.Name = "_btnTraCuuTheoDonGia"
        Me._btnTraCuuTheoDonGia.Size = New System.Drawing.Size(453, 48)
        Me._btnTraCuuTheoDonGia.TabIndex = 19
        Me._btnTraCuuTheoDonGia.Text = "Tra Cứu Theo Đơn Giá"
        Me._btnTraCuuTheoDonGia.UseVisualStyleBackColor = True
        '
        '_btnTraCuuTheoSoKhach
        '
        Me._btnTraCuuTheoSoKhach.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTraCuuTheoSoKhach.Location = New System.Drawing.Point(829, 478)
        Me._btnTraCuuTheoSoKhach.Name = "_btnTraCuuTheoSoKhach"
        Me._btnTraCuuTheoSoKhach.Size = New System.Drawing.Size(453, 49)
        Me._btnTraCuuTheoSoKhach.TabIndex = 20
        Me._btnTraCuuTheoSoKhach.Text = "Tra Cứu Theo Số Khách Trong Phòng"
        Me._btnTraCuuTheoSoKhach.UseVisualStyleBackColor = True
        '
        'TraCuuPhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1789, 988)
        Me.Controls.Add(Me._btnTraCuuTheoSoKhach)
        Me.Controls.Add(Me._btnTraCuuTheoDonGia)
        Me.Controls.Add(Me._btnTraCuuTheoLoaiPhong)
        Me.Controls.Add(Me._btnTraCuuTheoTenPhong)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me._btnTroVe)
        Me.Controls.Add(Me._cbSoLuongKhach)
        Me.Controls.Add(Me._lbSoLuongKhach)
        Me.Controls.Add(Me._lbHuongDan)
        Me.Controls.Add(Me._cbDonGia)
        Me.Controls.Add(Me._lbDonGia)
        Me.Controls.Add(Me._btnTraCuuTheoMaPhong)
        Me.Controls.Add(Me._cbLoaiPhong)
        Me.Controls.Add(Me._lbLoaiPhong)
        Me.Controls.Add(Me._tbTenPhong)
        Me.Controls.Add(Me._tbMaPhong)
        Me.Controls.Add(Me._btnPhongConTrong)
        Me.Controls.Add(Me._btnPhongDuocThue)
        Me.Controls.Add(Me._lbTenPhong)
        Me.Controls.Add(Me._lbMaPhong)
        Me.Controls.Add(Me._lbTraCuuPhong)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TraCuuPhong"
        Me.Text = "TraCuuPhong"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _lbTraCuuPhong As Label
    Public WithEvents _lbMaPhong As Label
    Friend WithEvents _lbTenPhong As Label
    Friend WithEvents _btnPhongDuocThue As Button
    Friend WithEvents _btnPhongConTrong As Button
    Friend WithEvents _tbMaPhong As TextBox
    Friend WithEvents _tbTenPhong As TextBox
    Friend WithEvents _lbLoaiPhong As Label
    Friend WithEvents _cbLoaiPhong As ComboBox
    Friend WithEvents _btnTraCuuTheoMaPhong As Button
    Friend WithEvents _lbDonGia As Label
    Friend WithEvents _cbDonGia As ComboBox
    Friend WithEvents _lbHuongDan As Label
    Friend WithEvents _lbSoLuongKhach As Label
    Friend WithEvents _cbSoLuongKhach As ComboBox
    Friend WithEvents _btnTroVe As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _btnTraCuuTheoTenPhong As Button
    Friend WithEvents _btnTraCuuTheoLoaiPhong As Button
    Friend WithEvents _btnTraCuuTheoDonGia As Button
    Friend WithEvents _btnTraCuuTheoSoKhach As Button
End Class
