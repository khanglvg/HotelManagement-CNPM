<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaoCaoDoanhThu
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._tbThang = New System.Windows.Forms.TextBox()
        Me._lbThang = New System.Windows.Forms.Label()
        Me._lbBaoCaoDoanhThu = New System.Windows.Forms.Label()
        Me._tbMaBaoCao = New System.Windows.Forms.TextBox()
        Me._lbMaBaoCao = New System.Windows.Forms.Label()
        Me._btnTroVe = New System.Windows.Forms.Button()
        Me._btnLuuBaoCao = New System.Windows.Forms.Button()
        Me._tbMaBaoCaoDoanhThu = New System.Windows.Forms.TextBox()
        Me._lbMaBaoCaoDoanhThu = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(39, 373)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(996, 209)
        Me.DataGridView1.TabIndex = 7
        '
        '_tbThang
        '
        Me._tbThang.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbThang.Location = New System.Drawing.Point(524, 184)
        Me._tbThang.Name = "_tbThang"
        Me._tbThang.ReadOnly = True
        Me._tbThang.Size = New System.Drawing.Size(114, 40)
        Me._tbThang.TabIndex = 6
        Me._tbThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_lbThang
        '
        Me._lbThang.AutoSize = True
        Me._lbThang.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbThang.Location = New System.Drawing.Point(382, 187)
        Me._lbThang.Name = "_lbThang"
        Me._lbThang.Size = New System.Drawing.Size(124, 34)
        Me._lbThang.TabIndex = 5
        Me._lbThang.Text = "Tháng:"
        '
        '_lbBaoCaoDoanhThu
        '
        Me._lbBaoCaoDoanhThu.AutoSize = True
        Me._lbBaoCaoDoanhThu.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbBaoCaoDoanhThu.Location = New System.Drawing.Point(23, 39)
        Me._lbBaoCaoDoanhThu.Name = "_lbBaoCaoDoanhThu"
        Me._lbBaoCaoDoanhThu.Size = New System.Drawing.Size(974, 48)
        Me._lbBaoCaoDoanhThu.TabIndex = 4
        Me._lbBaoCaoDoanhThu.Text = "Báo Cáo Doanh Thu Theo Từng Loại Phòng"
        '
        '_tbMaBaoCao
        '
        Me._tbMaBaoCao.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaBaoCao.Location = New System.Drawing.Point(273, 118)
        Me._tbMaBaoCao.Name = "_tbMaBaoCao"
        Me._tbMaBaoCao.ReadOnly = True
        Me._tbMaBaoCao.Size = New System.Drawing.Size(138, 40)
        Me._tbMaBaoCao.TabIndex = 11
        Me._tbMaBaoCao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_lbMaBaoCao
        '
        Me._lbMaBaoCao.AutoSize = True
        Me._lbMaBaoCao.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaBaoCao.Location = New System.Drawing.Point(33, 121)
        Me._lbMaBaoCao.Name = "_lbMaBaoCao"
        Me._lbMaBaoCao.Size = New System.Drawing.Size(209, 34)
        Me._lbMaBaoCao.TabIndex = 10
        Me._lbMaBaoCao.Text = "Mã Báo Cáo:"
        '
        '_btnTroVe
        '
        Me._btnTroVe.BackColor = System.Drawing.Color.DarkRed
        Me._btnTroVe.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTroVe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me._btnTroVe.Location = New System.Drawing.Point(718, 252)
        Me._btnTroVe.Name = "_btnTroVe"
        Me._btnTroVe.Size = New System.Drawing.Size(317, 90)
        Me._btnTroVe.TabIndex = 9
        Me._btnTroVe.Text = "Trở Về"
        Me._btnTroVe.UseVisualStyleBackColor = False
        '
        '_btnLuuBaoCao
        '
        Me._btnLuuBaoCao.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnLuuBaoCao.Location = New System.Drawing.Point(39, 252)
        Me._btnLuuBaoCao.Name = "_btnLuuBaoCao"
        Me._btnLuuBaoCao.Size = New System.Drawing.Size(372, 90)
        Me._btnLuuBaoCao.TabIndex = 8
        Me._btnLuuBaoCao.Text = "Lập Báo Cáo"
        Me._btnLuuBaoCao.UseVisualStyleBackColor = True
        '
        '_tbMaBaoCaoDoanhThu
        '
        Me._tbMaBaoCaoDoanhThu.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaBaoCaoDoanhThu.Location = New System.Drawing.Point(788, 118)
        Me._tbMaBaoCaoDoanhThu.Name = "_tbMaBaoCaoDoanhThu"
        Me._tbMaBaoCaoDoanhThu.ReadOnly = True
        Me._tbMaBaoCaoDoanhThu.Size = New System.Drawing.Size(234, 40)
        Me._tbMaBaoCaoDoanhThu.TabIndex = 13
        Me._tbMaBaoCaoDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_lbMaBaoCaoDoanhThu
        '
        Me._lbMaBaoCaoDoanhThu.AutoSize = True
        Me._lbMaBaoCaoDoanhThu.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaBaoCaoDoanhThu.Location = New System.Drawing.Point(475, 120)
        Me._lbMaBaoCaoDoanhThu.Name = "_lbMaBaoCaoDoanhThu"
        Me._lbMaBaoCaoDoanhThu.Size = New System.Drawing.Size(303, 34)
        Me._lbMaBaoCaoDoanhThu.TabIndex = 12
        Me._lbMaBaoCaoDoanhThu.Text = "Mã BC Doanh Thu:"
        '
        'BaoCaoDoanhThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 611)
        Me.Controls.Add(Me._tbMaBaoCaoDoanhThu)
        Me.Controls.Add(Me._lbMaBaoCaoDoanhThu)
        Me.Controls.Add(Me._tbMaBaoCao)
        Me.Controls.Add(Me._lbMaBaoCao)
        Me.Controls.Add(Me._btnTroVe)
        Me.Controls.Add(Me._btnLuuBaoCao)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me._tbThang)
        Me.Controls.Add(Me._lbThang)
        Me.Controls.Add(Me._lbBaoCaoDoanhThu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BaoCaoDoanhThu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BaoCaoDoanhThu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _tbThang As TextBox
    Friend WithEvents _lbThang As Label
    Friend WithEvents _lbBaoCaoDoanhThu As Label
    Friend WithEvents _tbMaBaoCao As TextBox
    Friend WithEvents _lbMaBaoCao As Label
    Friend WithEvents _btnTroVe As Button
    Friend WithEvents _btnLuuBaoCao As Button
    Friend WithEvents _tbMaBaoCaoDoanhThu As TextBox
    Friend WithEvents _lbMaBaoCaoDoanhThu As Label
End Class
