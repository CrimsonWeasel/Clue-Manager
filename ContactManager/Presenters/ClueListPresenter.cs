using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClueManager.Views;
using System.Collections.ObjectModel;
//using ClueManager.Model;

namespace ClueManager.Presenters
{
    public class ClueListPresenter: PresenterBase<ContactListView>
    {
        private readonly ApplicationPresenter _applicationPresenter;

        public ClueListPresenter(ApplicationPresenter applicationPresenter, ContactListView view)
            : base(view, "TabHeader")
        {
            _applicationPresenter = applicationPresenter;
        }

        
        public ObservableCollection<PrimaryViewModel> AllClues
        {
            get { return _applicationPresenter.CurrentClues; }
        }
               
        public string TabHeader
        {
            get { return "All Clues"; }
        }

        public void OpenClue(PrimaryViewModel clue)
        {
            _applicationPresenter.OpenClue(clue);
        }

        public void Close()
        {
            _applicationPresenter.CloseTab(this);
        }

        public override bool Equals(object obj)
        {
            return obj != null && GetType() == obj.GetType();
        }



    }
}
