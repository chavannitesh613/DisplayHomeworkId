using BusinessLayer;
using EntitiesLayer;
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

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Teacher teacher = new Teacher();
                teacher.TeacherId = txtTeacherId.Text;

                DisplayHomeworkIdBL displayHomeworkIdBL = new DisplayHomeworkIdBL();
                dgProds.ItemsSource = displayHomeworkIdBL.DisplayHomeworkId(teacher);

                if (dgProds.Items.Count > 0)
                    MessageBox.Show("Homework Found successfully");
                else
                    MessageBox.Show("Homework not Found");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void menuStudentLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuTeacherLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuAdminLogin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
