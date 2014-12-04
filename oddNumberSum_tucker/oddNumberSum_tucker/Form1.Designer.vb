<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(105, 137)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Button1"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(172, 78)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "pick a number greater than 1"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(119, 214)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(39, 13)
        Me.lblResults.TabIndex = 3
        Me.lblResults.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblResults As System.Windows.Forms.Label

End Class
