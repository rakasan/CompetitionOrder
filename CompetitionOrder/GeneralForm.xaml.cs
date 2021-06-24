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
using System.IO;
using Microsoft.Win32;

namespace CompetitionOrder
{
    /// <summary>
    /// Interaction logic for GeneralForm.xaml
    /// </summary>
    public partial class GeneralForm : Window
    {

        InfoComepetitie InfoC_backup;
        public GeneralForm(InfoComepetitie InfoC)
        {
            InitializeComponent();
            create_box(InfoC);
        }

        public void create_box(InfoComepetitie InfoC)
        {
            bool aranjat = false;
            int test = 1;
            int iterator;
           
            int participanti = InfoC.participanti;
            int casute = 0;
            int local_counter = 1;
            int local_random;
            bool all_registered = false;
            Random rnd = new Random();
            RandomTaken[] part = new RandomTaken[participanti];

            local_random = rnd.Next(0, participanti);
            for (iterator = 0; iterator < participanti; iterator++)
            {
                part[iterator] = new RandomTaken();
            }
                InfoC_backup = new InfoComepetitie();
            
            InfoC_backup.participant[0] = new Participant();
            InfoC_backup.participant[0].Nume = InfoC.participant[local_random].Nume;
            InfoC_backup.participant[0].Club = InfoC.participant[local_random].Club;
            InfoC_backup.participanti = InfoC.participanti;
            part[local_random].Taken = true;


            while(aranjat != true)
            {
                local_random = rnd.Next(0, participanti);
                if(part[local_random].Taken != true)
                {
                    if((InfoC.participant[local_random].Club != InfoC_backup.participant[local_counter - 1].Club))
                    {
                        InfoC_backup.participant[local_counter] = new Participant();
                        InfoC_backup.participant[local_counter].Club = InfoC.participant[local_random].Club;
                        InfoC_backup.participant[local_counter].Nume = InfoC.participant[local_random].Nume;
                        part[local_random].Taken = true;
                        local_counter++;
                        if(participanti == local_counter)
                        {
                            aranjat = true;
                        }

                    }
                    else
                    {

                        /* Club langa club */
                    }

                }
                else 
                {
                    /* Try again position is taken */
                }

            }
           
             
           
                for (int i = 0; i < InfoC.participanti; i++)
                {
                    TextBox txtNume = new TextBox();
                    //txtNume.Name = InfoC_backup.participant[i].Nume;
                    txtNume.Text = InfoC_backup.participant[i].Nume;

                    txtNume.Width = 150;
                    txtNume.Height = 20;

                    Thickness margin = txtNume.Margin;

                    margin.Top = 10;
                    margin.Right = 350;

                    txtNume.Margin = margin;

                    StackPanel_main.Children.Add(txtNume);


                }

            /*
                if (InfoC_backup.participanti % 2 == 0)
            {

                casute = InfoC_backup.participanti / 2;
            }
            else 
            {
                casute = InfoC_backup.participanti / 2 + 1;
            }


            for(int i = 0; i < casute; i ++)
            {
                TextBox Tb = new TextBox();

                Tb.Width = 150;
                Tb.Height = 20;

                Thickness margin = Tb.Margin;

                margin.Top = -200 + i*50;
                margin.Right = 0;

                Tb.Margin = margin;

                StackPanel_main.Children.Add(Tb);
            }
             */ 

        }

        private void SaveList_bt_Click(object sender, RoutedEventArgs e)
        {
            string Buffer;
            SaveFileDialog Sfd = new SaveFileDialog();
            if(Sfd.ShowDialog() == true)
            {
                StreamWriter sw = new StreamWriter(Sfd.FileName, true);
                for (int index = 0; index < InfoC_backup.participanti; index ++)
                {
                    Buffer = InfoC_backup.participant[index].Nume + InfoC_backup.participant[index].Club;
                    sw.WriteLine(Buffer);
                }

                sw.Close();
                
            }

        }
    }
}
