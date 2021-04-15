<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sale
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
        Me.txtOriginalPrice = New System.Windows.Forms.TextBox()
        Me.txtPercentOff = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOriginalPrice = New System.Windows.Forms.Label()
        Me.lblPercentOff = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Textbox1
        '
        Me.txtOriginalPrice.Location = New System.Drawing.Point(160, 77)
        Me.txtOriginalPrice.Name = "Textbox1"
        Me.txtOriginalPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtOriginalPrice.TabIndex = 0
        '
        'Textbox2
        '
        Me.txtPercentOff.Location = New System.Drawing.Point(160, 103)
        Me.txtPercentOff.Name = "Textbox2"
        Me.txtPercentOff.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentOff.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(23, 208)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(104, 208)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(185, 208)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'OriginalPrice
        '
        Me.lblOriginalPrice.AutoSize = True
        Me.lblOriginalPrice.Location = New System.Drawing.Point(59, 77)
        Me.lblOriginalPrice.Name = "OriginalPrice"
        Me.lblOriginalPrice.Size = New System.Drawing.Size(69, 13)
        Me.lblOriginalPrice.TabIndex = 5
        Me.lblOriginalPrice.Text = "Original Price"
        '
        'PercentOff
        '
        Me.lblPercentOff.AutoSize = True
        Me.lblPercentOff.Location = New System.Drawing.Point(59, 106)
        Me.lblPercentOff.Name = "PercentOff"
        Me.lblPercentOff.Size = New System.Drawing.Size(61, 13)
        Me.lblPercentOff.TabIndex = 6
        Me.lblPercentOff.Text = "Percent Off"
        '
        'TotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(59, 144)
        Me.lblTotalPrice.Name = "TotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalPrice.TabIndex = 7
        Me.lblTotalPrice.Text = "Total Price"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(160, 144)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 23)
        Me.lblResult.TabIndex = 8
        '
        'Sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblPercentOff)
        Me.Controls.Add(Me.lblOriginalPrice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtPercentOff)
        Me.Controls.Add(Me.txtOriginalPrice)
        Me.Name = "Sale"
        Me.Text = "Sale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOriginalPrice As TextBox
    Friend WithEvents txtPercentOff As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblOriginalPrice As Label
    Friend WithEvents lblPercentOff As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblResult As Label
End Class
