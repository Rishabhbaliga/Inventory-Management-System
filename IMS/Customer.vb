Imports System.Data.SqlClient
Public Class Customer
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call showdata()
    End Sub
    Function showdata()
        Dim adpt As SqlDataAdapter
        Dim dt As New DataTable
        Try
            adpt = New SqlDataAdapter("select bar_code as Bar_Code, name as Name, Prod_name as Product_Name, bill_no as Bill_Number, GSTIN as GSTIN, phone as Phone_Number, paid as Amount_Paid from customer;", Con)
            adpt.Fill(dt)
            customer_data.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Function showdata2()
        Dim adpt As SqlDataAdapter
        Dim dt As New DataTable
        Try
            adpt = New SqlDataAdapter("select bar_code as Bar_Code, name as Name, Prod_name as Product_Name, bill_no as Bill_Number, GSTIN as GSTIN, phone as Phone_Number, paid as Amount_Paid from customer;", Con)
            adpt.Fill(dt)
            customer_g.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "insert into customer values(" & bar_code.Text & ",'" & Cname.Text & "','" & Prod_name.Text & "'," & bill_no.Text & ", " & GSTIN.Text & ", '" & phone.Text & "','" & Paid.Text & "');"
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Added")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cname.Clear()
        bill_no.Clear()
        Prod_name.Clear()
        phone.Clear()
        bar_code.Clear()
        GSTIN.Clear()
        Paid.ResetText()

    End Sub

    Private Sub button6_click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "update customer set paid ='" & Paid.Text & "' where bill_no = " & bill_no.Text & ";"
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("data updated")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "delete from customer where bill_no=" & bill_no.Text & ""
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Deleted")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        customerh.Visible = False
        customers.Visible = True
        Call showdata2()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        customerh.Visible = True
        'customers.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim adpt As SqlDataAdapter
        Dim dt As New DataTable
        Try
            adpt = New SqlDataAdapter("select bar_code as Bar_Code, name as Name, Prod_name as Product_Name, bill_no as Bill_Number, GSTIN as GSTIN, phone as Phone_Number, paid as Amount_Paid from customer where name LIKE '%" & Cname.Text & "%';", Con)
            adpt.Fill(dt)
            customer_data.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim adpt As SqlDataAdapter
        Dim dt As New DataTable
        Try
            adpt = New SqlDataAdapter("select bar_code as Bar_Code, name as Name, Prod_name as Product_Name, bill_no as Bill_Number, GSTIN as GSTIN, phone as Phone_Number, paid as Amount_Paid from customer where paid='No';", Con)
            adpt.Fill(dt)
            customer_data.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class