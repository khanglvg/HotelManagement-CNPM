<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThayDoiQuyDinh
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
        Me._btnThayDoiLoaiPhong = New System.Windows.Forms.Button()
        Me._btnThayDoiSoLuongKhach = New System.Windows.Forms.Button()
        Me._btnThayDoiTyLePhuThu = New System.Windows.Forms.Button()
        Me._lbThayDoiQuyDinh = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '_btnThayDoiLoaiPhong
        '
        Me._btnThayDoiLoaiPhong.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnThayDoiLoaiPhong.Location = New System.Drawing.Point(32, 141)
        Me._btnThayDoiLoaiPhong.Name = "_btnThayDoiLoaiPhong"
        Me._btnThayDoiLoaiPhong.Size = New System.Drawing.Size(845, 110)
        Me._btnThayDoiLoaiPhong.TabIndex = 0
        Me._btnThayDoiLoaiPhong.Text = "Thay Đổi Số Lượng Và Đơn Giá Các Loại Phòng"
        Me._btnThayDoiLoaiPhong.UseVisualStyleBackColor = True
        '
        '_btnThayDoiSoLuongKhach
        '
        Me._btnThayDoiSoLuongKhach.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnThayDoiSoLuongKhach.Location = New System.Drawing.Point(32, 330)
        Me._btnThayDoiSoLuongKhach.Name = "_btnThayDoiSoLuongKhach"
        Me._btnThayDoiSoLuongKhach.Size = New System.Drawing.Size(845, 110)
        Me._btnThayDoiSoLuongKhach.TabIndex = 1
        Me._btnThayDoiSoLuongKhach.Text = "Thay Đổi Số Lượng Và Hệ Số Các Loại Khách, Số Lượng Khách Tối Đa Trong Phòng"
        Me._btnThayDoiSoLuongKhach.UseVisualStyleBackColor = True
        '
        '_btnThayDoiTyLePhuThu
        '
        Me._btnThayDoiTyLePhuThu.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnThayDoiTyLePhuThu.Location = New System.Drawing.Point(32, 509)
        Me._btnThayDoiTyLePhuThu.Name = "_btnThayDoiTyLePhuThu"
        Me._btnThayDoiTyLePhuThu.Size = New System.Drawing.Size(845, 110)
        Me._btnThayDoiTyLePhuThu.TabIndex = 2
        Me._btnThayDoiTyLePhuThu.Text = "Thay Đổi Tỷ Lệ Phụ Thu"
        Me._btnThayDoiTyLePhuThu.UseVisualStyleBackColor = True
        '
        '_lbThayDoiQuyDinh
        '
        Me._lbThayDoiQuyDinh.AutoSize = True
        Me._lbThayDoiQuyDinh.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbThayDoiQuyDinh.Location = New System.Drawing.Point(229, 48)
        Me._lbThayDoiQuyDinh.Name = "_lbThayDoiQuyDinh"
        Me._lbThayDoiQuyDinh.Size = New System.Drawing.Size(439, 48)
        Me._lbThayDoiQuyDinh.TabIndex = 3
        Me._lbThayDoiQuyDinh.Text = "Thay Đổi Quy Định"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkRed
        Me.Button4.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(703, 670)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(174, 75)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Trở Về"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ThayDoiQuyDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 757)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me._lbThayDoiQuyDinh)
        Me.Controls.Add(Me._btnThayDoiTyLePhuThu)
        Me.Controls.Add(Me._btnThayDoiSoLuongKhach)
        Me.Controls.Add(Me._btnThayDoiLoaiPhong)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ThayDoiQuyDinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThayDoiQuyDinh"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _btnThayDoiLoaiPhong As Button
    Friend WithEvents _btnThayDoiSoLuongKhach As Button
    Friend WithEvents _btnThayDoiTyLePhuThu As Button
    Friend WithEvents _lbThayDoiQuyDinh As Label
    Friend WithEvents Button4 As Button
End Class
