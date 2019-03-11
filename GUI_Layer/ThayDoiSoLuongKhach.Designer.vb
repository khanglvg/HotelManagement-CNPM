<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThayDoiSoLuongKhach
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._lbMaLoaiKhachMoi = New System.Windows.Forms.Label()
        Me._lbTenLoaiKhachMoi = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me._btnThem = New System.Windows.Forms.Button()
        Me._tbTenLoaiKhachMoi = New System.Windows.Forms.TextBox()
        Me._tbMaLoaiKhachMoi = New System.Windows.Forms.TextBox()
        Me._btnCapNhat = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._tbHeSoMoi = New System.Windows.Forms.TextBox()
        Me._tbHeSoCu = New System.Windows.Forms.TextBox()
        Me._btnXoa = New System.Windows.Forms.Button()
        Me._btnSua = New System.Windows.Forms.Button()
        Me._btnTroVe = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thay Đổi Số Lượng Khách"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 559)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(920, 217)
        Me.DataGridView1.TabIndex = 1
        '
        '_lbMaLoaiKhachMoi
        '
        Me._lbMaLoaiKhachMoi.AutoSize = True
        Me._lbMaLoaiKhachMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaLoaiKhachMoi.Location = New System.Drawing.Point(76, 50)
        Me._lbMaLoaiKhachMoi.Name = "_lbMaLoaiKhachMoi"
        Me._lbMaLoaiKhachMoi.Size = New System.Drawing.Size(234, 29)
        Me._lbMaLoaiKhachMoi.TabIndex = 2
        Me._lbMaLoaiKhachMoi.Text = "Mã Loại Khách Mới"
        '
        '_lbTenLoaiKhachMoi
        '
        Me._lbTenLoaiKhachMoi.AutoSize = True
        Me._lbTenLoaiKhachMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbTenLoaiKhachMoi.Location = New System.Drawing.Point(76, 114)
        Me._lbTenLoaiKhachMoi.Name = "_lbTenLoaiKhachMoi"
        Me._lbTenLoaiKhachMoi.Size = New System.Drawing.Size(245, 29)
        Me._lbTenLoaiKhachMoi.TabIndex = 3
        Me._lbTenLoaiKhachMoi.Text = "Tên Loại Khách Mới"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me._btnThem)
        Me.GroupBox1.Controls.Add(Me._tbTenLoaiKhachMoi)
        Me.GroupBox1.Controls.Add(Me._tbMaLoaiKhachMoi)
        Me.GroupBox1.Controls.Add(Me._lbMaLoaiKhachMoi)
        Me.GroupBox1.Controls.Add(Me._lbTenLoaiKhachMoi)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 175)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thay Đổi Loại Khách"
        '
        '_btnThem
        '
        Me._btnThem.Location = New System.Drawing.Point(726, 50)
        Me._btnThem.Name = "_btnThem"
        Me._btnThem.Size = New System.Drawing.Size(174, 93)
        Me._btnThem.TabIndex = 6
        Me._btnThem.Text = "Thêm Mới"
        Me._btnThem.UseVisualStyleBackColor = True
        '
        '_tbTenLoaiKhachMoi
        '
        Me._tbTenLoaiKhachMoi.Location = New System.Drawing.Point(353, 109)
        Me._tbTenLoaiKhachMoi.Name = "_tbTenLoaiKhachMoi"
        Me._tbTenLoaiKhachMoi.Size = New System.Drawing.Size(302, 34)
        Me._tbTenLoaiKhachMoi.TabIndex = 5
        '
        '_tbMaLoaiKhachMoi
        '
        Me._tbMaLoaiKhachMoi.Location = New System.Drawing.Point(353, 47)
        Me._tbMaLoaiKhachMoi.Name = "_tbMaLoaiKhachMoi"
        Me._tbMaLoaiKhachMoi.Size = New System.Drawing.Size(302, 34)
        Me._tbMaLoaiKhachMoi.TabIndex = 4
        '
        '_btnCapNhat
        '
        Me._btnCapNhat.Location = New System.Drawing.Point(726, 48)
        Me._btnCapNhat.Name = "_btnCapNhat"
        Me._btnCapNhat.Size = New System.Drawing.Size(174, 86)
        Me._btnCapNhat.TabIndex = 7
        Me._btnCapNhat.Text = "Cập Nhật"
        Me._btnCapNhat.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me._tbHeSoMoi)
        Me.GroupBox2.Controls.Add(Me._tbHeSoCu)
        Me.GroupBox2.Controls.Add(Me._btnCapNhat)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(920, 157)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thay Đổi Số Lượng Khách Tối Đa Trong Phòng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Hệ Số Mới"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hệ Số Cũ"
        '
        '_tbHeSoMoi
        '
        Me._tbHeSoMoi.Location = New System.Drawing.Point(353, 105)
        Me._tbHeSoMoi.Name = "_tbHeSoMoi"
        Me._tbHeSoMoi.Size = New System.Drawing.Size(302, 34)
        Me._tbHeSoMoi.TabIndex = 8
        '
        '_tbHeSoCu
        '
        Me._tbHeSoCu.Location = New System.Drawing.Point(353, 48)
        Me._tbHeSoCu.Name = "_tbHeSoCu"
        Me._tbHeSoCu.ReadOnly = True
        Me._tbHeSoCu.Size = New System.Drawing.Size(302, 34)
        Me._tbHeSoCu.TabIndex = 7
        '
        '_btnXoa
        '
        Me._btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnXoa.Location = New System.Drawing.Point(12, 460)
        Me._btnXoa.Name = "_btnXoa"
        Me._btnXoa.Size = New System.Drawing.Size(256, 84)
        Me._btnXoa.TabIndex = 9
        Me._btnXoa.Text = "Xóa Loại Khách Cũ"
        Me._btnXoa.UseVisualStyleBackColor = True
        '
        '_btnSua
        '
        Me._btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnSua.Location = New System.Drawing.Point(287, 460)
        Me._btnSua.Name = "_btnSua"
        Me._btnSua.Size = New System.Drawing.Size(256, 84)
        Me._btnSua.TabIndex = 10
        Me._btnSua.Text = "Sửa Loại Khách Cũ"
        Me._btnSua.UseVisualStyleBackColor = True
        '
        '_btnTroVe
        '
        Me._btnTroVe.BackColor = System.Drawing.Color.DarkRed
        Me._btnTroVe.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTroVe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me._btnTroVe.Location = New System.Drawing.Point(738, 460)
        Me._btnTroVe.Name = "_btnTroVe"
        Me._btnTroVe.Size = New System.Drawing.Size(174, 84)
        Me._btnTroVe.TabIndex = 11
        Me._btnTroVe.Text = "Trở Về"
        Me._btnTroVe.UseVisualStyleBackColor = False
        '
        'ThayDoiSoLuongKhach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 788)
        Me.Controls.Add(Me._btnTroVe)
        Me.Controls.Add(Me._btnSua)
        Me.Controls.Add(Me._btnXoa)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ThayDoiSoLuongKhach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThayDoiSoLuongKhach"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _lbMaLoaiKhachMoi As Label
    Friend WithEvents _lbTenLoaiKhachMoi As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents _btnThem As Button
    Friend WithEvents _tbTenLoaiKhachMoi As TextBox
    Friend WithEvents _tbMaLoaiKhachMoi As TextBox
    Friend WithEvents _btnCapNhat As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents _tbHeSoMoi As TextBox
    Friend WithEvents _tbHeSoCu As TextBox
    Friend WithEvents _btnXoa As Button
    Friend WithEvents _btnSua As Button
    Friend WithEvents _btnTroVe As Button
End Class
