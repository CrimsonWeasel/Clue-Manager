using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContactManager.Views;
using System.Collections.ObjectModel;
using ContactManager.Model;

namespace ContactManager.Presenters
{
    public class ClueListPresenter: PresenterBase<ContactListView>
    {
        private readonly ApplicationPresenter _applicationPresenter;

        public ClueListPresenter(ApplicationPresenter applicationPresenter, ContactListView view)
            : base(view, "TabHeader")
        {
            _applicationPresenter = applicationPresenter;
        }

        
        public ObservableCollection<Clue> AllClues
        {
            get { return _applicationPresenter.CurrentClues; }
        }
               
        public string TabHeader
        {
            get { return "All Clues"; }
        }

        public void OpenClue(Clue clue)
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
