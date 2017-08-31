<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Triangle_Practice_Form
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
        Me.Triangle_Question_Number_Label = New System.Windows.Forms.Label()
        Me.Triangle_Height_Label = New System.Windows.Forms.Label()
        Me.Triangle_Exit_Button = New System.Windows.Forms.Button()
        Me.Triangle_Points_Label = New System.Windows.Forms.Label()
        Me.Triangle_Option_4_Button = New System.Windows.Forms.Button()
        Me.Triangle_Option_3_Button = New System.Windows.Forms.Button()
        Me.Triangle_Option_2_Button = New System.Windows.Forms.Button()
        Me.Triangle_Option_1_Button = New System.Windows.Forms.Button()
        Me.Triangle_Question_Label = New System.Windows.Forms.Label()
        Me.Triangle_Label = New System.Windows.Forms.Label()
        Me.Triangle_Width_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Triangle_Question_Number_Label
        '
        Me.Triangle_Question_Number_Label.AutoSize = True
        Me.Triangle_Question_Number_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Triangle_Question_Number_Label.Location = New System.Drawing.Point(93, 9)
        Me.Triangle_Question_Number_Label.Name = "Triangle_Question_Number_Label"
        Me.Triangle_Question_Number_Label.Size = New System.Drawing.Size(161, 32)
        Me.Triangle_Question_Number_Label.TabIndex = 19
        Me.Triangle_Question_Number_Label.Text = "Question: 0"
        '
        'Triangle_Height_Label
        '
        Me.Triangle_Height_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Triangle_Height_Label.Location = New System.Drawing.Point(278, 145)
        Me.Triangle_Height_Label.Name = "Triangle_Height_Label"
        Me.Triangle_Height_Label.Size = New System.Drawing.Size(192, 25)
        Me.Triangle_Height_Label.TabIndex = 16
        Me.Triangle_Height_Label.Text = "Height = <Radius Here>"
        Me.Triangle_Height_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Triangle_Exit_Button
        '
        Me.Triangle_Exit_Button.Location = New System.Drawing.Point(12, 12)
        Me.Triangle_Exit_Button.Name = "Triangle_Exit_Button"
        Me.Triangle_Exit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Triangle_Exit_Button.TabIndex = 18
        Me.Triangle_Exit_Button.Text = "Exit"
        Me.Triangle_Exit_Button.UseVisualStyleBackColor = True
        '
        'Triangle_Points_Label
        '
        Me.Triangle_Points_Label.Location = New System.Drawing.Point(373, 9)
        Me.Triangle_Points_Label.Name = "Triangle_Points_Label"
        Me.Triangle_Points_Label.Size = New System.Drawing.Size(97, 26)
        Me.Triangle_Points_Label.TabIndex = 17
        Me.Triangle_Points_Label.Text = "Points: <Points>"
        Me.Triangle_Points_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Triangle_Option_4_Button
        '
        Me.Triangle_Option_4_Button.Location = New System.Drawing.Point(251, 388)
        Me.Triangle_Option_4_Button.Name = "Triangle_Option_4_Button"
        Me.Triangle_Option_4_Button.Size = New System.Drawing.Size(219, 55)
        Me.Triangle_Option_4_Button.TabIndex = 15
        Me.Triangle_Option_4_Button.Text = "Option 4"
        Me.Triangle_Option_4_Button.UseVisualStyleBackColor = True
        '
        'Triangle_Option_3_Button
        '
        Me.Triangle_Option_3_Button.Location = New System.Drawing.Point(12, 388)
        Me.Triangle_Option_3_Button.Name = "Triangle_Option_3_Button"
        Me.Triangle_Option_3_Button.Size = New System.Drawing.Size(219, 55)
        Me.Triangle_Option_3_Button.TabIndex = 14
        Me.Triangle_Option_3_Button.Text = "Option 3"
        Me.Triangle_Option_3_Button.UseVisualStyleBackColor = True
        '
        'Triangle_Option_2_Button
        '
        Me.Triangle_Option_2_Button.Location = New System.Drawing.Point(251, 327)
        Me.Triangle_Option_2_Button.Name = "Triangle_Option_2_Button"
        Me.Triangle_Option_2_Button.Size = New System.Drawing.Size(219, 55)
        Me.Triangle_Option_2_Button.TabIndex = 13
        Me.Triangle_Option_2_Button.Text = "Option 2"
        Me.Triangle_Option_2_Button.UseVisualStyleBackColor = True
        '
        'Triangle_Option_1_Button
        '
        Me.Triangle_Option_1_Button.Location = New System.Drawing.Point(12, 327)
        Me.Triangle_Option_1_Button.Name = "Triangle_Option_1_Button"
        Me.Triangle_Option_1_Button.Size = New System.Drawing.Size(219, 55)
        Me.Triangle_Option_1_Button.TabIndex = 12
        Me.Triangle_Option_1_Button.Text = "Option 1"
        Me.Triangle_Option_1_Button.UseVisualStyleBackColor = True
        '
        'Triangle_Question_Label
        '
        Me.Triangle_Question_Label.AutoSize = True
        Me.Triangle_Question_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Triangle_Question_Label.Location = New System.Drawing.Point(31, 278)
        Me.Triangle_Question_Label.Name = "Triangle_Question_Label"
        Me.Triangle_Question_Label.Size = New System.Drawing.Size(421, 32)
        Me.Triangle_Question_Label.TabIndex = 11
        Me.Triangle_Question_Label.Text = "What is the area of this triangle?"
        '
        'Triangle_Label
        '
        Me.Triangle_Label.AutoSize = True
        Me.Triangle_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 199.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Triangle_Label.Location = New System.Drawing.Point(-46, -54)
        Me.Triangle_Label.Name = "Triangle_Label"
        Me.Triangle_Label.Size = New System.Drawing.Size(401, 378)
        Me.Triangle_Label.TabIndex = 10
        Me.Triangle_Label.Text = "△"
        '
        'Triangle_Width_Label
        '
        Me.Triangle_Width_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Triangle_Width_Label.Location = New System.Drawing.Point(283, 170)
        Me.Triangle_Width_Label.Name = "Triangle_Width_Label"
        Me.Triangle_Width_Label.Size = New System.Drawing.Size(187, 25)
        Me.Triangle_Width_Label.TabIndex = 20
        Me.Triangle_Width_Label.Text = "Width = <Radius Here>"
        Me.Triangle_Width_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Triangle_Practice_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.Triangle_Width_Label)
        Me.Controls.Add(Me.Triangle_Question_Number_Label)
        Me.Controls.Add(Me.Triangle_Height_Label)
        Me.Controls.Add(Me.Triangle_Exit_Button)
        Me.Controls.Add(Me.Triangle_Points_Label)
        Me.Controls.Add(Me.Triangle_Option_4_Button)
        Me.Controls.Add(Me.Triangle_Option_3_Button)
        Me.Controls.Add(Me.Triangle_Option_2_Button)
        Me.Controls.Add(Me.Triangle_Option_1_Button)
        Me.Controls.Add(Me.Triangle_Question_Label)
        Me.Controls.Add(Me.Triangle_Label)
        Me.Name = "Triangle_Practice_Form"
        Me.Text = "Triangle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Triangle_Question_Number_Label As Label
    Friend WithEvents Triangle_Height_Label As Label
    Friend WithEvents Triangle_Exit_Button As Button
    Friend WithEvents Triangle_Points_Label As Label
    Friend WithEvents Triangle_Option_4_Button As Button
    Friend WithEvents Triangle_Option_3_Button As Button
    Friend WithEvents Triangle_Option_2_Button As Button
    Friend WithEvents Triangle_Option_1_Button As Button
    Friend WithEvents Triangle_Question_Label As Label
    Friend WithEvents Triangle_Label As Label
    Friend WithEvents Triangle_Width_Label As Label
End Class
