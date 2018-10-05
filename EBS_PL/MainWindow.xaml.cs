using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using EBS_BLL;
using EBS_DAL;
using EBS_Entities;
using EBS_Exception;

namespace EBS_PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        EBS_Validations bll = new EBS_Validations();
        EBS_Operations dal = new EBS_Operations();


        public MainWindow()
        {
            InitializeComponent();
        }
        //validating Login
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtID != null && passBox != null)
                {
                    Login login = new Login();
                    login.EmplpoyeeId = int.Parse(txtID.Text);
                    login.EmployeePassword = passBox.Password.ToString();
                    if (bll.LoginValidate(login.EmplpoyeeId, login.EmployeePassword))
                    {

                        MessageBox.Show("Login Success");
                        // Navigation to HomePage after Login Successfully.
                        NavigationService nav;
                        nav = NavigationService.GetNavigationService(this);
                        HomeWindow p3 = new HomeWindow();
                        nav.Navigate(p3);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Credentials");
                    }
                }
            }
             
                catch(Exception)
                {
                    MessageBox.Show("Credentials Cannot be empty");
                }
            }
            

        private void btn_Reg_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee add = new AddEmployee();

            this.NavigationService.Navigate(add);

        }
    }
}



