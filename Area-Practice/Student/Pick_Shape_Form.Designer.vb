<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pick_Shape_Form
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
        Me.Pick_Triangle_Button = New System.Windows.Forms.Button()
        Me.Pick_Rectangle_Button = New System.Windows.Forms.Button()
        Me.Pick_Circle_Button = New System.Windows.Forms.Button()
        Me.Welcome_Label = New System.Windows.Forms.Label()
        Me.Open_About_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Pick_Triangle_Button
        '
        Me.Pick_Triangle_Button.Location = New System.Drawing.Point(9, 46)
        Me.Pick_Triangle_Button.Name = "Pick_Triangle_Button"
        Me.Pick_Triangle_Button.Size = New System.Drawing.Size(89, 39)
        Me.Pick_Triangle_Button.TabIndex = 0
        Me.Pick_Triangle_Button.Text = "Triangle"
        Me.Pick_Triangle_Button.UseVisualStyleBackColor = True
        '
        'Pick_Rectangle_Button
        '
        Me.Pick_Rectangle_Button.Location = New System.Drawing.Point(9, 121)
        Me.Pick_Rectangle_Button.Name = "Pick_Rectangle_Button"
        Me.Pick_Rectangle_Button.Size = New System.Drawing.Size(89, 39)
        Me.Pick_Rectangle_Button.TabIndex = 3
        Me.Pick_Rectangle_Button.Text = "Rectangle"
        Me.Pick_Rectangle_Button.UseVisualStyleBackColor = True
        '
        'Pick_Circle_Button
        '
        Me.Pick_Circle_Button.Location = New System.Drawing.Point(9, 196)
        Me.Pick_Circle_Button.Name = "Pick_Circle_Button"
        Me.Pick_Circle_Button.Size = New System.Drawing.Size(89, 39)
        Me.Pick_Circle_Button.TabIndex = 4
        Me.Pick_Circle_Button.Text = "Circle"
        Me.Pick_Circle_Button.UseVisualStyleBackColor = True
        '
        'Welcome_Label
        '
        Me.Welcome_Label.Location = New System.Drawing.Point(2, 9)
        Me.Welcome_Label.Name = "Welcome_Label"
        Me.Welcome_Label.Size = New System.Drawing.Size(277, 18)
        Me.Welcome_Label.TabIndex = 5
        Me.Welcome_Label.Text = "Welome <Name Here>"
        Me.Welcome_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Open_About_Button
        '
        Me.Open_About_Button.Location = New System.Drawing.Point(201, 209)
        Me.Open_About_Button.Name = "Open_About_Button"
        Me.Open_About_Button.Size = New System.Drawing.Size(69, 32)
        Me.Open_About_Button.TabIndex = 6
        Me.Open_About_Button.Text = "About"
        Me.Open_About_Button.UseVisualStyleBackColor = True
        '
        'Pick_Shape_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.Open_About_Button)
        Me.Controls.Add(Me.Welcome_Label)
        Me.Controls.Add(Me.Pick_Circle_Button)
        Me.Controls.Add(Me.Pick_Rectangle_Button)
        Me.Controls.Add(Me.Pick_Triangle_Button)
        Me.Name = "Pick_Shape_Form"
        Me.Text = "Pick Shape"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pick_Triangle_Button As Button
    Friend WithEvents Pick_Rectangle_Button As Button
    Friend WithEvents Pick_Circle_Button As Button
    Friend WithEvents Welcome_Label As Label
    Friend WithEvents Open_About_Button As Button
End Class
