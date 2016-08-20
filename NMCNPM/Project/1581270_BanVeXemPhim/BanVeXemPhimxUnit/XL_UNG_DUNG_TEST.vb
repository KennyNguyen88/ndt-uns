Imports System.Globalization
Imports Xunit
Imports BVXP = BanVeXemPhim
Public Class XL_UNG_DUNG_TEST
    '<Theory>
    '<InlineData("20160820")>
    '<InlineData("20160821")>
    'Public Sub test(dt As String)
    '    'arrange
    '    Dim Luu_tru As BVXP.XL_LUU_TRU
    '    Dim Ung_dung As BVXP.XL_UNG_DUNG
    '    Luu_tru = New BVXP.XL_LUU_TRU("DO_AN")
    '    Dim Du_lieu As DataSet = Luu_tru.Doc_Du_lieu
    '    Ung_dung = New BVXP.XL_UNG_DUNG(Du_lieu)
    '    Dim testDay As Date = DateTime.ParseExact(dt, "yyyymmdd", CultureInfo.CurrentCulture).Date
    '    'act
    '    Dim cnt = Ung_dung.Danh_Sach_Phim_Xuat_Chieu_Sau_Ngay(testDay).Count
    '    'asset
    '    Assert.NotEqual(cnt, 0)
    'End Sub

    Protected Luu_tru As BVXP.XL_LUU_TRU
    Protected Ung_dung As BVXP.XL_UNG_DUNG

    Public Sub New()
        Luu_tru = New BVXP.XL_LUU_TRU("DO_AN")
        Dim Du_lieu As DataSet = Luu_tru.Doc_Du_lieu
        Ung_dung = New BVXP.XL_UNG_DUNG(Du_lieu)
    End Sub
    <Theory>
    <InlineData(10, 1, "20160820")>
    <InlineData(10, 1, "20160821")>
    Public Sub Return1XuatChieu(ID_PHIM As Integer, ID_CA_CHIEU As Integer, Ngay As String)
        'arrange
        Dim tNgay As Date = DateTime.ParseExact(Ngay, "yyyyMMdd", CultureInfo.CurrentCulture).Date
        'act
        Dim dsResult As List(Of BVXP.XL_XUAT_CHIEU) = Ung_dung.Danh_sach_Xuat_Chieu_Theo_Phim_Ca_Ngay(ID_PHIM, ID_CA_CHIEU, tNgay)
        Dim cnt = dsResult.Count
        'asset
        Assert.Equal(cnt, 1)
    End Sub

End Class
