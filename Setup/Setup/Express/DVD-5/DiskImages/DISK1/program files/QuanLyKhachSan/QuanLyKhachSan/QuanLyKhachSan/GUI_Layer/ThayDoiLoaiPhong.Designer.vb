<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThayDoiLoaiPhong
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
        Me._lbThayDoiLoaiPhong = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._lbMaLoaiPhong = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._tbMaLoaiPhong = New System.Windows.Forms.TextBox()
        Me._tbDonGia = New System.Windows.Forms.TextBox()
        Me._tbTenLoaiPhong = New System.Windows.Forms.TextBox()
        Me._btnThem = New System.Windows.Forms.Button()
        Me._btnXoa = New System.Windows.Forms.Button()
        Me._btnTroVe = New System.Windows.Forms.Button()
        Me._btnSua = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_lbThayDoiLoaiPhong
        '
        Me._lbThayDoiLoaiPhong.AutoSize = True
        Me._lbThayDoiLoaiPhong.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbThayDoiLoaiPhong.Location = New System.Drawing.Point(174, 33)
        Me._lbThayDoiLoaiPhong.Name = "_lbThayDoiLoaiPhong"
        Me._lbThayDoiLoaiPhong.Size = New System.Drawing.Size(480, 48)
        Me._lbThayDoiLoaiPhong.TabIndex = 0
        Me._lbThayDoiLoaiPhong.Text = "Thay Đổi Loại Phòng"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(47, 448)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(803, 167)
        Me.DataGridView1.TabIndex = 1
        '
        '_lbMaLoaiPhong
        '
        Me._lbMaLoaiPhong.AutoSize = True
        Me._lbMaLoaiPhong.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaLoaiPhong.Location = New System.Drawing.Point(42, 139)
        Me._lbMaLoaiPhong.Name = "_lbMaLoaiPhong"
        Me._lbMaLoaiPhong.Size = New System.Drawing.Size(273, 29)
        Me._lbMaLoaiPhong.TabIndex = 2
        Me._lbMaLoaiPhong.Text = "Mã Loại Phòng Mới:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên Loại Phòng Mới:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(328, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Đơn Giá Loại Phòng Mới"
        '
        '_tbMaLoaiPhong
        '
        Me._tbMaLoaiPhong.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaLoaiPhong.Location = New System.Drawing.Point(421, 136)
        Me._tbMaLoaiPhong.Name = "_tbMaLoaiPhong"
        Me._tbMaLoaiPhong.Size = New System.Drawing.Size(429, 35)
        Me._tbMaLoaiPhong.TabIndex = 5
        '
        '_tbDonGia
        '
        Me._tbDonGia.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbDonGia.Location = New System.Drawing.Point(421, 287)
        Me._tbDonGia.Name = "_tbDonGia"
        Me._tbDonGia.Size = New System.Drawing.Size(429, 35)
        Me._tbDonGia.TabIndex = 6
        '
        '_tbTenLoaiPhong
        '
        Me._tbTenLoaiPhong.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbTenLoaiPhong.Location = New System.Drawing.Point(421, 213)
        Me._tbTenLoaiPhong.Name = "_tbTenLoaiPhong"
        Me._tbTenLoaiPhong.Size = New System.Drawing.Size(429, 35)
        Me._tbTenLoaiPhong.TabIndex = 7
        '
        '_btnThem
        '
        Me._btnThem.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnThem.Location = New System.Drawing.Point(47, 361)
        Me._btnThem.Name = "_btnThem"
        Me._btnThem.Size = New System.Drawing.Size(204, 64)
        Me._btnThem.TabIndex = 8
        Me._btnThem.Text = "Thêm Mới"
        Me._btnThem.UseVisualStyleBackColor = True
        '
        '_btnXoa
        '
        Me._btnXoa.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnXoa.Location = New System.Drawing.Point(279, 361)
        Me._btnXoa.Name = "_btnXoa"
        Me._btnXoa.Size = New System.Drawing.Size(176, 64)
        Me._btnXoa.TabIndex = 9
        Me._btnXoa.Text = "Xóa"
        Me._btnXoa.UseVisualStyleBackColor = True
        '
        '_btnTroVe
        '
        Me._btnTroVe.BackColor = System.Drawing.Color.DarkRed
        Me._btnTroVe.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTroVe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me._btnTroVe.Location = New System.Drawing.Point(688, 361)
        Me._btnTroVe.Name = "_btnTroVe"
        Me._btnTroVe.Size = New System.Drawing.Size(162, 64)
        Me._btnTroVe.TabIndex = 10
        Me._btnTroVe.Text = "Trở Về"
        Me._btnTroVe.UseVisualStyleBackColor = False
        '
        '_btnSua
        '
        Me._btnSua.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnSua.Location = New System.Drawing.Point(480, 361)
        Me._btnSua.Name = "_btnSua"
        Me._btnSua.Size = New System.Drawing.Size(174, 64)
        Me._btnSua.TabIndex = 11
        Me._btnSua.Text = "Sửa"
        Me._btnSua.UseVisualStyleBackColor = True
        '
        'ThayDoiLoaiPhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 652)
        Me.Controls.Add(Me._btnSua)
        Me.Controls.Add(Me._btnTroVe)
        Me.Controls.Add(Me._btnXoa)
        Me.Controls.Add(Me._btnThem)
        Me.Controls.Add(Me._tbTenLoaiPhong)
        Me.Controls.Add(Me._tbDonGia)
        Me.Controls.Add(Me._tbMaLoaiPhong)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me._lbMaLoaiPhong)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me._lbThayDoiLoaiPhong)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ThayDoiLoaiPhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThayDoiLoaiPhong"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _lbThayDoiLoaiPhong As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _lbMaLoaiPhong As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents _tbMaLoaiPhong As TextBox
    Friend WithEvents _tbDonGia As TextBox
    Friend WithEvents _tbTenLoaiPhong As TextBox
    Friend WithEvents _btnThem As Button
    Friend WithEvents _btnXoa As Button
    Friend WithEvents _btnTroVe As Button
    Friend WithEvents _btnSua As Button
End Class
