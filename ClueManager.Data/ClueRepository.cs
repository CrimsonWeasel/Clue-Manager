using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ClueManager;
using ContactManager.Model;

namespace ContactManager.Model
{
    public class ClueRepository
    {
        //Create List that will be serialized to ClueManager.state.
        private List<Clue> clueStore;
        private readonly string stateFile;

        public ClueRepository()
        {
            stateFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ClueManager.state");
            Deserialize();
        }

        public void Save(Clue clue)
        {
            if (clue.Id == Guid.Empty)
                clue.Id = Guid.NewGuid();

            if (!clueStore.Contains(clue))
                clueStore.Add(clue);
            Serialize();
        }

        public void Delete(Clue clue)
        {
            clueStore.Remove(clue);
            Serialize();
        }

        public List<Clue> FindCluesByLookup(string lookupCriteria)
        {
            IEnumerable<Clue> found = from c in clueStore
                                         where c.LookupClue.StartsWith(lookupCriteria, StringComparison.OrdinalIgnoreCase)
                                         select c;
            return found.ToList();
        }

        public List<Clue> FindAnswersByLookup(string lookupCriteria)
        {
            IEnumerable<Clue> found = from c in clueStore
                                      from a in c.AnswerCollectionForClue.ToList<Answer>()  //is .ToList<Answer>() needed?
                                      where a.LookupAnswer.StartsWith(lookupCriteria, StringComparison.OrdinalIgnoreCase)
                                      select c;
            return found.ToList();
        }

        public List<Clue> FindAll()
        {
            return new List<Clue>(clueStore);
        }

        private void Serialize()
        {   
            //Save clueStore List to file
            using (FileStream stream = File.Open(stateFile, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, clueStore);                     
            }
        }

        private void Deserialize()
        {
            if (File.Exists(stateFile))
            {
                using (FileStream stream = File.Open(stateFile, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    clueStore = (List<Clue>)formatter.Deserialize(stream);
                }
            }
            else clueStore = new List<Clue>();
        }


    }
}
