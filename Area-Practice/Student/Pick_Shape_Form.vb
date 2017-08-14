Public Class Pick_Shape_Form
    Public Shared Circle_Guess As Integer = 0
    Public Shared Circle_Points As Integer
    Public Shared Circle_Button_Pressed As Integer
    Public Shared Circle_Question_Number As Integer
    Private Sub Pick_Triangle_Button_Click(sender As Object, e As EventArgs) Handles Pick_Triangle_Button.Click
        Triangle_Practice_Form.Show()
    End Sub

    Private Sub Pick_Rectangle_Button_Click(sender As Object, e As EventArgs) Handles Pick_Rectangle_Button.Click
        Rectangle_Practice_Form.Show()
    End Sub

    Private Sub Pick_Circle_Button_Click(sender As Object, e As EventArgs) Handles Pick_Circle_Button.Click
        Circle_Points = 0
        Create_Circle_Question_Class()
        Circle_Practice_Form.Show()
    End Sub
End Class