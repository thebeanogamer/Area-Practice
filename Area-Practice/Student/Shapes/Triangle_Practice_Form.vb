Public Class Triangle_Practice_Form
    Public Shared Triangle_Correct_Button_Number As Integer
    Private Sub Triangle_Option_1_Button_Click(sender As Object, e As EventArgs) Handles Triangle_Option_1_Button.Click
        Pick_Shape_Form.Triangle_Button_Pressed = 0
        Check_Answer_Module.Check_Triangle_Sub()
    End Sub

    Private Sub Triangle_Option_2_Button_Click(sender As Object, e As EventArgs) Handles Triangle_Option_2_Button.Click
        Pick_Shape_Form.Triangle_Button_Pressed = 1
        Check_Answer_Module.Check_Triangle_Sub()
    End Sub

    Private Sub Triangle_Option_3_Button_Click(sender As Object, e As EventArgs) Handles Triangle_Option_3_Button.Click
        Pick_Shape_Form.Triangle_Button_Pressed = 2
        Check_Answer_Module.Check_Triangle_Sub()
    End Sub

    Private Sub Triangle_Option_4_Button_Click(sender As Object, e As EventArgs) Handles Triangle_Option_4_Button.Click
        Pick_Shape_Form.Triangle_Button_Pressed = 3
        Check_Answer_Module.Check_Triangle_Sub()
    End Sub

    Private Sub Triangle_Exit_Button_Click(sender As Object, e As EventArgs) Handles Triangle_Exit_Button.Click
        Dim Triangle_Exit_Message As String
        Triangle_Exit_Message = ("Congratulations, you scored" + Str(Pick_Shape_Form.Triangle_Points) + " points!")
        MsgBox(Triangle_Exit_Message, MsgBoxStyle.Exclamation, "Congratulations")
        Me.Close()
    End Sub
End Class