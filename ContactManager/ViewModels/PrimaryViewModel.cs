using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;
using ClueManager.Data;  //.ClueDetails;

//namespace ContactManager.Model
namespace ClueManager.ViewModels
{
    [Serializable]
    public class PrimaryViewModel : Notifier 
    {
        //Under Construction
        //public ObservableCollection<ClueManager.Data.ClueDetails> ClueModels { get; set; }
        public ObservableCollection<ClueViewModel> ClueModels { get; set; }

        public PrimaryViewModel()
        {
            //TO DO
        }
        
        //Needs to change:
        private void _PopulateContacts(IEnumerable<ClueManager.Data.ClueDetails> contacts)
        {
            ClueModels.Clear();
            foreach(var contact in contacts)
            {
                ClueModels.Add(contact); //TO DO
            }
        }        
        //... more stuff to come...
        //----End Added Nov. 18
                
        private void SortAnswerCollection()
        {            
            AnswerViewModel [] answerArray = new AnswerViewModel[AnswerCollectionForClue.Count]; //= AnswerCollectionForClue.ToArray();
            answerArray = AnswerCollectionForClue.ToArray();
            //Answer[] newArray = new Answer[answerArray.Length];
            Array.Sort(answerArray);
            ObservableCollection<AnswerViewModel> newOC = new ObservableCollection<AnswerViewModel>();
            foreach (var item in answerArray)
            {
                newOC.Add(item);
            }

            AnswerCollectionForClue = newOC;
        }

        public ObservableCollection<AnswerViewModel> AnswerCollectionForClue
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
                AnswerCollectionForClue = new ObservableCollection<AnswerViewModel>();
 	        AnswerCollectionForClue.Add(new AnswerViewModel(answerText));

            SortAnswerCollection();
            
        }
        



        
}
}

        //public void CreateTestCollection(ObservableCollection<ClueDetails> clueStore)
        //{
        //    ObservableCollection<ClueViewModel> viewModels = new ObservableCollection<ClueViewModel>();
        //    foreach (var obj in clueStore)  //Collection of ClueDetails objects
        //    {
        //        ClueViewModel clueViewModel = obj as ClueViewModel;
        //        viewModels.Add(obj);
        //    }
        //}


//http://msdn.microsoft.com/en-us/magazine/dd419663.aspx
//Figure 15 The Save Logic for CustomerViewModel
 // In CustomerViewModel.cs 
//public ICommand SaveCommand 
//{ get { if (_saveCommand == null) 
//{ _saveCommand = new RelayCommand( param => this.Save(), param => this.CanSave ); }
//return _saveCommand; } } 
//public void Save() { if (!_customer.IsValid) throw new InvalidOperationException("..."); 
//if (this.IsNewCustomer) _customerRepository.AddCustomer(_customer); 
//base.OnPropertyChanged("DisplayName"); } 
//bool IsNewCustomer { get { return !_customerRepository.ContainsCustomer(_customer); } } 
//bool CanSave { get { return String.IsNullOrEmpty(this.ValidateCustomerType()) && _customer.IsValid; } }

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

