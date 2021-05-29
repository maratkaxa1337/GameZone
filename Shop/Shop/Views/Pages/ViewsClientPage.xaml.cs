using Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shop.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewsClientPage.xaml
    /// </summary>
    public partial class ViewsClientPage : Page
    {
        public ViewsClientPage()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataView.ItemsSource = ConnectContext.db.Client.ToList();
        }

        private void Btndelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Client client = (Client)DataView.SelectedItem;
                if (client != null)
                {
                    if (MessageBox.Show("Вы действительно хотите удалить","Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ConnectContext.db.Client.Remove(client);
                        ConnectContext.db.SaveChanges();
                        Page_Loaded(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали ни одного элемента","Система", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (DataView.SelectedItem != null)
            {
                NavigationService.Navigate(new ClientEditPage((Client)DataView.SelectedItem));
            }
        }
    }
}
