﻿using Microsoft.Win32;
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
    /// Interaction logic for Forma_9_jucatori.xaml
    /// </summary>
    public partial class Forma_9_jucatori : Window
    {
        public Forma_9_jucatori()
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
            tur1_participant5.Text = GlobalClass.participanti[GlobalClass.campionat.tur[0].lupta[2].id_p1].nume;
            tur1_participant6.Text = GlobalClass.participanti[GlobalClass.campionat.tur[0].lupta[2].id_p2].nume;
            tur1_participant7.Text = GlobalClass.participanti[GlobalClass.campionat.tur[0].lupta[3].id_p1].nume;
            tur1_participant8.Text = GlobalClass.participanti[GlobalClass.campionat.tur[0].lupta[3].id_p2].nume;
            tur2_participant1.Text = "";
            tur2_participant2.Text = "";
            tur2_participant3.Text = "";
            tur2_participant4.Text = "";
            tur3_participant1.Text = "";
            tur3_participant2.Text = "";
            tur4_participant1.Text = "";
        }

        private void tur1_participant1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur1_participant1.IsEnabled == true)
            {
                tur1_participant1.IsEnabled = false;
                tur1_participant2.IsEnabled = false;
                tur2_participant1.Text = tur1_participant1.Text;
                

            }
        }

        private void tur1_participant2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur1_participant2.IsEnabled == true)
            {
                tur1_participant1.IsEnabled = false;
                tur1_participant2.IsEnabled = false;
                tur2_participant1.Text = tur1_participant2.Text;
            }
        }


        private void tur1_participant3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (tur1_participant3.IsEnabled == true)
            {
                
                tur1_participant3.IsEnabled = false;
                tur2_participant2.Text = tur1_participant3.Text;
                
            }

        }


        private void tur1_participant4_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur1_participant4.IsEnabled == true)
            {
                tur1_participant4.IsEnabled = false;
                tur1_participant5.IsEnabled = false;
                tur2_participant3.Text = tur1_participant4.Text;
              

            }
        }

        private void tur1_participant5_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur1_participant5.IsEnabled == true)
            {
                tur1_participant4.IsEnabled = false;
                tur1_participant5.IsEnabled = false;
                tur2_participant3.Text = tur1_participant5.Text;
               
            }
        }

        private void tur1_participant6_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur1_participant6.IsEnabled == true)
            {
                tur1_participant6.IsEnabled = false;
                tur1_participant7.IsEnabled = false;
                tur2_participant4.Text = tur1_participant6.Text;

            }
        }

        private void tur1_participant7_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur1_participant7.IsEnabled == true)
            {
                tur1_participant6.IsEnabled = false;
                tur1_participant7.IsEnabled = false;
                tur2_participant4.Text = tur1_participant7.Text;
               
            }
        }

        private void tur1_participant8_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur1_participant8.IsEnabled == true)
            {
                tur1_participant8.IsEnabled = false;
                tur1_participant9.IsEnabled = false;
                tur2_participant5.Text = tur1_participant8.Text;
               
            }
        }


        private void tur1_participant9_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur1_participant9.IsEnabled == true)
            {
                tur1_participant9.IsEnabled = false;
                tur1_participant8.IsEnabled = false;
                tur2_participant5.Text = tur1_participant9.Text;
               
            }
        }


        private void tur2_participant1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur2_participant1.IsEnabled == true)
            {
                tur2_participant1.IsEnabled = false;
                tur2_participant2.IsEnabled = false;
                tur3_participant1.Text = tur2_participant1.Text;
               
            }
        }


        private void tur2_participant2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur2_participant2.IsEnabled == true)
            {
                tur2_participant1.IsEnabled = false;
                tur2_participant2.IsEnabled = false;
                tur3_participant1.Text = tur2_participant2.Text;

            }
        }

        private void tur2_participant3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur2_participant3.IsEnabled == true)
            {
              
                tur2_participant3.IsEnabled = false;
                tur3_participant2.Text = tur2_participant3.Text;

            }
        }


        private void tur2_participant4_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur2_participant4.IsEnabled == true)
            {
                tur2_participant5.IsEnabled = false;
                tur2_participant4.IsEnabled = false;
                tur3_participant3.Text = tur2_participant4.Text;

            }
        }

        private void tur2_participant5_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur2_participant5.IsEnabled == true)
            {
                tur2_participant5.IsEnabled = false;
                tur2_participant4.IsEnabled = false;
                tur3_participant3.Text = tur2_participant5.Text;

            }
        }


        private void tur3_participant1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur3_participant1.IsEnabled == true)
            {
                tur3_participant1.IsEnabled = false;
                tur3_participant2.IsEnabled = false;
                tur4_participant1.Text = tur3_participant1.Text;
                
            }
        }


        private void tur3_participant2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur3_participant2.IsEnabled == true)
            {
                tur3_participant1.IsEnabled = false;
                tur3_participant2.IsEnabled = false;
                tur4_participant1.Text = tur3_participant2.Text;

            }
        }

        private void tur3_participant3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tur3_participant3.IsEnabled == true)
            {
                tur3_participant3.IsEnabled = false;
               
                tur4_participant2.Text = tur3_participant3.Text;

            }
        }

        private void tur5_participant1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("WINNER: " + tur5_participant1.Text);
        }

        private void tur4_participant2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            tur4_participant1.IsEnabled = false;
            tur4_participant2.IsEnabled = false;
            tur5_participant1.Text = tur4_participant2.Text;

        }

        private void tur4_participant1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            tur4_participant1.IsEnabled = false;
            tur4_participant2.IsEnabled = false;
            tur5_participant1.Text = tur4_participant1.Text;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            WorkBook xls = new WorkBook();
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            xls.readXLSX(path + "\\output\\9.xlsx");
            xls.Sheet = 0;
            xls.setText(1, 1, GlobalClass.dataCampionat);
            xls.setText(2, 1, GlobalClass.numeCampionat);
            xls.setText(3, 1, GlobalClass.categorie);
            xls.setText(4, 1, GlobalClass.numeCategorie);
            xls.setText(9, 0, tur1_participant1.Text);
            xls.setText(11, 0, tur1_participant2.Text);
            xls.setText(13, 0, tur1_participant3.Text);
            xls.setText(15, 0, tur1_participant4.Text);
            xls.setText(17, 0, tur1_participant5.Text);
            xls.setText(19, 0, tur1_participant6.Text);
            xls.setText(21, 0, tur1_participant7.Text);
            xls.setText(23, 0, tur1_participant8.Text);
            xls.setText(25, 0, tur1_participant9.Text);

            xls.setText(10, 2, tur2_participant1.Text);
            xls.setText(13, 2, tur2_participant2.Text);
            xls.setText(16, 2, tur2_participant3.Text);
            xls.setText(20, 2, tur2_participant4.Text);
            xls.setText(24, 2, tur2_participant5.Text);

            xls.setText(11, 4, tur3_participant1.Text);
            xls.setText(16, 4, tur3_participant2.Text);
            xls.setText(22, 4, tur3_participant3.Text);


            xls.setText(14, 6, tur4_participant1.Text);
            xls.setText(22, 6, tur4_participant2.Text);


            xls.setText(18, 8, tur5_participant1.Text);
            

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