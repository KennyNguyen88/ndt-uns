Public Class Login
    Protected The_hien As XL_THE_HIEN
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        The_hien = New XL_THE_HIEN
        The_hien.Dinh_Dang_Form(Me)
        The_hien.Dinh_Dang_Button_Menu(Button1)
    End Sub
End Class
