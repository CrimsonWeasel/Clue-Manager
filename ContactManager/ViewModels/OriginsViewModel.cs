using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace ContactManager.Model
namespace ClueManager.ViewModels
{
    public static class OriginsViewModel
    {
        private static readonly List<string> originList;

        static OriginsViewModel()
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
