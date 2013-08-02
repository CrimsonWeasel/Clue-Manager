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


namespace ContactManager.UserControls
{
    /// <summary>
    /// Interaction logic for SearchBar.xaml
    /// </summary>
    public partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
        }

        public ApplicationPresenter Presenter
        {
            get { return DataContext as ApplicationPresenter; }
        }

        private void SearchCluesText_Changed(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            Presenter.SearchClues(searchText.Text);
        }

        private void SearchAnswersText_Changed(object sender, TextChangedEventArgs e)
        {
            Presenter.SearchAnswers(searchAnswersText.Text);
        }

        
        
    }
}
