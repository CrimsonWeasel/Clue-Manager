using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace ContactManager.Model
{
    [Serializable]
    public class Answer : IComparable  //Notifier
    {
        private string explanation;
        private string origin;
        private string example;
        private DateTime puzzleDate;
        private DateTime dateAnswerEntered = DateTime.Today;
        private string answerText;       
        
        public Answer(string newAnswerText) {
            answerText = newAnswerText;    
        }

        public string AnswerText
        {
            get { return answerText; }
            set
            {
                answerText = value;
                if (DateAnswerEntered == null || DateAnswerEntered.Year < 1900)
                    DateAnswerEntered = DateTime.Today;
                //OnPropertyChanged("AnswerText");
            }
        }
        
        public string Explanation
        {
            get { return explanation; }
            set
            {
                explanation = value;
                //OnPropertyChanged("Explanation");
            }
        }

        public string Origin
        {
            get { return origin; }
            set
            {
                origin = value;
                //OnPropertyChanged("Origin");   //OnPropertyChanged("State"); //
            }
        }

        public string Example
        {
            get { return example; }
            set
            {
                example = value;
                //OnPropertyChanged("Example");
            }
        }
        public DateTime DateAnswerEntered
        {
            get { return dateAnswerEntered; }
            set
            {
                dateAnswerEntered = value;
                //OnPropertyChanged("DateAnswerEntered");
            }
        }

        public DateTime PuzzleDate
        {
            get { return puzzleDate; }
            set
            {
                puzzleDate = value;
                //OnPropertyChanged("PuzzleDate");
            }
        }

        public string LookupAnswer
        {
            get { return string.Format("{0}", AnswerText); }           
        }

        public override string ToString()
        {
            return LookupAnswer;
        }

        public int CompareTo(object answerCompare)
        {
            if (answerCompare == null) return 1;

            Answer otherAnswer = answerCompare as Answer;
            if (otherAnswer != null)
                return this.AnswerText.CompareTo(otherAnswer.AnswerText);
            else
                throw new ArgumentException("Object is not an Answer");
        }

      
    }
}
