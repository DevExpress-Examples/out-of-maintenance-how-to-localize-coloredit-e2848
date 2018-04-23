Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Popup

Namespace CustomEditors
	Public Class MyColorListBox
		Inherits ColorListBox
		Protected Overrides Function GetColorName(ByVal color As System.Drawing.Color) As String
			Return ColorLocalizer.GetLocalizedColorName(color)
		End Function
	End Class
End Namespace
