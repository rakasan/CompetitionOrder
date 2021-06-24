using Microsoft.Win32;
using SmartXLS;
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
using System.Windows.Shapes;

namespace CompetionOrder
{
    /// <summary>
    /// Interaction logic for Forma_4_jucatori.xaml
    /// </summary>
    public partial class Forma_4_jucatori : Window
    {
        public Forma_4_jucatori()
        {
            InitializeComponent();
            GlobalClass.incarca_lista_participanti();
            init_forma();
        }


        public void init_forma()
        {
            tur1_participant1.Text = GlobalClass.participanti[GlobalClass.campionat.tur[0].lupta[0].id_p1].nume;
            tur1_participant2.Text = GlobalClass.participanti[GlobalClass.campionat.tur[0].lupta[0].id_p2].nume;
            tur1_participant3.Text = GlobalClass.participanti[GlobalClass.campionat.tur[0].lupta[1].id_p1].nume;
            tur1_participant4.Text = GlobalClass.participanti[GlobalClass.campionat.tur[0].lupta[1].id_p2].nume;
            tur2_participant1.Text = "";
            tur2_participant2.Text = "";
            tur3_participant1.Text = "";
        }

        public void actualizare_forma(int i)
        {

            nume_jos_2.Content = GlobalClass.participanti[i].nume;
            greutate_jos_2.Content = GlobalClass.participanti[i].greutate;
            club_jos_2.Content = GlobalClass.participanti[i].club;
            grad_jos_2.Content = GlobalClass.participanti[i].grad;
        }

        // participant 1

        private void tur1_participant1_MouseEnter(object sender, MouseEventArgs e)
        {
            actualizare_forma(GlobalClass.campionat.tur[0].lupta[0].id_p1);
            informatii_concurent.Visibility = Visibility.Visible;
        }

        private void tur1_participant1_MouseLeave(object sender, MouseEventArgs e)
        {
            informatii_concurent.Visibility = Visibility.Hidden;
        }

