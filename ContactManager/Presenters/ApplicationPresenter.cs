using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContactManager.Model;
using System.Collections.ObjectModel;
using ContactManager.Views;
using System.Collections;

namespace ContactManager.Presenters
{
    public class ApplicationPresenter : PresenterBase<Shell>
    {
        private readonly ClueRepository _clueRepository;
        private ObservableCollection<Clue> _currentClues;
        //private ObservableCollection<string> answerList;
        private string _statusText;

        public ApplicationPresenter(Shell view, ClueRepository clueRepository)
            : base(view)
        {
            _clueRepository = clueRepository;
            _currentClues = new ObservableCollection<Clue>(_clueRepository.FindAll());
            //answerList = new ObservableCollection<Clue>();  //This would need to be updated to find the correct list of answers.
        }

        public ObservableCollection<Clue> CurrentClues
        {
            get { return _currentClues; }
            set
            {
                _currentClues = value;
                OnPropertyChanged("CurrentClues");
            }
        }
        
        public string StatusText
        {
            get { return _statusText; }
            set
            {
                _statusText = value;
                OnPropertyChanged("StatusText");
            }
        }

        public void SearchClues(string criteria)
        {
            if (!string.IsNullOrEmpty(criteria) && criteria.Length > 1) //Changed from 2 to 1.
            {
                CurrentClues = new ObservableCollection<Clue>(_clueRepository.FindCluesByLookup(criteria));
                StatusText = string.Format("{0} clues found.", CurrentClues.Count);
            }
            else
            {
                CurrentClues = new ObservableCollection<Clue>(_clueRepository.FindAll());
                StatusText = "Displaying all clues.";
            }
        }

        public void SearchAnswers(string criteria) //Just adapted from SearchClues()
        {
            if (!string.IsNullOrEmpty(criteria) && criteria.Length > 1) 
            {
                CurrentClues = new ObservableCollection<Clue>(_clueRepository.FindAnswersByLookup(criteria));
                StatusText = string.Format("{0} clues found.", CurrentClues.Count);
            }
            else
            {
                CurrentClues = new ObservableCollection<Clue>(_clueRepository.FindAll());
                StatusText = "Displaying all clues.";
            }
        }

        public void NewClue()
        {
            OpenClue(new Clue());
        }

        public void OpenClue(Clue clue)
        {
            if (clue == null) return;

            View.AddTab(new EditCluePresenter(this, new Views.EditContactView(), clue));
        }

        public void AddAnswerToClue (Clue clueToUpdate, string answerText)
        {
            clueToUpdate.AddNewAnswer(answerText);
        }
        
        public void SaveClue(Clue clue)
        {
            if (!CurrentClues.Contains(clue))
                CurrentClues.Add(clue);

            _clueRepository.Save(clue);

            StatusText = string.Format("Clue {0} was saved.", clue.LookupClue);
        }

        public void DeleteClue(Clue clue)
        {
            if (CurrentClues.Contains(clue))
                CurrentClues.Remove(clue);

            _clueRepository.Delete(clue);

            StatusText = string.Format("Clue {0} was deleted.", clue.LookupClue);
        }

        public void CloseTab<T>(PresenterBase<T> presenter)
        {
            View.RemoveTab(presenter);
        }               

        public void DisplayAllClues()
        {
            //throw new NotImplementedException();

            View.AddTab( new ClueListPresenter(this, new ContactListView()));
        }
    }
}
