use QuanLyKhachSan

ALTER TABLE phong ADD CONSTRAINT FK_MaLoaiPhong1 FOREIGN KEY(MaLoaiPhong) REFERENCES loaiphong(MaLoaiPhong)

ALTER TABLE phieuthue ADD CONSTRAINT FK_MaPhong FOREIGN KEY(MaPhong) REFERENCES phong(MaPhong)

ALTER TABLE chitietphieuthue ADD CONSTRAINT FK_MaPhieuthue FOREIGN KEY(Maphieuthue) REFERENCES phieuthue(Maphieuthue)

ALTER TABLE chitietbaocaodoanhthu ADD CONSTRAINT FK_MaLoaiphong FOREIGN KEY(MaLoaiPhong) REFERENCES loaiphong(MaLoaiPhong)

ALTER TABLE chitietbaocaomatdo ADD CONSTRAINT FK_MaPhong1 FOREIGN KEY(MaPhong) REFERENCES phong(MaPhong)

ALTER TABLE chitietphieuthue ADD CONSTRAINT FK_MaKhachHang FOREIGN KEY(MaKhachHang ) REFERENCES KhachHang (MaKhachHang )

ALTER TABLE KhachHang ADD CONSTRAINT FK_MaLoaiKhachHang FOREIGN KEY(MaLoaiKhachHang) REFERENCES loaikhachhang(MaLoaiKhachHang)

ALTER TABLE chitiethoadon ADD CONSTRAINT FK_MaPhieuThue1 FOREIGN KEY(Maphieuthue) REFERENCES phieuthue(Maphieuthue)

ALTER TABLE chitiethoadon ADD CONSTRAINT FK_MaHoaDon FOREIGN KEY(MaHoaDon) REFERENCES hoadon(MaHoaDon)

ALTER TABLE hoadon ADD CONSTRAINT FK_MaKhachHang1 FOREIGN KEY(MaKhachHang) REFERENCES KhachHang(MaKhachHang)

ALTER TABLE chitietbaocaodoanhthu ADD CONSTRAINT FK_MaBaoCao FOREIGN KEY(MaBaoCao) REFERENCES baocao(MaBaoCao)

ALTER TABLE chitietbaocaomatdo ADD CONSTRAINT FK_MaBaoCao1 FOREIGN KEY(MaBaoCao) REFERENCES baocao(MaBaoCao)

