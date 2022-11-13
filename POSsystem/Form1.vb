' POS and Inventory System
' Author by Pheytun
' Possible upgrade is implementing staff management

Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient


Public Class Form1

    Private database As New Database("PHEYTUN\SQLEXPRESS", "posDB")
    Private conn As SqlConnection
    Private blnProductCodeSelected As Boolean = False
    Private currentProductId As Integer
    Private Const TAX As Integer = 2
    Private receipt

    ' Get subtotal of all products
    Private Function getSubTotal() As Integer



        Dim subTotal As Integer

        For i As Integer = 0 To tblData.Rows.Count() - 1

            subTotal = subTotal + (tblData.Rows(i).Cells("Total Price").Value)

        Next

        Return subTotal

    End Function

    ' This Function checks if stocks are low or empty
    Private Function checkStocks() As Boolean

        Dim reader As SqlDataReader
        Dim stocks As Integer
        Dim currentStocks As Integer = 0
        Dim productId As Integer

        conn = database.getConnection()

        reader = database.getProductInformation(conn, txtProductCode.Text)
        stocks = reader.GetValue("product_stock")
        productId = reader.GetValue("product_id")

        For i As Integer = 0 To tblData.Rows.Count() - 1

            If productId = tblData.Rows(i).Cells("ID").Value Then

                currentStocks = tblData.Rows(i).Cells("Qty").Value

            End If

        Next

        If stocks = 0 Then

            MsgBox("No more stocks!")

            Exit Function

        End If

        If numTotalProductQty.Value + currentStocks > stocks Then


            numTotalProductQty.Value = stocks - currentStocks

            MsgBox("Current Product Stock Cannot Exceed \n Stocks Left: " & stocks - currentStocks & " In List: " & currentStocks)

            Return False

            Exit Function

        End If

        Return True

    End Function


    ' Calculates Payment
    Private Sub calculatePayment()

        Dim payment As Double
        Dim total As Double

        ' Calculates the change of the products
        ' And a few checks to avoid crashing 


        If tblData.Rows.Count() = 0 Then

            MsgBox("No Items Yet.")

            Exit Sub

        End If


        If IsNumeric(txtPayment.Text) = False Then

            MsgBox("Please Input Numerics Only.")

            txtPayment.Text = ""

            Exit Sub
        End If

        payment = txtPayment.Text
        total = txtTotal.Text


        If total > payment Then

            MsgBox("Not Enough Money!")

            Exit Sub

        End If

        txtChange.Text = "$ " & Math.Round(payment - total, 2)

        ' Enables the button that gives the receipt 

        btnNext.Enabled = True

    End Sub


    ' Essentially reset every input on how it were when the program opened
    Private Sub reset(isFullReset As Boolean)

        ' Clear Textboxes and Disable Button

        lblProductPriceValue.Text = ""
        lblProductNameValue.Text = ""

        txtProductCode.Text = ""

        btnAdd.Enabled = False
        numTotalProductQty.ReadOnly = True
        btnNext.Enabled = False

        ' Reset Everything When Receipt is recieved
        If isFullReset Then

            txtSubTotal.Text = ""
            txtTax.Text = ""
            txtTotal.Text = ""
            txtPayment.Text = ""
            txtChange.Text = ""

            btnNext.Enabled = False


        End If


    End Sub

    ' enables certaim button and text box
    Private Sub enable()

        ' Enables textbox and button

        numTotalProductQty.ReadOnly = False
        btnAdd.Enabled = True

        'btnCash.Enabled = False
        'btnDebit.Enabled = False
        'btnCredCard.Enabled = False
        'btnPrintReceipt.Enabled = False
        'btnPayment.Enabled = False
        '-btnNext.Enabled = False
    End Sub


    ' Calculates the tax value
    Private Sub calculateTax(subTotal As Integer)

        Dim tax_total As Double

        tax_total = subTotal * (TAX / 100)

        txtTax.Text = "$ " & Math.Round(tax_total, 2)
        txtTotal.Text = "$ " & subTotal + tax_total


    End Sub

    ' This checks if inputted product code exists
    Private Sub searchCode()

        Dim productCode = txtProductCode.Text()
        Dim reader As SqlDataReader

        If IsNumeric(productCode) = False Then

            MsgBox("Please Input Numerics Only")
            txtProductCode.Text = ""
            Exit Sub

        End If


        Try

            conn = database.getConnection()

            reader = database.getProductInformation(conn, productCode)

            currentProductId = reader.GetValue("product_id")
            lblProductNameValue.Text = reader.GetValue("product_name")
            lblProductPriceValue.Text = reader.GetValue("product_price")
            numTotalProductQty.Value = 1

            enable()

            conn.Close()


        Catch ex As Exception

            MsgBox("Product Code Does Not Exist or Input Cannot Be Empty")

        End Try

    End Sub

    ' This adds the product selected and its quantity which to be bought
    Private Sub addToGrid()

        Dim isExist As Boolean = False
        Dim row As String() = New String() {currentProductId,
                                            "$ " & lblProductPriceValue.Text,
                                            lblProductNameValue.Text,
                                            numTotalProductQty.Value,
                                            "$ " & (numTotalProductQty.Value * lblProductPriceValue.Text).ToString,
                                            txtProductCode.Text
                                            }

        ' Iterates and Checks if Product already exists
        ' If exists then add both quantity and total them

        If checkStocks() = False Or numTotalProductQty.Value = 0 Then



            Exit Sub

        End If


        For i As Integer = 0 To tblData.Rows.Count() - 1

            If currentProductId = tblData.Rows(i).Cells("ID").Value Then

                tblData.Rows(i).Cells("Qty").Value = tblData.Rows(i).Cells("Qty").Value + numTotalProductQty.Value
                tblData.Rows(i).Cells("Total Price").Value = "$ " & tblData.Rows(i).Cells("Qty").Value * tblData.Rows(i).Cells("Price").Value

                isExist = True

            End If

        Next

        If Not isExist Then

            tblData.Rows.Add(row)

        End If



        txtSubTotal.Text = "$ " & getSubTotal()

        calculateTax(getSubTotal())

        reset(False)

    End Sub

    ' This updates stocks to the database
    Private Sub updateStocks()

        conn = database.getConnection()
        Dim quantity As Integer
        Dim id As String

        For i As Integer = 0 To tblData.Rows.Count() - 1


            quantity = tblData.Rows(i).Cells("Qty").Value
            id = tblData.Rows(i).Cells("ID").Value

            database.updateProductStocks(conn, id, quantity)

        Next

    End Sub

    ' Essentially saves all the product bought to our excel
    ' Prints the receipt of the products bought
    Private Sub saveReciept()

        Dim oexcel As Excel.Application
        Dim obook As Excel.Workbook
        Dim osheet As Excel.Worksheet
        Dim fnExc As String = "D:\RECEIPTS.xlsx"
        Dim rowCount As Integer = 2
        Dim cellCount As Integer
        Dim receiptNumber As Integer
        Dim dataArray(99, 99) As String
        Dim indexCount As Integer
        Dim receiptDate As String
        Dim receiptTax As String
        Dim receiptTotalPrice As String
        Dim receiptPayment As String
        Dim receiptChange As String
        Dim receiptPayType As String

        conn = database.getConnection()


        ' this should be used only once
        oexcel = CreateObject("Excel.Application")
        obook = oexcel.Workbooks.Open(fnExc)

        If oexcel.Application.Sheets.Count() < 1 Then
            osheet = CType(obook.Worksheets.Add(), Excel.Worksheet)

        Else
            osheet = oexcel.Worksheets(1)
        End If

        ' osheet.Name = "Sheet112312312"
        ' osheet.Range("A1").Value = "Row2"
        ' osheet.Range("A1", "A1").Insert(Shift:=Excel.XlDirection.xlToRight)
        ' osheet.Range("A1").Value = "Header"

        While True

            cellCount = 0

            For Each OneCell In osheet.Range("A" & rowCount & ":F" & rowCount).Value

                If OneCell = Nothing Then

                    cellCount += 1

                End If

                If IsNumeric(osheet.Range("A" & rowCount).Value) Then

                    receiptNumber = osheet.Range("A" & rowCount).Value

                End If

            Next OneCell

            If cellCount = 6 Then

                Exit While

            End If


            cellCount = 0

            rowCount += 1

        End While

        If receiptNumber = 0 Then

            receiptNumber = 1000

        End If

        receiptNumber += 1

        osheet.Range("A" & rowCount).Value = receiptNumber

        rowCount += 1

        For i As Integer = 0 To tblData.Rows.Count() - 1


            osheet.Range("B" & rowCount).Value = tblData.Rows(i).Cells("Product Code").Value
            osheet.Range("C" & rowCount).Value = tblData.Rows(i).Cells("Name").Value
            osheet.Range("D" & rowCount).Value = tblData.Rows(i).Cells("Qty").Value
            osheet.Range("E" & rowCount).Value = tblData.Rows(i).Cells("Price").Value
            osheet.Range("G" & rowCount).Value = tblData.Rows(i).Cells("Total Price").Value

            dataArray(indexCount, 0) = osheet.Range("D" & rowCount).Value
            dataArray(indexCount, 1) = osheet.Range("C" & rowCount).Value
            dataArray(indexCount, 2) = osheet.Range("E" & rowCount).Value
            dataArray(indexCount, 3) = osheet.Range("G" & rowCount).Value

            indexCount += 1
            rowCount += 1

        Next


        osheet.Range("F" & rowCount).Value = txtTax.Text
        osheet.Range("G" & rowCount).Value = txtTotal.Text
        osheet.Range("H" & rowCount).Value = txtPayment.Text
        osheet.Range("I" & rowCount).Value = txtChange.Text
        osheet.Range("J" & rowCount).Value = txtPaymentType.Text

        database.addReceipt(conn, receiptNumber)

        receiptDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        receiptTax = osheet.Range("F" & rowCount).Text
        receiptTotalPrice = osheet.Range("G" & rowCount).Text
        receiptPayment = osheet.Range("H" & rowCount).Text
        receiptChange = osheet.Range("I" & rowCount).Text
        receiptPayType = osheet.Range("J" & rowCount).Text



        Dim receipt As New Receipt(dataArray, indexCount, receiptNumber, receiptDate, receiptTax,
                                   receiptTotalPrice, receiptPayment, receiptPayType, receiptChange)

        receipt.print()


        oexcel.DisplayAlerts = False


        obook.Save()
        obook.Close()
        oexcel.Quit()


        oexcel.DisplayAlerts = True
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set up the columns for the data grid

        tblData.ColumnCount = 6
        tblData.Columns(0).Name = "ID"
        tblData.Columns(1).Name = "Price"
        tblData.Columns(2).Name = "Name"
        tblData.Columns(3).Name = "Qty"
        tblData.Columns(4).Name = "Total Price"
        tblData.Columns(5).Name = "Product Code"

        tblData.Columns(0).Visible = False
        tblData.Columns(5).Visible = False

    End Sub

    Private Sub btnSearchCode_Click(sender As Object, e As EventArgs) Handles btnSearchCode.Click

        searchCode()


    End Sub

    ' The 2 following functions are to tell which text box are focused
    ' Mainly the Product Code Textbox and the Payment Textbox
    Private Sub txtProductCode_HasFocus(sender As Object, e As EventArgs) Handles txtProductCode.GotFocus

        blnProductCodeSelected = True

    End Sub

    Private Sub txtPayment_HasFocus(sender As Object, e As EventArgs) Handles txtPayment.GotFocus

        blnProductCodeSelected = False

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        addToGrid()


    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        ' Remove Selected Row from the DataGrid

        Dim selectedRow As Integer

        If tblData.Rows.Count() > 0 Then

            selectedRow = tblData.CurrentCell.RowIndex
            tblData.Rows.RemoveAt(selectedRow)

        End If



    End Sub
    Private Sub btnNum1_Click(sender As Object, e As EventArgs) Handles btnNum1.Click

        If blnProductCodeSelected = True Then

            txtProductCode.Text = txtProductCode.Text & "1"

        Else

            txtPayment.Text = txtPayment.Text & "1"

        End If

    End Sub

    Private Sub btnNum2_Click(sender As Object, e As EventArgs) Handles btnNum2.Click

        If blnProductCodeSelected = True Then

            txtProductCode.Text = txtProductCode.Text & "2"

        Else

            txtPayment.Text = txtPayment.Text & "2"

        End If

    End Sub

    Private Sub btnNum3_Click(sender As Object, e As EventArgs) Handles btnNum3.Click

        If blnProductCodeSelected = True Then

            txtProductCode.Text = txtProductCode.Text & "3"

        Else

            txtPayment.Text = txtPayment.Text & "3"

        End If

    End Sub

    Private Sub btnNum4_Click(sender As Object, e As EventArgs) Handles btnNum4.Click

        If blnProductCodeSelected = True Then

            txtProductCode.Text = txtProductCode.Text & "4"

        Else

            txtPayment.Text = txtPayment.Text & "4"

        End If

    End Sub

    Private Sub btnNum5_Click(sender As Object, e As EventArgs) Handles btnNum5.Click

        If blnProductCodeSelected = True Then

            txtProductCode.Text = txtProductCode.Text & "5"

        Else

            txtPayment.Text = txtPayment.Text & "5"

        End If

    End Sub

    Private Sub btnNum6_Click(sender As Object, e As EventArgs) Handles btnNum6.Click

        If blnProductCodeSelected = True Then

            txtProductCode.Text = txtProductCode.Text & "6"

        Else

            txtPayment.Text = txtPayment.Text & "6"

        End If

    End Sub

    Private Sub btnNum7_Click(sender As Object, e As EventArgs) Handles btnNum7.Click

        If blnProductCodeSelected = True Then

            txtProductCode.Text = txtProductCode.Text & "7"

        Else

            txtPayment.Text = txtPayment.Text & "7"

        End If

    End Sub

    Private Sub btnNum8_Click(sender As Object, e As EventArgs) Handles btnNum8.Click

        If blnProductCodeSelected = True Then

            txtProductCode.Text = txtProductCode.Text & "8"

        Else

            txtPayment.Text = txtPayment.Text & "8"

        End If

    End Sub

    Private Sub btnNum9_Click(sender As Object, e As EventArgs) Handles btnNum9.Click

        If blnProductCodeSelected = True Then

            txtProductCode.Text = txtProductCode.Text & "9"

        Else

            txtPayment.Text = txtPayment.Text & "9"

        End If

    End Sub

    Private Sub btnNum0_Click(sender As Object, e As EventArgs) Handles btnNum0.Click

        If blnProductCodeSelected = True Then

            txtProductCode.Text = txtProductCode.Text & "0"

        Else

            txtPayment.Text = txtPayment.Text & "0"

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        If blnProductCodeSelected = True Then

            txtProductCode.Text = ""

        Else

            txtPayment.Text = ""
        End If

    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click

        If blnProductCodeSelected = True Then

            txtProductCode.Text = txtProductCode.Text & "."

        Else

            txtPayment.Text = txtPayment.Text & "."

        End If

    End Sub

    ' The next 3 buttons below are what type of way does the user want to pay
    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click

        txtPaymentType.Text = "Cash"

    End Sub

    Private Sub btnCredCard_Click(sender As Object, e As EventArgs) Handles btnCredCard.Click

        txtPaymentType.Text = "Credit Card"

    End Sub

    Private Sub btnDebit_Click(sender As Object, e As EventArgs) Handles btnDebit.Click

        txtPaymentType.Text = "Debit"



    End Sub

    ' This button is for clicking next which essentially prints receipt, updates stocks and reset
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        updateStocks()

        saveReciept()

        tblData.Rows.Clear()

        conn.Close()

        reset(True)

        MsgBox("Printed Receipt and Updated Stocks!")

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click

        calculatePayment()

    End Sub





    Private Sub btnManagement_Click(sender As Object, e As EventArgs) Handles btnManagement.Click

        Management.Show()

    End Sub


End Class
