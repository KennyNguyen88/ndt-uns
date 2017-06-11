using System;
using System.IO;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class Program
    {
        static void Main(string[] args)
        {
            THU_VIEN ThuVien = new THU_VIEN();
            int request;
            welcomeMessage();
            request = selectRequest();
            doRequest(request, ThuVien);
        }
        static void welcomeMessage()
        {
            Console.WriteLine("Lap trinh huong doi tuong - Do An Cuoi Ki");
            Console.WriteLine("Chon yeu cau can thuc hien");

            Console.WriteLine("=== Quan ly Doc Gia");
            Console.WriteLine("1 - Xem danh sach doc gia");
            Console.WriteLine("2 - Them doc gia");
            Console.WriteLine("3 - Chinh sua thong tin doc gia");
            Console.WriteLine("4 - Xoa thong tin doc gia");
            Console.WriteLine("5 - Tim kiem doc gia theo CMND");
            Console.WriteLine("6 - Tim kiem doc gia theo ho ten");
            Console.WriteLine("===================");
            Console.WriteLine("=== Quan ly Sach");
            Console.WriteLine("7 - Xem danh sach cac sach");
            Console.WriteLine("8 - Them sach");
            Console.WriteLine("9 - Chinh sua thong tin sach");
            Console.WriteLine("10 - Xoa thong tin sach");
            Console.WriteLine("11 - Tim kiem sach theo ISBN");
            Console.WriteLine("12 - Tim kiem sach theo ten");
            Console.WriteLine("================");
            Console.WriteLine("=== Quan ly phieu");
            Console.WriteLine("13 - Lap phieu muon sach");
            Console.WriteLine("14 - Lap phieu tra sach");
            Console.WriteLine("=================");
            Console.WriteLine("=== Thong ke");
            Console.WriteLine("15 - Thong ke so luong sach trong thu vien");
            Console.WriteLine("16 - Thong ke so luong sach theo the loai");
            Console.WriteLine("17 - Thong ke so luong doc gia");
            Console.WriteLine("18 - Thong ke so luong doc gia theo gioi tinh");
            Console.WriteLine("19 - Thong ke so sach dang duoc muon");
            Console.WriteLine("20 - Thong ke danh sach doc gia bi tre han");
        }        
        static int selectRequest()
        {
            int yeucau = 0;
            try
            {
                yeucau = int.Parse(Console.ReadLine());
                if (!(yeucau >= 0 && yeucau <= 21))
                {
                    Console.WriteLine("Vui long nhap so 0 ~ 20");
                    return selectRequest();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vui long nhap so 0 ~ 20");
                return selectRequest();
            }
            return yeucau;
        }
        static void anotherRequest(THU_VIEN ThuVien)
        {
            Console.WriteLine("===Nhap so 1 ~ 20 de thuc hien yeu cau tiep theo. Nhap 0 de ket thuc.  ?");
            int request = selectRequest();
            doRequest(request, ThuVien);
        }
        static void doRequest(int request, THU_VIEN ThuVien)
        {
            switch (request)
            {
                case 1:
                    request_01(ThuVien); break;
                case 2:
                    request_02(ThuVien); break;
                case 3:
                    request_03(ThuVien); break;
                case 4:
                    request_04(ThuVien); break;
                case 5:
                    request_05(ThuVien); break;
                case 6:
                    request_06(ThuVien); break;
                case 7:
                    request_07(ThuVien); break;
                case 8:
                    request_08(ThuVien); break;
                case 9:
                    request_09(ThuVien); break;
                case 10:
                    request_10(ThuVien); break;
                case 11:
                    request_11(ThuVien); break;
                case 12:
                    request_12(ThuVien); break;
                case 13:
                    request_13(ThuVien); break;
                case 14:
                    request_14(ThuVien); break;
                case 15:
                    request_15(ThuVien); break;
                case 16:
                    request_16(ThuVien); break;
                case 17:
                    request_17(ThuVien); break;
                case 18:
                    request_18(ThuVien); break;
                case 19:
                    request_19(ThuVien); break;
                case 20:
                    request_20(ThuVien); break;
                case 21:
                    test();break;
                default:
                    break;
            }
        }
        static void request_01(THU_VIEN ThuVien)
        {
            Console.WriteLine("Xem danh sach doc gia");
            try
            {
                ThuVien.printListDocGia();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_02(THU_VIEN ThuVien)
        {
            Console.WriteLine("Them doc gia");
            try
            {
                Console.WriteLine("Nhap CMND");
                String CMND = Console.ReadLine();
                if (!ThuVien.isDocGiaExist(CMND)) //Doc Gia not exist
                {
                    Console.WriteLine("Nhap MaDocGia");
                    String MaDocGia = Console.ReadLine();
                    if (!ThuVien.isMaDocGiaExist(MaDocGia))
                    {
                        DOC_GIA docgia = new DOC_GIA(MaDocGia);
                        if (docgia.input())
                        {
                            if (ThuVien.ThemDocGia(docgia))
                            {
                                Console.WriteLine("Them doc gia thanh cong !");
                            }
                            else
                            {
                                Console.WriteLine("Them doc gia khong thanh cong !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nhap thong tin doc gia khong thanh cong !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ma doc gia khong hop le !");
                    }
                }
                else
                {
                    Console.WriteLine("Doc gia da co trong thu vien !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_03(THU_VIEN ThuVien)
        {
            Console.WriteLine("Chinh sua thong tin doc gia");
            try
            {
                DOC_GIA docgia = ThuVien.getDocGia();
                if (docgia != null)
                {
                    if (docgia.modify())
                    {
                        if (ThuVien.CapNhatDocGia(docgia))
                        {
                            Console.WriteLine("Thong tin moi duoc cap nhat thanh cong !");
                        }
                        else
                        {
                            Console.WriteLine("Thong tin moi cap nhat khong thanh cong !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Chinh sua thong tin doc gia khong thanh cong !");
                    }
                }
                else
                {
                    Console.WriteLine("Khong tim thay doc gia phu hop !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_04(THU_VIEN ThuVien)
        {
            Console.WriteLine("Xoa thong tin doc gia");
            try
            {
                DOC_GIA docgia = ThuVien.getDocGia();
                if (docgia != null)
                {
                    if (ThuVien.XoaDocGia(docgia))
                    {
                        Console.WriteLine("Xoa thong tin doc gia thanh cong !");
                    }
                    else
                    {
                        Console.WriteLine("Xoa thong tin doc gia khong thanh cong !");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_05(THU_VIEN ThuVien)
        {
            Console.WriteLine("Tim kiem doc gia theo CMND");
            try
            {
                Console.WriteLine("Nhap CMND");
                String CMND = Console.ReadLine();
                DOC_GIA docgia = ThuVien.getDocGiaCMND(CMND);
                if (docgia != null)
                {
                    docgia.printLongDesc();
                }
                else
                {
                    Console.WriteLine("Khong tim thay doc gia phu hop !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_06(THU_VIEN ThuVien)
        {
            Console.WriteLine("Tim kiem doc gia theo ho ten");
            try
            {
                Console.WriteLine("Nhap Ho Ten");
                String HoTen = Console.ReadLine();
                ArrayList listDocGia = ThuVien.getDocGiaTen(HoTen);
                if (listDocGia != null && listDocGia.Count > 0)
                {
                    Console.WriteLine("Co " + listDocGia.Count + " doc gia thoa dieu kien");
                    foreach (DOC_GIA docgia in listDocGia)
                    {
                        docgia.printLongDesc();
                    }
                }
                else
                {
                    Console.WriteLine("Khong tim thay doc gia phu hop !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_07(THU_VIEN ThuVien)
        {
            Console.WriteLine("Xem danh sach cac sach");
            try
            {
                ThuVien.printListSach();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_08(THU_VIEN ThuVien)
        {
            Console.WriteLine("Them sach");
            try
            {
                Console.WriteLine("Nhap ISBN");
                String ISBN = Console.ReadLine();
                if (!ThuVien.isSachExist(ISBN)) //Sach not exist
                {
                    SACH sach = new SACH(ISBN);
                    if (sach.input())
                    {
                        if (ThuVien.ThemSach(sach))
                        {
                            Console.WriteLine("Them sach thanh cong !");
                        }
                        else
                        {
                            Console.WriteLine("Them sach khong thanh cong !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nhap thong tin sach khong thanh cong !");
                    }
                    
                    
                }
                else
                {
                    Console.WriteLine("Ma ISBN khong hop le hoac sach da co trong thu vien !");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_09(THU_VIEN ThuVien)
        {
            Console.WriteLine("Chinh sua thong tin sach");
            try
            {
                SACH sach = ThuVien.getSach();
                if (sach != null)
                {
                    if (sach.modify())
                    {
                        if (ThuVien.CapNhatSach(sach))
                        {
                            Console.WriteLine("Thong tin moi duoc cap nhat thanh cong !");
                        }
                        else
                        {
                            Console.WriteLine("Thong tin moi cap nhat khong thanh cong !");
                        }                        
                    }
                    else
                    {
                        Console.WriteLine("Chinh sua thong tin sach khong thanh cong !");
                    }
                }
                else
                {
                    Console.WriteLine("Khong tim thay sach phu hop !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_10(THU_VIEN ThuVien)
        {
            Console.WriteLine("Xoa thong tin sach");
            try
            {
                SACH sach = ThuVien.getSach();
                if (sach != null)
                {
                    if (ThuVien.XoaSach(sach))
                    {
                        Console.WriteLine("Xoa thong tin sach thanh cong !");
                    }
                    else
                    {
                        Console.WriteLine("Xoa thong tin sach khong thanh cong !");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_11(THU_VIEN ThuVien)
        {
            Console.WriteLine("Tim kiem sach theo ISBN");
            try
            {
                Console.WriteLine("Nhap ISBN");
                String ISBN = Console.ReadLine();
                SACH sach = ThuVien.getSachISBN(ISBN);
                if (sach != null)
                {
                    sach.printLongDesc();
                }
                else
                {
                    Console.WriteLine("Khong tim thay sach phu hop !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_12(THU_VIEN ThuVien)
        {
            Console.WriteLine("Tim kiem sach theo ten");
            try
            {
                Console.WriteLine("Nhap Ten Sach");
                String TenSach = Console.ReadLine();
                ArrayList listSach = ThuVien.getSachTen(TenSach);
                if (listSach != null && listSach.Count > 0)
                {
                    Console.WriteLine("Co " + listSach.Count + " sach thoa dieu kien");
                    foreach (SACH sach in listSach)
                    {
                        sach.printLongDesc();
                    }                    
                }
                else
                {
                    Console.WriteLine("Khong tim thay sach phu hop !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_13(THU_VIEN ThuVien)
        {
            Console.WriteLine("Lap phieu muon sach");
            try
            {
                DOC_GIA docgia = ThuVien.getDocGia();
                if (docgia != null)
                {
                    if (!ThuVien.havePhieuNotFinish(docgia.MaDocGia))
                    {
                        Console.WriteLine("Nhap Ma Phieu");
                        String MaPhieu = Console.ReadLine();
                        if (!ThuVien.isPhieuExist(MaPhieu))
                        {
                            PHIEU phieu = new PHIEU(MaPhieu, docgia.MaDocGia);
                            if (phieu.input())
                            {
                                //kiem tra sach muon
                                if (ThuVien.checkSachMuon(phieu))
                                {
                                    if (ThuVien.ThemPhieu(phieu))
                                    {
                                        Console.WriteLine("Lap phieu muon thanh cong !");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Lap phieu muon khong thanh cong !");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Kiem tra sach muon that bai - kiem tra lai isbn hoac so luong !");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nhap danh sach cac sach muon that bai !");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Ma Phieu khong hop le !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Phieu muon sach cu chua hoan tat");
                    }
                }
                else
                {
                    Console.WriteLine("Khong tim thay doc gia !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_14(THU_VIEN ThuVien)
        {
            Console.WriteLine("Lap phieu tra sach");
            try
            {
                Console.WriteLine("Nhap ma phieu");
                String MaPhieu = Console.ReadLine();
                if (ThuVien.isPhieuExist(MaPhieu))
                {
                    PHIEU phieu = ThuVien.getPhieuMa(MaPhieu);
                    if (phieu.NgayTraThucTe == null || phieu.NgayTraThucTe == "")
                    {
                        Console.WriteLine("Thong tin phieu muon!");
                        ThuVien.printPhieuMuonSach(phieu);
                        phieu.setNgayTraThucTe();
                        ArrayList listSachMuon = new ArrayList(phieu.SachMuon);
                        if (ThuVien.CapNhatPhieu(phieu))
                        {
                            Console.WriteLine("Thong tin phieu tra !");
                            ThuVien.printPhieuTraSach(phieu,listSachMuon);
                            Console.WriteLine("Hoan tat tra sach");
                        }
                        else
                        {
                            Console.WriteLine("Tra sach that bai");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Phieu muon sach da ket thuc !");
                    }
                }                
                else
                {
                    Console.WriteLine("Phieu muon sach khong ton tai");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_15(THU_VIEN ThuVien)
        {
            Console.WriteLine("Thong ke so luong sach trong thu vien");
            try
            {
                Console.WriteLine("Tong so luong sach: " + ThuVien.thongKeSach());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_16(THU_VIEN ThuVien)
        {
            Console.WriteLine("Thong ke so luong sach theo the loai");
            try
            {
                ArrayList result = ThuVien.thongKeSachTheoTheLoai();
                ArrayList TheLoai = (ArrayList) result[0];
                ArrayList SLTheLoai = (ArrayList)result[1];
                for (int i = 0; i < TheLoai.Count; i++)
                {
                    Console.WriteLine(TheLoai[i] + ": " + SLTheLoai[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_17(THU_VIEN ThuVien)
        {
            Console.WriteLine("Thong ke so luong doc gia");
            Console.WriteLine("Tong so luong doc gia: " + ThuVien.thongKeDocGia());            
            anotherRequest(ThuVien);
        }
        static void request_18(THU_VIEN ThuVien)
        {
            Console.WriteLine("Thong ke so luong doc gia theo gioi tinh");
            try
            {
                ArrayList result = ThuVien.thongKeDocGiaTheoGioiTinh();
                Console.WriteLine("Tong so doc gia Nam: " + result[0]);
                Console.WriteLine("Tong so doc gia Nu: " + result[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void request_19(THU_VIEN ThuVien)
        {
            Console.WriteLine("Thong ke so sach dang duoc muon");                  
            Console.WriteLine("Tong so sach dang duoc muon: " + ThuVien.thongKeSachDangMuon());            
            anotherRequest(ThuVien);
        }
        static void request_20(THU_VIEN ThuVien)
        {
            Console.WriteLine("Thong ke danh sach doc gia bi tre han");
            try
            {
                ArrayList result = ThuVien.thongkeDocGiaTreHan();
                Console.WriteLine("Co " + result.Count + " doc gia tre han");
                if (result.Count > 0)
                {                    
                    foreach(String MaDocGia in result)
                    {
                        DOC_GIA docgia = ThuVien.getDocGiaMa(MaDocGia);
                        docgia.printShortDesc();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(ThuVien);
        }
        static void test()
        {
            DateTime now = DateTime.Now;
            //Console.WriteLine(UTIL.formatDate(now));
            Console.ReadLine();
        }
    }
}
