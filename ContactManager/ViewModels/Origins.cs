using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactManager.Model
{
    public static class Origins
    {
        private static readonly List<string> originList;

        static Origins()
        {
            originList = new List<string>(6);

            originList.Add("BD");
            originList.Add("Morse");
            originList.Add("List");
            originList.Add("Learned");
            originList.Add("Guide");
            originList.Add("Guess");
        }

        public static IList<string> GetList()
        {
            return originList;
        }
    }
}
