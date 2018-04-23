using System;
using System.Drawing;



public static class ColorLocalizer
{
    static ColorConverter converter = new ColorConverter();
    public static string GetLocalizedColorName(System.Drawing.Color color)
    {
        return String.Format("{0}(Translated)", converter.ConvertToString(color));
    }
}
