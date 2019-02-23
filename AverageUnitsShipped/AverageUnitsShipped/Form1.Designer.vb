<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.txtUnitsEntry = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.txtUnitsShippedDisplay = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblAverageUnits = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtUnitsEntry
        '
        Me.txtUnitsEntry.Location = New System.Drawing.Point(102, 17)
        Me.txtUnitsEntry.Name = "txtUnitsEntry"
        Me.txtUnitsEntry.Size = New System.Drawing.Size(77, 22)
        Me.txtUnitsEntry.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.txtUnitsEntry, "Please enter the amount of units shipped for the current day")
        '
        'lblUnits
        '
        Me.lblUnits.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(48, 19)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(48, 17)
        Me.lblUnits.TabIndex = 8
        Me.lblUnits.Text = "&Units: "
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDays
        '
        Me.lblDays.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDays.Location = New System.Drawing.Point(199, 16)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(70, 23)
        Me.lblDays.TabIndex = 9
        Me.lblDays.Text = "Day 1"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnitsShippedDisplay
        '
        Me.txtUnitsShippedDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnitsShippedDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUnitsShippedDisplay.Location = New System.Drawing.Point(51, 44)
        Me.txtUnitsShippedDisplay.Multiline = True
        Me.txtUnitsShippedDisplay.Name = "txtUnitsShippedDisplay"
        Me.txtUnitsShippedDisplay.ReadOnly = True
        Me.txtUnitsShippedDisplay.Size = New System.Drawing.Size(218, 200)
        Me.txtUnitsShippedDisplay.TabIndex = 10
        Me.ToolTip.SetToolTip(Me.txtUnitsShippedDisplay, "Displays the units shipped for each day, up to a week")
        '
        'btnEnter
        '
        Me.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnter.Location = New System.Drawing.Point(12, 277)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(86, 38)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip.SetToolTip(Me.btnEnter, "Adds the current value in the top text box to the units shipped")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblAverageUnits
        '
        Me.lblAverageUnits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageUnits.Location = New System.Drawing.Point(48, 247)
        Me.lblAverageUnits.Name = "lblAverageUnits"
        Me.lblAverageUnits.Size = New System.Drawing.Size(221, 27)
        Me.lblAverageUnits.TabIndex = 11
        Me.lblAverageUnits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip.SetToolTip(Me.lblAverageUnits, "Outputs the average units shipped over a week ")
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(115, 277)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(86, 38)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset"
        Me.ToolTip.SetToolTip(Me.btnReset, "Reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(215, 277)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 38)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.btnExit, "Exits the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(313, 336)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblAverageUnits)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtUnitsShippedDisplay)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtUnitsEntry)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(331, 383)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(331, 383)
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUnitsEntry As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents txtUnitsShippedDisplay As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblAverageUnits As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip As ToolTip
End Class
