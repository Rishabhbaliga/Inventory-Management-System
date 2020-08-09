Imports System.Data.SqlClient
Public Class Inventory
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
End Class