using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWCServer.Integracao
{
    class AlignString
    {
        static public string Align(bool center, string s, int width)
        {
            int leftPadding = 0;
            int rightPadding = 0;

            if (s != null)
            {

                if (s.Length >= width)
                {
                    return s = s.Substring(0, width); //concatenated string;
                }
            }
            else
                s = "";

            if (center)
            {
                leftPadding = (width - s.Length) / 2;
                rightPadding = width - s.Length - leftPadding;
            }
            else
            {
                leftPadding = (width - s.Length);
            }

            return new string(' ', leftPadding) + s + new string(' ', rightPadding);
        }
    }
}
