<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThayDoiTyLePhuThu
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
        Me._lbTyLeCu = New System.Windows.Forms.Label()
        Me._lbTyLeMoi = New System.Windows.Forms.Label()
        Me._tbTyLeCu = New System.Windows.Forms.TextBox()
        Me._tbTyLeMoi = New System.Windows.Forms.TextBox()
        Me._btnThayDoi = New System.Windows.Forms.Button()
        Me._btnTroVe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(473, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thay Đổi Tỷ Lệ Phụ Thu"
        '
        '_lbTyLeCu
        '
        Me._lbTyLeCu.AutoSize = True
        Me._lbTyLeCu.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbTyLeCu.Location = New System.Drawing.Point(30, 101)
        Me._lbTyLeCu.Name = "_lbTyLeCu"
        Me._lbTyLeCu.Size = New System.Drawing.Size(267, 32)
        Me._lbTyLeCu.TabIndex = 1
        Me._lbTyLeCu.Text = "Tỷ Lệ Phụ Thu Cũ:"
        '
        '_lbTyLeMoi
        '
        Me._lbTyLeMoi.AutoSize = True
        Me._lbTyLeMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbTyLeMoi.Location = New System.Drawing.Point(30, 175)
        Me._lbTyLeMoi.Name = "_lbTyLeMoi"
        Me._lbTyLeMoi.Size = New System.Drawing.Size(278, 32)
        Me._lbTyLeMoi.TabIndex = 2
        Me._lbTyLeMoi.Text = "Tỷ Lệ Phụ Thu Mới:"
        '
        '_tbTyLeCu
        '
        Me._tbTyLeCu.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbTyLeCu.Location = New System.Drawing.Point(314, 97)
        Me._tbTyLeCu.Name = "_tbTyLeCu"
        Me._tbTyLeCu.ReadOnly = True
        Me._tbTyLeCu.Size = New System.Drawing.Size(190, 40)
        Me._tbTyLeCu.TabIndex = 3
        '
        '_tbTyLeMoi
        '
        Me._tbTyLeMoi.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbTyLeMoi.Location = New System.Drawing.Point(314, 171)
        Me._tbTyLeMoi.Name = "_tbTyLeMoi"
        Me._tbTyLeMoi.Size = New System.Drawing.Size(190, 40)
        Me._tbTyLeMoi.TabIndex = 4
        Me._tbTyLeMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_btnThayDoi
        '
        Me._btnThayDoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnThayDoi.Location = New System.Drawing.Point(510, 171)
        Me._btnThayDoi.Name = "_btnThayDoi"
        Me._btnThayDoi.Size = New System.Drawing.Size(151, 40)
        Me._btnThayDoi.TabIndex = 5
        Me._btnThayDoi.Text = "Thay Đổi"
        Me._btnThayDoi.UseVisualStyleBackColor = True
        '
        '_btnTroVe
        '
        Me._btnTroVe.BackColor = System.Drawing.Color.DarkRed
        Me._btnTroVe.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnTroVe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me._btnTroVe.Location = New System.Drawing.Point(271, 252)
        Me._btnTroVe.Name = "_btnTroVe"
        Me._btnTroVe.Size = New System.Drawing.Size(151, 61)
        Me._btnTroVe.TabIndex = 6
        Me._btnTroVe.Text = "Trở Về"
        Me._btnTroVe.UseVisualStyleBackColor = False
        '
        'ThayDoiTyLePhuThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 336)
        Me.Controls.Add(Me._btnTroVe)
        Me.Controls.Add(Me._btnThayDoi)
        Me.Controls.Add(Me._tbTyLeMoi)
        Me.Controls.Add(Me._tbTyLeCu)
        Me.Controls.Add(Me._lbTyLeMoi)
        Me.Controls.Add(Me._lbTyLeCu)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ThayDoiTyLePhuThu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThayDoiTyLePhuThu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents _lbTyLeCu As Label
    Friend WithEvents _lbTyLeMoi As Label
    Friend WithEvents _tbTyLeCu As TextBox
    Friend WithEvents _tbTyLeMoi As TextBox
    Friend WithEvents _btnThayDoi As Button
    Friend WithEvents _btnTroVe As Button
End Class
