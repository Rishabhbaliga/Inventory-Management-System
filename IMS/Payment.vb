Imports System.Data.SqlClient
Public Class Payment
    'initiate the link to the db
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call showdata()
    End Sub

    'showdata function declaration
    Function showdata()
        Dim adpt As SqlDataAdapter
        Dim dt As New DataTable
        Try
            adpt = New SqlDataAdapter("select bill_no as Bill_number, amount as Amount, payment_date as Payment, general as Payment_Mode, online as Online_Mode, offline as Offline_Mode, pending as Pending_Amount from payment;", Con)
            adpt.Fill(dt)
            spayment.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
    Function showdata2()
        Dim adpt As SqlDataAdapter
        Dim dt As New DataTable
        Try
            adpt = New SqlDataAdapter("select bill_no as Bill_number, amount as Amount, payment_date as Payment, general as Payment_Mode, online as Online_Mode, offline as Offline_Mode, pending as Pending_Amount from payment;", Con)
            adpt.Fill(dt)
            hpayment.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    'enable and disable as needed
    Private Sub Cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.Click
        Dim mode = cb1.Text
        'MsgBox(mode)
        If (mode.Equals("Online")) Then
            online.Enabled = True
            offline.Enabled = False
        ElseIf (mode.Equals("Offline")) Then
            online.Enabled = False
            offline.Enabled = True
        End If
    End Sub

    'add button
    Private Sub Add_e_Click(sender As Object, e As EventArgs) Handles add_e.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "insert into payment values(" & bill_no.Text & "," & amount.Text & ",'" & payment_date.Text & "','" & cb1.Text & "','" & online.Text & "','" & offline.Text & "','" & pending.Text & "');"
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Added")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bill_no.Clear()
        amount.Clear()
        payment_date.Clear()
        cb1.ResetText()
        online.ResetText()
        offline.ResetText()
        Call showdata()
    End Sub

    'back button in gb2
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        paymentsh.Visible = False
        paymentss.Visible = True
    End Sub

    'show all button
    Private Sub Show_all_Click(sender As Object, e As EventArgs) Handles Show_all.Click
        paymentss.Visible = False
        paymentsh.Visible = True
        Call showdata2()
    End Sub

    'Home button
    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Form1.Show()
        Me.Close()
    End Sub

    'delete button
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "delete from payment where bill_no=" & bill_no.Text & ""
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Deleted")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'update payment date
    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "update payment set payment_date='" & payment_date.Text & "'where bill_no=" & bill_no.Text & ""
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Updated")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'update balance amount
    Private Sub Update_amt_Click(sender As Object, e As EventArgs) Handles Update_amt.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "Update payment set pending='" & pending.Text & "'where bill_no=" & bill_no.Text & ""
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Updated")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'search box
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim adpt As SqlDataAdapter
        Dim dt As New DataTable
        Try
            adpt = New SqlDataAdapter("select bill_no as Bill_number, amount as Amount, payment_date as Payment, general as Payment_Mode, online as Online_Mode, offline as Offline_Mode, pending as Pending_Amount from payment where bill_no LIKE '%" & bill_no.Text & "%'", Con)
            adpt.Fill(dt)
            spayment.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class