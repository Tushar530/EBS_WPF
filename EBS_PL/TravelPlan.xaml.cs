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
using EBS_Entities;
using EBS_Exception;
namespace EBS_PL
{
    /// <summary>
    /// Interaction logic for Travelplan.xaml
    /// </summary>
    public partial class TravelPlan : Page
    {
        EBS_Validations bll = new EBS_Validations();
        public TravelPlan()
        {
            InitializeComponent();
        }

        private void btb_Submit_Click(object sender, RoutedEventArgs e)
        {

            string message = null;

            if (message == null)
            {
                Travel travel = new Travel();
                travel.SourceName = cmb_Source.Text;
                travel.DestinationName = cmb_Destination.Text;
                travel.FromDate = (DateTime)DateFrom.SelectedDate;
                travel.ToDate = (DateTime)DateTo.SelectedDate;

                try
                {
                    bll.Add(travel);
                    MessageBox.Show("Booked!");
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



            DateTime dateTimeObj = DateTime.Parse(DateFrom.Text);
            try
            {

                if (dateTimeObj < DateTime.Now)
                {
                    errormessage.Text = "Enter a valid Date Which is a Future Date.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                DateTime dateTimeeObj1 = DateTime.Parse(DateTo.Text);
                if (dateTimeeObj1 < dateTimeObj)
                {
                    errormessage.Text = "Enter a Date Which is greater than From Date.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Details detail = new Details();
            this.NavigationService.Navigate(detail);

            
        }   
    }
        
 }
