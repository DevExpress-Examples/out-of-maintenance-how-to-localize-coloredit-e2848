using System;
using DevExpress.XtraEditors;

namespace CustomEditors
{
    public class MyColorEdit : ColorEdit
    {
        static MyColorEdit()
        {
            RepositoryItemMyColorEdit.Register();
        }
        public MyColorEdit() { }

        public override string EditorTypeName
        {
            get { return RepositoryItemMyColorEdit.EditorName; }
        }

        protected override DevExpress.XtraEditors.Popup.PopupBaseForm CreatePopupForm()
        {
            return new MyPopupColorEditForm(this);
        }
    }
}
