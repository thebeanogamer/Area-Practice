Public Class Pick_Shape_Form
    Private Sub Pick_Triangle_Button_Click(sender As Object, e As EventArgs) Handles Pick_Triangle_Button.Click
        Triangle_Practice_Form.Show()
    End Sub

    Private Sub Pick_Rectangle_Button_Click(sender As Object, e As EventArgs) Handles Pick_Rectangle_Button.Click
        Rectangle_Practice_Form.Show()
    End Sub

    Private Sub Pick_Circle_Button_Click(sender As Object, e As EventArgs) Handles Pick_Circle_Button.Click
        Circle_Practice_Form.Show()
    End Sub
End Class