Public Class MH_Quan_Ly_Loai_Phong
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Public Sub New(Ung_dung As XL_UNG_DUNG)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Luu_tru = New XL_LUU_TRU
        Me.Ung_dung = Ung_dung
        The_hien = New XL_THE_HIEN(Ung_dung)
        Khoi_dong()
    End Sub
    Public Sub Khoi_dong()

        ''===Tiêu đề 
        Dim Tieu_de As String = "Quản Lý Loại Phòng"
        lbTieuDe.Text = Tieu_de.ToUpper
    End Sub
End Class