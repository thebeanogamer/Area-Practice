Module Check_Answer_Module
    Public Sub Check_Circle_Sub()
        If Pick_Shape_Form.Circle_Button_Pressed = Circle_Practice_Form.Circle_Correct_Button_Number Then
            MsgBox("That is the correct answer!", MsgBoxStyle.Information, "Correct!")
            If Pick_Shape_Form.Circle_Guess = 0 Then
                Pick_Shape_Form.Circle_Points = Pick_Shape_Form.Circle_Points + 2
                Create_Questions_Module.Create_Circle_Question_Class()
            Else
                Pick_Shape_Form.Circle_Points = Pick_Shape_Form.Circle_Points + 1
                Create_Questions_Module.Create_Circle_Question_Class()
            End If
        Else
            If Pick_Shape_Form.Circle_Guess = 0 Then
                MsgBox("That is the wrong answer, you have 1 go remaining!", MsgBoxStyle.Critical, "Incorrect!")
                Pick_Shape_Form.Circle_Guess = 1
            Else
                MsgBox("That is the wrong answer, you have 0 goes remaining", MsgBoxStyle.Critical, "Incorrect!")
                Pick_Shape_Form.Circle_Guess = 0
                Create_Questions_Module.Create_Circle_Question_Class()
            End If
        End If
    End Sub
    Public Sub Check_Triangle_Sub()
        If Pick_Shape_Form.Triangle_Button_Pressed = Triangle_Practice_Form.Triangle_Correct_Button_Number Then
            MsgBox("That is the correct answer!", MsgBoxStyle.Information, "Correct!")
            If Pick_Shape_Form.Triangle_Guess = 0 Then
                Pick_Shape_Form.Triangle_Points = Pick_Shape_Form.Triangle_Points + 2
                Create_Questions_Module.Create_Triangle_Question_Class()
            Else
                Pick_Shape_Form.Triangle_Points = Pick_Shape_Form.Triangle_Points + 1
                Create_Questions_Module.Create_Triangle_Question_Class()
            End If
        Else
            If Pick_Shape_Form.Triangle_Guess = 0 Then
                MsgBox("That is the wrong answer, you have 1 go remaining!", MsgBoxStyle.Critical, "Incorrect!")
                Pick_Shape_Form.Triangle_Guess = 1
            Else
                MsgBox("That is the wrong answer, you have 0 goes remaining", MsgBoxStyle.Critical, "Incorrect!")
                Pick_Shape_Form.Triangle_Guess = 0
                Create_Questions_Module.Create_Triangle_Question_Class()
            End If
        End If
    End Sub
End Module