using System.Text;

namespace StringBuilder1
{
    class Replace
    {
        public string txt = "LENOVO";

        public string Remplacer(string txt)
        {
            StringBuilder strB = new StringBuilder(txt, txt.Length);
            strB.Replace("L", "1");
            strB.Replace("E", "3");
            strB.Replace("N", "/\\/");
            strB.Replace("O", "0");
            strB.Replace("V", "\\/");
            return strB.ToString();
        }


    }
}
