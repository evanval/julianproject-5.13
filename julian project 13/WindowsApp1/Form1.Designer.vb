<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		Me.btnStart = New System.Windows.Forms.Button()
		Me.btnStop = New System.Windows.Forms.Button()
		Me.radBattingAverage = New System.Windows.Forms.RadioButton()
		Me.radExtraBaseHits = New System.Windows.Forms.RadioButton()
		Me.radSluggingPercentage = New System.Windows.Forms.RadioButton()
		Me.radHomeRunFrequency = New System.Windows.Forms.RadioButton()
		Me.SuspendLayout()
		'
		'btnStart
		'
		Me.btnStart.Location = New System.Drawing.Point(307, 181)
		Me.btnStart.Name = "btnStart"
		Me.btnStart.Size = New System.Drawing.Size(75, 23)
		Me.btnStart.TabIndex = 0
		Me.btnStart.Text = "Start"
		Me.btnStart.UseVisualStyleBackColor = True
		'
		'btnStop
		'
		Me.btnStop.Location = New System.Drawing.Point(307, 255)
		Me.btnStop.Name = "btnStop"
		Me.btnStop.Size = New System.Drawing.Size(75, 23)
		Me.btnStop.TabIndex = 1
		Me.btnStop.Text = "Stop"
		Me.btnStop.UseVisualStyleBackColor = True
		'
		'radBattingAverage
		'
		Me.radBattingAverage.AutoSize = True
		Me.radBattingAverage.Location = New System.Drawing.Point(282, 57)
		Me.radBattingAverage.Name = "radBattingAverage"
		Me.radBattingAverage.Size = New System.Drawing.Size(100, 17)
		Me.radBattingAverage.TabIndex = 2
		Me.radBattingAverage.TabStop = True
		Me.radBattingAverage.Text = "Batting average"
		Me.radBattingAverage.UseVisualStyleBackColor = True
		'
		'radExtraBaseHits
		'
		Me.radExtraBaseHits.AutoSize = True
		Me.radExtraBaseHits.Location = New System.Drawing.Point(282, 80)
		Me.radExtraBaseHits.Name = "radExtraBaseHits"
		Me.radExtraBaseHits.Size = New System.Drawing.Size(145, 17)
		Me.radExtraBaseHits.TabIndex = 3
		Me.radExtraBaseHits.TabStop = True
		Me.radExtraBaseHits.Text = "Number of extra base hits"
		Me.radExtraBaseHits.UseVisualStyleBackColor = True
		'
		'radSluggingPercentage
		'
		Me.radSluggingPercentage.AutoSize = True
		Me.radSluggingPercentage.Location = New System.Drawing.Point(282, 103)
		Me.radSluggingPercentage.Name = "radSluggingPercentage"
		Me.radSluggingPercentage.Size = New System.Drawing.Size(123, 17)
		Me.radSluggingPercentage.TabIndex = 4
		Me.radSluggingPercentage.TabStop = True
		Me.radSluggingPercentage.Text = "Slugging percentage"
		Me.radSluggingPercentage.UseVisualStyleBackColor = True
		'
		'radHomeRunFrequency
		'
		Me.radHomeRunFrequency.AutoSize = True
		Me.radHomeRunFrequency.Location = New System.Drawing.Point(282, 126)
		Me.radHomeRunFrequency.Name = "radHomeRunFrequency"
		Me.radHomeRunFrequency.Size = New System.Drawing.Size(121, 17)
		Me.radHomeRunFrequency.TabIndex = 5
		Me.radHomeRunFrequency.TabStop = True
		Me.radHomeRunFrequency.Text = "Home run frequency"
		Me.radHomeRunFrequency.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.radHomeRunFrequency)
		Me.Controls.Add(Me.radSluggingPercentage)
		Me.Controls.Add(Me.radExtraBaseHits)
		Me.Controls.Add(Me.radBattingAverage)
		Me.Controls.Add(Me.btnStop)
		Me.Controls.Add(Me.btnStart)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnStart As Button
	Friend WithEvents btnStop As Button
	Friend WithEvents radBattingAverage As RadioButton
	Friend WithEvents radExtraBaseHits As RadioButton
	Friend WithEvents radSluggingPercentage As RadioButton
	Friend WithEvents radHomeRunFrequency As RadioButton
End Class
