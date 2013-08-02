using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ContactManager.Presenters;
using Microsoft.Win32;

namespace ContactManager.Views
{
    /// <summary>
    /// Interaction logic for EditContactView.xaml
    /// </summary>
    public partial class EditContactView : UserControl
    {
        public EditContactView()
        {
            InitializeComponent();
        }

        public EditCluePresenter Presenter
        {
            get { return DataContext as EditCluePresenter; }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Presenter.Save();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Presenter.Delete();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Presenter.Close();
        }
        
        private void addAnswer_Click(object sender, RoutedEventArgs e)
        {
            //answersListBox.Items.Add(newAnswerTextBox.Text);
            Presenter.addAnswerToClue(newAnswerTextBox.Text);
            Presenter.Save(); //Added this because of broken functionality with add and remove between saves. 
            //answersListBox.ItemsSource = Presenter.Clue.AnswerCollectionForClue;  //Remove this to test ObservableCollection in Clue
            //answersListBox.Items.Refresh();  //Remove this to test ObservableCollection in Clue
            newAnswerTextBox.Clear();
        }

        private void newAnswerTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            newAnswerTextBox.SelectAll();
        }

        private void selectAnswer_Click(object sender, RoutedEventArgs e) 
        {
            //DELETE??? May not need this button at all since listbox binding is working.
        }

        //I think there must be a more appropriate way to do this:
        private void deleteAnswer_Click(object sender, RoutedEventArgs e)
        {            
            if (answersListBox.SelectedIndex < 0)
                return;
            Presenter.RemoveAnswerFromClueByIndex(answersListBox.SelectedIndex);
            //Presenter.RemoveAnswerFromClueByAnswer(answersListBox.SelectedItem);
            //Presenter.RemoveAnswerFromClue(answersListBox.SelectedItem);
            //Presenter.RemoveAnswerFromClue(answersListBox.SelectedValue);   //SelectedValue);     //(answersListBox.SelectedItem);
            //answersListBox.Items.RemoveAt(answersListBox.Items.IndexOf(answersListBox.SelectedItem));
            Presenter.Save();
        }
    }
}
