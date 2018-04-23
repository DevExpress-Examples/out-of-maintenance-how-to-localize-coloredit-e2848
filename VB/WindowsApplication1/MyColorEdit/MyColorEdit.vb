Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors

Namespace CustomEditors
	Public Class MyColorEdit
		Inherits ColorEdit
		Shared Sub New()
			RepositoryItemMyColorEdit.Register()
		End Sub
		Public Sub New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyColorEdit.EditorName
			End Get
		End Property

		Protected Overrides Function CreatePopupForm() As DevExpress.XtraEditors.Popup.PopupBaseForm
			Return New MyPopupColorEditForm(Me)
		End Function
	End Class
End Namespace
