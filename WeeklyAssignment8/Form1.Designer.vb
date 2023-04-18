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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.cbMonths = New System.Windows.Forms.ComboBox()
        Me.lblMonthSavings = New System.Windows.Forms.Label()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.lblAvgSavings = New System.Windows.Forms.Label()
        Me.lblMostSavings = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(430, 107)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(289, 107)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Smart Home Electric Savings"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbMonths
        '
        Me.cbMonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonths.FormattingEnabled = True
        Me.cbMonths.Location = New System.Drawing.Point(461, 227)
        Me.cbMonths.Name = "cbMonths"
        Me.cbMonths.Size = New System.Drawing.Size(215, 32)
        Me.cbMonths.TabIndex = 1
        '
        'lblMonthSavings
        '
        Me.lblMonthSavings.AutoSize = True
        Me.lblMonthSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthSavings.Location = New System.Drawing.Point(104, 352)
        Me.lblMonthSavings.Name = "lblMonthSavings"
        Me.lblMonthSavings.Size = New System.Drawing.Size(122, 24)
        Me.lblMonthSavings.TabIndex = 2
        Me.lblMonthSavings.Text = "Placeholder"
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStatistics.Location = New System.Drawing.Point(294, 412)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(191, 38)
        Me.btnStatistics.TabIndex = 3
        Me.btnStatistics.Text = "Display Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'lblAvgSavings
        '
        Me.lblAvgSavings.AutoSize = True
        Me.lblAvgSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgSavings.Location = New System.Drawing.Point(104, 484)
        Me.lblAvgSavings.Name = "lblAvgSavings"
        Me.lblAvgSavings.Size = New System.Drawing.Size(122, 24)
        Me.lblAvgSavings.TabIndex = 4
        Me.lblAvgSavings.Text = "Placeholder"
        '
        'lblMostSavings
        '
        Me.lblMostSavings.AutoSize = True
        Me.lblMostSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostSavings.Location = New System.Drawing.Point(104, 527)
        Me.lblMostSavings.Name = "lblMostSavings"
        Me.lblMostSavings.Size = New System.Drawing.Size(122, 24)
        Me.lblMostSavings.TabIndex = 5
        Me.lblMostSavings.Text = "Placeholder"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(374, 260)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(800, 606)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblMostSavings)
        Me.Controls.Add(Me.lblAvgSavings)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.lblMonthSavings)
        Me.Controls.Add(Me.cbMonths)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents cbMonths As ComboBox
    Friend WithEvents lblMonthSavings As Label
    Friend WithEvents btnStatistics As Button
    Friend WithEvents lblAvgSavings As Label
    Friend WithEvents lblMostSavings As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
