Module Create_Questions_Module
    Public Sub Create_Circle_Question_Class()
        Dim Circle_Answer As Double
        Dim Circle_Radius As Double
        Dim Circle_Button_Array(4)
        Dim Circle_Incorrect_Answer_1 As String
        Dim Circle_Incorrect_Answer_2 As String
        Dim Circle_Incorrect_Answer_3 As String
        Dim Random_Function As New Random
        Dim Circle_Answer_Multiplied As Integer
        ' Setup variables to store information required for question
        Circle_Practice_Form.Circle_Points_Label.Text() = ("Points: " + Str(Pick_Shape_Form.Circle_Points))
        Circle_Button_Array(0) = Circle_Practice_Form.Circle_Option_1_Button
        Circle_Button_Array(1) = Circle_Practice_Form.Circle_Option_2_Button
        Circle_Button_Array(2) = Circle_Practice_Form.Circle_Option_3_Button
        Circle_Button_Array(3) = Circle_Practice_Form.Circle_Option_4_Button
        ' Fill in array of buttons on the circle form
        Circle_Radius = Random_Function.Next(1, 20)
        ' Randomly generate a number between 1 and 20 to be the circle's radius 
        Circle_Practice_Form.Circle_Radius_Label.Text = ("Radius = " + Str(Circle_Radius))
        ' Write the radius to the form
        Circle_Answer = (Math.PI * (Circle_Radius * Circle_Radius))
        ' Calculate the radius of the circle
        Circle_Practice_Form.Circle_Correct_Button_Number = Random_Function.Next(0, 3)
        ' Randomly choose which button should contain the correct answer
        Circle_Answer = Math.Round(Circle_Answer, 2)
        ' Round the answer to 2 dp
        Circle_Button_Array(Circle_Practice_Form.Circle_Correct_Button_Number).Text() = (Str(Circle_Answer) + " cm²")
        ' Write the correct answer to the chosen button
        Circle_Answer_Multiplied = Circle_Answer * 100
        Circle_Incorrect_Answer_1 = (Str((Random_Function.Next(Circle_Answer_Multiplied - 1000, Circle_Answer_Multiplied + 1000)) / 100) + " cm²")
        Circle_Incorrect_Answer_2 = (Str((Random_Function.Next(Circle_Answer_Multiplied - 1000, Circle_Answer_Multiplied + 1000)) / 100) + " cm²")
        Circle_Incorrect_Answer_3 = (Str((Random_Function.Next(Circle_Answer_Multiplied - 1000, Circle_Answer_Multiplied + 1000)) / 100) + " cm²")
        If Circle_Practice_Form.Circle_Correct_Button_Number = 0 Then
            Circle_Button_Array(1).Text() = Circle_Incorrect_Answer_1
            Circle_Button_Array(2).Text() = Circle_Incorrect_Answer_2
            Circle_Button_Array(3).Text() = Circle_Incorrect_Answer_3
        ElseIf Circle_Practice_Form.Circle_Correct_Button_Number = 1 Then
            Circle_Button_Array(0).Text() = Circle_Incorrect_Answer_1
            Circle_Button_Array(2).Text() = Circle_Incorrect_Answer_2
            Circle_Button_Array(3).Text() = Circle_Incorrect_Answer_3
        ElseIf Circle_Practice_Form.Circle_Correct_Button_Number = 2 Then
            Circle_Button_Array(0).Text() = Circle_Incorrect_Answer_1
            Circle_Button_Array(1).Text() = Circle_Incorrect_Answer_2
            Circle_Button_Array(3).Text() = Circle_Incorrect_Answer_3
        ElseIf Circle_Practice_Form.Circle_Correct_Button_Number = 3 Then
            Circle_Button_Array(0).Text() = Circle_Incorrect_Answer_1
            Circle_Button_Array(1).Text() = Circle_Incorrect_Answer_2
            Circle_Button_Array(2).Text() = Circle_Incorrect_Answer_3
        End If
        Pick_Shape_Form.Circle_Question_Number = Pick_Shape_Form.Circle_Question_Number + 1
        Circle_Practice_Form.Circle_Question_Number_Label.Text() = ("Question: " + Str(Pick_Shape_Form.Circle_Question_Number))
    End Sub
End Module
