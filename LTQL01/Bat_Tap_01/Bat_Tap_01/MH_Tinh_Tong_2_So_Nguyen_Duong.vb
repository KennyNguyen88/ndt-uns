Public Class MH_Tinh_Tong_2_So_Nguyen_Duong
    Private Sub btnDongY_Click(sender As Object, e As EventArgs) Handles btnDongY.Click

        Dim x As Integer
        Dim y As Integer
        Dim kiem_tra_x As Boolean
        Dim kiem_tra_y As Boolean

        reset_error()

        kiem_tra_x = Integer.TryParse(txtX.Text, x)
        kiem_tra_y = Integer.TryParse(txtY.Text, y)


        If Not kiem_tra_x Then
            lb_X_error.Text = "* Vui lòng nhập số nguyên"
        ElseIf Not kiem_tra_y Then
            lb_Y_error.Text = "* Vui lòng nhập số nguyên"
        Else
            txtKQ.Text = x + y
        End If

    End Sub

    Private Sub reset_error()
        lb_X_error.Text = ""
        lb_Y_error.Text = ""
    End Sub

    Private Sub MH_Tinh_Tong_2_So_Nguyen_Duong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reset_error()

    End Sub
End Class
