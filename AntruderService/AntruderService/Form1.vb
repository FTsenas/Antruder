Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.Icon = My.Resources.kjhasdf
            Process.Start(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\SoftTouch\Antruder\Antruder.exe")
            Application.Exit()
        Catch ex As Exception
            MsgBox("Access is denied, you need to press 'Yes' to authorize this app to run!" & vbCrLf & "If the problem persists after rerun (with permission), contact the manufacturer.")
            Application.Exit()


        End Try

    End Sub
End Class
