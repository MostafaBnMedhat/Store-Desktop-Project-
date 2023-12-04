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

namespace Ecommerce.Login
{
    /// <summary>
    /// Interaction logic for SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            InitializeComponent();
            compoBox.Items.Add("Customer");
            compoBox.Items.Add("Seller");
        }
        Entities ED =new Entities();
        Customer customer =new Customer();
        Seller seller =new Seller();

        private void btn_singUp_Click_1(object sender, RoutedEventArgs e)
        {

            int SelectedIndexInCompobox = compoBox.SelectedIndex;// 0 -> user, 1 -> admin
            if (SelectedIndexInCompobox == 0)
            {

                LoginPage loginPage = new LoginPage();
                this.NavigationService.Navigate(loginPage);

            }

            else if (SelectedIndexInCompobox == 1)
            {

                LoginPage loginPage = new LoginPage();
                this.NavigationService.Navigate(loginPage);

            }
            if (SelectedIndexInCompobox == -1)
            {
                MessageBox.Show("You must choose before you do anything ");
            }
        }

        private void btn_login_Click_1(object sender, RoutedEventArgs e)
        {
            int SelectedIndexInCompobox = compoBox.SelectedIndex;// 0 -> Customer, 1 -> Seller
            if (SelectedIndexInCompobox == 0)
            {
                customer.password = Newtxt_password.Password = Newtxt_password_Copy.Password;
                customer.Name=Newtxt_userName.Text;
                ED.Customers.Add(customer);
                ED.SaveChanges();
                if (Newtxt_password_Copy.Password == Newtxt_password.Password  !=null && Newtxt_userName.Text !=null )
                {
                    Homepage_Customer homepage_Customer = new Homepage_Customer();
                    this.NavigationService.Navigate(homepage_Customer);
                }

              

            }
            else
            {
                MessageBox.Show("You must choose before you do anything ");
            }
            if (SelectedIndexInCompobox == 1)
            {
                seller.sellerName = Newtxt_userName.Text;
                seller.sellerPassword=Newtxt_password.Password= Newtxt_password_Copy.Password;
                ED.Sellers.Add(seller);
                ED.SaveChanges();
                if (Newtxt_password_Copy.Password == Newtxt_password.Password != null && Newtxt_userName.Text != null)
                {
                    HomePage_Seller homePage_Seller = new HomePage_Seller();
                    this.NavigationService.Navigate(homePage_Seller);
                }

            }
            if (SelectedIndexInCompobox == -1)
            {
                MessageBox.Show("You must choose before you do anything ");
            }

        }
    }
}