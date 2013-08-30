using System.Collections.Generic;

namespace ClueManager.Domain
{
    public class Origin
    {
        public int? OriginId { get; set; }

        public string Text { get; set; }

        public List<Answer> Answers { get; set; } 
    }
}
