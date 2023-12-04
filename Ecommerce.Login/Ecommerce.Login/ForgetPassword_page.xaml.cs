using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for ForgetPassword_page.xaml
    /// </summary>
    public partial class ForgetPassword_page : Page
    {
        public ForgetPassword_page()
        {
            InitializeComponent();

            compoBox.Items.Add("Customer");
            compoBox.Items.Add("Seller");
        }
        Entities ED =new Entities();
        Customer customer = new Customer();
        Seller seller = new Seller();
        private void back_login_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.NavigationService.Navigate(loginPage);
        }

        private void btn_ADD_Click(object sender, RoutedEventArgs e)
        {
            int SelectedIndexInCompobox = compoBox.SelectedIndex;// 0 -> Customer, 1 -> Seller
            if (SelectedIndexInCompobox == 0)
            {
                customer.password = Newtxt_password.Password = Newtxt_password_Copy.Password;
                customer.Name = Newtxt_userName.Text;
                ED.Customers.AddOrUpdate(customer);
                ED.SaveChanges();
                if (Newtxt_password_Copy.Password == Newtxt_password.Password != null && Newtxt_userName.Text != null)
                {
                    Homepage_Customer homepage_Customer = new Homepage_Customer();
                    this.NavigationService.Navigate(homepage_Customer);
                }



            }
         
            if (SelectedIndexInCompobox == 1)
            {
                seller.sellerName = Newtxt_userName.Text;
                seller.sellerPassword = Newtxt_password.Password = Newtxt_password_Copy.Password;
                ED.Sellers.AddOrUpdate(seller);
                ED.SaveChanges();
                if (Newtxt_password_Copy.Password == Newtxt_password.Password != null && Newtxt_userName.Text != null)
                {
                    HomePage_Seller homePage_Seller = new HomePage_Seller();
                    this.NavigationService.Navigate(homePage_Seller);
                }

            }
            if (SelectedIndexInCompobox == null)
            {
                MessageBox.Show("You must choose before you do anything ");
            }
        }
    }
}
