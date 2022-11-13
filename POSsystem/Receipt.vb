Imports System.Drawing.Printing

Public Class Receipt

    Private WithEvents PD As New PrintDocument
    Private PPD As New PrintPreviewDialog
    Private longpaper As Integer
    Private t_price As Long
    Private t_qty As Long
    Private arrayData(99, 99) As String
    Private arraySize As Integer
    Private receiptCode As String
    Private receiptCreated As String
    Private receiptTax As String
    Private receiptTotal As String
    Private receiptPay As String
    Private receiptPayType As String
    Private receiptChange As String

    Public Sub New(array, size, code, dateCreated, tax, total, pay, payType, change)

        arrayData = array
        arraySize = size
        receiptCode = code
        receiptCreated = dateCreated
        receiptTax = tax
        receiptTotal = total
        receiptPay = pay
        receiptPayType = payType
        receiptChange = change

    End Sub

    Sub changelongpaper()

        Dim rowcount As Integer
        longpaper = 0
        rowcount = 0
        longpaper = rowcount * 15
        longpaper = longpaper + 240

    End Sub
    Sub print()

        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
        PD.Print()  'Direct Print

    End Sub

    Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        'pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "****************************************************************"

        'range from top
        'logo
        'Dim logoImage As Image = My.Resources.ResourceManager.GetObject("logo")
        'e.Graphics.DrawImage(logoImage, CInt((e.PageBounds.Width - 150) / 2), 5, 150, 35)

        'e.Graphics.DrawImage(logoImage, 0, 250, 150, 50)
        'e.Graphics.DrawImage(logoImage, CInt((e.PageBounds.Width - logoImage.Width) / 2), CInt((e.PageBounds.Height - logoImage.Height) / 2), logoImage.Width, logoImage.Height)

        'e.Graphics.DrawString("Store :", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("GMA CARMONA CAVITE", f10, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("Contact No. 09977005734", f10, Brushes.Black, centermargin, 55, center)

        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString(receiptCode, f8, Brushes.Black, 70, 75)

        e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 85)
        e.Graphics.DrawString("Steve Jobs", f8, Brushes.Black, 70, 85)

        e.Graphics.DrawString(receiptCreated, f8, Brushes.Black, 0, 95)
        'DetailHeader
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 0, 110)
        e.Graphics.DrawString("Item", f8, Brushes.Black, 25, 110)
        e.Graphics.DrawString("Price", f8, Brushes.Black, 180, 110, right)
        e.Graphics.DrawString("Total", f8, Brushes.Black, rightmargin, 110, right)
        '
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 120)

        Dim height As Integer 'DGV Position


        For i As Integer = 0 To arraySize



            height += 15
            t_qty += arrayData(i, 0)
            e.Graphics.DrawString(arrayData(i, 0), f8, Brushes.Black, 0, 115 + height)
            e.Graphics.DrawString(arrayData(i, 1), f8, Brushes.Black, 25, 115 + height)
            e.Graphics.DrawString(arrayData(i, 2), f8, Brushes.Black, 180, 115 + height, right)
            e.Graphics.DrawString(arrayData(i, 3), f8, Brushes.Black, rightmargin, 115 + height, right)


        Next



        Dim height2 As Integer
        height2 = 145 + height

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)

        e.Graphics.DrawString("Tax", f8, Brushes.Black, 0, 10 + height2)
        e.Graphics.DrawString(receiptTax, f8, Brushes.Black, rightmargin, 10 + height2, right)

        e.Graphics.DrawString("Total", f8, Brushes.Black, 0, 30 + height2)
        e.Graphics.DrawString(receiptTotal, f8, Brushes.Black, rightmargin, 30 + height2, right)

        e.Graphics.DrawString("Payment", f8, Brushes.Black, 0, 50 + height2)
        e.Graphics.DrawString("$" & receiptPay, f8, Brushes.Black, rightmargin, 50 + height2, right)

        e.Graphics.DrawString("Change", f8, Brushes.Black, 0, 70 + height2)
        e.Graphics.DrawString(receiptChange, f8, Brushes.Black, rightmargin, 70 + height2, right)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2 + 100)




        'Barcode
        Dim gbarcode As New MessagingToolkit.Barcode.BarcodeEncoder
        Try
            Dim barcodeimage As Image
            barcodeimage = New Bitmap(gbarcode.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, receiptCode))
            e.Graphics.DrawImage(barcodeimage, CInt((e.PageBounds.Width - 180) / 2), 125 + height2, 180, 35)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        e.Graphics.DrawString("~ Thanks for shopping ~", f10, Brushes.Black, centermargin, 160 + height2, center)
        e.Graphics.DrawString("~ Pheytun Store ~", f10, Brushes.Black, centermargin, 175 + height2, center)
    End Sub
End Class
