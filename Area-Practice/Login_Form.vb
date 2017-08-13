Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Temp_Login_Button_Click(sender As Object, e As EventArgs) Handles Temp_Login_Button.Click
        Dim Username As String
        Dim Fullname As String
        Username = "TestingUsername"
        Fullname = "Testing McTestiname"
        Pick_Shape_Form.Show()
        Pick_Shape_Form.Welcome_Label.Text = ("Welcome " + Fullname)
    End Sub
End Class
