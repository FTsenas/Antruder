Module Launcher

    Public Sub Main()
        Try
            Application.EnableVisualStyles()
            Application.Run(New Starter)
        Catch ex As Exception
            MsgBox("An error occurred, restart the program.(Error Code: 0x0")
            Application.Exit()

        End Try

    End Sub

End Module
