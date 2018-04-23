using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;

namespace CustomEditors
{
    public class MyPopupColorEditForm : PopupColorEditForm
    {
        public MyPopupColorEditForm(ColorEdit ownerEdit) : base(ownerEdit) { }
        protected override ColorListBox CreateColorListBox()
        {
            return new MyColorListBox();
        }
    }
}
