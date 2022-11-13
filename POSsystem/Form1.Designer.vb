<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.lblTotalQuantity = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tblData = New System.Windows.Forms.DataGridView()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.lblProductCode = New System.Windows.Forms.Label()
        Me.btnSearchCode = New System.Windows.Forms.Button()
        Me.numTotalProductQty = New System.Windows.Forms.NumericUpDown()
        Me.lblProductNameValue = New System.Windows.Forms.Label()
        Me.lblProductPriceValue = New System.Windows.Forms.Label()
        Me.btnNum1 = New System.Windows.Forms.Button()
        Me.btnNum2 = New System.Windows.Forms.Button()
        Me.btnNum3 = New System.Windows.Forms.Button()
        Me.btnNum6 = New System.Windows.Forms.Button()
        Me.btnNum5 = New System.Windows.Forms.Button()
        Me.btnNum4 = New System.Windows.Forms.Button()
        Me.btnNum9 = New System.Windows.Forms.Button()
        Me.btnNum8 = New System.Windows.Forms.Button()
        Me.btnNum7 = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnNum0 = New System.Windows.Forms.Button()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.gbPayment = New System.Windows.Forms.GroupBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.txtPaymentType = New System.Windows.Forms.TextBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.gbPaymentType = New System.Windows.Forms.GroupBox()
        Me.btnDebit = New System.Windows.Forms.Button()
        Me.btnCredCard = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.gbItemInfo = New System.Windows.Forms.GroupBox()
        Me.btnManagement = New System.Windows.Forms.Button()
        CType(Me.tblData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalProductQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPayment.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbPaymentType.SuspendLayout()
        Me.gbItemInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(132, 21)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(126, 23)
        Me.txtSubTotal.TabIndex = 2
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProductName.Location = New System.Drawing.Point(63, 24)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(52, 20)
        Me.lblProductName.TabIndex = 3
        Me.lblProductName.Text = "Name:"
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProductPrice.Location = New System.Drawing.Point(71, 61)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(44, 20)
        Me.lblProductPrice.TabIndex = 4
        Me.lblProductPrice.Text = "Price:"
        '
        'lblTotalQuantity
        '
        Me.lblTotalQuantity.AutoSize = True
        Me.lblTotalQuantity.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalQuantity.Location = New System.Drawing.Point(47, 99)
        Me.lblTotalQuantity.Name = "lblTotalQuantity"
        Me.lblTotalQuantity.Size = New System.Drawing.Size(68, 20)
        Me.lblTotalQuantity.TabIndex = 5
        Me.lblTotalQuantity.Text = "Quantity:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubTotal.Location = New System.Drawing.Point(50, 24)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(70, 20)
        Me.lblSubTotal.TabIndex = 6
        Me.lblSubTotal.Text = "SubTotal:"
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(901, 534)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(171, 72)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "ADD ITEM"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tblData
        '
        Me.tblData.AllowUserToAddRows = False
        Me.tblData.AllowUserToResizeColumns = False
        Me.tblData.AllowUserToResizeRows = False
        Me.tblData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblData.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tblData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblData.Location = New System.Drawing.Point(585, 107)
        Me.tblData.Name = "tblData"
        Me.tblData.ReadOnly = True
        Me.tblData.RowTemplate.Height = 25
        Me.tblData.Size = New System.Drawing.Size(539, 421)
        Me.tblData.TabIndex = 9
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRemove.Location = New System.Drawing.Point(673, 534)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(168, 72)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "REMOVE ITEM"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(121, 131)
        Me.txtProductCode.MaxLength = 1000
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(137, 23)
        Me.txtProductCode.TabIndex = 1
        '
        'lblProductCode
        '
        Me.lblProductCode.AutoSize = True
        Me.lblProductCode.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProductCode.Location = New System.Drawing.Point(19, 130)
        Me.lblProductCode.Name = "lblProductCode"
        Me.lblProductCode.Size = New System.Drawing.Size(102, 20)
        Me.lblProductCode.TabIndex = 12
        Me.lblProductCode.Text = "Product Code:"
        '
        'btnSearchCode
        '
        Me.btnSearchCode.Location = New System.Drawing.Point(121, 160)
        Me.btnSearchCode.Name = "btnSearchCode"
        Me.btnSearchCode.Size = New System.Drawing.Size(137, 25)
        Me.btnSearchCode.TabIndex = 13
        Me.btnSearchCode.Text = "Search!"
        Me.btnSearchCode.UseVisualStyleBackColor = True
        '
        'numTotalProductQty
        '
        Me.numTotalProductQty.Location = New System.Drawing.Point(121, 96)
        Me.numTotalProductQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTotalProductQty.Name = "numTotalProductQty"
        Me.numTotalProductQty.ReadOnly = True
        Me.numTotalProductQty.Size = New System.Drawing.Size(59, 23)
        Me.numTotalProductQty.TabIndex = 14
        Me.numTotalProductQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblProductNameValue
        '
        Me.lblProductNameValue.AutoSize = True
        Me.lblProductNameValue.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProductNameValue.Location = New System.Drawing.Point(121, 24)
        Me.lblProductNameValue.Name = "lblProductNameValue"
        Me.lblProductNameValue.Size = New System.Drawing.Size(0, 20)
        Me.lblProductNameValue.TabIndex = 17
        '
        'lblProductPriceValue
        '
        Me.lblProductPriceValue.AutoSize = True
        Me.lblProductPriceValue.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProductPriceValue.Location = New System.Drawing.Point(121, 61)
        Me.lblProductPriceValue.Name = "lblProductPriceValue"
        Me.lblProductPriceValue.Size = New System.Drawing.Size(0, 20)
        Me.lblProductPriceValue.TabIndex = 18
        '
        'btnNum1
        '
        Me.btnNum1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum1.Location = New System.Drawing.Point(24, 305)
        Me.btnNum1.Name = "btnNum1"
        Me.btnNum1.Size = New System.Drawing.Size(84, 72)
        Me.btnNum1.TabIndex = 19
        Me.btnNum1.Text = "1"
        Me.btnNum1.UseVisualStyleBackColor = True
        '
        'btnNum2
        '
        Me.btnNum2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum2.Location = New System.Drawing.Point(114, 305)
        Me.btnNum2.Name = "btnNum2"
        Me.btnNum2.Size = New System.Drawing.Size(84, 72)
        Me.btnNum2.TabIndex = 20
        Me.btnNum2.Text = "2"
        Me.btnNum2.UseVisualStyleBackColor = True
        '
        'btnNum3
        '
        Me.btnNum3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum3.Location = New System.Drawing.Point(204, 305)
        Me.btnNum3.Name = "btnNum3"
        Me.btnNum3.Size = New System.Drawing.Size(84, 72)
        Me.btnNum3.TabIndex = 21
        Me.btnNum3.Text = "3"
        Me.btnNum3.UseVisualStyleBackColor = True
        '
        'btnNum6
        '
        Me.btnNum6.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum6.Location = New System.Drawing.Point(204, 383)
        Me.btnNum6.Name = "btnNum6"
        Me.btnNum6.Size = New System.Drawing.Size(84, 72)
        Me.btnNum6.TabIndex = 24
        Me.btnNum6.Text = "6"
        Me.btnNum6.UseVisualStyleBackColor = True
        '
        'btnNum5
        '
        Me.btnNum5.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum5.Location = New System.Drawing.Point(114, 383)
        Me.btnNum5.Name = "btnNum5"
        Me.btnNum5.Size = New System.Drawing.Size(84, 72)
        Me.btnNum5.TabIndex = 23
        Me.btnNum5.Text = "5"
        Me.btnNum5.UseVisualStyleBackColor = True
        '
        'btnNum4
        '
        Me.btnNum4.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum4.Location = New System.Drawing.Point(24, 383)
        Me.btnNum4.Name = "btnNum4"
        Me.btnNum4.Size = New System.Drawing.Size(84, 72)
        Me.btnNum4.TabIndex = 22
        Me.btnNum4.Text = "4"
        Me.btnNum4.UseVisualStyleBackColor = True
        '
        'btnNum9
        '
        Me.btnNum9.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum9.Location = New System.Drawing.Point(204, 461)
        Me.btnNum9.Name = "btnNum9"
        Me.btnNum9.Size = New System.Drawing.Size(84, 72)
        Me.btnNum9.TabIndex = 27
        Me.btnNum9.Text = "9"
        Me.btnNum9.UseVisualStyleBackColor = True
        '
        'btnNum8
        '
        Me.btnNum8.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum8.Location = New System.Drawing.Point(114, 461)
        Me.btnNum8.Name = "btnNum8"
        Me.btnNum8.Size = New System.Drawing.Size(84, 72)
        Me.btnNum8.TabIndex = 26
        Me.btnNum8.Text = "8"
        Me.btnNum8.UseVisualStyleBackColor = True
        '
        'btnNum7
        '
        Me.btnNum7.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum7.Location = New System.Drawing.Point(24, 461)
        Me.btnNum7.Name = "btnNum7"
        Me.btnNum7.Size = New System.Drawing.Size(84, 72)
        Me.btnNum7.TabIndex = 25
        Me.btnNum7.Text = "7"
        Me.btnNum7.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDot.Location = New System.Drawing.Point(204, 539)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(84, 72)
        Me.btnDot.TabIndex = 30
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(114, 539)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 72)
        Me.btnClear.TabIndex = 29
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnNum0
        '
        Me.btnNum0.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum0.Location = New System.Drawing.Point(24, 539)
        Me.btnNum0.Name = "btnNum0"
        Me.btnNum0.Size = New System.Drawing.Size(84, 72)
        Me.btnNum0.TabIndex = 28
        Me.btnNum0.Text = "0"
        Me.btnNum0.UseVisualStyleBackColor = True
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTax.Location = New System.Drawing.Point(87, 61)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(33, 20)
        Me.lblTax.TabIndex = 31
        Me.lblTax.Text = "Tax:"
        '
        'txtTax
        '
        Me.txtTax.AcceptsReturn = True
        Me.txtTax.Location = New System.Drawing.Point(132, 58)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(126, 23)
        Me.txtTax.TabIndex = 32
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New System.Drawing.Point(75, 99)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(45, 20)
        Me.lblTotal.TabIndex = 33
        Me.lblTotal.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(132, 96)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(126, 23)
        Me.txtTotal.TabIndex = 34
        '
        'gbPayment
        '
        Me.gbPayment.Controls.Add(Me.txtChange)
        Me.gbPayment.Controls.Add(Me.lblChange)
        Me.gbPayment.Controls.Add(Me.lblPayment)
        Me.gbPayment.Controls.Add(Me.txtPaymentType)
        Me.gbPayment.Controls.Add(Me.txtPayment)
        Me.gbPayment.Controls.Add(Me.lblPaymentType)
        Me.gbPayment.Controls.Add(Me.txtTotal)
        Me.gbPayment.Controls.Add(Me.txtSubTotal)
        Me.gbPayment.Controls.Add(Me.lblTotal)
        Me.gbPayment.Controls.Add(Me.lblSubTotal)
        Me.gbPayment.Controls.Add(Me.txtTax)
        Me.gbPayment.Controls.Add(Me.lblTax)
        Me.gbPayment.Location = New System.Drawing.Point(305, 107)
        Me.gbPayment.Name = "gbPayment"
        Me.gbPayment.Size = New System.Drawing.Size(264, 255)
        Me.gbPayment.TabIndex = 35
        Me.gbPayment.TabStop = False
        Me.gbPayment.Text = "Payment"
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(132, 200)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(126, 23)
        Me.txtChange.TabIndex = 40
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblChange.Location = New System.Drawing.Point(54, 203)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(62, 20)
        Me.lblChange.TabIndex = 39
        Me.lblChange.Text = "Change:"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPayment.Location = New System.Drawing.Point(48, 171)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(68, 20)
        Me.lblPayment.TabIndex = 37
        Me.lblPayment.Text = "Payment:"
        '
        'txtPaymentType
        '
        Me.txtPaymentType.Location = New System.Drawing.Point(132, 131)
        Me.txtPaymentType.Name = "txtPaymentType"
        Me.txtPaymentType.ReadOnly = True
        Me.txtPaymentType.Size = New System.Drawing.Size(126, 23)
        Me.txtPaymentType.TabIndex = 38
        Me.txtPaymentType.Text = "Cash"
        '
        'txtPayment
        '
        Me.txtPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPayment.Location = New System.Drawing.Point(132, 168)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(126, 23)
        Me.txtPayment.TabIndex = 37
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPaymentType.Location = New System.Drawing.Point(13, 134)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(103, 20)
        Me.lblPaymentType.TabIndex = 36
        Me.lblPaymentType.Text = "Payment Type:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPayment)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Location = New System.Drawing.Point(305, 474)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 137)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change and Receipt"
        '
        'btnPayment
        '
        Me.btnPayment.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPayment.Location = New System.Drawing.Point(6, 45)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(114, 54)
        Me.btnPayment.TabIndex = 38
        Me.btnPayment.Text = "CALCULATE CHANGE"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.Location = New System.Drawing.Point(126, 45)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(114, 54)
        Me.btnNext.TabIndex = 37
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'gbPaymentType
        '
        Me.gbPaymentType.Controls.Add(Me.btnDebit)
        Me.gbPaymentType.Controls.Add(Me.btnCredCard)
        Me.gbPaymentType.Controls.Add(Me.btnCash)
        Me.gbPaymentType.Location = New System.Drawing.Point(305, 368)
        Me.gbPaymentType.Name = "gbPaymentType"
        Me.gbPaymentType.Size = New System.Drawing.Size(264, 100)
        Me.gbPaymentType.TabIndex = 38
        Me.gbPaymentType.TabStop = False
        Me.gbPaymentType.Text = "Payment Type"
        '
        'btnDebit
        '
        Me.btnDebit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDebit.Location = New System.Drawing.Point(184, 32)
        Me.btnDebit.Name = "btnDebit"
        Me.btnDebit.Size = New System.Drawing.Size(74, 50)
        Me.btnDebit.TabIndex = 41
        Me.btnDebit.Text = "Debit"
        Me.btnDebit.UseVisualStyleBackColor = True
        '
        'btnCredCard
        '
        Me.btnCredCard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCredCard.Location = New System.Drawing.Point(95, 32)
        Me.btnCredCard.Name = "btnCredCard"
        Me.btnCredCard.Size = New System.Drawing.Size(74, 50)
        Me.btnCredCard.TabIndex = 40
        Me.btnCredCard.Text = "Credit Card"
        Me.btnCredCard.UseVisualStyleBackColor = True
        '
        'btnCash
        '
        Me.btnCash.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCash.Location = New System.Drawing.Point(13, 32)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(74, 50)
        Me.btnCash.TabIndex = 39
        Me.btnCash.Text = "Cash"
        Me.btnCash.UseVisualStyleBackColor = True
        '
        'gbItemInfo
        '
        Me.gbItemInfo.Controls.Add(Me.btnSearchCode)
        Me.gbItemInfo.Controls.Add(Me.lblProductName)
        Me.gbItemInfo.Controls.Add(Me.lblProductPrice)
        Me.gbItemInfo.Controls.Add(Me.lblTotalQuantity)
        Me.gbItemInfo.Controls.Add(Me.txtProductCode)
        Me.gbItemInfo.Controls.Add(Me.lblProductCode)
        Me.gbItemInfo.Controls.Add(Me.numTotalProductQty)
        Me.gbItemInfo.Controls.Add(Me.lblProductNameValue)
        Me.gbItemInfo.Controls.Add(Me.lblProductPriceValue)
        Me.gbItemInfo.Location = New System.Drawing.Point(24, 107)
        Me.gbItemInfo.Name = "gbItemInfo"
        Me.gbItemInfo.Size = New System.Drawing.Size(264, 191)
        Me.gbItemInfo.TabIndex = 39
        Me.gbItemInfo.TabStop = False
        Me.gbItemInfo.Text = "Item Information"
        '
        'btnManagement
        '
        Me.btnManagement.Location = New System.Drawing.Point(997, 32)
        Me.btnManagement.Name = "btnManagement"
        Me.btnManagement.Size = New System.Drawing.Size(108, 43)
        Me.btnManagement.TabIndex = 43
        Me.btnManagement.Text = "Management"
        Me.btnManagement.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 638)
        Me.Controls.Add(Me.btnManagement)
        Me.Controls.Add(Me.gbItemInfo)
        Me.Controls.Add(Me.gbPaymentType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbPayment)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnNum0)
        Me.Controls.Add(Me.btnNum9)
        Me.Controls.Add(Me.btnNum8)
        Me.Controls.Add(Me.btnNum7)
        Me.Controls.Add(Me.btnNum6)
        Me.Controls.Add(Me.btnNum5)
        Me.Controls.Add(Me.btnNum4)
        Me.Controls.Add(Me.btnNum3)
        Me.Controls.Add(Me.btnNum2)
        Me.Controls.Add(Me.btnNum1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.tblData)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "POS                        "
        CType(Me.tblData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalProductQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPayment.ResumeLayout(False)
        Me.gbPayment.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbPaymentType.ResumeLayout(False)
        Me.gbItemInfo.ResumeLayout(False)
        Me.gbItemInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents lblTotalQuantity As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents tblData As DataGridView
    Friend WithEvents btnRemove As Button
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents lblProductCode As Label
    Friend WithEvents btnSearchCode As Button
    Friend WithEvents numTotalProductQty As NumericUpDown
    Friend WithEvents lblProductNameValue As Label
    Friend WithEvents lblProductPriceValue As Label
    Friend WithEvents btnNum1 As Button
    Friend WithEvents btnNum2 As Button
    Friend WithEvents btnNum3 As Button
    Friend WithEvents btnNum6 As Button
    Friend WithEvents btnNum5 As Button
    Friend WithEvents btnNum4 As Button
    Friend WithEvents btnNum9 As Button
    Friend WithEvents btnNum8 As Button
    Friend WithEvents btnNum7 As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnNum0 As Button
    Friend WithEvents lblTax As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents gbPayment As GroupBox
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents txtPaymentType As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents gbPaymentType As GroupBox
    Friend WithEvents btnDebit As Button
    Friend WithEvents btnCredCard As Button
    Friend WithEvents btnCash As Button
    Friend WithEvents gbItemInfo As GroupBox
    Friend WithEvents btnManagement As Button
End Class
