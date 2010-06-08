<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.runtmformtext = New System.Windows.Forms.TextBox
        Me.runtmbutton = New System.Windows.Forms.Button
        Me.runtmclose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.runtmlabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'runtmformtext
        '
        Me.runtmformtext.Location = New System.Drawing.Point(12, 12)
        Me.runtmformtext.Name = "runtmformtext"
        Me.runtmformtext.Size = New System.Drawing.Size(100, 20)
        Me.runtmformtext.TabIndex = 0
        '
        'runtmbutton
        '
        Me.runtmbutton.Location = New System.Drawing.Point(118, 9)
        Me.runtmbutton.Name = "runtmbutton"
        Me.runtmbutton.Size = New System.Drawing.Size(75, 23)
        Me.runtmbutton.TabIndex = 1
        Me.runtmbutton.Text = "Button1"
        Me.runtmbutton.UseVisualStyleBackColor = True
        '
        'runtmclose
        '
        Me.runtmclose.Location = New System.Drawing.Point(249, 247)
        Me.runtmclose.Name = "runtmclose"
        Me.runtmclose.Size = New System.Drawing.Size(43, 25)
        Me.runtmclose.TabIndex = 2
        Me.runtmclose.Text = "Close"
        Me.runtmclose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'runtmlabel
        '
        Me.runtmlabel.AutoSize = True
        Me.runtmlabel.Location = New System.Drawing.Point(19, 84)
        Me.runtmlabel.Name = "runtmlabel"
        Me.runtmlabel.Size = New System.Drawing.Size(39, 13)
        Me.runtmlabel.TabIndex = 4
        Me.runtmlabel.Text = "Label2"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.runtmlabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.runtmclose)
        Me.Controls.Add(Me.runtmbutton)
        Me.Controls.Add(Me.runtmformtext)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents runtmformtext As System.Windows.Forms.TextBox
    Friend WithEvents runtmbutton As System.Windows.Forms.Button
    Friend WithEvents runtmclose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents runtmlabel As System.Windows.Forms.Label
End Class
