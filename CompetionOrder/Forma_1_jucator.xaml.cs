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
using SmartXLS;
using Microsoft.Win32;
namespace CompetionOrder
{
    /// <summary>
    /// Interaction logic for Forma_1_jucator.xaml
    /// </summary>
    public partial class Forma_1_jucator : Window
    {
        public Forma_1_jucator()
        {
            InitializeComponent();
            GlobalClass.incarca_lista_participanti();
            actualizare_forma(0);
        }

        public void actualizare_forma(int i)
        {
            tur1_participant1.Text = GlobalClass.participanti[i].nume;
            nume_jos_2.Content = GlobalClass.participanti[i].nume;
            greutate_jos_2.Content = GlobalClass.participanti[i].greutate;
            club_jos_2.Content = GlobalClass.participanti[i].club;
            grad_jos_2.Content = GlobalClass.participanti[i].grad;
        }

        private void tur1_participant1_MouseEnter(object sender, MouseEventArgs e)
        {
            tur1_participant1.Text = GlobalClass.participanti[0].nume;
            nume_jos_2.Content = GlobalClass.participanti[0].nume;
            greutate_jos_2.Content = GlobalClass.participanti[0].greutate;
            club_jos_2.Content = GlobalClass.participanti[0].club;
            grad_jos_2.Content = GlobalClass.participanti[0].grad;
       
        }

        private void tur1_participant1_MouseLeave(object sender, MouseEventArgs e)
        {
        
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            WorkBook xls = new WorkBook();
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            xls.readXLSX(path + "\\output\\1.xlsx");
            xls.Sheet = 0;
            xls.setText(1, 1, GlobalClass.dataCampionat);
            xls.setText(2, 1, GlobalClass.numeCampionat);
            xls.setText(3, 1, GlobalClass.categorie);
            xls.setText(4, 1, GlobalClass.numeCategorie);
            xls.setText(9, 0, tur1_participant1.Text);
            
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

        private void tur1_participant1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
