using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;

namespace ContactManager.Model
{
    [Serializable]
    public class Clue : Notifier 
    {
        private string clueText;
        private DateTime dateEntered = DateTime.Now;
        private ObservableCollection<Answer> answerCollectionForClue = new ObservableCollection<Answer>();
        private Guid _id = Guid.Empty;
                
        public string ClueText
        {
            get { return clueText; }
            set
            {
                clueText = value;
                OnPropertyChanged("ClueText");  
                OnPropertyChanged("LookupClue");
            }
        }

        //private void SortAnswerCollection()
        //{
        //    Answer[] answerArray = AnswerCollectionForClue.ToArray();
        //    Answer[] newArray = new Answer[answerArray.Length];
        //    Array.Sort(answerArray);
        //    ObservableCollection<Answer> newOC = new ObservableCollection<Answer>();
        //    foreach (var item in newArray)
        //    {
        //        newOC.Add(item);
        //    }

        //    AnswerCollectionForClue = newOC;
        //}

        private void SortAnswerCollection()
        {            
            Answer [] answerArray = new Answer[AnswerCollectionForClue.Count]; //= AnswerCollectionForClue.ToArray();
            answerArray = AnswerCollectionForClue.ToArray();
            //Answer[] newArray = new Answer[answerArray.Length];
            Array.Sort(answerArray);
            ObservableCollection<Answer> newOC = new ObservableCollection<Answer>();
            foreach (var item in answerArray)
            {
                newOC.Add(item);
            }

            AnswerCollectionForClue = newOC;
        }

        public ObservableCollection<Answer> AnswerCollectionForClue
        {
            get { return answerCollectionForClue; }
            set
            {
                answerCollectionForClue = value;
                OnPropertyChanged("AnswerCollectionForClue");                
            }
        }
        
        public void AddNewAnswer(string answerText)
        {
            if (AnswerCollectionForClue == null)
                AnswerCollectionForClue = new ObservableCollection<Answer>();
 	        AnswerCollectionForClue.Add(new Answer(answerText));

            SortAnswerCollection();
            
        }
        
        public DateTime DateEntered
        {
            get
            {
                if (dateEntered == null)
                    return DateTime.Now;  //This fixes the DateTime problem. Still need to clean up old dates.
                else 
                    return dateEntered; }
            set
            {
                if (dateEntered != value) //Be sure I need this
                {
                    dateEntered = value;
                    OnPropertyChanged("DateEntered");
                }
            }
        }

        public Guid Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }
        
        public string LookupClue
        {
            get { return string.Format("{0}", clueText); }
            //get { return string.Format("{0}, {1}", answer, clueText); }
        }

        public override string ToString()
        {
            return LookupClue;
        }

        public override bool Equals(object obj)
        {
            Clue other = obj as Clue;
            return other != null && other.Id == Id;
        }

    
}
}
