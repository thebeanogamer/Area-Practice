<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Temp_Login_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Temp_Login_Button
        '
        Me.Temp_Login_Button.Location = New System.Drawing.Point(73, 79)
        Me.Temp_Login_Button.Name = "Temp_Login_Button"
        Me.Temp_Login_Button.Size = New System.Drawing.Size(132, 82)
        Me.Temp_Login_Button.TabIndex = 0
        Me.Temp_Login_Button.Text = "Login"
        Me.Temp_Login_Button.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.Temp_Login_Button)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Temp_Login_Button As Button
End Class
