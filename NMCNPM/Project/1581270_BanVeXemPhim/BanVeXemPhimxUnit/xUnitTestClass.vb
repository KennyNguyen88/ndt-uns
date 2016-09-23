Imports System.Globalization
Imports Xunit
Imports BVXP = BanVeXemPhim
Public Class xUnitTestClass
    <Theory>
    <InlineData("20160820")>
    <InlineData("20160821")>
    Public Sub test(dt As String)
        'arrange
        Dim Luu_tru As BVXP.XL_LUU_TRU
        Dim Ung_dung As BVXP.XL_UNG_DUNG
        Luu_tru = New BVXP.XL_LUU_TRU("DO_AN")
        Dim Du_lieu As DataSet = Luu_tru.Doc_Du_lieu
        Ung_dung = New BVXP.XL_UNG_DUNG(Du_lieu)
        Dim testDay As Date = DateTime.ParseExact(dt, "yyyymmdd", CultureInfo.CurrentCulture).Date
        'act
        Dim cnt = Ung_dung.Danh_Sach_Phim_Xuat_Chieu_Sau_Ngay(testDay).Count
        'asset
        Assert.NotEqual(cnt, 0)
    End Sub


End Class
