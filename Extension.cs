using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ExtendCSharpWPF
{
    public static class Extension
    {

        //TODO: controllare il parametro stretch!!
        public static Size RealImageSize(this Image img)
        {
            double x = img.Source.Width;
            double y = img.Source.Width;
            double propY = img.ActualHeight/y;
            double propX = img.ActualWidth/x ;
            if( propY< propX)
            {
                return new Size(x * propY, y * propY);
            }
            else
            {
                return new Size(x * propX, y * propX);

            }
        }
    }
}
