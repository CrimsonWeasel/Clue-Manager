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
using ClueManager.Views;
using ClueManager.Presenters;
using ClueManager.Model;

namespace ClueManager.Views
{
    /// <summary>
    /// Interaction logic for ContactListView.xaml
    /// </summary>
    public partial class ContactListView : UserControl
    {
        public ContactListView()
        {
            InitializeComponent();
        }

         public ClueListPresenter Presenter
        {
            get {return DataContext as ClueListPresenter;}
        }        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Presenter.Close();
        }

        private void OpenClue_Click(object sender, RoutedEventArgs e)
        {
            Button button = e.OriginalSource as Button;
            if (button != null)
                Presenter.OpenClue(button.DataContext as PrimaryViewModel);
        }
    }
}
