Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository

Namespace CustomEditors
	<UserRepositoryItem("Register")> _
	Public Class RepositoryItemMyColorEdit
		Inherits RepositoryItemColorEdit
		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
		End Sub

		Friend Const EditorName As String = "MyColorEdit"

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyColorEdit), GetType(RepositoryItemMyColorEdit), GetType(DevExpress.XtraEditors.ViewInfo.ColorEditViewInfo), New DevExpress.XtraEditors.Drawing.ColorEditPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property

		Protected Overrides Function GetColorDisplayText(ByVal editValue As System.Drawing.Color) As String
			Return ColorLocalizer.GetLocalizedColorName(editValue)
		End Function
	End Class
End Namespace
