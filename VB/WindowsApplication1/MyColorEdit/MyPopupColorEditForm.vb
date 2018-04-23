Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup

Namespace CustomEditors
	Public Class MyPopupColorEditForm
		Inherits PopupColorEditForm
		Public Sub New(ByVal ownerEdit As ColorEdit)
			MyBase.New(ownerEdit)
		End Sub
		Protected Overrides Function CreateColorListBox() As ColorListBox
			Return New MyColorListBox()
		End Function
	End Class
End Namespace
