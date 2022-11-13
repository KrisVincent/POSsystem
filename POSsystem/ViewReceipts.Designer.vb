<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewReceipts
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
        Me.tblReceipts = New System.Windows.Forms.DataGridView()
        Me.txtReceiptCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnViewReceipt = New System.Windows.Forms.Button()
        CType(Me.tblReceipts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblReceipts
        '
        Me.tblReceipts.AllowUserToAddRows = False
        Me.tblReceipts.AllowUserToResizeColumns = False
        Me.tblReceipts.AllowUserToResizeRows = False
        Me.tblReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblReceipts.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tblReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblReceipts.Location = New System.Drawing.Point(27, 73)
        Me.tblReceipts.Name = "tblReceipts"
        Me.tblReceipts.ReadOnly = True
        Me.tblReceipts.RowTemplate.Height = 25
        Me.tblReceipts.Size = New System.Drawing.Size(345, 318)
        Me.tblReceipts.TabIndex = 10
        '
        'txtReceiptCode
        '
        Me.txtReceiptCode.Location = New System.Drawing.Point(171, 42)
        Me.txtReceiptCode.Name = "txtReceiptCode"
        Me.txtReceiptCode.Size = New System.Drawing.Size(134, 23)
        Me.txtReceiptCode.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(50, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Receipt Code:"
        '
        'btnViewReceipt
        '
        Me.btnViewReceipt.Enabled = False
        Me.btnViewReceipt.Location = New System.Drawing.Point(137, 397)
        Me.btnViewReceipt.Name = "btnViewReceipt"
        Me.btnViewReceipt.Size = New System.Drawing.Size(123, 30)
        Me.btnViewReceipt.TabIndex = 13
        Me.btnViewReceipt.Text = "View Receipt"
        Me.btnViewReceipt.UseVisualStyleBackColor = True
        '
        'ViewReceipts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 462)
        Me.Controls.Add(Me.btnViewReceipt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReceiptCode)
        Me.Controls.Add(Me.tblReceipts)
        Me.Name = "ViewReceipts"
        Me.Text = "inventory"
        CType(Me.tblReceipts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblReceipts As DataGridView
    Friend WithEvents txtReceiptCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnViewReceipt As Button
End Class
