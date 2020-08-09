Imports System.Data.SqlClient
Module inventry
    Public Con As SqlConnection
    Public Function Connect()
        Try
            Con = New SqlConnection("Data Source=SQL5041.site4now.net;Initial Catalog=DB_A62F3C_rishabh9954;User Id=DB_A62F3C_rishabh9954_admin;Password=H9e9rambh5#;")
            Con.Open()
            'MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
End Module
