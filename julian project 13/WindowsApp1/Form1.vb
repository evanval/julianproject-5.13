Imports str = Microsoft.VisualBasic.Strings
Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
		Dim bats, hits, doubles, triples, homeruns, totalbases As Integer
		Dim battingaverage As Decimal
		Dim name As String
		name = InputBox("Enter the name of the batter.")
		bats = InputBox("Enter the number of at-bats the batter has.")
		hits = InputBox("Enter the number of hits the batter has.")
		doubles = InputBox("Enter the number of doubles the batter has.")
		triples = InputBox("Enter the number of triples the batter has.")
		homeruns = InputBox("Enter the number of homeruns the batter has.")
		' calculate the total bases for latter use in the slugging percentage.
		totalbases = (hits) + (2 * doubles) + (3 * triples) + (4 * homeruns)
		' calculate batting average
		If radBattingAverage.Checked = True Then
			battingaverage = hits / bats
			MsgBox(name & " has a batting average of " & battingaverage & ".")
			' calculate extra base hits
		ElseIf radExtraBaseHits.Checked = True Then
			Dim extrabasehits As Integer
			extrabasehits = doubles + triples + homeruns
			MsgBox(name + " has " & extrabasehits & " extra base hits.")
			' calculate slugging percentage
		ElseIf radSluggingPercentage.Checked = True Then
			Dim sluggingpercentage As Decimal
			sluggingpercentage = totalbases / bats
			MsgBox(name & " has a slugging percentage of " & sluggingpercentage & ".")
			' calculate home-run frequency
		ElseIf radHomeRunFrequency.Checked = True Then
			Dim homerunfrequency As Decimal
			homerunfrequency = bats / homeruns
			MsgBox(name & " has a home run frequency of " & homerunfrequency & ".")
		End If
	End Sub
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStop.Click
		End
	End Sub
End Class
