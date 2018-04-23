using System;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace CustomEditors
{
    [UserRepositoryItem("Register")]
    public class RepositoryItemMyColorEdit : RepositoryItemColorEdit
    {
        static RepositoryItemMyColorEdit()
        {
            Register();
        }
        public RepositoryItemMyColorEdit() { }

        internal const string EditorName = "MyColorEdit";

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyColorEdit),
                typeof(RepositoryItemMyColorEdit), typeof(DevExpress.XtraEditors.ViewInfo.ColorEditViewInfo),
                new DevExpress.XtraEditors.Drawing.ColorEditPainter(), true, null));
        }
        public override string EditorTypeName
        {
            get { return EditorName; }
        }

        protected override string GetColorDisplayText(System.Drawing.Color editValue)
        {
            return ColorLocalizer.GetLocalizedColorName(editValue);
        }
    }
}
