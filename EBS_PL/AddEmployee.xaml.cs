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
using EBS_BLL;
using EBS_DAL;
using EBS_Exception;
using EBS_Entities;

namespace EBS_PL
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Page
    {
        EBS_Validations bll = new EBS_Validations();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            string message = null;

            if (message == null)
            {
                Employee emp = new Employee();
                emp.EmployeeName =txtName.Text;
                emp.EmployeeDesignation = cmbDesignation.Text;
             
                try
                {
                    bll.Add(emp);
                    MessageBox.Show("Registered");
                }
                catch (EBSException ex1)
                {
                    MessageBox.Show(ex1.Message);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message);
                }
            }
            else
            {
                MessageBox.Show(message);
            }


            MainWindow main = new MainWindow();

            this.NavigationService.Navigate(main);
        }
    }
}
