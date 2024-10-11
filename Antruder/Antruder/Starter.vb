Imports System.Management
Imports Microsoft.Win32

Public Class Starter
    Inherits ApplicationContext

    Public WithEvents _icon As NotifyIcon
    Private WithEvents _contextMenu As ContextMenuStrip
    Private WithEvents _lock As ToolStripMenuItem



    Public str As String = "SYSTEM\CurrentControlSet\Services\USBSTOR"
    Public _regKey As RegistryKey = Registry.LocalMachine.OpenSubKey(str, True)


    Public WithEvents _plugOut As Management.ManagementEventWatcher
    Public WithEvents _timer As New Timer
    Private count As Short = 0

    Public Sub New()
        Try
            _plugOut = New ManagementEventWatcher("Select * From Win32_DeviceChangeEvent Where EventType = 3")
            _plugOut.Start()
            _regKey.SetValue("Start", 4)

            _timer.Interval = 100
            _timer.Start()

            'THE BELOW CONDITION WAS DELETED FOR SECURITY PURPOSES


            '  If ********** Then
            '
            '   Else
            '     *****************





            _icon = New NotifyIcon
            _contextMenu = New ContextMenuStrip
            _lock = New ToolStripMenuItem("Lock")

            _contextMenu.Items.Add(_lock)

            'Notification Icon Initialization 
            _icon.ContextMenuStrip = _contextMenu
            _icon.Icon = My.Resources.kjhasdf
            _icon.Text = Application.ProductName & " " & Application.ProductVersion
            _icon.ContextMenuStrip = _contextMenu
            _icon.Visible = True

        Catch ex As Exception
            MsgBox("An error occurred, restart the program.(Error Code: 0x000)")
            Application.Exit()

        End Try


    End Sub



    Private Function defaultPassword()

        Dim encrypt As String = ""

        Try

            Dim letter As Char
            Dim i, charsInFile As Short
            Dim _default As String = "0000"
            Dim _defaultEnKey As String = Nothing 'CODE DELETED FOR SECURITY PURPOSES

            charsInFile = _default.Length

            'THE BELOW LOOP WAS DELETED FOR SECURITY PURPOSES

            'For ***** To charsInFile - *
            '*****
            '****
            '*****
            '  Next


        Catch ex As Exception
            MsgBox("An error occurred, restart the program.(Error Code: 0x001)")
        End Try

        Return encrypt
    End Function



    Private Sub _plugOut_EventArrived(sender As Object, e As EventArrivedEventArgs) Handles _plugOut.EventArrived

        count = 1

    End Sub

    Private Sub _timer_Tick(sender As Object, e As EventArgs) Handles _timer.Tick
        Try
            If count = 1 Then
                _timer.Stop()
                count = 0
                _icon.ShowBalloonTip(2000, Application.ProductName, "Your PC is not safe in this current state" & vbCrLf & "Please Lock your USB ports.", ToolTipIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox("An error occurred, restart the program.(Error Code: 0x002)")
        End Try


    End Sub

    Private Sub _lock_Click(sender As Object, e As EventArgs) Handles _lock.Click
        Try
            _regKey.SetValue("Start", 4)
            _icon.ShowBalloonTip(2000, Application.ProductName, "Your PC is now protected.", ToolTipIcon.Info)

        Catch ex As Exception
            MsgBox("An error occurred, restart the program.(Error Code: 0x003)")
        End Try

    End Sub

    Private Sub _icon_MouseClick(sender As Object, e As MouseEventArgs) Handles _icon.MouseClick
        Try
            If e.Button = MouseButtons.Left Then
                Form1.Show()
            End If
        Catch ex As Exception
            MsgBox("An error occurred, restart the program.(Error Code: 0x004)")
        End Try



    End Sub
End Class
