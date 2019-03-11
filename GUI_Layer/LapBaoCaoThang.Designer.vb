<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapBaoCaoThang
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me._lbLapBaoCao = New System.Windows.Forms.Label()
        Me._lbMaBaoCao = New System.Windows.Forms.Label()
        Me._lbTenBaoCao = New System.Windows.Forms.Label()
        Me._lbThang = New System.Windows.Forms.Label()
        Me._tbMaBaoCao = New System.Windows.Forms.TextBox()
        Me._cbTenLoaiBaoCao = New System.Windows.Forms.ComboBox()
        Me._cbThang = New System.Windows.Forms.ComboBox()
        Me._btnTroVe = New System.Windows.Forms.Button()
        Me._btnLapBaoCao = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '_lbLapBaoCao
        '
        Me._lbLapBaoCao.AutoSize = True
        Me._lbLapBaoCao.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbLapBaoCao.Location = New System.Drawing.Point(252, 32)
        Me._lbLapBaoCao.Name = "_lbLapBaoCao"
        Me._lbLapBaoCao.Size = New System.Drawing.Size(449, 48)
        Me._lbLapBaoCao.TabIndex = 0
        Me._lbLapBaoCao.Text = "Lập Báo Cáo Tháng"
        '
        '_lbMaBaoCao
        '
        Me._lbMaBaoCao.AutoSize = True
        Me._lbMaBaoCao.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaBaoCao.Location = New System.Drawing.Point(36, 125)
        Me._lbMaBaoCao.Name = "_lbMaBaoCao"
        Me._lbMaBaoCao.Size = New System.Drawing.Size(177, 29)
        Me._lbMaBaoCao.TabIndex = 1
        Me._lbMaBaoCao.Text = "Mã Báo Cáo:"
        '
        '_lbTenBaoCao
        '
        Me._lbTenBaoCao.AutoSize = True
        Me._lbTenBaoCao.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbTenBaoCao.Location = New System.Drawing.Point(36, 206)
        Me._lbTenBaoCao.Name = "_lbTenBaoCao"
        Me._lbTenBaoCao.Size = New System.Drawing.Size(250, 29)
        Me._lbTenBaoCao.TabIndex = 2
        Me._lbTenBaoCao.Text = "Tên Loại Báo Cáo:"
        '
        '_lbThang
        '
        Me._lbThang.AutoSize = True
        Me._lbThang.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbThang.Location = New System.Drawing.Point(36, 291)
        Me._lbThang.Name = "_lbThang"
        Me._lbThang.Size = New System.Drawing.Size(106, 29)
        Me._lbThang.TabIndex = 3
        Me._lbThang.Text = "Tháng:"
        '
        '_tbMaBaoCao
        '
        Me._tbMaBaoCao.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaBaoCao.Location = New System.Drawing.Point(367, 122)
        Me._tbMaBaoCao.Name = "_tbMaBaoCao"
        Me._tbMaBaoCao.ReadOnly = True
        Me._tbMaBaoCao.Size = New System.Drawing.Size(510, 35)
        Me._tbMaBaoCao.TabIndex = 4
        '
        '_cbTenLoaiBaoCao
        '
        Me._cbTenLoaiBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cbTenLoaiBaoCao.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cbTenLoaiBaoCao.FormattingEnabled = True
        Me._cbTenLoaiBaoCao.Items.AddRange(New Object() {"Báo Cáo Doanh Thu Theo Loại Phòng", "Báo Cáo Mật Độ Sử Dụng Phòng"})
        Me._cbTenLoaiBaoCao.Location = New System.Drawing.Point(367, 203)
        Me._cbTenLoaiBaoCao.Name = "_cbTenLoaiBaoCao"
        Me._cbTenLoaiBaoCao.Size = New System.Drawing.Size(510, 36)
        Me._cbTenLoaiBaoCao.TabIndex = 5
        '
        '_cbThang
        '
        Me._cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cbThang.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._cbThang.FormattingEnabled = True
        Me._cbThang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me._cbThang.Location = New System.Drawing.Point(367, 284)
        Me._cbThang.Name = "_cbThang"
        Me._cbThang.Size = New System.Drawing.Size(510, 36)
        Me._cbThang.TabIndex = 6
        '
        '_btnTroVe
        '
        Me._btnTroVe.BackColor = System.Drawing.Color.DarkRed
        Me._btnTroVe.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTroVe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me._btnTroVe.Location = New System.Drawing.Point(625, 411)
        Me._btnTroVe.Name = "_btnTroVe"
        Me._btnTroVe.Size = New System.Drawing.Size(252, 83)
        Me._btnTroVe.TabIndex = 7
        Me._btnTroVe.Text = "Trở Về"
        Me._btnTroVe.UseVisualStyleBackColor = False
        '
        '_btnLapBaoCao
        '
        Me._btnLapBaoCao.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnLapBaoCao.Location = New System.Drawing.Point(41, 411)
        Me._btnLapBaoCao.Name = "_btnLapBaoCao"
        Me._btnLapBaoCao.Size = New System.Drawing.Size(385, 83)
        Me._btnLapBaoCao.TabIndex = 8
        Me._btnLapBaoCao.Text = "Lập Báo Cáo"
        Me._btnLapBaoCao.UseVisualStyleBackColor = True
        '
        'LapBaoCaoThang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 557)
        Me.Controls.Add(Me._btnLapBaoCao)
        Me.Controls.Add(Me._btnTroVe)
        Me.Controls.Add(Me._cbThang)
        Me.Controls.Add(Me._cbTenLoaiBaoCao)
        Me.Controls.Add(Me._tbMaBaoCao)
        Me.Controls.Add(Me._lbThang)
        Me.Controls.Add(Me._lbTenBaoCao)
        Me.Controls.Add(Me._lbMaBaoCao)
        Me.Controls.Add(Me._lbLapBaoCao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LapBaoCaoThang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LapBaoCaoThang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _lbLapBaoCao As Label
    Friend WithEvents _lbMaBaoCao As Label
    Friend WithEvents _lbTenBaoCao As Label
    Friend WithEvents _lbThang As Label
    Public WithEvents _tbMaBaoCao As TextBox
    Friend WithEvents _cbTenLoaiBaoCao As ComboBox
    Public WithEvents _cbThang As ComboBox
    Friend WithEvents _btnTroVe As Button
    Friend WithEvents _btnLapBaoCao As Button
End Class
