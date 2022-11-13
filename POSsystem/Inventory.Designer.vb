<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tblProducts = New System.Windows.Forms.DataGridView()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.txtProductStock = New System.Windows.Forms.TextBox()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReadProductCode = New System.Windows.Forms.TextBox()
        Me.btnUpdateStocks = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnDeselectRow = New System.Windows.Forms.Button()
        Me.btnRemoveProduct = New System.Windows.Forms.Button()
        CType(Me.tblProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblProducts
        '
        Me.tblProducts.AllowUserToAddRows = False
        Me.tblProducts.AllowUserToDeleteRows = False
        Me.tblProducts.AllowUserToResizeColumns = False
        Me.tblProducts.AllowUserToResizeRows = False
        Me.tblProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblProducts.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tblProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblProducts.Location = New System.Drawing.Point(12, 52)
        Me.tblProducts.Name = "tblProducts"
        Me.tblProducts.ReadOnly = True
        Me.tblProducts.RowTemplate.Height = 25
        Me.tblProducts.Size = New System.Drawing.Size(407, 318)
        Me.tblProducts.TabIndex = 11
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(101, 18)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(100, 23)
        Me.txtProductCode.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Product Code:"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(526, 104)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(137, 23)
        Me.txtProductName.TabIndex = 14
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(526, 144)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(137, 23)
        Me.txtProductPrice.TabIndex = 15
        '
        'txtProductStock
        '
        Me.txtProductStock.Location = New System.Drawing.Point(526, 187)
        Me.txtProductStock.Name = "txtProductStock"
        Me.txtProductStock.Size = New System.Drawing.Size(137, 23)
        Me.txtProductStock.TabIndex = 16
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(427, 112)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(87, 15)
        Me.lblProductName.TabIndex = 17
        Me.lblProductName.Text = "Product Name:"
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.Location = New System.Drawing.Point(427, 152)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(81, 15)
        Me.lblProductPrice.TabIndex = 18
        Me.lblProductPrice.Text = "Product Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Product Stock:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(425, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Product Code:"
        '
        'txtReadProductCode
        '
        Me.txtReadProductCode.Location = New System.Drawing.Point(526, 64)
        Me.txtReadProductCode.Name = "txtReadProductCode"
        Me.txtReadProductCode.ReadOnly = True
        Me.txtReadProductCode.Size = New System.Drawing.Size(100, 23)
        Me.txtReadProductCode.TabIndex = 20
        '
        'btnUpdateStocks
        '
        Me.btnUpdateStocks.Enabled = False
        Me.btnUpdateStocks.Location = New System.Drawing.Point(436, 229)
        Me.btnUpdateStocks.Name = "btnUpdateStocks"
        Me.btnUpdateStocks.Size = New System.Drawing.Size(105, 40)
        Me.btnUpdateStocks.TabIndex = 22
        Me.btnUpdateStocks.Text = "Update Product"
        Me.btnUpdateStocks.UseVisualStyleBackColor = True
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(558, 229)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(105, 40)
        Me.btnAddProduct.TabIndex = 24
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnDeselectRow
        '
        Me.btnDeselectRow.Location = New System.Drawing.Point(233, 18)
        Me.btnDeselectRow.Name = "btnDeselectRow"
        Me.btnDeselectRow.Size = New System.Drawing.Size(105, 23)
        Me.btnDeselectRow.TabIndex = 25
        Me.btnDeselectRow.Text = "Deselect Row"
        Me.btnDeselectRow.UseVisualStyleBackColor = True
        '
        'btnRemoveProduct
        '
        Me.btnRemoveProduct.Location = New System.Drawing.Point(498, 288)
        Me.btnRemoveProduct.Name = "btnRemoveProduct"
        Me.btnRemoveProduct.Size = New System.Drawing.Size(105, 40)
        Me.btnRemoveProduct.TabIndex = 26
        Me.btnRemoveProduct.Text = "Remove Product"
        Me.btnRemoveProduct.UseVisualStyleBackColor = True
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 392)
        Me.Controls.Add(Me.btnRemoveProduct)
        Me.Controls.Add(Me.btnDeselectRow)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.btnUpdateStocks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReadProductCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblProductPrice)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.txtProductStock)
        Me.Controls.Add(Me.txtProductPrice)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.tblProducts)
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        CType(Me.tblProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblProducts As DataGridView
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents txtProductStock As TextBox
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReadProductCode As TextBox
    Friend WithEvents btnUpdateStocks As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnDeselectRow As Button
    Friend WithEvents btnRemoveProduct As Button
End Class