        private void tur1_participant1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur1_participant1.IsEnabled)
            {
                tur2_participant1.Text = tur1_participant1.Text;
                tur1_participant1.IsEnabled = false;
                tur1_participant2.IsEnabled = false;
                GlobalClass.campionat.tur[0].lupta[0].id_castigator = GlobalClass.campionat.tur[0].lupta[0].id_p1;
                GlobalClass.campionat.tur[1].lupta[0].id_p1 = GlobalClass.campionat.tur[0].lupta[0].id_p1;
            }
        }


        //participant 2

        private void tur1_participant2_MouseEnter(object sender, MouseEventArgs e)
        {
            actualizare_forma(GlobalClass.campionat.tur[0].lupta[0].id_p2);
            informatii_concurent.Visibility = Visibility.Visible;
        }

        private void tur1_participant2_MouseLeave(object sender, MouseEventArgs e)
        {
            informatii_concurent.Visibility = Visibility.Hidden;
        }

        private void tur1_participant2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur1_participant2.IsEnabled)
            {
                tur2_participant1.Text = tur1_participant2.Text;
                tur1_participant1.IsEnabled = false;
                tur1_participant2.IsEnabled = false;
                GlobalClass.campionat.tur[0].lupta[0].id_castigator = GlobalClass.campionat.tur[0].lupta[0].id_p2;
                GlobalClass.campionat.tur[1].lupta[0].id_p1 = GlobalClass.campionat.tur[0].lupta[0].id_p2;

            }
        }

        // participant 3

        private void tur1_participant3_MouseEnter(object sender, MouseEventArgs e)
        {
            actualizare_forma(GlobalClass.campionat.tur[0].lupta[1].id_p1);
            informatii_concurent.Visibility = Visibility.Visible;
        }

        private void tur1_participant3_MouseLeave(object sender, MouseEventArgs e)
        {
            informatii_concurent.Visibility = Visibility.Hidden;
        }

        private void tur1_participant3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur1_participant3.IsEnabled)
            {
                tur2_participant2.Text = tur1_participant3.Text;
                tur1_participant3.IsEnabled = false;
                tur1_participant4.IsEnabled = false;
                GlobalClass.campionat.tur[0].lupta[1].id_castigator = GlobalClass.campionat.tur[0].lupta[1].id_p1;
                GlobalClass.campionat.tur[1].lupta[0].id_p2= GlobalClass.campionat.tur[0].lupta[1].id_p1;

            }
        }

        //participant 4

        private void tur1_participant4_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur1_participant4.IsEnabled)
            {
                tur2_participant2.Text = tur1_participant4.Text;
                tur1_participant3.IsEnabled = false;
                tur1_participant4.IsEnabled = false;
                GlobalClass.campionat.tur[0].lupta[1].id_castigator = GlobalClass.campionat.tur[0].lupta[1].id_p2;
                GlobalClass.campionat.tur[1].lupta[0].id_p2 = GlobalClass.campionat.tur[0].lupta[1].id_p2;

            }
        }

        private void tur1_participant4_MouseEnter(object sender, MouseEventArgs e)
        {
            actualizare_forma(GlobalClass.campionat.tur[0].lupta[1].id_p2);
            informatii_concurent.Visibility = Visibility.Visible;
        }

        private void tur1_participant4_MouseLeave(object sender, MouseEventArgs e)
        {
            informatii_concurent.Visibility = Visibility.Hidden;
        }




        // tur 2 participant 1
        private void tur2_participant1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (GlobalClass.campionat.tur[1].lupta[0].id_p1 != 99)
            {
                actualizare_forma(GlobalClass.campionat.tur[1].lupta[0].id_p1);
                informatii_concurent.Visibility = Visibility.Visible;

            }

        }

        private void tur2_participant1_MouseLeave(object sender, MouseEventArgs e)
        {
            informatii_concurent.Visibility = Visibility.Hidden;
        }

        private void tur2_participant1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur2_participant1.IsEnabled)
            {
                tur3_participant1.Text = tur2_participant1.Text;
                tur2_participant1.IsEnabled = false;
                tur2_participant2.IsEnabled = false;
                GlobalClass.campionat.tur[1].lupta[0].id_castigator = GlobalClass.campionat.tur[1].lupta[0].id_p1;
                GlobalClass.campionat.tur[2].lupta[0].id_p1 = GlobalClass.campionat.tur[1].lupta[0].id_p1;
            }
        }


        // tur 2 participant 2
        private void tur2_participant2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (GlobalClass.campionat.tur[1].lupta[0].id_p2 != 99)
            {
                actualizare_forma(GlobalClass.campionat.tur[1].lupta[0].id_p2);
                informatii_concurent.Visibility = Visibility.Visible;

            }

        }

        private void tur2_participant2_MouseLeave(object sender, MouseEventArgs e)
        {
            informatii_concurent.Visibility = Visibility.Hidden;
        }

        private void tur2_participant2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur2_participant2.IsEnabled)
            {
                tur3_participant1.Text = tur2_participant2.Text;
                tur2_participant1.IsEnabled = false;
                tur2_participant2.IsEnabled = false;
                GlobalClass.campionat.tur[1].lupta[0].id_castigator = GlobalClass.campionat.tur[1].lupta[0].id_p2;
                GlobalClass.campionat.tur[2].lupta[0].id_p1 = GlobalClass.campionat.tur[1].lupta[0].id_p1;
            }
        }

        //tur 3 participant 1
        private void tur3_participant1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (GlobalClass.campionat.tur[2].lupta[0].id_p1 != 99)
            {
                actualizare_forma(GlobalClass.campionat.tur[2].lupta[0].id_p1);
                informatii_concurent.Visibility = Visibility.Visible;

            }
        }

        private void tur3_participant1_MouseLeave(object sender, MouseEventArgs e)
        {
            informatii_concurent.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            WorkBook xls = new WorkBook();
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            xls.readXLSX(path + "\\output\\4.xlsx");
            xls.Sheet = 0;
            xls.setText(1, 1, GlobalClass.dataCampionat);
            xls.setText(2, 1, GlobalClass.numeCampionat);
            xls.setText(3, 1, GlobalClass.categorie);
            xls.setText(4, 1, GlobalClass.numeCategorie);
            xls.setText(9, 0, tur1_participant1.Text);
            xls.setText(11, 0, tur1_participant2.Text);
            xls.setText(13, 0, tur1_participant3.Text);
            xls.setText(15, 0, tur1_participant4.Text);
            xls.setText(10, 2, tur2_participant1.Text);
            xls.setText(14, 2, tur2_participant2.Text);
            xls.setText(12, 4, tur3_participant1.Text);
            

            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == true)
            {
                xls.writeXLSX(sfd.FileName);
            }
            else
            {
                MessageBox.Show("Operatia de export a esuat");
            }



        }

       

        

       
    }
}
