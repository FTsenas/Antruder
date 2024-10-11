Imports AntruderConfig

Public Class ManagementClass

    Dim classInst As New middleBoy

    Private Sub ChangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeToolStripMenuItem.Click
        Try
            If TextBox1.Text = classInst.passwordOperationsRetreive Then
                If TextBox2.Text = TextBox3.Text Then
                    classInst.passwordOperations(TextBox2.Text)
                    textBoxesCleanUp()
                    Dim msg As String = MessageBox.Show("Configuration Saved!", Application.ProductName, MessageBoxButtons.OK)
                    If msg = vbOK Then
                        Me.Hide()
                        Form1.Show()
                    End If

                Else
                    ToolTip1.Show("Passwords do not match!", TextBox2, 500)

                End If
            Else
                ToolTip1.Show("Incorrect Password!", TextBox1, 500)
            End If

        Catch ex As Exception
            MsgBox("An error occurred, restart the program.(Error Code: 0x024")
        End Try


    End Sub

    Private Sub textBoxesCleanUp()
        Try
            ToolTip1.Dispose()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox1.Focus()
        Catch ex As Exception
            MsgBox("An error occurred, restart the program.(Error Code: 0x023")
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            textBoxesCleanUp()
            Form1.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("An error occurred, restart the program.(Error Code: 0x022")
        End Try



    End Sub

    Private Sub ManagementClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.kjhasdf
        Me.Text = "Antruder Management"
    End Sub

    Private Sub DisableProtectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableProtectionToolStripMenuItem.Click
        Try
            If TextBox1.Text = classInst.passwordOperationsRetreive Then
                Dim starterInst As New Starter
                starterInst._regKey.SetValue("Start", 3)
                starterInst._icon.ShowBalloonTip(2000, Application.ProductName, "Protection disabled untill restart!", ToolTipIcon.Warning)
                starterInst._icon.Dispose()
                starterInst.Dispose()
                Application.Exit()
            Else
                If TextBox1.Text = Nothing Then
                    MsgBox("Provide current password first!")
                Else
                    MsgBox("Current password invalid!")
                End If

            End If
        Catch ex As Exception
            MsgBox("An error occurred, restart the program.(Error Code: 0x021")
        End Try

    End Sub
End Class