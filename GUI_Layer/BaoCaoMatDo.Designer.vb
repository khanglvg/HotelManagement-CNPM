<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaoCaoMatDo
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
        Me._lbBaoCaoMatDo = New System.Windows.Forms.Label()
        Me._lbThang = New System.Windows.Forms.Label()
        Me._tbThang = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me._btnLuuBaoCao = New System.Windows.Forms.Button()
        Me._btnTroVe = New System.Windows.Forms.Button()
        Me._lbMaBaoCao = New System.Windows.Forms.Label()
        Me._tbMaBaoCao = New System.Windows.Forms.TextBox()
        Me._tbMaBaoCaoMatDo = New System.Windows.Forms.TextBox()
        Me._lbMaBaoCaoMatDo = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_lbBaoCaoMatDo
        '
        Me._lbBaoCaoMatDo.AutoSize = True
        Me._lbBaoCaoMatDo.Font = New System.Drawing.Font("Verdana", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbBaoCaoMatDo.Location = New System.Drawing.Point(75, 27)
        Me._lbBaoCaoMatDo.Name = "_lbBaoCaoMatDo"
        Me._lbBaoCaoMatDo.Size = New System.Drawing.Size(733, 48)
        Me._lbBaoCaoMatDo.TabIndex = 0
        Me._lbBaoCaoMatDo.Text = "Báo Cáo Mật Độ Sử Dụng Phòng"
        '
        '_lbThang
        '
        Me._lbThang.AutoSize = True
        Me._lbThang.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbThang.Location = New System.Drawing.Point(302, 189)
        Me._lbThang.Name = "_lbThang"
        Me._lbThang.Size = New System.Drawing.Size(124, 34)
        Me._lbThang.TabIndex = 1
        Me._lbThang.Text = "Tháng:"
        '
        '_tbThang
        '
        Me._tbThang.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbThang.Location = New System.Drawing.Point(463, 189)
        Me._tbThang.Name = "_tbThang"
        Me._tbThang.ReadOnly = True
        Me._tbThang.Size = New System.Drawing.Size(114, 40)
        Me._tbThang.TabIndex = 2
        Me._tbThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 396)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(904, 209)
        Me.DataGridView1.TabIndex = 3
        '
        '_btnLuuBaoCao
        '
        Me._btnLuuBaoCao.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnLuuBaoCao.Location = New System.Drawing.Point(20, 267)
        Me._btnLuuBaoCao.Name = "_btnLuuBaoCao"
        Me._btnLuuBaoCao.Size = New System.Drawing.Size(359, 90)
        Me._btnLuuBaoCao.TabIndex = 4
        Me._btnLuuBaoCao.Text = "Lập Báo Cáo"
        Me._btnLuuBaoCao.UseVisualStyleBackColor = True
        '
        '_btnTroVe
        '
        Me._btnTroVe.BackColor = System.Drawing.Color.DarkRed
        Me._btnTroVe.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTroVe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me._btnTroVe.Location = New System.Drawing.Point(607, 267)
        Me._btnTroVe.Name = "_btnTroVe"
        Me._btnTroVe.Size = New System.Drawing.Size(317, 90)
        Me._btnTroVe.TabIndex = 5
        Me._btnTroVe.Text = "Trở Về"
        Me._btnTroVe.UseVisualStyleBackColor = False
        '
        '_lbMaBaoCao
        '
        Me._lbMaBaoCao.AutoSize = True
        Me._lbMaBaoCao.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaBaoCao.Location = New System.Drawing.Point(14, 118)
        Me._lbMaBaoCao.Name = "_lbMaBaoCao"
        Me._lbMaBaoCao.Size = New System.Drawing.Size(209, 34)
        Me._lbMaBaoCao.TabIndex = 6
        Me._lbMaBaoCao.Text = "Mã Báo Cáo:"
        '
        '_tbMaBaoCao
        '
        Me._tbMaBaoCao.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaBaoCao.Location = New System.Drawing.Point(229, 112)
        Me._tbMaBaoCao.Name = "_tbMaBaoCao"
        Me._tbMaBaoCao.ReadOnly = True
        Me._tbMaBaoCao.Size = New System.Drawing.Size(138, 40)
        Me._tbMaBaoCao.TabIndex = 7
        Me._tbMaBaoCao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_tbMaBaoCaoMatDo
        '
        Me._tbMaBaoCaoMatDo.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaBaoCaoMatDo.Location = New System.Drawing.Point(662, 112)
        Me._tbMaBaoCaoMatDo.Name = "_tbMaBaoCaoMatDo"
        Me._tbMaBaoCaoMatDo.ReadOnly = True
        Me._tbMaBaoCaoMatDo.Size = New System.Drawing.Size(262, 40)
        Me._tbMaBaoCaoMatDo.TabIndex = 9
        Me._tbMaBaoCaoMatDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_lbMaBaoCaoMatDo
        '
        Me._lbMaBaoCaoMatDo.AutoSize = True
        Me._lbMaBaoCaoMatDo.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbMaBaoCaoMatDo.Location = New System.Drawing.Point(412, 112)
        Me._lbMaBaoCaoMatDo.Name = "_lbMaBaoCaoMatDo"
        Me._lbMaBaoCaoMatDo.Size = New System.Drawing.Size(244, 34)
        Me._lbMaBaoCaoMatDo.TabIndex = 8
        Me._lbMaBaoCaoMatDo.Text = "Mã BC Mật Độ:"
        '
        'BaoCaoMatDo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 625)
        Me.Controls.Add(Me._tbMaBaoCaoMatDo)
        Me.Controls.Add(Me._lbMaBaoCaoMatDo)
        Me.Controls.Add(Me._tbMaBaoCao)
        Me.Controls.Add(Me._lbMaBaoCao)
        Me.Controls.Add(Me._btnTroVe)
        Me.Controls.Add(Me._btnLuuBaoCao)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me._tbThang)
        Me.Controls.Add(Me._lbThang)
        Me.Controls.Add(Me._lbBaoCaoMatDo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BaoCaoMatDo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BaoCaoMatDo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _lbBaoCaoMatDo As Label
    Friend WithEvents _lbThang As Label
    Friend WithEvents _tbThang As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _btnLuuBaoCao As Button
    Friend WithEvents _btnTroVe As Button
    Friend WithEvents _lbMaBaoCao As Label
    Friend WithEvents _tbMaBaoCao As TextBox
    Friend WithEvents _tbMaBaoCaoMatDo As TextBox
    Friend WithEvents _lbMaBaoCaoMatDo As Label
End Class
