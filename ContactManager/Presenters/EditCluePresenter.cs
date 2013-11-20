using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using ClueManager.Model;   //Stopped working after namespace change
using ClueManager.Views;
using System.Collections;
using System.Collections.ObjectModel;
using ClueManager.ViewModels;

namespace ClueManager.Presenters
{
    public class EditCluePresenter : PresenterBase<EditContactView>
    {
        private readonly ApplicationPresenter _applicationPresenter;
        private readonly ClueViewModel _clue;

        public EditCluePresenter(ApplicationPresenter applicationPresenter, EditContactView view, PrimaryViewModel clue) :
            base(view, "Clue.LookupClue")
        {
            _applicationPresenter = applicationPresenter;
            _clue = clue;
        }

        public ClueViewModel Clue
        {
            get { return _clue; }
        }

        public void addAnswerToClue(string answerText)
        {
            _applicationPresenter.AddAnswerToClue(Clue, answerText);            
        }
             
        public void RemoveAnswerFromClueByIndex(int i)  //Should this be working automatically through binding?
        {

            if (Clue.AnswerCollectionForClue == null)
                return;
            Clue.AnswerCollectionForClue.RemoveAt(i);     //(answerToRemove);
        }

        //public void RemoveAnswerFromClueByAnswer(Answer answerToRemove)  //TO DO: Need to move this functionality to applicationPresenter!!!
        //{
        //    if (Clue.AnswerCollectionForClue == null)
        //        return;
        //    Clue.AnswerCollectionForClue.Remove(answerToRemove);
        //}
                
        public void Save()
        {
            _applicationPresenter.SaveClue(Clue);
        }

        public void Delete()
        {
            _applicationPresenter.CloseTab(this);
            _applicationPresenter.DeleteClue(Clue);
        }
        public void Close()
        {
            _applicationPresenter.CloseTab(this);
        }

        public override bool Equals(object obj)
        {
            EditCluePresenter presenter = obj as EditCluePresenter;
            return presenter != null && presenter.Clue.Equals(Clue);
        }
    }
}
