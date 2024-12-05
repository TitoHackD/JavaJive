<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JavaJive
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(JavaJive))
        grpCoffee = New GroupBox()
        radLatte = New RadioButton()
        radIced = New RadioButton()
        radEspresso = New RadioButton()
        radAmericano = New RadioButton()
        radCappucino = New RadioButton()
        radBlack = New RadioButton()
        grpToppings = New GroupBox()
        chkWhipCream = New CheckBox()
        chkCaramel = New CheckBox()
        chkChocolate = New CheckBox()
        chkSprinkles = New CheckBox()
        chkFood = New GroupBox()
        chkDonut = New CheckBox()
        chkCakePop = New CheckBox()
        chkBagel = New CheckBox()
        chkCroissant = New CheckBox()
        Label4 = New Label()
        lblTime = New Label()
        lblDate = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        lblDateData = New Label()
        picBlack = New PictureBox()
        picCappucino = New PictureBox()
        picAmericano = New PictureBox()
        picEspresso = New PictureBox()
        picIcedCoffee = New PictureBox()
        picCroissant = New PictureBox()
        picLatte = New PictureBox()
        PicSprinkles = New PictureBox()
        picChocolate = New PictureBox()
        picCaramel = New PictureBox()
        picWhipCream = New PictureBox()
        picBagel = New PictureBox()
        picCakePop = New PictureBox()
        picDonut = New PictureBox()
        lblSubtotal = New Label()
        lblTax = New Label()
        lblTotal = New Label()
        Timer1 = New Timer(components)
        lblTimeData = New Label()
        grpCoffee.SuspendLayout()
        grpToppings.SuspendLayout()
        chkFood.SuspendLayout()
        CType(picBlack, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCappucino, ComponentModel.ISupportInitialize).BeginInit()
        CType(picAmericano, ComponentModel.ISupportInitialize).BeginInit()
        CType(picEspresso, ComponentModel.ISupportInitialize).BeginInit()
        CType(picIcedCoffee, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCroissant, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLatte, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSprinkles, ComponentModel.ISupportInitialize).BeginInit()
        CType(picChocolate, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCaramel, ComponentModel.ISupportInitialize).BeginInit()
        CType(picWhipCream, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBagel, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCakePop, ComponentModel.ISupportInitialize).BeginInit()
        CType(picDonut, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpCoffee
        ' 
        grpCoffee.BackColor = Color.Sienna
        grpCoffee.Controls.Add(radLatte)
        grpCoffee.Controls.Add(radIced)
        grpCoffee.Controls.Add(radEspresso)
        grpCoffee.Controls.Add(radAmericano)
        grpCoffee.Controls.Add(radCappucino)
        grpCoffee.Controls.Add(radBlack)
        grpCoffee.Location = New Point(12, 69)
        grpCoffee.Name = "grpCoffee"
        grpCoffee.Size = New Size(308, 192)
        grpCoffee.TabIndex = 0
        grpCoffee.TabStop = False
        grpCoffee.Text = "Coffee"
        ' 
        ' radLatte
        ' 
        radLatte.AutoSize = True
        radLatte.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        radLatte.Location = New Point(161, 139)
        radLatte.Name = "radLatte"
        radLatte.Size = New Size(84, 25)
        radLatte.TabIndex = 4
        radLatte.TabStop = True
        radLatte.Text = "&Latte $3"
        radLatte.UseVisualStyleBackColor = True
        ' 
        ' radIced
        ' 
        radIced.AutoSize = True
        radIced.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        radIced.Location = New Point(161, 92)
        radIced.Name = "radIced"
        radIced.Size = New Size(127, 25)
        radIced.TabIndex = 4
        radIced.TabStop = True
        radIced.Text = "&Iced Coffee $3"
        radIced.UseVisualStyleBackColor = True
        ' 
        ' radEspresso
        ' 
        radEspresso.AutoSize = True
        radEspresso.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        radEspresso.Location = New Point(161, 48)
        radEspresso.Name = "radEspresso"
        radEspresso.Size = New Size(111, 25)
        radEspresso.TabIndex = 3
        radEspresso.TabStop = True
        radEspresso.Text = "&Espresso $3"
        radEspresso.UseVisualStyleBackColor = True
        ' 
        ' radAmericano
        ' 
        radAmericano.AutoSize = True
        radAmericano.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        radAmericano.Location = New Point(25, 139)
        radAmericano.Name = "radAmericano"
        radAmericano.Size = New Size(125, 25)
        radAmericano.TabIndex = 2
        radAmericano.TabStop = True
        radAmericano.Text = "&Americano $3"
        radAmericano.UseVisualStyleBackColor = True
        ' 
        ' radCappucino
        ' 
        radCappucino.AutoSize = True
        radCappucino.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        radCappucino.Location = New Point(25, 92)
        radCappucino.Name = "radCappucino"
        radCappucino.Size = New Size(124, 25)
        radCappucino.TabIndex = 1
        radCappucino.TabStop = True
        radCappucino.Text = "&Cappucino $3"
        radCappucino.UseVisualStyleBackColor = True
        ' 
        ' radBlack
        ' 
        radBlack.AutoSize = True
        radBlack.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        radBlack.Location = New Point(25, 48)
        radBlack.Name = "radBlack"
        radBlack.Size = New Size(135, 25)
        radBlack.TabIndex = 0
        radBlack.TabStop = True
        radBlack.Text = "&Black Coffee $3"
        radBlack.UseVisualStyleBackColor = True
        ' 
        ' grpToppings
        ' 
        grpToppings.BackColor = Color.Sienna
        grpToppings.Controls.Add(chkWhipCream)
        grpToppings.Controls.Add(chkCaramel)
        grpToppings.Controls.Add(chkChocolate)
        grpToppings.Controls.Add(chkSprinkles)
        grpToppings.Location = New Point(479, 69)
        grpToppings.Name = "grpToppings"
        grpToppings.Size = New Size(201, 192)
        grpToppings.TabIndex = 1
        grpToppings.TabStop = False
        grpToppings.Text = "Toppings"
        ' 
        ' chkWhipCream
        ' 
        chkWhipCream.AutoSize = True
        chkWhipCream.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chkWhipCream.Location = New Point(40, 140)
        chkWhipCream.Name = "chkWhipCream"
        chkWhipCream.Size = New Size(159, 25)
        chkWhipCream.TabIndex = 3
        chkWhipCream.Text = "&Whip Cream $0.50"
        chkWhipCream.UseVisualStyleBackColor = True
        ' 
        ' chkCaramel
        ' 
        chkCaramel.AutoSize = True
        chkCaramel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chkCaramel.Location = New Point(40, 105)
        chkCaramel.Name = "chkCaramel"
        chkCaramel.Size = New Size(130, 25)
        chkCaramel.TabIndex = 2
        chkCaramel.Text = "C&aramel $0.50"
        chkCaramel.UseVisualStyleBackColor = True
        ' 
        ' chkChocolate
        ' 
        chkChocolate.AutoSize = True
        chkChocolate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chkChocolate.Location = New Point(40, 68)
        chkChocolate.Name = "chkChocolate"
        chkChocolate.Size = New Size(141, 25)
        chkChocolate.TabIndex = 1
        chkChocolate.Text = "&Chocolate $0.50"
        chkChocolate.UseVisualStyleBackColor = True
        ' 
        ' chkSprinkles
        ' 
        chkSprinkles.AutoSize = True
        chkSprinkles.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chkSprinkles.Location = New Point(40, 33)
        chkSprinkles.Name = "chkSprinkles"
        chkSprinkles.Size = New Size(136, 25)
        chkSprinkles.TabIndex = 0
        chkSprinkles.Text = "&Sprinkles $0.50"
        chkSprinkles.UseVisualStyleBackColor = True
        ' 
        ' chkFood
        ' 
        chkFood.BackColor = Color.Sienna
        chkFood.Controls.Add(chkDonut)
        chkFood.Controls.Add(chkCakePop)
        chkFood.Controls.Add(chkBagel)
        chkFood.Controls.Add(chkCroissant)
        chkFood.Location = New Point(12, 292)
        chkFood.Name = "chkFood"
        chkFood.Size = New Size(352, 137)
        chkFood.TabIndex = 2
        chkFood.TabStop = False
        chkFood.Text = "Food"
        ' 
        ' chkDonut
        ' 
        chkDonut.AutoSize = True
        chkDonut.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        chkDonut.Location = New Point(206, 89)
        chkDonut.Name = "chkDonut"
        chkDonut.Size = New Size(113, 32)
        chkDonut.TabIndex = 3
        chkDonut.Text = "&Donut $4"
        chkDonut.UseVisualStyleBackColor = True
        ' 
        ' chkCakePop
        ' 
        chkCakePop.AutoSize = True
        chkCakePop.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        chkCakePop.Location = New Point(206, 38)
        chkCakePop.Name = "chkCakePop"
        chkCakePop.Size = New Size(139, 32)
        chkCakePop.TabIndex = 2
        chkCakePop.Text = "Cake &Pop $4"
        chkCakePop.UseVisualStyleBackColor = True
        ' 
        ' chkBagel
        ' 
        chkBagel.AutoSize = True
        chkBagel.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        chkBagel.Location = New Point(32, 89)
        chkBagel.Name = "chkBagel"
        chkBagel.Size = New Size(106, 32)
        chkBagel.TabIndex = 1
        chkBagel.Text = "&Bagel $4"
        chkBagel.UseVisualStyleBackColor = True
        ' 
        ' chkCroissant
        ' 
        chkCroissant.AutoSize = True
        chkCroissant.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        chkCroissant.Location = New Point(32, 38)
        chkCroissant.Name = "chkCroissant"
        chkCroissant.Size = New Size(138, 32)
        chkCroissant.TabIndex = 0
        chkCroissant.Text = "&Croissant $4"
        chkCroissant.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Sienna
        Label4.Font = New Font("Showcard Gothic", 39F, FontStyle.Underline, GraphicsUnit.Point)
        Label4.Location = New Point(309, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(269, 57)
        Label4.TabIndex = 4
        Label4.Text = "Java Jive"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.BackColor = Color.Sienna
        lblTime.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblTime.Location = New Point(12, 30)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(47, 21)
        lblTime.TabIndex = 5
        lblTime.Text = "Time:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Sienna
        lblDate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDate.ForeColor = Color.Black
        lblDate.Location = New Point(12, 9)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(45, 21)
        lblDate.TabIndex = 6
        lblDate.Text = "Date:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.Sienna
        btnCalculate.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalculate.Location = New Point(44, 459)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(142, 68)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Sienna
        btnClear.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(372, 459)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(142, 68)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Sienna
        btnExit.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnExit.Location = New Point(689, 459)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(142, 68)
        btnExit.TabIndex = 9
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblDateData
        ' 
        lblDateData.BackColor = Color.Sienna
        lblDateData.BorderStyle = BorderStyle.FixedSingle
        lblDateData.Location = New Point(77, 9)
        lblDateData.Name = "lblDateData"
        lblDateData.Size = New Size(100, 21)
        lblDateData.TabIndex = 10
        ' 
        ' picBlack
        ' 
        picBlack.BackColor = Color.Sienna
        picBlack.Image = CType(resources.GetObject("picBlack.Image"), Image)
        picBlack.Location = New Point(326, 88)
        picBlack.Name = "picBlack"
        picBlack.Size = New Size(142, 147)
        picBlack.SizeMode = PictureBoxSizeMode.Zoom
        picBlack.TabIndex = 12
        picBlack.TabStop = False
        picBlack.Visible = False
        ' 
        ' picCappucino
        ' 
        picCappucino.BackColor = Color.Sienna
        picCappucino.Image = CType(resources.GetObject("picCappucino.Image"), Image)
        picCappucino.InitialImage = CType(resources.GetObject("picCappucino.InitialImage"), Image)
        picCappucino.Location = New Point(326, 87)
        picCappucino.Name = "picCappucino"
        picCappucino.Size = New Size(142, 147)
        picCappucino.SizeMode = PictureBoxSizeMode.StretchImage
        picCappucino.TabIndex = 13
        picCappucino.TabStop = False
        picCappucino.Visible = False
        ' 
        ' picAmericano
        ' 
        picAmericano.BackColor = Color.Sienna
        picAmericano.Image = CType(resources.GetObject("picAmericano.Image"), Image)
        picAmericano.Location = New Point(326, 87)
        picAmericano.Name = "picAmericano"
        picAmericano.Size = New Size(142, 147)
        picAmericano.SizeMode = PictureBoxSizeMode.Zoom
        picAmericano.TabIndex = 15
        picAmericano.TabStop = False
        picAmericano.Visible = False
        ' 
        ' picEspresso
        ' 
        picEspresso.BackColor = Color.Sienna
        picEspresso.Image = CType(resources.GetObject("picEspresso.Image"), Image)
        picEspresso.Location = New Point(326, 88)
        picEspresso.Name = "picEspresso"
        picEspresso.Size = New Size(142, 147)
        picEspresso.SizeMode = PictureBoxSizeMode.Zoom
        picEspresso.TabIndex = 16
        picEspresso.TabStop = False
        picEspresso.Visible = False
        ' 
        ' picIcedCoffee
        ' 
        picIcedCoffee.BackColor = Color.Sienna
        picIcedCoffee.Image = CType(resources.GetObject("picIcedCoffee.Image"), Image)
        picIcedCoffee.Location = New Point(326, 87)
        picIcedCoffee.Name = "picIcedCoffee"
        picIcedCoffee.Size = New Size(142, 147)
        picIcedCoffee.SizeMode = PictureBoxSizeMode.Zoom
        picIcedCoffee.TabIndex = 17
        picIcedCoffee.TabStop = False
        picIcedCoffee.Visible = False
        ' 
        ' picCroissant
        ' 
        picCroissant.BackColor = Color.Sienna
        picCroissant.Image = CType(resources.GetObject("picCroissant.Image"), Image)
        picCroissant.Location = New Point(372, 320)
        picCroissant.Name = "picCroissant"
        picCroissant.Size = New Size(99, 109)
        picCroissant.SizeMode = PictureBoxSizeMode.Zoom
        picCroissant.TabIndex = 18
        picCroissant.TabStop = False
        picCroissant.Visible = False
        ' 
        ' picLatte
        ' 
        picLatte.BackColor = Color.Sienna
        picLatte.Image = CType(resources.GetObject("picLatte.Image"), Image)
        picLatte.Location = New Point(326, 87)
        picLatte.Name = "picLatte"
        picLatte.Size = New Size(142, 147)
        picLatte.SizeMode = PictureBoxSizeMode.Zoom
        picLatte.TabIndex = 19
        picLatte.TabStop = False
        picLatte.Visible = False
        ' 
        ' PicSprinkles
        ' 
        PicSprinkles.BackColor = Color.Sienna
        PicSprinkles.Image = CType(resources.GetObject("PicSprinkles.Image"), Image)
        PicSprinkles.Location = New Point(698, 86)
        PicSprinkles.Name = "PicSprinkles"
        PicSprinkles.Size = New Size(85, 76)
        PicSprinkles.SizeMode = PictureBoxSizeMode.StretchImage
        PicSprinkles.TabIndex = 20
        PicSprinkles.TabStop = False
        PicSprinkles.Visible = False
        ' 
        ' picChocolate
        ' 
        picChocolate.BackColor = Color.Sienna
        picChocolate.Image = CType(resources.GetObject("picChocolate.Image"), Image)
        picChocolate.Location = New Point(789, 86)
        picChocolate.Name = "picChocolate"
        picChocolate.Size = New Size(85, 76)
        picChocolate.SizeMode = PictureBoxSizeMode.Zoom
        picChocolate.TabIndex = 21
        picChocolate.TabStop = False
        picChocolate.Visible = False
        ' 
        ' picCaramel
        ' 
        picCaramel.BackColor = Color.Sienna
        picCaramel.Image = CType(resources.GetObject("picCaramel.Image"), Image)
        picCaramel.Location = New Point(698, 174)
        picCaramel.Name = "picCaramel"
        picCaramel.Size = New Size(85, 76)
        picCaramel.SizeMode = PictureBoxSizeMode.Zoom
        picCaramel.TabIndex = 22
        picCaramel.TabStop = False
        picCaramel.Visible = False
        ' 
        ' picWhipCream
        ' 
        picWhipCream.BackColor = Color.Sienna
        picWhipCream.Image = CType(resources.GetObject("picWhipCream.Image"), Image)
        picWhipCream.Location = New Point(790, 174)
        picWhipCream.Name = "picWhipCream"
        picWhipCream.Size = New Size(85, 76)
        picWhipCream.SizeMode = PictureBoxSizeMode.Zoom
        picWhipCream.TabIndex = 23
        picWhipCream.TabStop = False
        picWhipCream.Visible = False
        ' 
        ' picBagel
        ' 
        picBagel.BackColor = Color.Sienna
        picBagel.Image = CType(resources.GetObject("picBagel.Image"), Image)
        picBagel.Location = New Point(490, 320)
        picBagel.Name = "picBagel"
        picBagel.Size = New Size(99, 109)
        picBagel.SizeMode = PictureBoxSizeMode.Zoom
        picBagel.TabIndex = 24
        picBagel.TabStop = False
        picBagel.Visible = False
        ' 
        ' picCakePop
        ' 
        picCakePop.BackColor = Color.Sienna
        picCakePop.Image = CType(resources.GetObject("picCakePop.Image"), Image)
        picCakePop.Location = New Point(617, 320)
        picCakePop.Name = "picCakePop"
        picCakePop.Size = New Size(99, 109)
        picCakePop.SizeMode = PictureBoxSizeMode.Zoom
        picCakePop.TabIndex = 25
        picCakePop.TabStop = False
        picCakePop.Visible = False
        ' 
        ' picDonut
        ' 
        picDonut.BackColor = Color.Sienna
        picDonut.Image = CType(resources.GetObject("picDonut.Image"), Image)
        picDonut.Location = New Point(751, 320)
        picDonut.Name = "picDonut"
        picDonut.Size = New Size(99, 109)
        picDonut.SizeMode = PictureBoxSizeMode.Zoom
        picDonut.TabIndex = 26
        picDonut.TabStop = False
        picDonut.Visible = False
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(608, 33)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(0, 15)
        lblSubtotal.TabIndex = 27
        ' 
        ' lblTax
        ' 
        lblTax.AutoSize = True
        lblTax.Location = New Point(698, 35)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(0, 15)
        lblTax.TabIndex = 28
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(799, 35)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(0, 15)
        lblTotal.TabIndex = 29
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' lblTimeData
        ' 
        lblTimeData.BackColor = Color.Sienna
        lblTimeData.BorderStyle = BorderStyle.FixedSingle
        lblTimeData.Location = New Point(77, 34)
        lblTimeData.Name = "lblTimeData"
        lblTimeData.Size = New Size(100, 21)
        lblTimeData.TabIndex = 11
        ' 
        ' JavaJive
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download
        ClientSize = New Size(887, 557)
        Controls.Add(lblTotal)
        Controls.Add(lblTax)
        Controls.Add(lblSubtotal)
        Controls.Add(picDonut)
        Controls.Add(picCakePop)
        Controls.Add(picBagel)
        Controls.Add(picWhipCream)
        Controls.Add(picCaramel)
        Controls.Add(picChocolate)
        Controls.Add(PicSprinkles)
        Controls.Add(picLatte)
        Controls.Add(picCroissant)
        Controls.Add(picIcedCoffee)
        Controls.Add(picEspresso)
        Controls.Add(picAmericano)
        Controls.Add(picBlack)
        Controls.Add(lblTimeData)
        Controls.Add(picCappucino)
        Controls.Add(lblDateData)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(lblDate)
        Controls.Add(lblTime)
        Controls.Add(Label4)
        Controls.Add(chkFood)
        Controls.Add(grpToppings)
        Controls.Add(grpCoffee)
        Name = "JavaJive"
        Text = "Java Jive"
        grpCoffee.ResumeLayout(False)
        grpCoffee.PerformLayout()
        grpToppings.ResumeLayout(False)
        grpToppings.PerformLayout()
        chkFood.ResumeLayout(False)
        chkFood.PerformLayout()
        CType(picBlack, ComponentModel.ISupportInitialize).EndInit()
        CType(picCappucino, ComponentModel.ISupportInitialize).EndInit()
        CType(picAmericano, ComponentModel.ISupportInitialize).EndInit()
        CType(picEspresso, ComponentModel.ISupportInitialize).EndInit()
        CType(picIcedCoffee, ComponentModel.ISupportInitialize).EndInit()
        CType(picCroissant, ComponentModel.ISupportInitialize).EndInit()
        CType(picLatte, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSprinkles, ComponentModel.ISupportInitialize).EndInit()
        CType(picChocolate, ComponentModel.ISupportInitialize).EndInit()
        CType(picCaramel, ComponentModel.ISupportInitialize).EndInit()
        CType(picWhipCream, ComponentModel.ISupportInitialize).EndInit()
        CType(picBagel, ComponentModel.ISupportInitialize).EndInit()
        CType(picCakePop, ComponentModel.ISupportInitialize).EndInit()
        CType(picDonut, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpCoffee As GroupBox
    Friend WithEvents grpToppings As GroupBox
    Friend WithEvents chkFood As GroupBox
    Friend WithEvents radLatte As RadioButton
    Friend WithEvents radIced As RadioButton
    Friend WithEvents radEspresso As RadioButton
    Friend WithEvents radAmericano As RadioButton
    Friend WithEvents radCappucino As RadioButton
    Friend WithEvents radBlack As RadioButton
    Friend WithEvents chkWhipCream As CheckBox
    Friend WithEvents chkCaramel As CheckBox
    Friend WithEvents chkChocolate As CheckBox
    Friend WithEvents chkSprinkles As CheckBox
    Friend WithEvents chkDonut As CheckBox
    Friend WithEvents chkCakePop As CheckBox
    Friend WithEvents chkBagel As CheckBox
    Friend WithEvents chkCroissant As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDateData As Label
    Friend WithEvents picBlack As PictureBox
    Friend WithEvents picCappucino As PictureBox
    Friend WithEvents picAmericano As PictureBox
    Friend WithEvents picEspresso As PictureBox
    Friend WithEvents picIcedCoffee As PictureBox
    Friend WithEvents picCroissant As PictureBox
    Friend WithEvents picLatte As PictureBox
    Friend WithEvents PicSprinkles As PictureBox
    Friend WithEvents picChocolate As PictureBox
    Friend WithEvents picCaramel As PictureBox
    Friend WithEvents picWhipCream As PictureBox
    Friend WithEvents picBagel As PictureBox
    Friend WithEvents picCakePop As PictureBox
    Friend WithEvents picDonut As PictureBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTimeData As Label
End Class
