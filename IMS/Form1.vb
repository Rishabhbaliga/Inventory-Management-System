Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call showdata()
    End Sub

    Function showdata()
        Dim adpt As SqlDataAdapter
        Dim dt As New DataTable
        Try
            adpt = New SqlDataAdapter("select bar_code as Bar_Code, Prod_name as Poduct_Name, price as Price, quantity as Quantity, veg_non as Veg_NonVeg, expiry_date as Expiry_Date from stock;", Con)
            adpt.Fill(dt)
            imsdata.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "insert into stock values(" & Bar_code.Text & ",'" & Prod_name.Text & "'," & Price.Text & "," & Qty.Text & ",'" & veg_non.Text & "','" & Expdt.Text & "');"
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Added")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Bar_code.Clear()
        Prod_name.Clear()
        Price.Clear()
        veg_non.Clear()
        Qty.Clear()
        veg_non.Clear()
        Expdt.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "delete from stock where Prod_name='" & Prod_name.Text & "'"
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Deleted")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Bar_code.Clear()
        Prod_name.Clear()
        Price.Clear()
        veg_non.Clear()
        Qty.Clear()
        veg_non.Clear()
        Expdt.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "update stock set price=" & Price.Text & " where bar_code=" & Bar_code.Text & ""
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Updated")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Bar_code.Clear()
        Prod_name.Clear()
        Price.Clear()
        veg_non.Clear()
        Qty.Clear()
        veg_non.Clear()
        Expdt.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Inventory.Visible = False
        Stock_Table.Visible = True
        Call showdata2()
    End Sub
    Function showdata2()
        Dim adpt As SqlDataAdapter
        Dim dt As New DataTable
        Try
            adpt = New SqlDataAdapter("select bar_code as Bar_Code, Prod_name as Poduct_Name, price as Price, quantity as Quantity, veg_non as Veg_NonVeg, expiry_date as Expiry_Date from stock;", Con)
            adpt.Fill(dt)
            Stock_Table.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Inventory.Visible = True
        Stock_Table.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "update stock set quantity=" & Qty.Text & " where bar_code= " & Bar_code.Text & ""
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Updated")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Bar_code.Clear()
        Prod_name.Clear()
        Price.Clear()
        veg_non.Clear()
        Qty.Clear()
        veg_non.Clear()
        Expdt.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "update stock set expiry_date='" & Expdt.Text & "' where bar_code= " & Bar_code.Text & ""
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Updated")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Bar_code.Clear()
        Prod_name.Clear()
        Price.Clear()
        veg_non.Clear()
        Qty.Clear()
        veg_non.Clear()
        Expdt.Clear()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Inventorysearch.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Customer.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Payment.Show()
        Me.Close()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim adpt As SqlDataAdapter
        Dim dt As New DataTable
        Try
            adpt = New SqlDataAdapter("select bar_code as Bar_Code, Prod_name as Poduct_Name, price as Price, quantity as Quantity, veg_non as Veg_NonVeg, expiry_date as Expiry_Date from stock where Prod_name like '%" & Prod_name.Text & "%';", Con)
            adpt.Fill(dt)
            imsdata.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        FTP.Show()
        Me.Close()
    End Sub
End Class