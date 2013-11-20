using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using ClueManager.Domain; //Does this need to go?

namespace ClueManager.Data
{
    //Wait and finish this later when other tasks are finished. Putting Save back the way it was for now. 
    public class SaveClueRequest
    {
        private ClueDetails _clueDetails;
        public List<ClueDetails> clueStore;
        //public List<Clue> clueStore;  //This needs to be a clueDetails so the reference above can go away.
        
        public SaveClueRequest(ClueDetails clueDetails)
        {
            _clueDetails = clueDetails;
        }

        public void Save()  //(ClueDetails clueDetails)
        {   //Extracted from old ClueRepository.Save
            //_clueDetails = clueDetails;

            if (_clueDetails.Id == Guid.Empty)
                _clueDetails.Id = Guid.NewGuid();

            if (!clueStore.Contains(_clueDetails))
                clueStore.Add(_clueDetails);
        }
    }
}
