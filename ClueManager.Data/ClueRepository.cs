using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using ClueManager.Domain;
using System.Collections.ObjectModel;

//using ContactManager.Model;

namespace ClueManager.Data
{
    public class ClueRepository : IClueRepository
    {   //??//ClueDetails clueDetailsToDisplay = new ClueDetails(clue);??
        //Added 11-18:
        ClueDetails _clueDetails;
        //private SaveClueRequest _request;// = new SaveClueRequest();

        //Create List that will be serialized to ClueManager.state.
        private List<ClueDetails> clueStore;
        private readonly string stateFile;

        public ClueRepository()
        {
            stateFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ClueManager.state");
            Deserialize();
        }

        public void Save(ClueDetails clue)
        {
            //Removed 11-18:
            if (clue.Id == Guid.Empty)
                clue.Id = Guid.NewGuid();

            if (!clueStore.Contains(clue))
                clueStore.Add(clue);
            Serialize();
        }

        //Do later:
        //public void Save(Clue clue)
        //public void Save(SaveClueRequest request)
        //public SaveClueResponse Save(SaveClueRequest request)
        //{
        //Added 11-18:
        //_request = new SaveClueRequest(_clueDetails);
        //_request = request;
        //_request.clueStore = clueStore;/This should be set where the request is created. 
        //_request.Save(); //Need to make sure this has a value!
        //Serialize();

        //Removed 11-18:
        //if (clue.Id == Guid.Empty)
        //    clue.Id = Guid.NewGuid();

        //if (!clueStore.Contains(clue))
        //    clueStore.Add(clue);
        //}
        
        public void Delete(ClueDetails clue)
        {
            clueStore.Remove(clue);
            Serialize();
        }

        public List<ClueDetails> FindCluesByLookup(string lookupCriteria)
        {
            IEnumerable<ClueDetails> found = from c in clueStore
                                      where c.LookupClue.StartsWith(lookupCriteria, StringComparison.OrdinalIgnoreCase)
                                      select c;
            return found.ToList();
        }

        public List<ClueDetails> FindAnswersByLookup(string lookupCriteria)
        {
            IEnumerable<ClueDetails> found = from c in clueStore
                                      from a in c.AnswerCollectionForClue.ToList<Answer>()  //is .ToList<Answer>() needed?
                                      where a.LookupAnswer.StartsWith(lookupCriteria, StringComparison.OrdinalIgnoreCase)
                                      select c;
            return found.ToList();
        }

        public List<ClueDetails> FindAll()
        {
            return new List<ClueDetails>(clueStore);
        }

        public void Serialize()
        {
            //Save clueStore List to file
            using (FileStream stream = File.Open(stateFile, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, clueStore);
            }
        }

        public void Deserialize()
        {
            if (File.Exists(stateFile))
            {
                using (FileStream stream = File.Open(stateFile, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    clueStore = (List<ClueDetails>)formatter.Deserialize(stream);
                }
            }
            else clueStore = new List<ClueDetails>();
        }



    }
}
