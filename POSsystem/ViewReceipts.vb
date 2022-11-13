Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class ViewReceipts

    Private database As New Database("PHEYTUN\SQLEXPRESS", "posDB")
    Private conn As SqlConnection
    Private receipt
    Private iRowIndex As Integer

    ' Sets our connection object
    ' And fill our table of all available receips recorded
    Private Sub view_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dataTable As DataTable
        conn = database.getConnection()

        dataTable = database.fillReceipts(conn)

        tblReceipts.DataSource = dataTable

        tblReceipts.Columns(0).HeaderCell.Value = "Receipt Number"
        tblReceipts.Columns(1).HeaderCell.Value = "Date Created"

    End Sub

    ' Code responsible when user clicks one of the rows
    Private Sub tblReceipts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblReceipts.CellClick


        If tblReceipts.SelectedRows.Count = 1 Then

            btnViewReceipt.Enabled = True

            For i As Integer = 0 To tblReceipts.SelectedCells.Count - 1
                iRowIndex = tblReceipts.SelectedCells.Item(i).RowIndex
            Next


        Else



            btnViewReceipt.Enabled = False

        End If
    End Sub

    ' Our search query for the receipt code/bar code number
    Private Sub txtReceiptCode_TextChanged(sender As Object, e As EventArgs) Handles txtReceiptCode.TextChanged


        Dim dataTable As DataTable
        Dim receiptCode As String = txtReceiptCode.Text

        conn = database.getConnection()

        dataTable = database.fillProducts(conn, receiptCode)

        tblReceipts.DataSource = dataTable

        btnViewReceipt.Enabled = False

    End Sub

    ' Our view receipt which pulls out the record on the excel sheet which has all the receipts recorded
    Private Sub btnViewReceipt_Click(sender As Object, e As EventArgs) Handles btnViewReceipt.Click

        Dim oexcel As Excel.Application
        Dim obook As Excel.Workbook
        Dim osheet As Excel.Worksheet
        Dim fnExc As String = "D:\RECEIPTS.xlsx"
        Dim indexCount As Integer
        Dim rowCount As Integer = 1
        Dim targetReceipt As String = "1001"
        Dim dataArray(99, 99) As String
        Dim receiptDate As String
        Dim receiptTax As String
        Dim receiptTotalPrice As String
        Dim receiptPayment As String
        Dim receiptChange As String
        Dim receiptPayType As String



        ' this should be used only once
        oexcel = CreateObject("Excel.Application")
        obook = oexcel.Workbooks.Open(fnExc)

        If oexcel.Application.Sheets.Count() < 1 Then
            osheet = CType(obook.Worksheets.Add(), Excel.Worksheet)

        Else
            osheet = oexcel.Worksheets(1)
        End If




        While Not osheet.Range("A" & rowCount).Value = targetReceipt

            rowCount += 1

        End While

        rowCount += 1

        While Not osheet.Range("B" & rowCount).Value = Nothing

            dataArray(indexCount, 0) = osheet.Range("D" & rowCount).Value
            dataArray(indexCount, 1) = osheet.Range("C" & rowCount).Value
            dataArray(indexCount, 2) = osheet.Range("E" & rowCount).Value
            dataArray(indexCount, 3) = osheet.Range("G" & rowCount).Value

            rowCount += 1
            indexCount += 1

        End While


        receiptTax = osheet.Range("F" & rowCount).Text
        receiptTotalPrice = osheet.Range("G" & rowCount).Text
        receiptPayment = osheet.Range("H" & rowCount).Text
        receiptChange = osheet.Range("I" & rowCount).Text
        receiptPayType = osheet.Range("J" & rowCount).Text
        receiptDate = tblReceipts.Rows(iRowIndex).Cells("receipt_created").Value

        Dim receipt As New Receipt(dataArray, indexCount, targetReceipt, receiptDate, receiptTax,
                                   receiptTotalPrice, receiptPayment, receiptPayType, receiptChange)

        receipt.print()

        oexcel.Quit()
        oexcel = Nothing

    End Sub
End Class