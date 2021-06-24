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
    /// Interaction logic for GenerateList.xaml
    /// </summary>
    public partial class GenerateList : Window
    {
        public bool load;
        InfoComepetitie SendIc;
        public GenerateList(InfoComepetitie IC, bool loaded)
        {
            InitializeComponent();
            load = loaded;
            SendIc = new InfoComepetitie();
            SendIc = IC;
        }

        InfoComepetitie IC;
        int position = 0;
        public void Create_btn_Click(object sender, RoutedEventArgs e)
        {
            IC = new InfoComepetitie();
            IC.nume = CompName_tb.Text;
            IC.categorie = CompCategory_tb.Text;
            IC.tipCompetitie = CompType_tb.Text;
            CompetitionName.Content = IC.nume;
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
           
            IC.participant[position] = new Participant();
            IC.participanti = position;
            IC.participant[position].Nume = Name_tb.Text;
            IC.participant[position].Club = Club_tb.Text;

            string local_buffer = Convert.ToString(Name_tb.Text) + Convert.ToString(Club_tb.Text);

            Participant_lb.Items.Add(local_buffer);

            position++;

        }

        private void Remove_btn_Click(object sender, RoutedEventArgs e)
        {
            Participant_lb.Items.RemoveAt(Participant_lb.Items.IndexOf(Participant_lb.SelectedItem));
        }

        private void LoadList_btn_Click(object sender, RoutedEventArgs e)
        {
            if (load == true)
            {
                IC = new InfoComepetitie();
                IC.nume = SendIc.nume;
                IC.categorie = SendIc.categorie;
                IC.tipCompetitie = SendIc.tipCompetitie;
                CompetitionName.Content = IC.nume;

                for(int i = 0;i<SendIc.participanti;i++)
                {
                    IC.participant[i] = new Participant();
                    IC.participant[i].Nume = SendIc.participant[i].Nume;
                    IC.participant[i].Club = SendIc.participant[i].Club;

                    string local_buffer = SendIc.participant[i].Nume +" _" + SendIc.participant[i].Club;

                    Participant_lb.Items.Add(local_buffer);
                }

                IC.participanti = SendIc.participanti;
                position = SendIc.participanti;
            }

            else
            {
                for (int i = 0; i < SendIc.participanti; i++)
                {
                    IC.participant[i + position] = new Participant();
                    IC.participant[i + position].Nume = SendIc.participant[i].Nume;
                    IC.participant[i + position].Club = SendIc.participant[i].Club;

                    string local_buffer = SendIc.participant[i + position].Nume + SendIc.participant[i + position].Club;

                    Participant_lb.Items.Add(local_buffer);
                }

                IC.participanti = SendIc.participanti + position;
                position += SendIc.participanti;


            }
        }

        private void GenerateList_btn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog Sfd = new SaveFileDialog();
            if(Sfd.ShowDialog() == true)
            {
                StreamWriter sw = new StreamWriter(Sfd.FileName, true);
                string buffer = IC.nume + ',' + IC.tipCompetitie + ',' + IC.categorie + ',' + IC.participanti;
                sw.WriteLine(buffer);
                //File.WriteAllText(Sfd.FileName, buffer);

                
                foreach (string s in Participant_lb.Items)
                {

                    string[] pieces = s.Split('_');
                    buffer = pieces[0] + ',' + pieces[1];
                    sw.WriteLine(buffer);

                }

                sw.Close();
            }
            else
            {
                MessageBox.Show("Problem at opening the file");
            }
            
        }
    }
}
