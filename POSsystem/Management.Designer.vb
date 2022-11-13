<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management
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
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnTransactions = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStaff
        '
        Me.btnStaff.Location = New System.Drawing.Point(71, 54)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(96, 34)
        Me.btnStaff.TabIndex = 0
        Me.btnStaff.Text = "Staffs"
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnTransactions
        '
        Me.btnTransactions.Location = New System.Drawing.Point(71, 94)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(96, 34)
        Me.btnTransactions.TabIndex = 1
        Me.btnTransactions.Text = "View Receipts"
        Me.btnTransactions.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(71, 134)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(96, 34)
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 299)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnTransactions)
        Me.Controls.Add(Me.btnStaff)
        Me.Name = "Management"
        Me.Text = "Management"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStaff As Button
    Friend WithEvents btnTransactions As Button
    Friend WithEvents btnInventory As Button
End Class
