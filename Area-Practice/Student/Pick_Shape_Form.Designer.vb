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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Welcome_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Triangle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(9, 121)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 39)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Rectangle"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(9, 196)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 39)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Circle"
        Me.Button5.UseVisualStyleBackColor = True
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
        'Pick_Shape_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.Welcome_Label)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Pick_Shape_Form"
        Me.Text = "Pick Shape"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Welcome_Label As Label
End Class
