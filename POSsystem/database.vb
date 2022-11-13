Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Database

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private reader As SqlDataReader
    Private server As String
    Private db As String

    Public Sub New(server_name, db_name)

        server = server_name
        db = db_name

    End Sub

    ' This gets our connection and readily open
    Function getConnection() As SqlConnection

        conn = New SqlConnection("SERVER = " + server + "; DATABASE = " + db + "; Integrated Security = true")

        conn.Open()

        Return conn

    End Function


    Function getProductInformation(conn As SqlConnection, productCode As String) As SqlDataReader

        Dim query = "SELECT * FROM products WHERE product_code = " & productCode
        Dim cmd As New SqlCommand(query, conn)
        Dim reader = cmd.ExecuteReader()


        reader.Read()

        Return reader

    End Function

    Function getReceiptNumber(conn As SqlConnection) As Integer

        Dim query = "SELECT * FROM products"
        Dim cmd As New SqlCommand(query, conn)
        Dim reader = cmd.ExecuteReader()
        Dim receiptNumber As Integer

        While reader.Read()

            receiptNumber = reader.GetValue("product_code")

        End While

        conn.Close()

        Return receiptNumber

    End Function


    Sub addReceipt(conn As SqlConnection, receiptCode As Integer)


        Dim cmd As New SqlCommand("INSERT INTO receipt(receipt_code, receipt_created) values(@rcode,@rcreate)", conn)
        Dim currentDateTime As DateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")


        cmd.Parameters.Add("@rcode", SqlDbType.VarChar).Value = receiptCode
        cmd.Parameters.Add("@rcreate", SqlDbType.DateTime).Value = currentDateTime

        cmd.ExecuteNonQuery()


        conn.Close()


    End Sub

    Sub addProduct(conn As SqlConnection, productPrice As String, productName As String, productStock As String, receiptCode As Integer)


        Dim cmd As New SqlCommand("INSERT INTO products(product_price, product_name, product_stock, product_code) values(@price,@name,@stock,@code)", conn)
        Dim currentDateTime As DateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")


        cmd.Parameters.Add("@price", SqlDbType.Int).Value = productPrice
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = productName
        cmd.Parameters.Add("@stock", SqlDbType.VarChar).Value = productStock
        cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = receiptCode


        cmd.ExecuteNonQuery()


        conn.Close()


    End Sub

    Sub updateProductDetails(conn As SqlConnection, productCode As String, productPrice As String, productName As String, productStock As String)


        Try

            Dim query As String = "UPDATE products SET product_price = @price , product_name = @name , product_stock = @stock WHERE product_code = @code"


            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.Add("@price", SqlDbType.Int).Value = productPrice
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = productName
            cmd.Parameters.Add("@stock", SqlDbType.VarChar).Value = productStock
            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = productCode

            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox(ex.ToString())

        End Try
    End Sub


    Sub updateProductStocks(conn As SqlConnection, productId As String, productStock As Integer)


        Try

            Dim query = "SELECT * FROM products WHERE product_id = " & productId
            Dim cmd As New SqlCommand(query, conn)


            reader = cmd.ExecuteReader()


            reader.Read()

            cmd = New SqlCommand("UPDATE products SET product_stock = @stock  WHERE product_id = @id", conn)

            cmd.Parameters.Add("@stock", SqlDbType.Int).Value = reader.GetValue("product_stock") - productStock
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = reader.GetValue("product_id")

            reader.Close()

            cmd.ExecuteNonQuery()



        Catch ex As Exception

            MsgBox(ex.ToString())

        End Try
    End Sub

    Function fillReceipts(conn As SqlConnection, Optional receiptCode As String = Nothing) As DataTable

        Dim query As String

        If receiptCode = Nothing Then

            query = "SELECT * FROM receipt ORDER BY receipt_code ASC"

        Else

            query = "SELECT * FROM receipt WHERE receipt_code LIKE '" & receiptCode & "%' ORDER BY receipt_code ASC"

        End If

        Dim dataTable As New DataTable
        Dim dataAdapter As New SqlDataAdapter(query, conn)

        dataAdapter.Fill(dataTable)

        conn.Close()

        Return dataTable



    End Function

    Function fillProducts(conn As SqlConnection, Optional productCode As String = Nothing) As DataTable

        Dim query As String

        If productCode = Nothing Then

            query = "SELECT * FROM products ORDER BY product_code ASC"

        Else

            query = "SELECT * FROM products WHERE product_code LIKE '" & productCode & "%' ORDER BY product_code ASC"

        End If

        Dim dataTable As New DataTable
        Dim dataAdapter As New SqlDataAdapter(query, conn)

        dataAdapter.Fill(dataTable)

        conn.Close()

        Return dataTable



    End Function

    Sub deleteProduct(conn As SqlConnection, productCode As String)


        Try


            Dim cmd As New SqlCommand("DELETE products WHERE product_code = @code", conn)

            cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = productCode

            cmd.ExecuteNonQuery()



        Catch ex As Exception

            MsgBox(ex.ToString())

        End Try
    End Sub


End Class
