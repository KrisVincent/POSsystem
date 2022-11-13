Imports System.Data.SqlClient

Public Class Inventory

    Private database As New Database("PHEYTUN\SQLEXPRESS", "posDB")
    Private conn As SqlConnection
    Private iRowIndex As Integer

    Private Sub clearTxtBox()

        txtReadProductCode.Text = ""
        txtProductName.Text = ""
        txtProductPrice.Text = ""
        txtProductStock.Text = ""
        txtProductCode.Text = ""

    End Sub
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataTable As DataTable
        conn = Database.getConnection()

        dataTable = database.fillProducts(conn)

        tblProducts.DataSource = dataTable

        tblProducts.Columns(0).Visible = False
        tblProducts.Columns(1).HeaderCell.Value = "Product Price"
        tblProducts.Columns(2).HeaderCell.Value = "Product Name"
        tblProducts.Columns(3).HeaderCell.Value = "Product Stock"
        tblProducts.Columns(4).HeaderCell.Value = "Product Code"



    End Sub

    Private Sub txtProductCode_TextChanged(sender As Object, e As EventArgs) Handles txtProductCode.TextChanged

        Dim dataTable As DataTable
        Dim productCode As String = txtProductCode.Text

        conn = database.getConnection()

        dataTable = database.fillProducts(conn, productCode)

        tblProducts.DataSource = dataTable



    End Sub

    Private Sub tblProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblProducts.CellClick


        If tblProducts.SelectedRows.Count = 1 Then

            btnUpdateStocks.Enabled = True
            btnAddProduct.Enabled = False

            For i As Integer = 0 To tblProducts.SelectedCells.Count - 1
                iRowIndex = tblProducts.SelectedCells.Item(i).RowIndex
            Next

            txtReadProductCode.Text = tblProducts.Rows(iRowIndex).Cells("product_code").Value
            txtProductName.Text = tblProducts.Rows(iRowIndex).Cells("product_name").Value
            txtProductPrice.Text = tblProducts.Rows(iRowIndex).Cells("product_price").Value
            txtProductStock.Text = tblProducts.Rows(iRowIndex).Cells("product_stock").Value



        Else

            btnUpdateStocks.Enabled = False
            btnAddProduct.Enabled = True

        End If

    End Sub

    Private Sub btnDeselectRow_Click(sender As Object, e As EventArgs) Handles btnDeselectRow.Click

        tblProducts.ClearSelection()

        clearTxtBox()

    End Sub

    Private Sub btnUpdateStocks_Click(sender As Object, e As EventArgs) Handles btnUpdateStocks.Click

        conn = database.getConnection()

        database.updateProductDetails(conn, txtReadProductCode.Text, txtProductPrice.Text, txtProductName.Text, txtProductStock.Text)

        clearTxtBox()

    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click

        conn = database.getConnection()

        Dim receiptNumber = database.getReceiptNumber(conn) + 1

        conn.Open()

        database.addProduct(conn, txtProductPrice.Text, txtProductName.Text, txtProductStock.Text, receiptNumber)

        MsgBox("Product Added!")

        clearTxtBox()

    End Sub

    Private Sub btnRemoveProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveProduct.Click

        conn = database.getConnection()

        If tblProducts.SelectedRows.Count = 1 Then



            database.deleteProduct(conn, tblProducts.Rows(iRowIndex).Cells("product_code").Value)

            clearTxtBox()

        End If

    End Sub
End Class