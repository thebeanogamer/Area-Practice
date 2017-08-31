<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rectangle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Circle_Question_Number_Label = New System.Windows.Forms.Label()
        Me.Circle_Radius_Label = New System.Windows.Forms.Label()
        Me.Circle_Exit_Button = New System.Windows.Forms.Button()
        Me.Circle_Points_Label = New System.Windows.Forms.Label()
        Me.Circle_Option_4_Button = New System.Windows.Forms.Button()
        Me.Circle_Option_3_Button = New System.Windows.Forms.Button()
        Me.Circle_Option_2_Button = New System.Windows.Forms.Button()
        Me.Circle_Option_1_Button = New System.Windows.Forms.Button()
        Me.Circle_Question_Label = New System.Windows.Forms.Label()
        Me.Circle_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Circle_Question_Number_Label
        '
        Me.Circle_Question_Number_Label.AutoSize = True
        Me.Circle_Question_Number_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Circle_Question_Number_Label.Location = New System.Drawing.Point(93, 9)
        Me.Circle_Question_Number_Label.Name = "Circle_Question_Number_Label"
        Me.Circle_Question_Number_Label.Size = New System.Drawing.Size(161, 32)
        Me.Circle_Question_Number_Label.TabIndex = 19
        Me.Circle_Question_Number_Label.Text = "Question: 0"
        '
        'Circle_Radius_Label
        '
        Me.Circle_Radius_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Circle_Radius_Label.Location = New System.Drawing.Point(311, 145)
        Me.Circle_Radius_Label.Name = "Circle_Radius_Label"
        Me.Circle_Radius_Label.Size = New System.Drawing.Size(159, 25)
        Me.Circle_Radius_Label.TabIndex = 16
        Me.Circle_Radius_Label.Text = "Radius = <Radius Here>"
        Me.Circle_Radius_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Circle_Exit_Button
        '
        Me.Circle_Exit_Button.Location = New System.Drawing.Point(12, 12)
        Me.Circle_Exit_Button.Name = "Circle_Exit_Button"
        Me.Circle_Exit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Circle_Exit_Button.TabIndex = 18
        Me.Circle_Exit_Button.Text = "Exit"
        Me.Circle_Exit_Button.UseVisualStyleBackColor = True
        '
        'Circle_Points_Label
        '
        Me.Circle_Points_Label.Location = New System.Drawing.Point(373, 9)
        Me.Circle_Points_Label.Name = "Circle_Points_Label"
        Me.Circle_Points_Label.Size = New System.Drawing.Size(97, 26)
        Me.Circle_Points_Label.TabIndex = 17
        Me.Circle_Points_Label.Text = "Points: <Points>"
        Me.Circle_Points_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Circle_Option_4_Button
        '
        Me.Circle_Option_4_Button.Location = New System.Drawing.Point(251, 388)
        Me.Circle_Option_4_Button.Name = "Circle_Option_4_Button"
        Me.Circle_Option_4_Button.Size = New System.Drawing.Size(219, 55)
        Me.Circle_Option_4_Button.TabIndex = 15
        Me.Circle_Option_4_Button.Text = "Option 4"
        Me.Circle_Option_4_Button.UseVisualStyleBackColor = True
        '
        'Circle_Option_3_Button
        '
        Me.Circle_Option_3_Button.Location = New System.Drawing.Point(12, 388)
        Me.Circle_Option_3_Button.Name = "Circle_Option_3_Button"
        Me.Circle_Option_3_Button.Size = New System.Drawing.Size(219, 55)
        Me.Circle_Option_3_Button.TabIndex = 14
        Me.Circle_Option_3_Button.Text = "Option 3"
        Me.Circle_Option_3_Button.UseVisualStyleBackColor = True
        '
        'Circle_Option_2_Button
        '
        Me.Circle_Option_2_Button.Location = New System.Drawing.Point(251, 327)
        Me.Circle_Option_2_Button.Name = "Circle_Option_2_Button"
        Me.Circle_Option_2_Button.Size = New System.Drawing.Size(219, 55)
        Me.Circle_Option_2_Button.TabIndex = 13
        Me.Circle_Option_2_Button.Text = "Option 2"
        Me.Circle_Option_2_Button.UseVisualStyleBackColor = True
        '
        'Circle_Option_1_Button
        '
        Me.Circle_Option_1_Button.Location = New System.Drawing.Point(12, 327)
        Me.Circle_Option_1_Button.Name = "Circle_Option_1_Button"
        Me.Circle_Option_1_Button.Size = New System.Drawing.Size(219, 55)
        Me.Circle_Option_1_Button.TabIndex = 12
        Me.Circle_Option_1_Button.Text = "Option 1"
        Me.Circle_Option_1_Button.UseVisualStyleBackColor = True
        '
        'Circle_Question_Label
        '
        Me.Circle_Question_Label.AutoSize = True
        Me.Circle_Question_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Circle_Question_Label.Location = New System.Drawing.Point(45, 278)
        Me.Circle_Question_Label.Name = "Circle_Question_Label"
        Me.Circle_Question_Label.Size = New System.Drawing.Size(393, 32)
        Me.Circle_Question_Label.TabIndex = 11
        Me.Circle_Question_Label.Text = "What is the area of this circle?"
        '
        'Circle_Label
        '
        Me.Circle_Label.AutoSize = True
        Me.Circle_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 199.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Circle_Label.Location = New System.Drawing.Point(-46, -54)
        Me.Circle_Label.Name = "Circle_Label"
        Me.Circle_Label.Size = New System.Drawing.Size(401, 378)
        Me.Circle_Label.TabIndex = 10
        Me.Circle_Label.Text = "○"
        '
        'Rectangle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.Circle_Question_Number_Label)
        Me.Controls.Add(Me.Circle_Radius_Label)
        Me.Controls.Add(Me.Circle_Exit_Button)
        Me.Controls.Add(Me.Circle_Points_Label)
        Me.Controls.Add(Me.Circle_Option_4_Button)
        Me.Controls.Add(Me.Circle_Option_3_Button)
        Me.Controls.Add(Me.Circle_Option_2_Button)
        Me.Controls.Add(Me.Circle_Option_1_Button)
        Me.Controls.Add(Me.Circle_Question_Label)
        Me.Controls.Add(Me.Circle_Label)
        Me.Name = "Rectangle"
        Me.Text = "Rectangle_Practice_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Circle_Question_Number_Label As Label
    Friend WithEvents Circle_Radius_Label As Label
    Friend WithEvents Circle_Exit_Button As Button
    Friend WithEvents Circle_Points_Label As Label
    Friend WithEvents Circle_Option_4_Button As Button
    Friend WithEvents Circle_Option_3_Button As Button
    Friend WithEvents Circle_Option_2_Button As Button
    Friend WithEvents Circle_Option_1_Button As Button
    Friend WithEvents Circle_Question_Label As Label
    Friend WithEvents Circle_Label As Label
End Class
