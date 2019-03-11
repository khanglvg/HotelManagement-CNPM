<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapDanhMucPhong
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
        Me._lbLapDanhMucPhong = New System.Windows.Forms.Label()
        Me._tbMaPhong = New System.Windows.Forms.TextBox()
        Me._tbTenPhong = New System.Windows.Forms.TextBox()
        Me._lbMaPhong = New System.Windows.Forms.Label()
        Me._lbTenPhong = New System.Windows.Forms.Label()
        Me._lbMaLoaiPhong = New System.Windows.Forms.Label()
        Me._lbGhiChu = New System.Windows.Forms.Label()
        Me._btnThemPhong = New System.Windows.Forms.Button()
        Me._btnXoaPhong = New System.Windows.Forms.Button()
        Me._btnTroVe = New System.Windows.Forms.Button()
        Me._lbTinhTrangPhong = New System.Windows.Forms.Label()
        Me._rtbGhiChu = New System.Windows.Forms.RichTextBox()
        Me._cbTinhTrangPhong = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._tbTenLoaiPhong = New System.Windows.Forms.TextBox()
        Me._cbMaLoaiPhong = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_lbLapDanhMucPhong
        '
        Me._lbLapDanhMucPhong.AutoSize = True
        Me._lbLapDanhMucPhong.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbLapDanhMucPhong.Location = New System.Drawing.Point(427, 23)
        Me._lbLapDanhMucPhong.Name = "_lbLapDanhMucPhong"
        Me._lbLapDanhMucPhong.Size = New System.Drawing.Size(394, 45)
        Me._lbLapDanhMucPhong.TabIndex = 0
        Me._lbLapDanhMucPhong.Text = "Lập Danh Mục Phòng"
        '
        '_tbMaPhong
        '
        Me._tbMaPhong.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaPhong.Location = New System.Drawing.Point(324, 104)
        Me._tbMaPhong.MaxLength = 8
        Me._tbMaPhong.Name = "_tbMaPhong"
        Me._tbMaPhong.Size = New System.Drawing.Size(174, 36)
        Me._tbMaPhong.TabIndex = 1
        '
        '_tbTenPhong
        '
        Me._tbTenPhong.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbTenPhong.Location = New System.Drawing.Point(992, 104)
        Me._tbTenPhong.MaxLength = 8
        Me._tbTenPhong.Name = "_tbTenPhong"
        Me._tbTenPhong.Size = New System.Drawing.Size(247, 36)
        Me._tbTenPhong.TabIndex = 2
        '
        '_lbMaPhong
        '
        Me._lbMaPhong.AutoSize = True
        Me._lbMaPhong.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaPhong.Location = New System.Drawing.Point(68, 104)
        Me._lbMaPhong.Name = "_lbMaPhong"
        Me._lbMaPhong.Size = New System.Drawing.Size(140, 32)
        Me._lbMaPhong.TabIndex = 4
        Me._lbMaPhong.Text = "Mã Phòng"
        '
        '_lbTenPhong
        '
        Me._lbTenPhong.AutoSize = True
        Me._lbTenPhong.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbTenPhong.Location = New System.Drawing.Point(735, 100)
        Me._lbTenPhong.Name = "_lbTenPhong"
        Me._lbTenPhong.Size = New System.Drawing.Size(146, 32)
        Me._lbTenPhong.TabIndex = 5
        Me._lbTenPhong.Text = "Tên Phòng"
        '
        '_lbMaLoaiPhong
        '
        Me._lbMaLoaiPhong.AutoSize = True
        Me._lbMaLoaiPhong.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaLoaiPhong.Location = New System.Drawing.Point(59, 185)
        Me._lbMaLoaiPhong.Name = "_lbMaLoaiPhong"
        Me._lbMaLoaiPhong.Size = New System.Drawing.Size(202, 32)
        Me._lbMaLoaiPhong.TabIndex = 6
        Me._lbMaLoaiPhong.Text = "Mã Loại Phòng"
        '
        '_lbGhiChu
        '
        Me._lbGhiChu.AutoSize = True
        Me._lbGhiChu.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbGhiChu.Location = New System.Drawing.Point(59, 353)
        Me._lbGhiChu.Name = "_lbGhiChu"
        Me._lbGhiChu.Size = New System.Drawing.Size(120, 32)
        Me._lbGhiChu.TabIndex = 8
        Me._lbGhiChu.Text = "Ghi Chú"
        '
        '_btnThemPhong
        '
        Me._btnThemPhong.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnThemPhong.Location = New System.Drawing.Point(65, 468)
        Me._btnThemPhong.Name = "_btnThemPhong"
        Me._btnThemPhong.Size = New System.Drawing.Size(197, 64)
        Me._btnThemPhong.TabIndex = 9
        Me._btnThemPhong.Text = "Thêm Phòng"
        Me._btnThemPhong.UseVisualStyleBackColor = True
        '
        '_btnXoaPhong
        '
        Me._btnXoaPhong.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnXoaPhong.Location = New System.Drawing.Point(303, 468)
        Me._btnXoaPhong.Name = "_btnXoaPhong"
        Me._btnXoaPhong.Size = New System.Drawing.Size(175, 64)
        Me._btnXoaPhong.TabIndex = 11
        Me._btnXoaPhong.Text = "Xóa Phòng"
        Me._btnXoaPhong.UseVisualStyleBackColor = True
        '
        '_btnTroVe
        '
        Me._btnTroVe.BackColor = System.Drawing.Color.DarkRed
        Me._btnTroVe.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTroVe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me._btnTroVe.Location = New System.Drawing.Point(1064, 468)
        Me._btnTroVe.Name = "_btnTroVe"
        Me._btnTroVe.Size = New System.Drawing.Size(175, 74)
        Me._btnTroVe.TabIndex = 12
        Me._btnTroVe.Text = "Trở Về"
        Me._btnTroVe.UseVisualStyleBackColor = False
        '
        '_lbTinhTrangPhong
        '
        Me._lbTinhTrangPhong.AutoSize = True
        Me._lbTinhTrangPhong.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbTinhTrangPhong.Location = New System.Drawing.Point(59, 272)
        Me._lbTinhTrangPhong.Name = "_lbTinhTrangPhong"
        Me._lbTinhTrangPhong.Size = New System.Drawing.Size(236, 32)
        Me._lbTinhTrangPhong.TabIndex = 13
        Me._lbTinhTrangPhong.Text = "Tình Trạng Phòng"
        '
        '_rtbGhiChu
        '
        Me._rtbGhiChu.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._rtbGhiChu.Location = New System.Drawing.Point(324, 353)
        Me._rtbGhiChu.MaxLength = 8
        Me._rtbGhiChu.Name = "_rtbGhiChu"
        Me._rtbGhiChu.Size = New System.Drawing.Size(915, 96)
        Me._rtbGhiChu.TabIndex = 14
        Me._rtbGhiChu.Text = "Không"
        '
        '_cbTinhTrangPhong
        '
        Me._cbTinhTrangPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cbTinhTrangPhong.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cbTinhTrangPhong.FormattingEnabled = True
        Me._cbTinhTrangPhong.Items.AddRange(New Object() {"Trong ", "Da Thue "})
        Me._cbTinhTrangPhong.Location = New System.Drawing.Point(325, 272)
        Me._cbTinhTrangPhong.MaxLength = 8
        Me._cbTinhTrangPhong.Name = "_cbTinhTrangPhong"
        Me._cbTinhTrangPhong.Size = New System.Drawing.Size(174, 37)
        Me._cbTinhTrangPhong.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(65, 570)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1174, 408)
        Me.DataGridView1.TabIndex = 16
        '
        '_tbTenLoaiPhong
        '
        Me._tbTenLoaiPhong.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbTenLoaiPhong.Location = New System.Drawing.Point(992, 185)
        Me._tbTenLoaiPhong.Name = "_tbTenLoaiPhong"
        Me._tbTenLoaiPhong.ReadOnly = True
        Me._tbTenLoaiPhong.Size = New System.Drawing.Size(247, 36)
        Me._tbTenLoaiPhong.TabIndex = 20
        '
        '_cbMaLoaiPhong
        '
        Me._cbMaLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cbMaLoaiPhong.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cbMaLoaiPhong.FormattingEnabled = True
        Me._cbMaLoaiPhong.Location = New System.Drawing.Point(324, 185)
        Me._cbMaLoaiPhong.MaxLength = 8
        Me._cbMaLoaiPhong.Name = "_cbMaLoaiPhong"
        Me._cbMaLoaiPhong.Size = New System.Drawing.Size(174, 37)
        Me._cbMaLoaiPhong.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(735, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 32)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Tên Loại Phòng"
        '
        'LapDanhMucPhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1445, 1092)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._cbMaLoaiPhong)
        Me.Controls.Add(Me._tbTenLoaiPhong)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me._cbTinhTrangPhong)
        Me.Controls.Add(Me._rtbGhiChu)
        Me.Controls.Add(Me._lbTinhTrangPhong)
        Me.Controls.Add(Me._btnTroVe)
        Me.Controls.Add(Me._btnXoaPhong)
        Me.Controls.Add(Me._btnThemPhong)
        Me.Controls.Add(Me._lbGhiChu)
        Me.Controls.Add(Me._lbMaLoaiPhong)
        Me.Controls.Add(Me._lbTenPhong)
        Me.Controls.Add(Me._lbMaPhong)
        Me.Controls.Add(Me._tbTenPhong)
        Me.Controls.Add(Me._tbMaPhong)
        Me.Controls.Add(Me._lbLapDanhMucPhong)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LapDanhMucPhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LapDanhMucPhong"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _lbLapDanhMucPhong As Label
    Friend WithEvents _tbMaPhong As TextBox
    Friend WithEvents _tbTenPhong As TextBox
    Friend WithEvents _lbMaPhong As Label
    Friend WithEvents _lbTenPhong As Label
    Friend WithEvents _lbMaLoaiPhong As Label
    Friend WithEvents _lbGhiChu As Label
    Friend WithEvents _btnThemPhong As Button
    Friend WithEvents _btnXoaPhong As Button
    Friend WithEvents _btnTroVe As Button
    Friend WithEvents _lbTinhTrangPhong As Label
    Friend WithEvents _rtbGhiChu As RichTextBox
    Friend WithEvents _cbTinhTrangPhong As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _tbTenLoaiPhong As TextBox
    Friend WithEvents _cbMaLoaiPhong As ComboBox
    Friend WithEvents Label1 As Label
End Class
