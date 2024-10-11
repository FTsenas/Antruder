Imports AntruderConfig
Imports Microsoft.Win32
Imports System.IO

Public Class Form1

    Private frmClassInst As New middleBoy
    Private count As Short = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.kjhasdf

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Try
            If e.KeyCode = Keys.Return Then
                If frmClassInst.passwordOperationsRetreive = TextBox1.Text Then
                    Dim starterInst As New Starter
                    starterInst._regKey.SetValue("Start", 3)
                    starterInst._icon.ShowBalloonTip(2000, Application.ProductName, "Port Unlocked" & vbCrLf & "Please reinsert your removable media.", ToolTipIcon.Info)
                    TextBox1.Clear()
                    starterInst._icon.Dispose()
                    starterInst.Dispose()
                    Me.Close()


                Else
                    ToolTip1.Show("Wrong Password!", TextBox1, 300)

                End If

            End If
        Catch ex As Exception
            MsgBox("An error occurred, restart the program.(Error Code: 0x011")
        End Try


    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Antruder.Show()

    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click


        Try
            Process.Start("C:\Program Files\Internet Explorer\iexplore.exe", "www.SoftTouch.com")
        Catch ex As Exception
            MsgBox("Could not load the browser correctly!")
        End Try

    End Sub


    Private Sub PasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasswordToolStripMenuItem.Click
        ManagementClass.Show()
        Me.Hide()
    End Sub

    Private Sub LockPortsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockPortsToolStripMenuItem.Click
        Try
            Dim starterInst As New Starter
            starterInst._regKey.SetValue("Start", 4)
            starterInst._icon.ShowBalloonTip(2000, Application.ProductName, "Your PC is now protected.", ToolTipIcon.Info)
            starterInst._icon.Dispose()
            starterInst.Dispose()
            Me.Close()
        Catch ex As Exception
            MsgBox("An error occurred, restart the program.(Error Code: 0x012")
        End Try



    End Sub

End Class
