Imports MetroFramework

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits MetroFramework.Forms.MetroForm

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
        Me._pnUser = New System.Windows.Forms.Panel()
        Me._tbUser = New System.Windows.Forms.TextBox()
        Me._pnPass = New System.Windows.Forms.Panel()
        Me._tbPass = New System.Windows.Forms.TextBox()
        Me._btnLogin = New System.Windows.Forms.Button()
        Me._lbClient = New System.Windows.Forms.Label()
        Me._lbTemp = New System.Windows.Forms.Label()
        Me._pnUser.SuspendLayout()
        Me._pnPass.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnUser
        '
        Me._pnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me._pnUser.Controls.Add(Me._tbUser)
        Me._pnUser.Location = New System.Drawing.Point(60, 104)
        Me._pnUser.Name = "_pnUser"
        Me._pnUser.Size = New System.Drawing.Size(471, 80)
        Me._pnUser.TabIndex = 0
        '
        '_tbUser
        '
        Me._tbUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me._tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._tbUser.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbUser.ForeColor = System.Drawing.Color.DarkGray
        Me._tbUser.Location = New System.Drawing.Point(3, 23)
        Me._tbUser.Name = "_tbUser"
        Me._tbUser.Size = New System.Drawing.Size(463, 31)
        Me._tbUser.TabIndex = 0
        Me._tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_pnPass
        '
        Me._pnPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me._pnPass.Controls.Add(Me._tbPass)
        Me._pnPass.ForeColor = System.Drawing.Color.CornflowerBlue
        Me._pnPass.Location = New System.Drawing.Point(60, 227)
        Me._pnPass.Name = "_pnPass"
        Me._pnPass.Size = New System.Drawing.Size(471, 80)
        Me._pnPass.TabIndex = 1
        '
        '_tbPass
        '
        Me._tbPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me._tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._tbPass.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbPass.ForeColor = System.Drawing.Color.DarkGray
        Me._tbPass.Location = New System.Drawing.Point(3, 22)
        Me._tbPass.Name = "_tbPass"
        Me._tbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me._tbPass.Size = New System.Drawing.Size(463, 31)
        Me._tbPass.TabIndex = 1
        Me._tbPass.Tag = ""
        Me._tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_btnLogin
        '
        Me._btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me._btnLogin.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnLogin.ForeColor = System.Drawing.Color.Transparent
        Me._btnLogin.Location = New System.Drawing.Point(60, 349)
        Me._btnLogin.Name = "_btnLogin"
        Me._btnLogin.Size = New System.Drawing.Size(471, 79)
        Me._btnLogin.TabIndex = 2
        Me._btnLogin.Text = "Log in"
        Me._btnLogin.UseVisualStyleBackColor = False
        '
        '_lbClient
        '
        Me._lbClient.AutoSize = True
        Me._lbClient.Font = New System.Drawing.Font("Verdana", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbClient.Location = New System.Drawing.Point(63, 476)
        Me._lbClient.Name = "_lbClient"
        Me._lbClient.Size = New System.Drawing.Size(482, 34)
        Me._lbClient.TabIndex = 3
        Me._lbClient.Text = "Đăng nhập với tư cách khách "
        '
        '_lbTemp
        '
        Me._lbTemp.AutoSize = True
        Me._lbTemp.Location = New System.Drawing.Point(525, 9)
        Me._lbTemp.Name = "_lbTemp"
        Me._lbTemp.Size = New System.Drawing.Size(51, 17)
        Me._lbTemp.TabIndex = 4
        Me._lbTemp.Text = "Label1"
        Me._lbTemp.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 552)
        Me.Controls.Add(Me._lbTemp)
        Me.Controls.Add(Me._lbClient)
        Me.Controls.Add(Me._btnLogin)
        Me.Controls.Add(Me._pnPass)
        Me.Controls.Add(Me._pnUser)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me._pnUser.ResumeLayout(False)
        Me._pnUser.PerformLayout()
        Me._pnPass.ResumeLayout(False)
        Me._pnPass.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _pnUser As Panel
    Public WithEvents _tbUser As TextBox
    Friend WithEvents _pnPass As Panel
    Friend WithEvents _tbPass As TextBox
    Friend WithEvents _btnLogin As Button
    Friend WithEvents _lbClient As Label
    Friend WithEvents _lbTemp As Label
End Class
