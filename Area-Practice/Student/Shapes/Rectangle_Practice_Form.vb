Public Class Rectangle_Practice_Form
    Public Shared Rectangle_Correct_Button_Number As Integer
    Private Sub Rectangle_Exit_Button_Click(sender As Object, e As EventArgs) Handles Rectangle_Exit_Button.Click
        Dim Rectangle_Exit_Message As String
        Rectangle_Exit_Message = ("Congratulations, you scored" + Str(Pick_Shape_Form.Rectangle_Points) + " points!")
        MsgBox(Rectangle_Exit_Message, MsgBoxStyle.Exclamation, "Congratulations")
        Me.Close()
    End Sub

    Private Sub Rectangle_Option_1_Button_Click(sender As Object, e As EventArgs) Handles Rectangle_Option_1_Button.Click
        Pick_Shape_Form.Rectangle_Button_Pressed = 0
        Check_Answer_Module.Check_Rectangle_Sub()
    End Sub

    Private Sub Rectangle_Option_2_Button_Click(sender As Object, e As EventArgs) Handles Rectangle_Option_2_Button.Click
        Pick_Shape_Form.Rectangle_Button_Pressed = 1
        Check_Answer_Module.Check_Rectangle_Sub()
    End Sub

    Private Sub Rectangle_Option_3_Button_Click(sender As Object, e As EventArgs) Handles Rectangle_Option_3_Button.Click
        Pick_Shape_Form.Rectangle_Button_Pressed = 2
        Check_Answer_Module.Check_Rectangle_Sub()
    End Sub

    Private Sub Rectangle_Option_4_Button_Click(sender As Object, e As EventArgs) Handles Rectangle_Option_4_Button.Click
        Pick_Shape_Form.Rectangle_Button_Pressed = 3
        Check_Answer_Module.Check_Rectangle_Sub()
    End Sub
End Class