<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRental
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
        Me.components = New System.ComponentModel.Container()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.BeginningOdometerReadingTextBox = New System.Windows.Forms.TextBox()
        Me.BeginningOdometerReadingLabel = New System.Windows.Forms.Label()
        Me.EndingOdometerReadingTextBox = New System.Windows.Forms.TextBox()
        Me.EndingOdometerReadingLabel = New System.Windows.Forms.Label()
        Me.NumberOfDaysTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfDaysLabel = New System.Windows.Forms.Label()
        Me.MIilesOrKilometersGroupBox = New System.Windows.Forms.GroupBox()
        Me.KilomtersRadioButton = New System.Windows.Forms.RadioButton()
        Me.MilesRadioButton = New System.Windows.Forms.RadioButton()
        Me.DiscountsGroupBox = New System.Windows.Forms.GroupBox()
        Me.SeniorCitizenDiscountCheckBox = New System.Windows.Forms.CheckBox()
        Me.AAAMemberDiscountCheckBox = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DistanceDrivenLabel = New System.Windows.Forms.Label()
        Me.DistanceDrivenTextBox = New System.Windows.Forms.TextBox()
        Me.MilageChargeTextBox = New System.Windows.Forms.TextBox()
        Me.MileageChargeLabel = New System.Windows.Forms.Label()
        Me.DayChargeTextBox = New System.Windows.Forms.TextBox()
        Me.DayChargeLabel = New System.Windows.Forms.Label()
        Me.MinusDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.MinusDiscountLabel = New System.Windows.Forms.Label()
        Me.YouOweTextBox = New System.Windows.Forms.TextBox()
        Me.YouOwnLabel = New System.Windows.Forms.Label()
        Me.MIilesOrKilometersGroupBox.SuspendLayout()
        Me.DiscountsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(66, 548)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(127, 63)
        Me.CalculateButton.TabIndex = 0
        Me.CalculateButton.Text = "Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculates  price of car sales")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(238, 548)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(127, 63)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Resets form to default")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(402, 548)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(127, 63)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "&Summary"
        Me.ToolTip1.SetToolTip(Me.SummaryButton, "Displays a summary of all past sales and clears the text boxes")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(574, 548)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(127, 63)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exits the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.Location = New System.Drawing.Point(56, 42)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(124, 20)
        Me.CustomerNameLabel.TabIndex = 4
        Me.CustomerNameLabel.Text = "Customer Name"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(332, 36)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CustomerNameTextBox.TabIndex = 5
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(332, 79)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 26)
        Me.AddressTextBox.TabIndex = 7
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(56, 79)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(68, 20)
        Me.AddressLabel.TabIndex = 6
        Me.AddressLabel.Text = "Address"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(332, 121)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CityTextBox.TabIndex = 9
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(56, 121)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(39, 20)
        Me.CityLabel.TabIndex = 8
        Me.CityLabel.Text = "City "
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(332, 165)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 26)
        Me.StateTextBox.TabIndex = 11
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(56, 159)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(48, 20)
        Me.StateLabel.TabIndex = 10
        Me.StateLabel.Text = "State"
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(332, 203)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ZipCodeTextBox.TabIndex = 13
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(56, 203)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(73, 20)
        Me.ZipCodeLabel.TabIndex = 12
        Me.ZipCodeLabel.Text = "Zip Code"
        '
        'BeginningOdometerReadingTextBox
        '
        Me.BeginningOdometerReadingTextBox.Location = New System.Drawing.Point(332, 246)
        Me.BeginningOdometerReadingTextBox.Name = "BeginningOdometerReadingTextBox"
        Me.BeginningOdometerReadingTextBox.Size = New System.Drawing.Size(100, 26)
        Me.BeginningOdometerReadingTextBox.TabIndex = 15
        '
        'BeginningOdometerReadingLabel
        '
        Me.BeginningOdometerReadingLabel.AutoSize = True
        Me.BeginningOdometerReadingLabel.Location = New System.Drawing.Point(56, 240)
        Me.BeginningOdometerReadingLabel.Name = "BeginningOdometerReadingLabel"
        Me.BeginningOdometerReadingLabel.Size = New System.Drawing.Size(219, 20)
        Me.BeginningOdometerReadingLabel.TabIndex = 14
        Me.BeginningOdometerReadingLabel.Text = "Beginning Odometer Reading"
        '
        'EndingOdometerReadingTextBox
        '
        Me.EndingOdometerReadingTextBox.Location = New System.Drawing.Point(332, 288)
        Me.EndingOdometerReadingTextBox.Name = "EndingOdometerReadingTextBox"
        Me.EndingOdometerReadingTextBox.Size = New System.Drawing.Size(100, 26)
        Me.EndingOdometerReadingTextBox.TabIndex = 17
        '
        'EndingOdometerReadingLabel
        '
        Me.EndingOdometerReadingLabel.AutoSize = True
        Me.EndingOdometerReadingLabel.Location = New System.Drawing.Point(56, 282)
        Me.EndingOdometerReadingLabel.Name = "EndingOdometerReadingLabel"
        Me.EndingOdometerReadingLabel.Size = New System.Drawing.Size(198, 20)
        Me.EndingOdometerReadingLabel.TabIndex = 16
        Me.EndingOdometerReadingLabel.Text = "Ending Odometer Reading"
        '
        'NumberOfDaysTextBox
        '
        Me.NumberOfDaysTextBox.Location = New System.Drawing.Point(332, 331)
        Me.NumberOfDaysTextBox.Name = "NumberOfDaysTextBox"
        Me.NumberOfDaysTextBox.Size = New System.Drawing.Size(100, 26)
        Me.NumberOfDaysTextBox.TabIndex = 19
        '
        'NumberOfDaysLabel
        '
        Me.NumberOfDaysLabel.AutoSize = True
        Me.NumberOfDaysLabel.Location = New System.Drawing.Point(56, 328)
        Me.NumberOfDaysLabel.Name = "NumberOfDaysLabel"
        Me.NumberOfDaysLabel.Size = New System.Drawing.Size(123, 20)
        Me.NumberOfDaysLabel.TabIndex = 18
        Me.NumberOfDaysLabel.Text = "Number of Days"
        '
        'MIilesOrKilometersGroupBox
        '
        Me.MIilesOrKilometersGroupBox.Controls.Add(Me.KilomtersRadioButton)
        Me.MIilesOrKilometersGroupBox.Controls.Add(Me.MilesRadioButton)
        Me.MIilesOrKilometersGroupBox.Location = New System.Drawing.Point(60, 380)
        Me.MIilesOrKilometersGroupBox.Name = "MIilesOrKilometersGroupBox"
        Me.MIilesOrKilometersGroupBox.Size = New System.Drawing.Size(305, 121)
        Me.MIilesOrKilometersGroupBox.TabIndex = 20
        Me.MIilesOrKilometersGroupBox.TabStop = False
        Me.MIilesOrKilometersGroupBox.Text = "Is Odometer In Miles Or Kilometers?"
        Me.ToolTip1.SetToolTip(Me.MIilesOrKilometersGroupBox, "Select setting of the vehicles odometer")
        '
        'KilomtersRadioButton
        '
        Me.KilomtersRadioButton.AutoSize = True
        Me.KilomtersRadioButton.Location = New System.Drawing.Point(50, 80)
        Me.KilomtersRadioButton.Name = "KilomtersRadioButton"
        Me.KilomtersRadioButton.Size = New System.Drawing.Size(108, 24)
        Me.KilomtersRadioButton.TabIndex = 1
        Me.KilomtersRadioButton.TabStop = True
        Me.KilomtersRadioButton.Text = "Kilometers"
        Me.KilomtersRadioButton.UseVisualStyleBackColor = True
        '
        'MilesRadioButton
        '
        Me.MilesRadioButton.AutoSize = True
        Me.MilesRadioButton.Location = New System.Drawing.Point(50, 39)
        Me.MilesRadioButton.Name = "MilesRadioButton"
        Me.MilesRadioButton.Size = New System.Drawing.Size(70, 24)
        Me.MilesRadioButton.TabIndex = 0
        Me.MilesRadioButton.TabStop = True
        Me.MilesRadioButton.Text = "Miles"
        Me.MilesRadioButton.UseVisualStyleBackColor = True
        '
        'DiscountsGroupBox
        '
        Me.DiscountsGroupBox.Controls.Add(Me.SeniorCitizenDiscountCheckBox)
        Me.DiscountsGroupBox.Controls.Add(Me.AAAMemberDiscountCheckBox)
        Me.DiscountsGroupBox.Location = New System.Drawing.Point(437, 380)
        Me.DiscountsGroupBox.Name = "DiscountsGroupBox"
        Me.DiscountsGroupBox.Size = New System.Drawing.Size(283, 137)
        Me.DiscountsGroupBox.TabIndex = 21
        Me.DiscountsGroupBox.TabStop = False
        Me.DiscountsGroupBox.Text = "Enter Any Discounts"
        Me.ToolTip1.SetToolTip(Me.DiscountsGroupBox, "Select discounts that apply")
        '
        'SeniorCitizenDiscountCheckBox
        '
        Me.SeniorCitizenDiscountCheckBox.AutoSize = True
        Me.SeniorCitizenDiscountCheckBox.Location = New System.Drawing.Point(64, 97)
        Me.SeniorCitizenDiscountCheckBox.Name = "SeniorCitizenDiscountCheckBox"
        Me.SeniorCitizenDiscountCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.SeniorCitizenDiscountCheckBox.TabIndex = 1
        Me.SeniorCitizenDiscountCheckBox.Text = "Senior Citizen Discount"
        Me.SeniorCitizenDiscountCheckBox.UseVisualStyleBackColor = True
        '
        'AAAMemberDiscountCheckBox
        '
        Me.AAAMemberDiscountCheckBox.AutoSize = True
        Me.AAAMemberDiscountCheckBox.Location = New System.Drawing.Point(64, 40)
        Me.AAAMemberDiscountCheckBox.Name = "AAAMemberDiscountCheckBox"
        Me.AAAMemberDiscountCheckBox.Size = New System.Drawing.Size(197, 24)
        Me.AAAMemberDiscountCheckBox.TabIndex = 0
        Me.AAAMemberDiscountCheckBox.Text = "AAA Member Discount"
        Me.AAAMemberDiscountCheckBox.UseVisualStyleBackColor = True
        '
        'DistanceDrivenLabel
        '
        Me.DistanceDrivenLabel.AutoSize = True
        Me.DistanceDrivenLabel.Location = New System.Drawing.Point(497, 39)
        Me.DistanceDrivenLabel.Name = "DistanceDrivenLabel"
        Me.DistanceDrivenLabel.Size = New System.Drawing.Size(179, 20)
        Me.DistanceDrivenLabel.TabIndex = 22
        Me.DistanceDrivenLabel.Text = "Distance Driven In Miles"
        '
        'DistanceDrivenTextBox
        '
        Me.DistanceDrivenTextBox.Location = New System.Drawing.Point(688, 33)
        Me.DistanceDrivenTextBox.Name = "DistanceDrivenTextBox"
        Me.DistanceDrivenTextBox.Size = New System.Drawing.Size(100, 26)
        Me.DistanceDrivenTextBox.TabIndex = 23
        '
        'MilageChargeTextBox
        '
        Me.MilageChargeTextBox.Location = New System.Drawing.Point(688, 79)
        Me.MilageChargeTextBox.Name = "MilageChargeTextBox"
        Me.MilageChargeTextBox.Size = New System.Drawing.Size(100, 26)
        Me.MilageChargeTextBox.TabIndex = 25
        '
        'MileageChargeLabel
        '
        Me.MileageChargeLabel.AutoSize = True
        Me.MileageChargeLabel.Location = New System.Drawing.Point(497, 85)
        Me.MileageChargeLabel.Name = "MileageChargeLabel"
        Me.MileageChargeLabel.Size = New System.Drawing.Size(120, 20)
        Me.MileageChargeLabel.TabIndex = 24
        Me.MileageChargeLabel.Text = "Mileage Charge"
        '
        'DayChargeTextBox
        '
        Me.DayChargeTextBox.Location = New System.Drawing.Point(688, 121)
        Me.DayChargeTextBox.Name = "DayChargeTextBox"
        Me.DayChargeTextBox.Size = New System.Drawing.Size(100, 26)
        Me.DayChargeTextBox.TabIndex = 27
        '
        'DayChargeLabel
        '
        Me.DayChargeLabel.AutoSize = True
        Me.DayChargeLabel.Location = New System.Drawing.Point(497, 127)
        Me.DayChargeLabel.Name = "DayChargeLabel"
        Me.DayChargeLabel.Size = New System.Drawing.Size(93, 20)
        Me.DayChargeLabel.TabIndex = 26
        Me.DayChargeLabel.Text = "Day Charge"
        '
        'MinusDiscountTextBox
        '
        Me.MinusDiscountTextBox.Location = New System.Drawing.Point(688, 165)
        Me.MinusDiscountTextBox.Name = "MinusDiscountTextBox"
        Me.MinusDiscountTextBox.Size = New System.Drawing.Size(100, 26)
        Me.MinusDiscountTextBox.TabIndex = 29
        '
        'MinusDiscountLabel
        '
        Me.MinusDiscountLabel.AutoSize = True
        Me.MinusDiscountLabel.Location = New System.Drawing.Point(497, 171)
        Me.MinusDiscountLabel.Name = "MinusDiscountLabel"
        Me.MinusDiscountLabel.Size = New System.Drawing.Size(118, 20)
        Me.MinusDiscountLabel.TabIndex = 28
        Me.MinusDiscountLabel.Text = "Minus Discount"
        '
        'YouOweTextBox
        '
        Me.YouOweTextBox.Location = New System.Drawing.Point(688, 214)
        Me.YouOweTextBox.Name = "YouOweTextBox"
        Me.YouOweTextBox.Size = New System.Drawing.Size(100, 26)
        Me.YouOweTextBox.TabIndex = 31
        '
        'YouOwnLabel
        '
        Me.YouOwnLabel.AutoSize = True
        Me.YouOwnLabel.Location = New System.Drawing.Point(497, 220)
        Me.YouOwnLabel.Name = "YouOwnLabel"
        Me.YouOwnLabel.Size = New System.Drawing.Size(74, 20)
        Me.YouOwnLabel.TabIndex = 30
        Me.YouOwnLabel.Text = "You Owe"
        '
        'CarRental
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(873, 644)
        Me.Controls.Add(Me.YouOweTextBox)
        Me.Controls.Add(Me.YouOwnLabel)
        Me.Controls.Add(Me.MinusDiscountTextBox)
        Me.Controls.Add(Me.MinusDiscountLabel)
        Me.Controls.Add(Me.DayChargeTextBox)
        Me.Controls.Add(Me.DayChargeLabel)
        Me.Controls.Add(Me.MilageChargeTextBox)
        Me.Controls.Add(Me.MileageChargeLabel)
        Me.Controls.Add(Me.DistanceDrivenTextBox)
        Me.Controls.Add(Me.DistanceDrivenLabel)
        Me.Controls.Add(Me.DiscountsGroupBox)
        Me.Controls.Add(Me.MIilesOrKilometersGroupBox)
        Me.Controls.Add(Me.NumberOfDaysTextBox)
        Me.Controls.Add(Me.NumberOfDaysLabel)
        Me.Controls.Add(Me.EndingOdometerReadingTextBox)
        Me.Controls.Add(Me.EndingOdometerReadingLabel)
        Me.Controls.Add(Me.BeginningOdometerReadingTextBox)
        Me.Controls.Add(Me.BeginningOdometerReadingLabel)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(Me.ZipCodeLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.CustomerNameLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Name = "CarRental"
        Me.Text = "Green Rental Car Company"
        Me.MIilesOrKilometersGroupBox.ResumeLayout(False)
        Me.MIilesOrKilometersGroupBox.PerformLayout()
        Me.DiscountsGroupBox.ResumeLayout(False)
        Me.DiscountsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents AddressLabel As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents BeginningOdometerReadingTextBox As TextBox
    Friend WithEvents BeginningOdometerReadingLabel As Label
    Friend WithEvents EndingOdometerReadingTextBox As TextBox
    Friend WithEvents EndingOdometerReadingLabel As Label
    Friend WithEvents NumberOfDaysTextBox As TextBox
    Friend WithEvents NumberOfDaysLabel As Label
    Friend WithEvents MIilesOrKilometersGroupBox As GroupBox
    Friend WithEvents DiscountsGroupBox As GroupBox
    Friend WithEvents KilomtersRadioButton As RadioButton
    Friend WithEvents MilesRadioButton As RadioButton
    Friend WithEvents SeniorCitizenDiscountCheckBox As CheckBox
    Friend WithEvents AAAMemberDiscountCheckBox As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DistanceDrivenLabel As Label
    Friend WithEvents DistanceDrivenTextBox As TextBox
    Friend WithEvents MilageChargeTextBox As TextBox
    Friend WithEvents MileageChargeLabel As Label
    Friend WithEvents DayChargeTextBox As TextBox
    Friend WithEvents DayChargeLabel As Label
    Friend WithEvents MinusDiscountTextBox As TextBox
    Friend WithEvents MinusDiscountLabel As Label
    Friend WithEvents YouOweTextBox As TextBox
    Friend WithEvents YouOwnLabel As Label
End Class
