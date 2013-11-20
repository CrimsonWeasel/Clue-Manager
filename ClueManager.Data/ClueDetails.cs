using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClueManager.Domain;
using System.Collections.ObjectModel;
using System.ComponentModel; //Needed for INotifyPropertyChanged

namespace ClueManager.Data
{
    public class ClueDetails //: INotifyPropertyChanged
    {
        private ClueManager.Domain.Clue _clue;  

        public ClueDetails() //New clue
        {
            Id = Guid.Empty;
            Answers = new List<Answer>();
        }

        public ClueDetails(ClueManager.Domain.Clue clue) //Existing clue
        {
            _clue = clue;
        }

        public int? ClueId { get; set; }

        public string Text { get; set; }

        public List<Answer> Answers { get; set; }

        public DateTime DateEntered { get; set; }

        public Guid Id { get; set; }

        //Added 11-20 to fix error in ClueRepository.cs:
        public string LookupClue
        {
            get { return string.Format("{0}", Text); }            
        }

        //Added 11-20 to fix error in ClueRepository.cs:
        public override string ToString()
        {
            return LookupClue;
        }

    }
}
