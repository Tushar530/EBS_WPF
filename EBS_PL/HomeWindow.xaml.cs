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
using EBS_Entities;
using EBS_Exception;
using EBS_DAL;
using EBS_BLL;

namespace EBS_PL
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Page
    {
        EBS_Validations bll = null;
        public HomeWindow()
        {
            InitializeComponent();
            bll = new EBS_Validations();
        }

      

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            TravelPlan travel = new TravelPlan();

            this.NavigationService.Navigate(travel);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               bll.Remove(int.Parse(txtPlan.Text));
                MessageBox.Show("Deleted!");
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

        private void btnStatus_Click(object sender, RoutedEventArgs e)
        {
            txtCheck.Text = "Accepted";
        }
    }
}
