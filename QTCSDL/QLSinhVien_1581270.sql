/* 4.1 Danh sách các sinh viên khoa "Công nghệ thông tin" khóa 2002-2006 */
Select SV.*
from SinhVien SV, Lop L, Khoa K, KhoaHoc KH
where 
	SV.maLop = L.maLop
	and L.maKhoa = K.maKhoa
	and UPPER(K.tenKhoa) = N'CÔNG NGHỆ THÔNG TIN' 
	and L.maKhoaHoc = KH.maKhoaHoc
	and KH.namBatDau = 2002
	and KH.namKetThuc = 2006 
;

/* 4.2 Cho biết các sinh viên (MSSV, họ tên, năm sinh) của các sinh viên học sớm
hơn tuổi quy định (theo tuổi quy định thì sinh viên đủ 18 tuổi khi bắt đầu khóa học)
 */
Select SV.maSinhVien, SV.hoTen, SV.namSinh
from SinhVien SV, Lop L, KhoaHoc KH
where 
	SV.maLop = L.maLop
	and L.maKhoaHoc = KH.maKhoaHoc
	and SV.namSinh + 18 < KH.namBatDau
;

/* 4.3 Cho biết sinh viên khoa CNTT, khóa 2002-2006 chưa học môn cấu trúc dữ liệu 1 */

/** INSERT DATA **/

insert into GiangKhoa values('GK001','CQ','CNTT','THCS01',2004,1,45,30,4);
insert into GiangKhoa values('GK002','CQ','CNTT','THCS02',2004,1,45,30,4);
insert into GiangKhoa values('GK003','CQ','CNTT','THCS01',2004,2,45,30,4);

insert into KetQua values('0212001','GK001',3,1);
insert into KetQua values('0212002','GK002',6,1);
insert into KetQua values('0212003','GK001',4,1);
insert into KetQua values('0212003','GK003',6,2);
;

Select SV.*
from SinhVien SV, Lop L, Khoa K, KhoaHoc KH
where 
	SV.maLop = L.maLop
	and L.maKhoa = K.maKhoa
	and UPPER(K.tenKhoa) = N'CÔNG NGHỆ THÔNG TIN' 
	and L.maKhoaHoc = KH.maKhoaHoc
	and KH.namBatDau = 2002
	and KH.namKetThuc = 2006 
	and not exists (
		Select *
		from KetQua KQ, GiangKhoa GK, MonHoc MH
		where UPPER(MH.tenMonHoc) = N'Cấu trúc dữ liệu 1'
		and MH.maMonHoc = GK.maMonHoc
		and GK.maGiangKhoa = KQ.maGiangKhoa
		and KQ.maSinhVien = SV.maSinhVien
	)

;

/* 4.4 Cho biết sinh viên thi không đậu (Diem < 5) môn cấu trúc dữ liệu 1 nhưng chưa thi lại */
Select SV1.*
from SinhVien SV1, KetQua KQ1, GiangKhoa GK1, MonHoc MH1
where 
	UPPER(MH1.tenMonHoc) = N'CẤU TRÚC DỮ LIỆU 1'
	and KQ1.diem < 5
	and lanThi = 1
	and MH1.maMonHoc = GK1.maMonHoc
	and GK1.maGiangKhoa = KQ1.maGiangKhoa
	and SV1.maSinhVien = KQ1.maSinhVien
	and not exists (
		Select *
		from KetQua KQ2
		where 
			KQ2.maSinhVien = SV1.maSinhVien
			and lanThi > 1
	)
;
/* 4.5 Với mỗi lớp thuộc khoa CNTT, cho biết mã lớp, mã khóa học, tên chương trình và số sinh viên thuộc lớp đó */

Select 
	L.maLop,
	L.maKhoaHoc,
	(Select tenChuongTrinh from ChuongTrinh CT where CT.maChuongTrinh = L.maChuongTrinh) as TenChuongTrinh,
	(Select COUNT(*) from SinhVien SV where SV.maLop = L.maLop) as SoLuong
from Lop L, Khoa K
where 
	UPPER(K.tenKhoa) = N'CÔNG NGHỆ THÔNG TIN'
	and K.maKhoa = L.maKhoa

;

/*4.6 Cho biết điểm trung bình của sinh viên có mã số 0212003 (Điểm trung bình chỉ tính trên lần thi sau cùng) */



;