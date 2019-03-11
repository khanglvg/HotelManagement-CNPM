<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapHoaDonThanhToan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._dtpNgayLapHoaDon = New System.Windows.Forms.DateTimePicker()
        Me._lbNgayLapHoaDon = New System.Windows.Forms.Label()
        Me._btnTroVe = New System.Windows.Forms.Button()
        Me._lbLapHoaDon = New System.Windows.Forms.Label()
        Me._lbTenKhachHang = New System.Windows.Forms.Label()
        Me._lbDiaChi = New System.Windows.Forms.Label()
        Me._lbTriGiaHoaDon = New System.Windows.Forms.Label()
        Me._tbDiaChi = New System.Windows.Forms.TextBox()
        Me._tbTriGiaHoaDon = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._lbMaKhachHang = New System.Windows.Forms.Label()
        Me._lbMaHoaDon = New System.Windows.Forms.Label()
        Me._tbMaHoaDon = New System.Windows.Forms.TextBox()
        Me._tbMaKhachHang = New System.Windows.Forms.TextBox()
        Me._tbTenKhachHang = New System.Windows.Forms.TextBox()
        Me._btnThanhToan = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_dtpNgayLapHoaDon
        '
        Me._dtpNgayLapHoaDon.CustomFormat = "dddd,  dd MMMM yyyy"
        Me._dtpNgayLapHoaDon.Enabled = False
        Me._dtpNgayLapHoaDon.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._dtpNgayLapHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me._dtpNgayLapHoaDon.Location = New System.Drawing.Point(1285, 117)
        Me._dtpNgayLapHoaDon.Name = "_dtpNgayLapHoaDon"
        Me._dtpNgayLapHoaDon.Size = New System.Drawing.Size(601, 40)
        Me._dtpNgayLapHoaDon.TabIndex = 0
        '
        '_lbNgayLapHoaDon
        '
        Me._lbNgayLapHoaDon.AutoSize = True
        Me._lbNgayLapHoaDon.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbNgayLapHoaDon.Location = New System.Drawing.Point(867, 117)
        Me._lbNgayLapHoaDon.Name = "_lbNgayLapHoaDon"
        Me._lbNgayLapHoaDon.Size = New System.Drawing.Size(306, 34)
        Me._lbNgayLapHoaDon.TabIndex = 1
        Me._lbNgayLapHoaDon.Text = "Ngày Lập Hóa Đơn"
        '
        '_btnTroVe
        '
        Me._btnTroVe.BackColor = System.Drawing.Color.DarkRed
        Me._btnTroVe.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTroVe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me._btnTroVe.Location = New System.Drawing.Point(1651, 458)
        Me._btnTroVe.Name = "_btnTroVe"
        Me._btnTroVe.Size = New System.Drawing.Size(235, 107)
        Me._btnTroVe.TabIndex = 2
        Me._btnTroVe.Text = "Trở Về"
        Me._btnTroVe.UseVisualStyleBackColor = False
        '
        '_lbLapHoaDon
        '
        Me._lbLapHoaDon.AutoSize = True
        Me._lbLapHoaDon.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbLapHoaDon.Location = New System.Drawing.Point(427, 35)
        Me._lbLapHoaDon.Name = "_lbLapHoaDon"
        Me._lbLapHoaDon.Size = New System.Drawing.Size(584, 48)
        Me._lbLapHoaDon.TabIndex = 3
        Me._lbLapHoaDon.Text = "Lập Hóa Đơn Thanh Toán"
        '
        '_lbTenKhachHang
        '
        Me._lbTenKhachHang.AutoSize = True
        Me._lbTenKhachHang.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbTenKhachHang.Location = New System.Drawing.Point(61, 336)
        Me._lbTenKhachHang.Name = "_lbTenKhachHang"
        Me._lbTenKhachHang.Size = New System.Drawing.Size(272, 34)
        Me._lbTenKhachHang.TabIndex = 4
        Me._lbTenKhachHang.Text = "Tên Khách Hàng"
        '
        '_lbDiaChi
        '
        Me._lbDiaChi.AutoSize = True
        Me._lbDiaChi.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbDiaChi.Location = New System.Drawing.Point(61, 423)
        Me._lbDiaChi.Name = "_lbDiaChi"
        Me._lbDiaChi.Size = New System.Drawing.Size(127, 34)
        Me._lbDiaChi.TabIndex = 6
        Me._lbDiaChi.Text = "Địa Chỉ"
        '
        '_lbTriGiaHoaDon
        '
        Me._lbTriGiaHoaDon.AutoSize = True
        Me._lbTriGiaHoaDon.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbTriGiaHoaDon.Location = New System.Drawing.Point(61, 507)
        Me._lbTriGiaHoaDon.Name = "_lbTriGiaHoaDon"
        Me._lbTriGiaHoaDon.Size = New System.Drawing.Size(351, 34)
        Me._lbTriGiaHoaDon.TabIndex = 7
        Me._lbTriGiaHoaDon.Text = "Tổng Trị Giá Hóa Đơn"
        '
        '_tbDiaChi
        '
        Me._tbDiaChi.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbDiaChi.Location = New System.Drawing.Point(457, 423)
        Me._tbDiaChi.Name = "_tbDiaChi"
        Me._tbDiaChi.ReadOnly = True
        Me._tbDiaChi.Size = New System.Drawing.Size(768, 40)
        Me._tbDiaChi.TabIndex = 8
        '
        '_tbTriGiaHoaDon
        '
        Me._tbTriGiaHoaDon.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbTriGiaHoaDon.Location = New System.Drawing.Point(457, 507)
        Me._tbTriGiaHoaDon.Name = "_tbTriGiaHoaDon"
        Me._tbTriGiaHoaDon.ReadOnly = True
        Me._tbTriGiaHoaDon.Size = New System.Drawing.Size(768, 40)
        Me._tbTriGiaHoaDon.TabIndex = 9
        Me._tbTriGiaHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(67, 704)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1819, 324)
        Me.DataGridView1.TabIndex = 10
        '
        '_lbMaKhachHang
        '
        Me._lbMaKhachHang.AutoSize = True
        Me._lbMaKhachHang.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaKhachHang.Location = New System.Drawing.Point(61, 247)
        Me._lbMaKhachHang.Name = "_lbMaKhachHang"
        Me._lbMaKhachHang.Size = New System.Drawing.Size(260, 34)
        Me._lbMaKhachHang.TabIndex = 12
        Me._lbMaKhachHang.Text = "Mã Khách Hàng"
        '
        '_lbMaHoaDon
        '
        Me._lbMaHoaDon.AutoSize = True
        Me._lbMaHoaDon.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaHoaDon.Location = New System.Drawing.Point(61, 153)
        Me._lbMaHoaDon.Name = "_lbMaHoaDon"
        Me._lbMaHoaDon.Size = New System.Drawing.Size(204, 34)
        Me._lbMaHoaDon.TabIndex = 14
        Me._lbMaHoaDon.Text = "Mã Hóa Đơn"
        '
        '_tbMaHoaDon
        '
        Me._tbMaHoaDon.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaHoaDon.Location = New System.Drawing.Point(457, 147)
        Me._tbMaHoaDon.Name = "_tbMaHoaDon"
        Me._tbMaHoaDon.ReadOnly = True
        Me._tbMaHoaDon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMaHoaDon.Size = New System.Drawing.Size(205, 40)
        Me._tbMaHoaDon.TabIndex = 15
        Me._tbMaHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_tbMaKhachHang
        '
        Me._tbMaKhachHang.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaKhachHang.Location = New System.Drawing.Point(457, 247)
        Me._tbMaKhachHang.Name = "_tbMaKhachHang"
        Me._tbMaKhachHang.ReadOnly = True
        Me._tbMaKhachHang.Size = New System.Drawing.Size(205, 40)
        Me._tbMaKhachHang.TabIndex = 16
        '
        '_tbTenKhachHang
        '
        Me._tbTenKhachHang.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbTenKhachHang.Location = New System.Drawing.Point(457, 336)
        Me._tbTenKhachHang.Name = "_tbTenKhachHang"
        Me._tbTenKhachHang.ReadOnly = True
        Me._tbTenKhachHang.Size = New System.Drawing.Size(768, 40)
        Me._tbTenKhachHang.TabIndex = 17
        '
        '_btnThanhToan
        '
        Me._btnThanhToan.BackColor = System.Drawing.Color.Purple
        Me._btnThanhToan.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnThanhToan.ForeColor = System.Drawing.Color.White
        Me._btnThanhToan.Location = New System.Drawing.Point(457, 593)
        Me._btnThanhToan.Name = "_btnThanhToan"
        Me._btnThanhToan.Size = New System.Drawing.Size(768, 89)
        Me._btnThanhToan.TabIndex = 18
        Me._btnThanhToan.Text = "Thanh Toán"
        Me._btnThanhToan.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1059)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1924, 25)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'LapHoaDonThanhToan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1084)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me._btnThanhToan)
        Me.Controls.Add(Me._tbTenKhachHang)
        Me.Controls.Add(Me._tbMaKhachHang)
        Me.Controls.Add(Me._tbMaHoaDon)
        Me.Controls.Add(Me._lbMaHoaDon)
        Me.Controls.Add(Me._lbMaKhachHang)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me._tbTriGiaHoaDon)
        Me.Controls.Add(Me._tbDiaChi)
        Me.Controls.Add(Me._lbTriGiaHoaDon)
        Me.Controls.Add(Me._lbDiaChi)
        Me.Controls.Add(Me._lbTenKhachHang)
        Me.Controls.Add(Me._lbLapHoaDon)
        Me.Controls.Add(Me._btnTroVe)
        Me.Controls.Add(Me._lbNgayLapHoaDon)
        Me.Controls.Add(Me._dtpNgayLapHoaDon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LapHoaDonThanhToan"
        Me.Text = "LapHoaDonThanhToan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _dtpNgayLapHoaDon As DateTimePicker
    Friend WithEvents _lbNgayLapHoaDon As Label
    Friend WithEvents _btnTroVe As Button
    Friend WithEvents _lbLapHoaDon As Label
    Friend WithEvents _lbTenKhachHang As Label
    Friend WithEvents _lbDiaChi As Label
    Friend WithEvents _lbTriGiaHoaDon As Label
    Friend WithEvents _tbTriGiaHoaDon As TextBox
    Friend WithEvents _lbMaKhachHang As Label
    Friend WithEvents _lbMaHoaDon As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _tbMaHoaDon As TextBox
    Friend WithEvents _tbDiaChi As TextBox
    Friend WithEvents _tbMaKhachHang As TextBox
    Friend WithEvents _tbTenKhachHang As TextBox
    Friend WithEvents _btnThanhToan As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
