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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
          
            compoBox.Items.Add("Customer");
            compoBox.Items.Add("Seller");
        }
        Entities db = new Entities();
       
        public static int theCustomerID = 0;

        private void btn_singUp_Click_1(object sender, RoutedEventArgs e)
        {
            int SelectedIndexInCompobox = compoBox.SelectedIndex;// 0 -> user, 1 -> admin
            if (SelectedIndexInCompobox == 0)
            {
                SignUpPage signUpPage = new SignUpPage();
                this.NavigationService.Navigate(signUpPage);
            }
          
            if (SelectedIndexInCompobox == 1)
            {
                SignUpPage signUpPage = new SignUpPage();
                this.NavigationService.Navigate(signUpPage);
            }
            if(SelectedIndexInCompobox ==null)
            {
                MessageBox.Show("You must choose before you do anything ");
            }

        }
        private void ForgetPassword_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            ForgetPassword_page forgetPasswordPage = new ForgetPassword_page();
            NavigationService.Navigate(forgetPasswordPage);
        }

        private void btn_login_Click_1(object sender, RoutedEventArgs e)

        {
           
            int SelectedIndexInCompobox = compoBox.SelectedIndex;// 0 -> user, 1 -> admin
            if (SelectedIndexInCompobox == -1)
            {
                MessageBox.Show("You must choose before you do anything ");
            }
            if (SelectedIndexInCompobox == 0)
            {
                //User Code
                var CustomerRec = db.Customers.FirstOrDefault(x => x.Name == txt_userName.Text && x.password == txt_password.Password);
                if (CustomerRec != null)
                {
                    Homepage_Customer customerProfilePage = new Homepage_Customer();
                    this.NavigationService.Navigate(customerProfilePage);

                

                }
                else
                {
                    MessageBox.Show("Wrong user name or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                   
            }
            else if (SelectedIndexInCompobox == 1)
            {
                //Admin Code
                var adminRec = db.Sellers.FirstOrDefault(x => x.sellerName == txt_userName.Text && x.sellerPassword == txt_password.Password);
                if (adminRec != null)
                {

                    HomePage_Seller sellerPage = new HomePage_Seller();
                    this.NavigationService.Navigate(sellerPage);
                  
                 
                }
                else
                {
                    MessageBox.Show("Wrong user name or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                   
            }
            if (SelectedIndexInCompobox == -1)
            {
                MessageBox.Show("You must choose before you do anything ");
            }
        }
        
    }
}
