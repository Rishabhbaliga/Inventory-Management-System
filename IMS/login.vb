Imports System.Data.SqlClient

Public Class login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
    End Sub

    'verify and login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name = UName.Text
        Dim password = pword.Text

        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        Try
            cmd.Connection = Con
            cmd.Connection = Con
            cmd.CommandText = "select uname, pword from login where uname='" & name & "' and pword='" & password & "'"
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                MsgBox("Login Successful")
                Form1.Show()
                Me.Close()
            Else
                MsgBox("Wrong User name and password")
                UName.Clear()
                pword.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'reset textfields
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UName.Clear()
        pword.Clear()
    End Sub

    'toggle password visibility
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If pword.UseSystemPasswordChar = True Then
            pword.UseSystemPasswordChar = False
            LinkLabel1.Text = "Hide Password"
        Else
            pword.UseSystemPasswordChar = True
            LinkLabel1.Text = "Show Password"
        End If
    End Sub

    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        Sign_up.Show()
        Me.Close()
    End Sub

End Class