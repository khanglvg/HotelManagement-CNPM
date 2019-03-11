<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me._tbConfirm = New System.Windows.Forms.TextBox()
        Me._tbNewPass = New System.Windows.Forms.TextBox()
        Me._tbOldPass = New System.Windows.Forms.TextBox()
        Me._tbUserName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._btnChange = New MetroFramework.Controls.MetroTile()
        Me._btnTroVe = New MetroFramework.Controls.MetroTile()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me._tbConfirm)
        Me.GroupBox1.Controls.Add(Me._tbNewPass)
        Me.GroupBox1.Controls.Add(Me._tbOldPass)
        Me.GroupBox1.Controls.Add(Me._tbUserName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(590, 293)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        '_tbConfirm
        '
        Me._tbConfirm.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbConfirm.Location = New System.Drawing.Point(271, 227)
        Me._tbConfirm.Name = "_tbConfirm"
        Me._tbConfirm.Size = New System.Drawing.Size(279, 38)
        Me._tbConfirm.TabIndex = 7
        '
        '_tbNewPass
        '
        Me._tbNewPass.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNewPass.Location = New System.Drawing.Point(271, 175)
        Me._tbNewPass.Name = "_tbNewPass"
        Me._tbNewPass.Size = New System.Drawing.Size(279, 38)
        Me._tbNewPass.TabIndex = 6
        '
        '_tbOldPass
        '
        Me._tbOldPass.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbOldPass.Location = New System.Drawing.Point(271, 122)
        Me._tbOldPass.Name = "_tbOldPass"
        Me._tbOldPass.Size = New System.Drawing.Size(279, 38)
        Me._tbOldPass.TabIndex = 5
        '
        '_tbUserName
        '
        Me._tbUserName.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbUserName.Location = New System.Drawing.Point(271, 66)
        Me._tbUserName.Name = "_tbUserName"
        Me._tbUserName.ReadOnly = True
        Me._tbUserName.Size = New System.Drawing.Size(279, 38)
        Me._tbUserName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 40)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Comfirm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NewPass:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "OldPass:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserName: "
        '
        '_btnChange
        '
        Me._btnChange.ActiveControl = Nothing
        Me._btnChange.BackColor = System.Drawing.Color.LemonChiffon
        Me._btnChange.Location = New System.Drawing.Point(62, 387)
        Me._btnChange.Name = "_btnChange"
        Me._btnChange.Size = New System.Drawing.Size(177, 82)
        Me._btnChange.TabIndex = 1
        Me._btnChange.Text = "Change"
        Me._btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._btnChange.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me._btnChange.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me._btnChange.UseCustomBackColor = True
        Me._btnChange.UseCustomForeColor = True
        Me._btnChange.UseSelectable = True
        '
        '_btnTroVe
        '
        Me._btnTroVe.ActiveControl = Nothing
        Me._btnTroVe.BackColor = System.Drawing.Color.Purple
        Me._btnTroVe.Location = New System.Drawing.Point(396, 387)
        Me._btnTroVe.Name = "_btnTroVe"
        Me._btnTroVe.Size = New System.Drawing.Size(177, 82)
        Me._btnTroVe.TabIndex = 2
        Me._btnTroVe.Text = "Back"
        Me._btnTroVe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._btnTroVe.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me._btnTroVe.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me._btnTroVe.UseCustomBackColor = True
        Me._btnTroVe.UseSelectable = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(20, 487)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(596, 22)
        Me.StatusStrip1.TabIndex = 3
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        Me.ToolStripStatusLabel1.Visible = False
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 529)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me._btnTroVe)
        Me.Controls.Add(Me._btnChange)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ChangePassword"
        Me.Text = "ChangePassword"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents _tbConfirm As TextBox
    Friend WithEvents _tbNewPass As TextBox
    Friend WithEvents _tbOldPass As TextBox
    Friend WithEvents _tbUserName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents _btnChange As MetroFramework.Controls.MetroTile
    Friend WithEvents _btnTroVe As MetroFramework.Controls.MetroTile
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
