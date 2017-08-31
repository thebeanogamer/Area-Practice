Public Class Pick_Shape_Form
    Public Shared Circle_Guess As Integer = 0
    Public Shared Circle_Points As Integer
    Public Shared Circle_Button_Pressed As Integer
    Public Shared Circle_Question_Number As Integer
    Public Shared Triangle_Guess As Integer = 0
    Public Shared Triangle_Points As Integer
    Public Shared Triangle_Button_Pressed As Integer
    Public Shared Triangle_Question_Number As Integer
    Private Sub Pick_Triangle_Button_Click(sender As Object, e As EventArgs) Handles Pick_Triangle_Button.Click
        Triangle_Points = 0
        Create_Triangle_Question_Class()
        Triangle_Practice_Form.Show()
    End Sub

    Private Sub Pick_Rectangle_Button_Click(sender As Object, e As EventArgs) Handles Pick_Rectangle_Button.Click
        Rectangle.Show()
    End Sub

    Private Sub Pick_Circle_Button_Click(sender As Object, e As EventArgs) Handles Pick_Circle_Button.Click
        Circle_Points = 0
        Create_Circle_Question_Class()
        Circle_Practice_Form.Show()
    End Sub

    Private Sub Open_About_Button_Click(sender As Object, e As EventArgs) Handles Open_About_Button.Click
        About_Box.Show()
    End Sub
End Class