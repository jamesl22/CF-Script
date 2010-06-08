Option Strict Off
Option Explicit On
Imports System.IO
Friend Class code_editor
	Inherits System.Windows.Forms.Form
    Private Declare Function BeepAPI Lib "kernel32" Alias "Beep" (ByVal dwFrequency As Integer, ByVal dwMilliseconds As Integer) As Integer
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Dim filelocation As String
    Dim runtmform As Form = Form2
    Public userclose As Integer
    Public playsound As String
    Public getinputst As String
    Dim codeedited As String
    Dim downloaddest As String
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        open()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        saveas()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If filelocation = "" Then
            saveas()
        Else
            If System.IO.File.Exists(filelocation) = True Then
                ' append saves over file if it assists
                FileOpen(1, filelocation, OpenMode.Output)
                PrintLine(1, code.Text)
                FileClose(1)
                Me.Text = "CF Script" + " - " + filelocation
            Else
                ' append saves over file if it assists
                FileOpen(1, filelocation, OpenMode.Append)
                PrintLine(1, code.Text)
                FileClose(1)
                Me.Text = "CF Script" + " - " + filelocation
            End If
        End If
    End Sub

    Private Sub saveas()
        ' loads save as box
        'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        cdlgOpen.Filter = "Code Forge Source Files (*.cf) | *.cf"
        cdlgSave.Filter = "Code Forge Source Files (*.cf) | *.cf"
        cdlgOpen.InitialDirectory = "c:\"
        cdlgSave.InitialDirectory = "c:\"
        cdlgSave.ShowDialog()
        cdlgOpen.FileName = cdlgSave.FileName

        filelocation = cdlgOpen.FileName
        If filelocation = "" Then

        Else
            If System.IO.File.Exists(filelocation) = True Then
                ' append saves over file if it assists
                FileOpen(1, filelocation, OpenMode.Output)
                PrintLine(1, code.Text)
                FileClose(1)
                Me.Text = "CF Script" + " - " + filelocation
            Else
                ' append saves over file if it assists
                FileOpen(1, filelocation, OpenMode.Append)
                PrintLine(1, code.Text)
                FileClose(1)
                Me.Text = "CF Script" + " - " + filelocation
            End If
        End If
    End Sub

    Private Sub open()
        Dim Data As String

        ' show open box
        'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        cdlgOpen.Filter = "Code Forge Source Files (*.cf) | *.cf"
        cdlgSave.Filter = "Code Forge Source Files (*.cf) | *.cf"
        cdlgOpen.InitialDirectory = "c:\"
        cdlgSave.InitialDirectory = "c:\"
        cdlgOpen.ShowDialog()
        cdlgSave.FileName = cdlgOpen.FileName

        filelocation = cdlgOpen.FileName
        If filelocation = "" Then

        Else
            ' input files into code.text
            FileOpen(1, filelocation, OpenMode.Input)
            code.Text = ""
            Do Until EOF(1)

                Input(1, Data)
                'UPGRADE_WARNING: Couldn't resolve default property of object Data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                code.Text = code.Text + Data + vbNewLine
                EOF(1)
            Loop
            FileClose(1)
        End If
        Me.Text = "CF Script" + " - " + filelocation
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripMenuItem.Click
        run()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles code.TextChanged
        ToolStripStatus.Text = "Editing Code"
        codeedited = True
    End Sub

    Private Sub code_editor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim ans As String
        If codeedited = True Then
            ans = MessageBox.Show("Would you like to save changes?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ans = Windows.Forms.DialogResult.Yes Then
                saveas()
                Me.code.Text = ""
                filelocation = ""
                Me.Text = "CF Script"
                codeedited = False
            End If
            If ans = Windows.Forms.DialogResult.No Then
                Me.code.Text = ""
                filelocation = ""
                Me.Text = "CF Script"
                codeedited = False
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub code_editor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape = True Then
            If playsound = True Then

            End If
        End If

        If e.KeyCode = Keys.F5 = True Then
            run()
        End If

        If e.KeyCode = Keys.F1 = True Then
            helpform.Show()
        End If
    End Sub

    Private Sub code_editor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = 350
        ProgressBar1.Minimum = 0
        ProgressBar1.Step = 20
    End Sub


 
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Enabled = False
            Exit Sub
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        helpform.Show()
    End Sub

    Public Sub PlayWav(ByVal filename As String)
     

        Dim Sound As New System.Media.SoundPlayer()

        Sound.SoundLocation = filename
        Sound.Load()
        Sound.Play()

    End Sub

    Public Sub run()
        Dim Data As Object
        Dim codetp As String = interpreter.code.Text

        cfconsole.consoletext.Text = ""
        ToolStripStatus.Text = "Running Program"
        If filelocation = "" Then
            MsgBox("You must save your source code before you can run it!")
        Else
            ' input files into code.text
            FileOpen(1, filelocation, OpenMode.Input)
            interpreter.Show()

            Do Until EOF(1)
                Timer1_Tick(Me, Nothing)
                Data = LineInput(1)
                'UPGRADE_WARNING: Couldn't resolve default property of object Data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                interpreter.code.Text = Data
                If interpreter.code.Text.StartsWith("beep") Then
                    Beep()

                ElseIf interpreter.code.Text.StartsWith("print") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "print(""", "")
                    interpreter.code.Text = Replace(interpreter.code.Text, """)", "")
                    MsgBox(interpreter.code.Text)

                ElseIf interpreter.code.Text.StartsWith("form::show") Then
                    runtmform.Show()

                ElseIf interpreter.code.Text.StartsWith("textbox::show") Then
                    Form2.runtmformtext.Visible = True

                ElseIf interpreter.code.Text.StartsWith("wait") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "wait(""", "")
                    interpreter.code.Text = Replace(interpreter.code.Text, """)", "")
                    Sleep(interpreter.code.Text)

                ElseIf interpreter.code.Text.StartsWith("form::close") Then
                    runtmform.Hide()

                ElseIf interpreter.code.Text.StartsWith("button::show") Then
                    Form2.runtmbutton.Visible = True

                ElseIf interpreter.code.Text.StartsWith("button::text") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "button::text(""", "")
                    interpreter.code.Text = Replace(interpreter.code.Text, """)", "")
                    Form2.runtmbutton.Text = interpreter.code.Text

                ElseIf interpreter.code.Text.StartsWith("//") Then

                ElseIf interpreter.code.Text.StartsWith("textbox::text") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "textbox::text(""", "")
                    interpreter.code.Text = Replace(interpreter.code.Text, """)", "")
                    Form2.runtmformtext.Text = interpreter.code.Text

                ElseIf interpreter.code.Text.StartsWith("form::colour") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "form::colour(""", "")
                    interpreter.code.Text = Replace(interpreter.code.Text, """)", "")
                    Form2.BackColor = System.Drawing.Color.FromName(interpreter.code.Text)

                ElseIf interpreter.code.Text.StartsWith("form::title") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "form::title(""", "")
                    interpreter.code.Text = Replace(interpreter.code.Text, """)", "")
                    Form2.Text = interpreter.code.Text

                ElseIf interpreter.code.Text.StartsWith("button::colour") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "button::colour(""", "")
                    interpreter.code.Text = Replace(interpreter.code.Text, """)", "")
                    Form2.runtmbutton.BackColor = System.Drawing.Color.FromName(interpreter.code.Text)

                ElseIf interpreter.code.Text.StartsWith("caption::text") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "caption::text(""", "")
                    interpreter.code.Text = Replace(interpreter.code.Text, """)", "")
                    Form2.runtmlabel.Text = interpreter.code.Text

                ElseIf interpreter.code.Text.StartsWith("caption::show") Then
                    Form2.runtmlabel.Visible = True

                ElseIf interpreter.code.Text.StartsWith("caption::position") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "caption::position(""", "")
                    interpreter.code.Text = Replace(interpreter.code.Text, """)", "")

                ElseIf interpreter.code.Text.StartsWith("console::print") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "console::print(""", "")
                    interpreter.code.Text = Replace(interpreter.code.Text, """)", "")
                    cfconsole.WriteLine(interpreter.code.Text)

                ElseIf interpreter.code.Text.StartsWith("console::show") Then
                    cfconsole.Show()

                ElseIf interpreter.code.Text.StartsWith("console::close") Then
                    cfconsole.Hide()

                ElseIf interpreter.code.Text.StartsWith("console::userclose") Then
                    cfconsole.WriteLine("Press Enter to close window!")
                    userclose = 1

                ElseIf interpreter.code.Text.StartsWith("console::input::enter") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "console::input::enter ", "")
                    cfconsole.WriteLine("Press enter to move on")
                    getinputst = True
                    cfconsole.getinput()
                    If interpreter.code.Text.StartsWith("and") Then
                        interpreter.code.Text = Replace(interpreter.code.Text, "and ", "")
                        If interpreter.code.Text.StartsWith("playsound") Then
                            interpreter.code.Text = Replace(interpreter.code.Text, "playsound(""", "")
                            interpreter.code.Text = Replace(interpreter.code.Text, """)", "")
                            If System.IO.File.Exists(interpreter.code.Text) = True Then
                                playsound = True
                                PlayWav(interpreter.code.Text)
                            Else
                                MsgBox("Cannot play sound! " + interpreter.code.Text + " not found. Stopping!")
                                FileClose(1)
                                ProgressBar1.Value = ProgressBar1.Maximum
                                Timer1.Enabled = False
                                interpreter.Hide()
                                ToolStripStatus.Text = "Idle"
                                ProgressBar1.Value = ProgressBar1.Minimum
                                Exit Sub
                            End If
                        End If
                    End If
                ElseIf interpreter.code.Text.StartsWith("playsound") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "playsound(""", "")
                    interpreter.code.Text = Replace(interpreter.code.Text, """)", "")
                    If System.IO.File.Exists(interpreter.code.Text) = True Then
                        playsound = True
                        PlayWav(interpreter.code.Text)
                    Else
                        MsgBox("Cannot play sound! " + interpreter.code.Text + " not found. Stopping!")
                        FileClose(1)
                        ProgressBar1.Value = ProgressBar1.Maximum
                        Timer1.Enabled = False
                        interpreter.Hide()
                        ToolStripStatus.Text = "Idle"
                        ProgressBar1.Value = ProgressBar1.Minimum
                        Exit Sub
                    End If

                ElseIf interpreter.code.Text.StartsWith("download::dest") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "download::dest(""", "")
                    interpreter.code.Text = Replace(interpreter.code.Text, """)", "")
                    downloaddest = interpreter.code.Text

                ElseIf interpreter.code.Text.StartsWith("download::file") Then
                    interpreter.code.Text = Replace(interpreter.code.Text, "download::file(""", "")
                    interpreter.code.Text = Replace(interpreter.code.Text, """)", "")
                    My.Computer.Network.DownloadFile(interpreter.code.Text, downloaddest)

                End If
                EOF(1)
            Loop
            FileClose(1)
            ProgressBar1.Value = ProgressBar1.Maximum
            Timer1.Enabled = False
            interpreter.Hide()
            ToolStripStatus.Text = "Idle"
            ProgressBar1.Value = ProgressBar1.Minimum
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub
End Class
