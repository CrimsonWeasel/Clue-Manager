using System;

namespace ClueManager.Domain
{
    public class Answer 
    {       
        public int? AnswerId { get; set; }

        public Clue Clue { get; set; }

        public string Text { get; set; }

        public string Explanation { get; set; }

        public Origin Origin { get; set; }

        public string Example { get; set; }

        public DateTime DateAnswerEntered { get; set; }

        public DateTime PuzzleDate { get; set; }

      
    }
}
