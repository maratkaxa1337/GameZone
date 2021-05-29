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
    /// Логика взаимодействия для ClientEditPage.xaml
    /// </summary>
    public partial class ClientEditPage : Page
    {
        private Client selectitem;
        public ClientEditPage(Client selectitem)
        {
            InitializeComponent();
            this.selectitem = selectitem;
            TxbLast.Text = selectitem.LastName;
            TxbFirst.Text = selectitem.FirstName;
            TxbPatronymic.Text = selectitem.Patronymic;
            TxbPhone.Text = selectitem.Phone;
            DateBritch.SelectedDate = selectitem.DateOfBirth;
            DateRegister.SelectedDate = selectitem.DateRegister;
            CmbGender.SelectedItem = selectitem.GenderCode;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try

            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ViewsClientPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
