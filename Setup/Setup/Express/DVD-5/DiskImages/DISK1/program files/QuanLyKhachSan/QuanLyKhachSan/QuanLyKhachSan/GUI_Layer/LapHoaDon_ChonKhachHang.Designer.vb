<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapHoaDon_ChonKhachHang
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
        Me._tbMaKhachHang = New System.Windows.Forms.TextBox()
        Me._lbMaKhachHang = New System.Windows.Forms.Label()
        Me._lbTenKhachHang = New System.Windows.Forms.Label()
        Me._cbTenKhachHang = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me._lbTimKhachHang = New System.Windows.Forms.Label()
        Me._btnLapHoaDon = New System.Windows.Forms.Button()
        Me._btnTroVe = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_tbMaKhachHang
        '
        Me._tbMaKhachHang.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaKhachHang.Location = New System.Drawing.Point(368, 107)
        Me._tbMaKhachHang.Name = "_tbMaKhachHang"
        Me._tbMaKhachHang.ReadOnly = True
        Me._tbMaKhachHang.Size = New System.Drawing.Size(335, 40)
        Me._tbMaKhachHang.TabIndex = 21
        '
        '_lbMaKhachHang
        '
        Me._lbMaKhachHang.AutoSize = True
        Me._lbMaKhachHang.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaKhachHang.Location = New System.Drawing.Point(74, 110)
        Me._lbMaKhachHang.Name = "_lbMaKhachHang"
        Me._lbMaKhachHang.Size = New System.Drawing.Size(260, 34)
        Me._lbMaKhachHang.TabIndex = 20
        Me._lbMaKhachHang.Text = "Mã Khách Hàng"
        '
        '_lbTenKhachHang
        '
        Me._lbTenKhachHang.AutoSize = True
        Me._lbTenKhachHang.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbTenKhachHang.Location = New System.Drawing.Point(74, 178)
        Me._lbTenKhachHang.Name = "_lbTenKhachHang"
        Me._lbTenKhachHang.Size = New System.Drawing.Size(272, 34)
        Me._lbTenKhachHang.TabIndex = 17
        Me._lbTenKhachHang.Text = "Tên Khách Hàng"
        '
        '_cbTenKhachHang
        '
        Me._cbTenKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me._cbTenKhachHang.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cbTenKhachHang.Location = New System.Drawing.Point(368, 172)
        Me._cbTenKhachHang.Name = "_cbTenKhachHang"
        Me._cbTenKhachHang.Size = New System.Drawing.Size(335, 40)
        Me._cbTenKhachHang.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(80, 324)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(788, 237)
        Me.DataGridView1.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(734, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 59)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Tìm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '_lbTimKhachHang
        '
        Me._lbTimKhachHang.AutoSize = True
        Me._lbTimKhachHang.Font = New System.Drawing.Font("Verdana", 25.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbTimKhachHang.Location = New System.Drawing.Point(219, 21)
        Me._lbTimKhachHang.Name = "_lbTimKhachHang"
        Me._lbTimKhachHang.Size = New System.Drawing.Size(418, 52)
        Me._lbTimKhachHang.TabIndex = 25
        Me._lbTimKhachHang.Text = "Tìm Khách Hàng"
        '
        '_btnLapHoaDon
        '
        Me._btnLapHoaDon.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnLapHoaDon.Location = New System.Drawing.Point(80, 232)
        Me._btnLapHoaDon.Name = "_btnLapHoaDon"
        Me._btnLapHoaDon.Size = New System.Drawing.Size(303, 71)
        Me._btnLapHoaDon.TabIndex = 26
        Me._btnLapHoaDon.Text = "Lập Hóa Đơn"
        Me._btnLapHoaDon.UseVisualStyleBackColor = True
        '
        '_btnTroVe
        '
        Me._btnTroVe.BackColor = System.Drawing.Color.DarkRed
        Me._btnTroVe.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTroVe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me._btnTroVe.Location = New System.Drawing.Point(704, 227)
        Me._btnTroVe.Name = "_btnTroVe"
        Me._btnTroVe.Size = New System.Drawing.Size(164, 71)
        Me._btnTroVe.TabIndex = 27
        Me._btnTroVe.Text = "Trở Về"
        Me._btnTroVe.UseVisualStyleBackColor = False
        '
        'LapHoaDon_ChonKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 589)
        Me.Controls.Add(Me._btnTroVe)
        Me.Controls.Add(Me._btnLapHoaDon)
        Me.Controls.Add(Me._lbTimKhachHang)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me._cbTenKhachHang)
        Me.Controls.Add(Me._tbMaKhachHang)
        Me.Controls.Add(Me._lbMaKhachHang)
        Me.Controls.Add(Me._lbTenKhachHang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LapHoaDon_ChonKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LapHoaDon_ChonKhachHang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _lbMaKhachHang As Label
    Friend WithEvents _lbTenKhachHang As Label
    Friend WithEvents _cbTenKhachHang As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents _lbTimKhachHang As Label
    Friend WithEvents _btnLapHoaDon As Button
    Friend WithEvents _btnTroVe As Button
    Public WithEvents _tbMaKhachHang As TextBox
End Class
