using System;
using DevExpress.XtraEditors.Popup;

namespace CustomEditors
{
    public class MyColorListBox : ColorListBox
    {
        protected override string GetColorName(System.Drawing.Color color)
        {
            return ColorLocalizer.GetLocalizedColorName(color);
        }
    }
}
