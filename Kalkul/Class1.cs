using System;
namespace ClassLibrary2
{
    public class Radical
    {
        private string a;
        private string b;
        public Radical(string a, string b)
        {
            this.a = a;
            this.b = b;
        }
        public string getRad()
        {
            if (a.Trim() != "")
            {
                if (Int32.Parse(a) > 0)
                { return "" + (Math.Sqrt(Int32.Parse(a))); }
                else { return "ЧИСЛО ОТРИЦАТЕТЕЛЬНОЕ!!!"; }
            }
            if (b.Trim() != "")
            {
                if (Int32.Parse(b) > 0)
                { return "" + (Math.Sqrt(Int32.Parse(b))); }
                else { return "ЧИСЛО ОТРИЦАТЕТЕЛЬНОЕ!!!"; }
            }
            else return "";
        }
    }
}
