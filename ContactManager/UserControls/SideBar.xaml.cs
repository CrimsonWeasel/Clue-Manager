using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClueManager.Presenters;
using System.Windows.Controls;
using ClueManager.Model;

namespace ClueManager.UserControls
{
    /// <summary>
    /// Interaction logic for SideBar.xaml
    /// </summary>
    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
        }

        public ApplicationPresenter Presenter
        {
            get { return DataContext as ApplicationPresenter; }
        }

        private void New_click(object sender, RoutedEventArgs e)
        {
            Presenter.NewClue();
        }

        private void ViewAll_Click(object sender, RoutedEventArgs e)
        {
            Presenter.DisplayAllClues();
        }

        private void OpenClue_Click(object sender, RoutedEventArgs e)
        {
            Button button = e.OriginalSource as Button;

            if (button != null)
                Presenter.OpenClue(button.DataContext as PrimaryViewModel);
        }

        //This ended up not being able to be adapted to what I want
        private void cluesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ListBox box = e.OriginalSource as ListBox;

            //if (box != null)
            //    Presenter.OpenClue(box.DataContext as Clue);
        }

        private void leftListBox_ItemSelected(object sender, RoutedEventArgs e)
        {
            //ListBoxItem item = e.OriginalSource as ListBoxItem;
            //if (item != null)
            //    Presenter.OpenClue(item.DataContext as Clue);
        }
    }
}
