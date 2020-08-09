Imports System.Data.SqlClient
Public Class Inventorysearch
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call showdata()
    End Sub
    Function showdata()
        Dim adpt As SqlDataAdapter
        Dim dt As New DataTable
        Try
            adpt = New SqlDataAdapter("select bar_code as Bar_Code, Prod_name as Product_Name, shelf_no as Shelf_Number, rack_no as Rack_Number from inventory;", Con)
            adpt.Fill(dt)
            sinvtry.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Function showdata2()
        Dim adpt As SqlDataAdapter
        Dim dt As New DataTable
        Try
            adpt = New SqlDataAdapter("select bar_code as Bar_Code, Prod_name as Product_Name, shelf_no as Shelf_Number, rack_no as Rack_Number from inventory;", Con)
            adpt.Fill(dt)
            invtry.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "insert into inventory values(" & bar_code.Text & ",'" & prod_name.Text & "'," & shelf_no.Text & "," & rack_no.Text & ");"
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Added")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "update inventory set rack_no =" & rack_no.Text & " , shelf_no = " & shelf_no.Text & " where bar_code = " & bar_code.Text & ";"
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Updated")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String
        Dim sqlcon As SqlCommand
        Try
            query = "delete from inventory where Prod_name='" & prod_name.Text & "'"
            sqlcon = New SqlCommand(query, Con)
            sqlcon.ExecuteNonQuery()
            MsgBox("Data Deleted")
            Call showdata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        inventoryh.Visible = False
        inventorys.Visible = True
        Call showdata2()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        inventoryh.Visible = True
        inventorys.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim adpt As SqlDataAdapter
        Dim dt As New DataTable
        Try
            'MsgBox("Data Found")
            adpt = New SqlDataAdapter("select bar_code as Bar_Code, Prod_name as Poduct_Name, shelf_no as Shelf_Number, rack_no as Rack_Number from inventory where Prod_name like '%" & prod_name.Text & "%';", Con)
            adpt.Fill(dt)
            sinvtry.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        prod_name.Clear()
        bar_code.Clear()
        rack_no.Clear()
        shelf_no.Clear()
    End Sub
End Class