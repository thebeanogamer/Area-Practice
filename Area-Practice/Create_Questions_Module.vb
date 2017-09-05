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
    Public Sub Create_Triangle_Question_Class()
        Dim Triangle_Answer As Double
        Dim Triangle_Height As Double
        Dim Triangle_Width As Double
        Dim Triangle_Button_Array(4)
        Dim Triangle_Incorrect_Answer_1 As String
        Dim Triangle_Incorrect_Answer_2 As String
        Dim Triangle_Incorrect_Answer_3 As String
        Dim Random_Function As New Random
        Dim Triangle_Answer_Multiplied As Integer
        ' Setup variables to store information required for question
        Triangle_Practice_Form.Triangle_Points_Label.Text() = ("Points: " + Str(Pick_Shape_Form.Triangle_Points))
        Triangle_Button_Array(0) = Triangle_Practice_Form.Triangle_Option_1_Button
        Triangle_Button_Array(1) = Triangle_Practice_Form.Triangle_Option_2_Button
        Triangle_Button_Array(2) = Triangle_Practice_Form.Triangle_Option_3_Button
        Triangle_Button_Array(3) = Triangle_Practice_Form.Triangle_Option_4_Button
        ' Fill in array of buttons on the Triangle form
        Triangle_Height = Random_Function.Next(1, 20)
        ' Randomly generate a number between 1 and 20 to be the Triangle's height
        Triangle_Width = Random_Function.Next(1, 20)
        ' Randomly generate a number between 1 and 20 to be the Triangle's width
        Triangle_Practice_Form.Triangle_Height_Label.Text = ("Height = " + Str(Triangle_Height) + "cm")
        Triangle_Practice_Form.Triangle_Width_Label.Text = ("Width = " + Str(Triangle_Width) + "cm")
        ' Write the height and width to the form
        Triangle_Answer = (0.5 * (Triangle_Height * Triangle_Width))
        ' Calculate the area of the Triangle
        Triangle_Practice_Form.Triangle_Correct_Button_Number = Random_Function.Next(0, 3)
        ' Randomly choose which button should contain the correct answer
        Triangle_Answer = Math.Round(Triangle_Answer, 2)
        ' Round the answer to 2 dp
        Triangle_Button_Array(Triangle_Practice_Form.Triangle_Correct_Button_Number).Text() = (Str(Triangle_Answer) + " cm²")
        ' Write the correct answer to the chosen button
        Triangle_Answer_Multiplied = Triangle_Answer * 100
        Triangle_Incorrect_Answer_1 = (Str((Random_Function.Next(Triangle_Answer_Multiplied - 499, Triangle_Answer_Multiplied + 499)) / 100) + " cm²")
        Triangle_Incorrect_Answer_2 = (Str((Random_Function.Next(Triangle_Answer_Multiplied - 499, Triangle_Answer_Multiplied + 499)) / 100) + " cm²")
        Triangle_Incorrect_Answer_3 = (Str((Random_Function.Next(Triangle_Answer_Multiplied - 499, Triangle_Answer_Multiplied + 499)) / 100) + " cm²")
        If Triangle_Practice_Form.Triangle_Correct_Button_Number = 0 Then
            Triangle_Button_Array(1).Text() = Triangle_Incorrect_Answer_1
            Triangle_Button_Array(2).Text() = Triangle_Incorrect_Answer_2
            Triangle_Button_Array(3).Text() = Triangle_Incorrect_Answer_3
        ElseIf Triangle_Practice_Form.Triangle_Correct_Button_Number = 1 Then
            Triangle_Button_Array(0).Text() = Triangle_Incorrect_Answer_1
            Triangle_Button_Array(2).Text() = Triangle_Incorrect_Answer_2
            Triangle_Button_Array(3).Text() = Triangle_Incorrect_Answer_3
        ElseIf Triangle_Practice_Form.Triangle_Correct_Button_Number = 2 Then
            Triangle_Button_Array(0).Text() = Triangle_Incorrect_Answer_1
            Triangle_Button_Array(1).Text() = Triangle_Incorrect_Answer_2
            Triangle_Button_Array(3).Text() = Triangle_Incorrect_Answer_3
        ElseIf Triangle_Practice_Form.Triangle_Correct_Button_Number = 3 Then
            Triangle_Button_Array(0).Text() = Triangle_Incorrect_Answer_1
            Triangle_Button_Array(1).Text() = Triangle_Incorrect_Answer_2
            Triangle_Button_Array(2).Text() = Triangle_Incorrect_Answer_3
        End If
        Pick_Shape_Form.Triangle_Question_Number = Pick_Shape_Form.Triangle_Question_Number + 1
        Triangle_Practice_Form.Triangle_Question_Number_Label.Text() = ("Question: " + Str(Pick_Shape_Form.Triangle_Question_Number))
    End Sub
    Public Sub Create_Rectangle_Question_Class()
        Dim Rectangle_Answer As Double
        Dim Rectangle_Height As Double
        Dim Rectangle_Width As Double
        Dim Rectangle_Button_Array(4)
        Dim Rectangle_Incorrect_Answer_1 As String
        Dim Rectangle_Incorrect_Answer_2 As String
        Dim Rectangle_Incorrect_Answer_3 As String
        Dim Random_Function As New Random
        Dim Rectangle_Answer_Multiplied As Integer
        ' Setup variables to store information required for question
        Rectangle_Practice_Form.Rectangle_Points_Label.Text() = ("Points: " + Str(Pick_Shape_Form.Rectangle_Points))
        Rectangle_Button_Array(0) = Rectangle_Practice_Form.Rectangle_Option_1_Button
        Rectangle_Button_Array(1) = Rectangle_Practice_Form.Rectangle_Option_2_Button
        Rectangle_Button_Array(2) = Rectangle_Practice_Form.Rectangle_Option_3_Button
        Rectangle_Button_Array(3) = Rectangle_Practice_Form.Rectangle_Option_4_Button
        ' Fill in array of buttons on the Rectangle form
        Rectangle_Height = Random_Function.Next(1, 20)
        ' Randomly generate a number between 1 and 20 to be the Rectangle's height
        Rectangle_Width = Random_Function.Next(1, 20)
        ' Randomly generate a number between 1 and 20 to be the Rectangle's width
        Rectangle_Practice_Form.Rectangle_Height_Label.Text = ("Height = " + Str(Rectangle_Height) + "cm")
        Rectangle_Practice_Form.Rectangle_Width_Label.Text = ("Width = " + Str(Rectangle_Width) + "cm")
        ' Write the height and width to the form
        Rectangle_Answer = (Rectangle_Height * Rectangle_Width)
        ' Calculate the area of the Rectangle
        Rectangle_Practice_Form.Rectangle_Correct_Button_Number = Random_Function.Next(0, 3)
        ' Randomly choose which button should contain the correct answer
        Rectangle_Answer = Math.Round(Rectangle_Answer, 2)
        ' Round the answer to 2 dp
        Rectangle_Button_Array(Rectangle_Practice_Form.Rectangle_Correct_Button_Number).Text() = (Str(Rectangle_Answer) + " cm²")
        ' Write the correct answer to the chosen button
        Rectangle_Answer_Multiplied = Rectangle_Answer * 100
        Rectangle_Incorrect_Answer_1 = (Str((Random_Function.Next(Rectangle_Answer_Multiplied - 499, Rectangle_Answer_Multiplied + 499)) / 100) + " cm²")
        Rectangle_Incorrect_Answer_2 = (Str((Random_Function.Next(Rectangle_Answer_Multiplied - 499, Rectangle_Answer_Multiplied + 499)) / 100) + " cm²")
        Rectangle_Incorrect_Answer_3 = (Str((Random_Function.Next(Rectangle_Answer_Multiplied - 499, Rectangle_Answer_Multiplied + 499)) / 100) + " cm²")
        If Rectangle_Practice_Form.Rectangle_Correct_Button_Number = 0 Then
            Rectangle_Button_Array(1).Text() = Rectangle_Incorrect_Answer_1
            Rectangle_Button_Array(2).Text() = Rectangle_Incorrect_Answer_2
            Rectangle_Button_Array(3).Text() = Rectangle_Incorrect_Answer_3
        ElseIf Rectangle_Practice_Form.Rectangle_Correct_Button_Number = 1 Then
            Rectangle_Button_Array(0).Text() = Rectangle_Incorrect_Answer_1
            Rectangle_Button_Array(2).Text() = Rectangle_Incorrect_Answer_2
            Rectangle_Button_Array(3).Text() = Rectangle_Incorrect_Answer_3
        ElseIf Rectangle_Practice_Form.Rectangle_Correct_Button_Number = 2 Then
            Rectangle_Button_Array(0).Text() = Rectangle_Incorrect_Answer_1
            Rectangle_Button_Array(1).Text() = Rectangle_Incorrect_Answer_2
            Rectangle_Button_Array(3).Text() = Rectangle_Incorrect_Answer_3
        ElseIf Rectangle_Practice_Form.Rectangle_Correct_Button_Number = 3 Then
            Rectangle_Button_Array(0).Text() = Rectangle_Incorrect_Answer_1
            Rectangle_Button_Array(1).Text() = Rectangle_Incorrect_Answer_2
            Rectangle_Button_Array(2).Text() = Rectangle_Incorrect_Answer_3
        End If
        Pick_Shape_Form.Rectangle_Question_Number = Pick_Shape_Form.Rectangle_Question_Number + 1
        Rectangle_Practice_Form.Rectangle_Question_Number_Label.Text() = ("Question: " + Str(Pick_Shape_Form.Rectangle_Question_Number))
    End Sub
End Module
