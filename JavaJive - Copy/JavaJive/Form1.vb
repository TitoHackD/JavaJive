'Authors: Nicholas, Bryce 
'Date: 12/5/2024
Imports System.Reflection.Emit

Public Class JavaJive

    Private Sub JavaJive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GET DATE AND POPULATE DATE LADEL
        lblDateData.Text = Now.ToString("MM/dd/yyyy")
        'Get the time and populate the Time Label
        lblTimeData.Text = Now.ToString("HH:mm:ss")
    End Sub

    'Class level declarations
    Const TAX_RATE As Decimal = 0.08D
    Const decBLACK_COFFEE As Decimal = 3D
    Const decESPRESSO As Decimal = 3D
    Const decCAPPUCINO As Decimal = 3D
    Const decICED_COFFEE As Decimal = 3D
    Const decAMERICANO As Decimal = 3D
    Const decLATTE As Decimal = 3D
    Const decCROISSANT As Decimal = 4D
    Const decCAKE_POP As Decimal = 4D
    Const decBAGEL As Decimal = 4D
    Const decDONUT As Decimal = 4D
    Const decSPRINKLES As Decimal = 0.5D
    Const decCHOCOLATE As Decimal = 0.5D
    Const decCHARAMEL As Decimal = 0.5D
    Const decWHIP_CREAM As Decimal = 0.5D

    Dim subtotal As Decimal = 0 ' To store the price of the selected coffee
    Dim tax As Decimal = 0 ' To store the calculated tax
    Dim total As Decimal = 0 ' To store the total amount after adding tax

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Calculate the price of the selected coffee
        If radBlack.Checked Then
            subtotal += decBLACK_COFFEE
        ElseIf radEspresso.Checked Then
            subtotal += decESPRESSO
        ElseIf radCappucino.Checked Then
            subtotal += decCAPPUCINO
        ElseIf radIced.Checked Then
            subtotal += decICED_COFFEE
        ElseIf radAmericano.Checked Then
            subtotal += decAMERICANO
        ElseIf radLatte.Checked Then
            subtotal += decLATTE
        End If

        ' Add the cost of any selected pastries or snacks
        If chkCroissant.Checked Then
            subtotal += decCROISSANT
        End If
        If chkCakePop.Checked Then
            subtotal += decCAKE_POP
        End If
        If chkBagel.Checked Then
            subtotal += decBAGEL
        End If
        If chkDonut.Checked Then
            subtotal += decDONUT
        End If

        ' Add the cost of any selected add-ons
        If chkSprinkles.Checked Then
            subtotal += decSPRINKLES
        End If
        If chkChocolate.Checked Then
            subtotal += decCHOCOLATE
        End If
        If chkCaramel.Checked Then
            subtotal += decCHARAMEL
        End If
        If chkWhipCream.Checked Then
            subtotal += decWHIP_CREAM
        End If

        ' Calculate the tax 
        tax = subtotal * TAX_RATE

        ' Calculate the total 
        total = subtotal + tax

        ' Now create and show Form2 with the calculated values
        Dim summaryForm As New Form2() ' Create a new instance of Form2
        summaryForm.SubtotalValue = subtotal ' Pass the subtotal to Form2
        summaryForm.TaxValue = tax ' Pass the tax to Form2
        summaryForm.TotalValue = total ' Pass the total to Form2
        summaryForm.DisplayOrderSummary() ' Display the calculated values in Form2
        summaryForm.ShowDialog() ' Show Form2 as a dialog
    End Sub

    Private Sub radBlack_CheckedChanged(sender As Object, e As EventArgs) Handles radBlack.CheckedChanged
        If radBlack.Checked Then
            ' Show the PictureBox when the RadioButton is selected
            picBlack.Visible = True
        Else
            ' Hide the PictureBox when the RadioButton is deselected
            picBlack.Visible = False
        End If
    End Sub

    Private Sub radCappucino_CheckedChanged(sender As Object, e As EventArgs) Handles radCappucino.CheckedChanged
        If radCappucino.Checked Then
            ' Show the PictureBox when the RadioButton is selected
            picCappucino.Visible = True
        Else
            ' Hide the PictureBox when the RadioButton is deselected
            picCappucino.Visible = False
        End If
    End Sub

    Private Sub radAmericano_CheckedChanged(sender As Object, e As EventArgs) Handles radAmericano.CheckedChanged
        If radAmericano.Checked Then
            ' Show the PictureBox when the RadioButton is selected
            picAmericano.Visible = True
        Else
            ' Hide the PictureBox when the RadioButton is deselected
            picAmericano.Visible = False
        End If
    End Sub

    Private Sub radEspresso_CheckedChanged(sender As Object, e As EventArgs) Handles radEspresso.CheckedChanged
        If radEspresso.Checked Then
            ' Show the PictureBox when the RadioButton is selected
            picEspresso.Visible = True
        Else
            ' Hide the PictureBox when the RadioButton is deselected
            picEspresso.Visible = False
        End If
    End Sub

    Private Sub radIced_CheckedChanged(sender As Object, e As EventArgs) Handles radIced.CheckedChanged
        If radIced.Checked Then
            ' Show the PictureBox when the RadioButton is selected
            picIcedCoffee.Visible = True
        Else
            ' Hide the PictureBox when the RadioButton is deselected
            picIcedCoffee.Visible = False
        End If
    End Sub

    Private Sub radLatte_CheckedChanged(sender As Object, e As EventArgs) Handles radLatte.CheckedChanged
        If radLatte.Checked Then
            ' Show the PictureBox when the RadioButton is selected
            picLatte.Visible = True
        Else
            ' Hide the PictureBox when the RadioButton is deselected
            picLatte.Visible = False
        End If
    End Sub

    Private Sub chkSprinkles_CheckedChanged(sender As Object, e As EventArgs) Handles chkSprinkles.CheckedChanged
        If chkSprinkles.Checked Then
            ' Show the PictureBox when the CheckBox is checked
            PicSprinkles.Visible = True
        Else
            ' Hide the PictureBox when the CheckBox is unchecked
            PicSprinkles.Visible = False
        End If
    End Sub

    Private Sub chkChocolate_CheckedChanged(sender As Object, e As EventArgs) Handles chkChocolate.CheckedChanged
        If chkChocolate.Checked Then
            ' Show the PictureBox when the CheckBox is checked
            picChocolate.Visible = True
        Else
            ' Hide the PictureBox when the CheckBox is unchecked
            picChocolate.Visible = False
        End If
    End Sub

    Private Sub chkCaramel_CheckedChanged(sender As Object, e As EventArgs) Handles chkCaramel.CheckedChanged
        If chkCaramel.Checked Then
            ' Show the PictureBox when the CheckBox is checked
            picCaramel.Visible = True
        Else
            ' Hide the PictureBox when the CheckBox is unchecked
            picCaramel.Visible = False
        End If
    End Sub

    Private Sub chkWhipCream_CheckedChanged(sender As Object, e As EventArgs) Handles chkWhipCream.CheckedChanged
        If chkWhipCream.Checked Then
            ' Show the PictureBox when the CheckBox is checked
            picWhipCream.Visible = True
        Else
            ' Hide the PictureBox when the CheckBox is unchecked
            picWhipCream.Visible = False
        End If
    End Sub

    Private Sub chkCroissant_CheckedChanged(sender As Object, e As EventArgs) Handles chkCroissant.CheckedChanged
        If chkCroissant.Checked Then
            ' Show the PictureBox when the CheckBox is checked
            picCroissant.Visible = True
        Else
            ' Hide the PictureBox when the CheckBox is unchecked
            picCroissant.Visible = False
        End If
    End Sub

    Private Sub chkBagel_CheckedChanged(sender As Object, e As EventArgs) Handles chkBagel.CheckedChanged
        If chkBagel.Checked Then
            ' Show the PictureBox when the CheckBox is checked
            picBagel.Visible = True
        Else
            ' Hide the PictureBox when the CheckBox is unchecked
            picBagel.Visible = False
        End If
    End Sub

    Private Sub chkCakePop_CheckedChanged(sender As Object, e As EventArgs) Handles chkCakePop.CheckedChanged
        If chkCakePop.Checked Then
            ' Show the PictureBox when the CheckBox is checked
            picCakePop.Visible = True
        Else
            ' Hide the PictureBox when the CheckBox is unchecked
            picCakePop.Visible = False
        End If
    End Sub

    Private Sub chkDonut_CheckedChanged(sender As Object, e As EventArgs) Handles chkDonut.CheckedChanged
        If chkDonut.Checked Then
            ' Show the PictureBox when the CheckBox is checked
            picDonut.Visible = True
        Else
            ' Hide the PictureBox when the CheckBox is unchecked
            picDonut.Visible = False
        End If
    End Sub

    Sub ResetToppings()
        'This Procedure resets the topping selection
        chkSprinkles.Checked = False
        chkChocolate.Checked = False
        chkCaramel.Checked = False
        chkWhipCream.Checked = False
    End Sub
    Sub ResetCoffee()
        'This procedure resets the coffee selection.
        radBlack.Checked = False
        radEspresso.Checked = False
        radCappucino.Checked = False
        radIced.Checked = False
        radAmericano.Checked = False
        radLatte.Checked = False
    End Sub
    Sub ResetFood()
        'This precedure resets the Food selection.
        chkCroissant.Checked = False
        chkCakePop.Checked = False
        chkBagel.Checked = False
        chkDonut.Checked = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This Takes the info from the above subs and 
        ResetFood()
        ResetToppings()
        ResetCoffee()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimeData.Text = Now.ToString("HH:mm:ss")
    End Sub
End Class
