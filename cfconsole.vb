Public Class cfconsole

    Private Sub cfconsole_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Me.consoletext.ReadOnly = False Then
            If e.KeyCode = Keys.Enter Then

            End If
        End If



        If code_editor.userclose = 1 Then
            If e.KeyCode = Keys.Enter Then
                Me.Hide()
                code_editor.userclose = 0
            End If
        End If
    End Sub

    Public Sub getinput()
        While code_editor.getinputst = False
            Exit Sub
        End While
    End Sub
    Private Sub cfconsole_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

    End Sub
    Public Sub WriteLine(ByVal text As String)
        consoletext.Text = consoletext.Text + text + vbCrLf
        Exit Sub
    End Sub


    Private Sub consoletext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles consoletext.TextChanged

    End Sub
End Class