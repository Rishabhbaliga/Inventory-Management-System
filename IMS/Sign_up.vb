Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Sign_up
    Private Sub Sign_up_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        Dim regemail As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        Dim query As String
        Dim sqlcon As SqlCommand
        If PWord.Text.Equals(Pcheck.Text) Then
            If regemail.IsMatch(Email.Text) Then
                Try
                    query = "insert into login values('" & UName.Text & "','" & PWord.Text & "','" & Email.Text & "');"
                    sqlcon = New SqlCommand(query, Con)
                    sqlcon.ExecuteNonQuery()
                    MsgBox("Data Added")
                    login.Show()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                UName.Clear()
                PWord.Clear()
                Pcheck.Clear()
                Email.Clear()
            Else
                MsgBox("Enter a valid email")
                Email.Clear()
            End If
        Else
            MsgBox("Entered passwords do not match")
            PWord.Clear()
            Pcheck.Clear()
        End If
    End Sub

    'toggle password visibility
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If PWord.UseSystemPasswordChar = True Then
            PWord.UseSystemPasswordChar = False
            LinkLabel1.Text = "Hide Password"
        Else
            PWord.UseSystemPasswordChar = True
            LinkLabel1.Text = "Show Password"
        End If
    End Sub

    'reset textfields
    Private Sub Reset_Click_1(sender As Object, e As EventArgs) Handles Reset.Click
        UName.Clear()
        PWord.Clear()
        Pcheck.Clear()
        Email.Clear()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If Pcheck.UseSystemPasswordChar = True Then
            Pcheck.UseSystemPasswordChar = False
            LinkLabel2.Text = "Hide Password"
        Else
            Pcheck.UseSystemPasswordChar = True
            LinkLabel2.Text = "Show Password"
        End If
    End Sub

    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        login.Show()
        Me.Close()
    End Sub
End Class