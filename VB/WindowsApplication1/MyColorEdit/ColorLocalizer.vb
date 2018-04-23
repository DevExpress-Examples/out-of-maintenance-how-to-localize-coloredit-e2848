Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing



Public NotInheritable Class ColorLocalizer
	Private Shared converter As New ColorConverter()
	Private Sub New()
	End Sub
	Public Shared Function GetLocalizedColorName(ByVal color As System.Drawing.Color) As String
		Return String.Format("{0}(Translated)", converter.ConvertToString(color))
	End Function
End Class
