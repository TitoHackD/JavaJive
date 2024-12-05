<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        GroupBox1 = New GroupBox()
        btnPrint = New Button()
        btnExit2 = New Button()
        lblTotal = New Label()
        lblTax = New Label()
        lblSubtotal = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnPrint)
        GroupBox1.Controls.Add(btnExit2)
        GroupBox1.Controls.Add(lblTotal)
        GroupBox1.Controls.Add(lblTax)
        GroupBox1.Controls.Add(lblSubtotal)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(370, 216)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(288, 56)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(75, 23)
        btnPrint.TabIndex = 7
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnExit2
        ' 
        btnExit2.Location = New Point(289, 106)
        btnExit2.Name = "btnExit2"
        btnExit2.Size = New Size(75, 23)
        btnExit2.TabIndex = 6
        btnExit2.Text = "Exit"
        btnExit2.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.BorderStyle = BorderStyle.Fixed3D
        lblTotal.Location = New Point(182, 161)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(87, 25)
        lblTotal.TabIndex = 5
        ' 
        ' lblTax
        ' 
        lblTax.BorderStyle = BorderStyle.Fixed3D
        lblTax.Location = New Point(182, 106)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(87, 25)
        lblTax.TabIndex = 4
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.BorderStyle = BorderStyle.Fixed3D
        lblSubtotal.Location = New Point(182, 48)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(87, 25)
        lblSubtotal.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(74, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 21)
        Label3.TabIndex = 2
        Label3.Text = "Total:"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(78, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 19)
        Label2.TabIndex = 1
        Label2.Text = "Tax:"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(46, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 23)
        Label1.TabIndex = 0
        Label1.Text = "Subtotal:"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(394, 240)
        Controls.Add(GroupBox1)
        Name = "Form2"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents btnExit2 As Button
    Friend WithEvents btnPrint As Button
End Class
