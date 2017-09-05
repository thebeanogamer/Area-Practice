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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Temp_Login_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Temp_Login_Button
        '
        Me.Temp_Login_Button.Location = New System.Drawing.Point(55, 64)
        Me.Temp_Login_Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Temp_Login_Button.Name = "Temp_Login_Button"
        Me.Temp_Login_Button.Size = New System.Drawing.Size(99, 67)
        Me.Temp_Login_Button.TabIndex = 0
        Me.Temp_Login_Button.Text = "Login"
        Me.Temp_Login_Button.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 206)
        Me.Controls.Add(Me.Temp_Login_Button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Temp_Login_Button As Button
End Class
