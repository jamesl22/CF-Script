<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cfconsole
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cfconsole))
        Me.consoletext = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'consoletext
        '
        Me.consoletext.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.consoletext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.consoletext.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consoletext.ForeColor = System.Drawing.SystemColors.Info
        Me.consoletext.Location = New System.Drawing.Point(0, 0)
        Me.consoletext.Multiline = True
        Me.consoletext.Name = "consoletext"
        Me.consoletext.ReadOnly = True
        Me.consoletext.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.consoletext.Size = New System.Drawing.Size(600, 325)
        Me.consoletext.TabIndex = 1
        '
        'cfconsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 325)
        Me.Controls.Add(Me.consoletext)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cfconsole"
        Me.Text = "Console - CF Script"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents consoletext As System.Windows.Forms.TextBox
End Class
