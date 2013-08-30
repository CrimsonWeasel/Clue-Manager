using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClueManager.Domain
{
    public class Clue //: Notifier 
    {
        public Clue()
        {
            Id = Guid.Empty;
            Answers = new List<Answer>();
        }

        public int? ClueId { get; set; }

        public string Text { get; set; }

        public List<Answer> Answers { get; set; }

        public DateTime DateEntered { get; set; }

        public Guid Id { get; set; }
    }
}