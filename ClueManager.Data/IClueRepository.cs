using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ClueManager.Domain;

namespace ClueManager.Data
{
    public interface IClueRepository
    {
        //List<Clue> clueStore;
        //string stateFile;

        void Save(ClueDetails clue);

        void Delete(ClueDetails clue);

        List<ClueDetails> FindCluesByLookup(string lookupCriteria);

        List<ClueDetails> FindAnswersByLookup(string lookupCriteria);

        List<ClueDetails> FindAll();

        void Serialize();

        void Deserialize();
    }
}
//public interface IClueRepository
//{
//    private List<Clue> clueStore;

//    private readonly string stateFile;

//    public void Save(Clue clue);

//    public void Delete(Clue clue);

//    public List<Clue> FindCluesByLookup(string lookupCriteria);

//    public List<Clue> FindAnswersByLookup(string lookupCriteria);

//    public List<Clue> FindAll();

//    private void Serialize();

//    private void Deserialize();
//}