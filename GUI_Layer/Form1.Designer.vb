Imports MetroFramework

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.lbQuanLyKhachSan = New System.Windows.Forms.Label()
        Me._mtLapPhieuThuePhong = New MetroFramework.Controls.MetroTile()
        Me._mtThayDoiQuyDinh = New MetroFramework.Controls.MetroTile()
        Me._mtLapBaoCao = New MetroFramework.Controls.MetroTile()
        Me._mtLapHoaDonThanhToan = New MetroFramework.Controls.MetroTile()
        Me._mtLapDanhMucPhong = New MetroFramework.Controls.MetroTile()
        Me._lbUserId = New System.Windows.Forms.Label()
        Me._lbRole = New System.Windows.Forms.Label()
        Me._mtNewLogin = New MetroFramework.Controls.MetroTile()
        Me._mtChangePassword = New MetroFramework.Controls.MetroTile()
        Me._btnTroVe = New System.Windows.Forms.Button()
        Me._mtThoat = New MetroFramework.Controls.MetroTile()
        Me._mtTraCuuPhong = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'lbQuanLyKhachSan
        '
        Me.lbQuanLyKhachSan.AutoSize = True
        Me.lbQuanLyKhachSan.BackColor = System.Drawing.Color.Transparent
        Me.lbQuanLyKhachSan.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQuanLyKhachSan.ForeColor = System.Drawing.Color.Yellow
        Me.lbQuanLyKhachSan.Location = New System.Drawing.Point(147, 18)
        Me.lbQuanLyKhachSan.Name = "lbQuanLyKhachSan"
        Me.lbQuanLyKhachSan.Size = New System.Drawing.Size(376, 45)
        Me.lbQuanLyKhachSan.TabIndex = 0
        Me.lbQuanLyKhachSan.Text = "Quản Lý Khách Sạn"
        '
        '_mtLapPhieuThuePhong
        '
        Me._mtLapPhieuThuePhong.ActiveControl = Nothing
        Me._mtLapPhieuThuePhong.Location = New System.Drawing.Point(353, 120)
        Me._mtLapPhieuThuePhong.Name = "_mtLapPhieuThuePhong"
        Me._mtLapPhieuThuePhong.Size = New System.Drawing.Size(295, 110)
        Me._mtLapPhieuThuePhong.TabIndex = 15
        Me._mtLapPhieuThuePhong.Text = "Lập Phiếu Thuê Phòng"
        Me._mtLapPhieuThuePhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._mtLapPhieuThuePhong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me._mtLapPhieuThuePhong.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me._mtLapPhieuThuePhong.UseSelectable = True
        '
        '_mtThayDoiQuyDinh
        '
        Me._mtThayDoiQuyDinh.ActiveControl = Nothing
        Me._mtThayDoiQuyDinh.Location = New System.Drawing.Point(353, 399)
        Me._mtThayDoiQuyDinh.Name = "_mtThayDoiQuyDinh"
        Me._mtThayDoiQuyDinh.Size = New System.Drawing.Size(295, 110)
        Me._mtThayDoiQuyDinh.TabIndex = 16
        Me._mtThayDoiQuyDinh.Text = "Thay Đổi Quy Định"
        Me._mtThayDoiQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._mtThayDoiQuyDinh.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me._mtThayDoiQuyDinh.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me._mtThayDoiQuyDinh.UseSelectable = True
        '
        '_mtLapBaoCao
        '
        Me._mtLapBaoCao.ActiveControl = Nothing
        Me._mtLapBaoCao.Location = New System.Drawing.Point(23, 399)
        Me._mtLapBaoCao.Name = "_mtLapBaoCao"
        Me._mtLapBaoCao.Size = New System.Drawing.Size(289, 110)
        Me._mtLapBaoCao.TabIndex = 18
        Me._mtLapBaoCao.Text = "Lập Báo Cáo"
        Me._mtLapBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._mtLapBaoCao.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me._mtLapBaoCao.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me._mtLapBaoCao.UseSelectable = True
        '
        '_mtLapHoaDonThanhToan
        '
        Me._mtLapHoaDonThanhToan.ActiveControl = Nothing
        Me._mtLapHoaDonThanhToan.Location = New System.Drawing.Point(353, 256)
        Me._mtLapHoaDonThanhToan.Name = "_mtLapHoaDonThanhToan"
        Me._mtLapHoaDonThanhToan.Size = New System.Drawing.Size(295, 110)
        Me._mtLapHoaDonThanhToan.TabIndex = 19
        Me._mtLapHoaDonThanhToan.Text = "Lập Hóa Đơn "
        Me._mtLapHoaDonThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._mtLapHoaDonThanhToan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me._mtLapHoaDonThanhToan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me._mtLapHoaDonThanhToan.UseSelectable = True
        '
        '_mtLapDanhMucPhong
        '
        Me._mtLapDanhMucPhong.ActiveControl = Nothing
        Me._mtLapDanhMucPhong.Location = New System.Drawing.Point(23, 120)
        Me._mtLapDanhMucPhong.Name = "_mtLapDanhMucPhong"
        Me._mtLapDanhMucPhong.Size = New System.Drawing.Size(289, 110)
        Me._mtLapDanhMucPhong.TabIndex = 20
        Me._mtLapDanhMucPhong.Text = "Lập Danh Mục Phòng"
        Me._mtLapDanhMucPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._mtLapDanhMucPhong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me._mtLapDanhMucPhong.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me._mtLapDanhMucPhong.UseSelectable = True
        '
        '_lbUserId
        '
        Me._lbUserId.AutoSize = True
        Me._lbUserId.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbUserId.Location = New System.Drawing.Point(24, 78)
        Me._lbUserId.Name = "_lbUserId"
        Me._lbUserId.Size = New System.Drawing.Size(25, 25)
        Me._lbUserId.TabIndex = 23
        Me._lbUserId.Text = "a"
        '
        '_lbRole
        '
        Me._lbRole.AutoSize = True
        Me._lbRole.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbRole.Location = New System.Drawing.Point(417, 78)
        Me._lbRole.Name = "_lbRole"
        Me._lbRole.Size = New System.Drawing.Size(25, 25)
        Me._lbRole.TabIndex = 24
        Me._lbRole.Text = "a"
        '
        '_mtNewLogin
        '
        Me._mtNewLogin.ActiveControl = Nothing
        Me._mtNewLogin.Location = New System.Drawing.Point(23, 540)
        Me._mtNewLogin.Name = "_mtNewLogin"
        Me._mtNewLogin.Size = New System.Drawing.Size(289, 110)
        Me._mtNewLogin.TabIndex = 25
        Me._mtNewLogin.Text = "Đăng Ký Mới"
        Me._mtNewLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._mtNewLogin.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me._mtNewLogin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me._mtNewLogin.UseSelectable = True
        '
        '_mtChangePassword
        '
        Me._mtChangePassword.ActiveControl = Nothing
        Me._mtChangePassword.Location = New System.Drawing.Point(353, 540)
        Me._mtChangePassword.Name = "_mtChangePassword"
        Me._mtChangePassword.Size = New System.Drawing.Size(289, 110)
        Me._mtChangePassword.TabIndex = 26
        Me._mtChangePassword.Text = "Đổi Mật Khẩu"
        Me._mtChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._mtChangePassword.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me._mtChangePassword.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me._mtChangePassword.UseSelectable = True
        '
        '_btnTroVe
        '
        Me._btnTroVe.BackgroundImage = CType(resources.GetObject("_btnTroVe.BackgroundImage"), System.Drawing.Image)
        Me._btnTroVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me._btnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._btnTroVe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me._btnTroVe.Location = New System.Drawing.Point(3, 6)
        Me._btnTroVe.Name = "_btnTroVe"
        Me._btnTroVe.Size = New System.Drawing.Size(100, 50)
        Me._btnTroVe.TabIndex = 22
        Me._btnTroVe.UseVisualStyleBackColor = True
        '
        '_mtThoat
        '
        Me._mtThoat.ActiveControl = Nothing
        Me._mtThoat.Location = New System.Drawing.Point(603, 6)
        Me._mtThoat.Name = "_mtThoat"
        Me._mtThoat.Size = New System.Drawing.Size(65, 59)
        Me._mtThoat.TabIndex = 21
        Me._mtThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._mtThoat.TileImage = CType(resources.GetObject("_mtThoat.TileImage"), System.Drawing.Image)
        Me._mtThoat.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._mtThoat.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me._mtThoat.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me._mtThoat.UseCustomBackColor = True
        Me._mtThoat.UseSelectable = True
        Me._mtThoat.UseTileImage = True
        '
        '_mtTraCuuPhong
        '
        Me._mtTraCuuPhong.ActiveControl = Nothing
        Me._mtTraCuuPhong.Location = New System.Drawing.Point(23, 256)
        Me._mtTraCuuPhong.Name = "_mtTraCuuPhong"
        Me._mtTraCuuPhong.Size = New System.Drawing.Size(289, 110)
        Me._mtTraCuuPhong.TabIndex = 17
        Me._mtTraCuuPhong.Text = "Tra Cứu Phòng"
        Me._mtTraCuuPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._mtTraCuuPhong.TileImage = CType(resources.GetObject("_mtTraCuuPhong.TileImage"), System.Drawing.Image)
        Me._mtTraCuuPhong.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._mtTraCuuPhong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me._mtTraCuuPhong.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me._mtTraCuuPhong.UseSelectable = True
        Me._mtTraCuuPhong.UseTileImage = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(669, 665)
        Me.Controls.Add(Me._mtChangePassword)
        Me.Controls.Add(Me._mtNewLogin)
        Me.Controls.Add(Me._lbRole)
        Me.Controls.Add(Me._lbUserId)
        Me.Controls.Add(Me._btnTroVe)
        Me.Controls.Add(Me._mtThoat)
        Me.Controls.Add(Me._mtLapDanhMucPhong)
        Me.Controls.Add(Me._mtLapHoaDonThanhToan)
        Me.Controls.Add(Me._mtLapBaoCao)
        Me.Controls.Add(Me._mtTraCuuPhong)
        Me.Controls.Add(Me._mtThayDoiQuyDinh)
        Me.Controls.Add(Me._mtLapPhieuThuePhong)
        Me.Controls.Add(Me.lbQuanLyKhachSan)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Name = "mainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbQuanLyKhachSan As Label
    Public WithEvents _mtLapPhieuThuePhong As Controls.MetroTile
    Public WithEvents _mtThayDoiQuyDinh As Controls.MetroTile
    Public WithEvents _mtTraCuuPhong As Controls.MetroTile
    Public WithEvents _mtLapBaoCao As Controls.MetroTile
    Public WithEvents _mtLapHoaDonThanhToan As Controls.MetroTile
    Public WithEvents _mtLapDanhMucPhong As Controls.MetroTile
    Friend WithEvents _mtThoat As Controls.MetroTile
    Friend WithEvents _btnTroVe As Button
    Friend WithEvents _lbUserId As Label
    Friend WithEvents _lbRole As Label
    Public WithEvents _mtNewLogin As Controls.MetroTile
    Public WithEvents _mtChangePassword As Controls.MetroTile
End Class
