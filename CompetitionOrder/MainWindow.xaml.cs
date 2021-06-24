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
using Microsoft.Win32;

namespace CompetitionOrder
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

        public bool Loaded = false;
        public InfoComepetitie Transmision = new InfoComepetitie();

        private void LoadFilebtn_Click(object sender, RoutedEventArgs e)
        {
            string text;
            string[] desfacut = new string[10];
            string[] pregatit = new string[40];
            int old = 0;
            Loaded = true;

            OpenFileDialog newFile = new OpenFileDialog();
            if(newFile.ShowDialog() == true)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(newFile.FileName);

                while((text = file.ReadLine()) !=null)
                {
                    desfacut = text.Split(',');
                    for(int i =0; i<desfacut.Length; i++)
                    {
                        pregatit[i+old] = desfacut[i];
                    }
                    old = old+desfacut.Length;
                }

                InfoComepetitie InfoComp = new InfoComepetitie();

                InfoComp.nume = pregatit[0];
                InfoComp.tipCompetitie = pregatit[1];
                InfoComp.categorie = pregatit[2];
                InfoComp.participanti = Convert.ToInt16(pregatit[3]);
              ;

              old = 0;
                for(int i=0; i < (InfoComp.participanti * 2); i = i+2)
                {
                    InfoComp.participant[old] = new Participant();
                    InfoComp.participant[old].Nume = pregatit[i + 4];
                    InfoComp.participant[old].Club = pregatit[i + 4 + 1];
                    old++;
                    
               }

                Transmision = InfoComp;

            }
            else
            {

            }
        }

        private void GenerateBtn_Click(object sender, RoutedEventArgs e)
        {
            GeneralForm Gf = new GeneralForm(Transmision);
            Gf.Show();
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            GenerateList Gl = new GenerateList(Transmision, Loaded);
            Gl.Show();
        }
    }
}
