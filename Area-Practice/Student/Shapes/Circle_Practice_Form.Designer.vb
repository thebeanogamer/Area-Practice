<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Circle_Practice_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Circle_Practice_Form))
        Me.Circle_Label = New System.Windows.Forms.Label()
        Me.Circle_Question_Label = New System.Windows.Forms.Label()
        Me.Circle_Option_1_Button = New System.Windows.Forms.Button()
        Me.Circle_Option_2_Button = New System.Windows.Forms.Button()
        Me.Circle_Option_4_Button = New System.Windows.Forms.Button()
        Me.Circle_Option_3_Button = New System.Windows.Forms.Button()
        Me.Circle_Radius_Label = New System.Windows.Forms.Label()
        Me.Circle_Points_Label = New System.Windows.Forms.Label()
        Me.Circle_Exit_Button = New System.Windows.Forms.Button()
        Me.Circle_Question_Number_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Circle_Label
        '
        Me.Circle_Label.AutoSize = True
        Me.Circle_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 199.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Circle_Label.Location = New System.Drawing.Point(-34, -44)
        Me.Circle_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Circle_Label.Name = "Circle_Label"
        Me.Circle_Label.Size = New System.Drawing.Size(323, 302)
        Me.Circle_Label.TabIndex = 0
        Me.Circle_Label.Text = "○"
        '
        'Circle_Question_Label
        '
        Me.Circle_Question_Label.AutoSize = True
        Me.Circle_Question_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Circle_Question_Label.Location = New System.Drawing.Point(34, 226)
        Me.Circle_Question_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Circle_Question_Label.Name = "Circle_Question_Label"
        Me.Circle_Question_Label.Size = New System.Drawing.Size(303, 26)
        Me.Circle_Question_Label.TabIndex = 1
        Me.Circle_Question_Label.Text = "What is the area of this circle?"
        '
        'Circle_Option_1_Button
        '
        Me.Circle_Option_1_Button.Location = New System.Drawing.Point(9, 266)
        Me.Circle_Option_1_Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Circle_Option_1_Button.Name = "Circle_Option_1_Button"
        Me.Circle_Option_1_Button.Size = New System.Drawing.Size(164, 45)
        Me.Circle_Option_1_Button.TabIndex = 2
        Me.Circle_Option_1_Button.Text = "Option 1"
        Me.Circle_Option_1_Button.UseVisualStyleBackColor = True
        '
        'Circle_Option_2_Button
        '
        Me.Circle_Option_2_Button.Location = New System.Drawing.Point(188, 266)
        Me.Circle_Option_2_Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Circle_Option_2_Button.Name = "Circle_Option_2_Button"
        Me.Circle_Option_2_Button.Size = New System.Drawing.Size(164, 45)
        Me.Circle_Option_2_Button.TabIndex = 3
        Me.Circle_Option_2_Button.Text = "Option 2"
        Me.Circle_Option_2_Button.UseVisualStyleBackColor = True
        '
        'Circle_Option_4_Button
        '
        Me.Circle_Option_4_Button.Location = New System.Drawing.Point(188, 315)
        Me.Circle_Option_4_Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Circle_Option_4_Button.Name = "Circle_Option_4_Button"
        Me.Circle_Option_4_Button.Size = New System.Drawing.Size(164, 45)
        Me.Circle_Option_4_Button.TabIndex = 5
        Me.Circle_Option_4_Button.Text = "Option 4"
        Me.Circle_Option_4_Button.UseVisualStyleBackColor = True
        '
        'Circle_Option_3_Button
        '
        Me.Circle_Option_3_Button.Location = New System.Drawing.Point(9, 315)
        Me.Circle_Option_3_Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Circle_Option_3_Button.Name = "Circle_Option_3_Button"
        Me.Circle_Option_3_Button.Size = New System.Drawing.Size(164, 45)
        Me.Circle_Option_3_Button.TabIndex = 4
        Me.Circle_Option_3_Button.Text = "Option 3"
        Me.Circle_Option_3_Button.UseVisualStyleBackColor = True
        '
        'Circle_Radius_Label
        '
        Me.Circle_Radius_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Circle_Radius_Label.Location = New System.Drawing.Point(233, 118)
        Me.Circle_Radius_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Circle_Radius_Label.Name = "Circle_Radius_Label"
        Me.Circle_Radius_Label.Size = New System.Drawing.Size(119, 20)
        Me.Circle_Radius_Label.TabIndex = 6
        Me.Circle_Radius_Label.Text = "Radius = <Radius Here>"
        Me.Circle_Radius_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Circle_Points_Label
        '
        Me.Circle_Points_Label.Location = New System.Drawing.Point(280, 7)
        Me.Circle_Points_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Circle_Points_Label.Name = "Circle_Points_Label"
        Me.Circle_Points_Label.Size = New System.Drawing.Size(73, 21)
        Me.Circle_Points_Label.TabIndex = 7
        Me.Circle_Points_Label.Text = "Points: <Points>"
        Me.Circle_Points_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Circle_Exit_Button
        '
        Me.Circle_Exit_Button.Location = New System.Drawing.Point(9, 10)
        Me.Circle_Exit_Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Circle_Exit_Button.Name = "Circle_Exit_Button"
        Me.Circle_Exit_Button.Size = New System.Drawing.Size(56, 19)
        Me.Circle_Exit_Button.TabIndex = 8
        Me.Circle_Exit_Button.Text = "Exit"
        Me.Circle_Exit_Button.UseVisualStyleBackColor = True
        '
        'Circle_Question_Number_Label
        '
        Me.Circle_Question_Number_Label.AutoSize = True
        Me.Circle_Question_Number_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Circle_Question_Number_Label.Location = New System.Drawing.Point(70, 7)
        Me.Circle_Question_Number_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Circle_Question_Number_Label.Name = "Circle_Question_Number_Label"
        Me.Circle_Question_Number_Label.Size = New System.Drawing.Size(123, 26)
        Me.Circle_Question_Number_Label.TabIndex = 9
        Me.Circle_Question_Number_Label.Text = "Question: 0"
        '
        'Circle_Practice_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 368)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Circle_Practice_Form"
        Me.Text = "Circle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Circle_Label As Label
    Friend WithEvents Circle_Question_Label As Label
    Friend WithEvents Circle_Option_1_Button As Button
    Friend WithEvents Circle_Option_2_Button As Button
    Friend WithEvents Circle_Option_4_Button As Button
    Friend WithEvents Circle_Option_3_Button As Button
    Friend WithEvents Circle_Radius_Label As Label
    Friend WithEvents Circle_Points_Label As Label
    Friend WithEvents Circle_Exit_Button As Button
    Friend WithEvents Circle_Question_Number_Label As Label
End Class
