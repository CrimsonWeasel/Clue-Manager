using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using ClueManager.Data;

//namespace ContactManager.ViewModels
//namespace ContactManager.Model
namespace ClueManager.ViewModels
{   
    //******New class added to be the REAL ClueViewModel after renaming the other one PrimaryViewModel.
    public class ClueViewModel : Notifier
    {
        //Under Construction
        //public ObservableCollection<ClueManager.Data.ClueDetails> ClueModels { get; set; }
        public ObservableCollection<PrimaryViewModel> ClueModels { get; set; }
        private string clueText;
        private DateTime dateEntered = DateTime.Now;
        private ObservableCollection<AnswerViewModel> answerCollectionForClue = new ObservableCollection<AnswerViewModel>();
        private Guid _id = Guid.Empty;

        public ClueViewModel()
        {
            //ClueModels = new ObservableCollection<ClueManager.Data.ClueDetails>();
            ClueModels = new ObservableCollection<PrimaryViewModel>();
        }

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
            ClueViewModel other = obj as ClueViewModel;
            return other != null && other.Id == Id;
        }

        public DateTime DateEntered
        {
            get
            {
                if (dateEntered == null)
                    return DateTime.Now;  //This fixes the DateTime problem. Still need to clean up old dates.
                else
                    return dateEntered;
            }
            set
            {
                if (dateEntered != value) //Be sure I need this
                {
                    dateEntered = value;
                    OnPropertyChanged("DateEntered");
                }
            }
        }
    }
}
