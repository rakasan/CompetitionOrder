using Microsoft.Win32;
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

namespace CompetionOrder
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()== true)
            {
                GlobalClass.xlsfile.readXLSX(ofd.FileName);
                GlobalClass.xlsfile.Sheet = 0;
                int i = 6;
                int gasit = 0;
                while(gasit==0)
                {
                    if (GlobalClass.xlsfile.getText(i, 0) == "")
                        gasit = 1;
                    else
                        i++;
                }
                GlobalClass.nr_participanti = i - 6;
                GlobalClass.categorie = GlobalClass.xlsfile.getText(2, 1);
                GlobalClass.numeCategorie = GlobalClass.xlsfile.getText(3, 1);
                GlobalClass.dataCampionat = GlobalClass.xlsfile.getText(0, 1);
                GlobalClass.numeCampionat = GlobalClass.xlsfile.getText(1, 1);
            }
            else
            {
                MessageBox.Show("Nu ati selectat nici un fisier va rugma reincercati");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            int width = Math.Min(800,(int) System.Windows.SystemParameters.PrimaryScreenWidth -100);
            int height = Math.Min(800, (int)System.Windows.SystemParameters.PrimaryScreenHeight-100);

            switch(GlobalClass.nr_participanti)
            {
                case 1:
                    {
                        Forma_1_jucator f = new Forma_1_jucator();
                        f.Title = this.Title;
                       // f.Width = width;
                        //f.Height = height;
                       // f.Width = 800;
                        //f.Height = 800;
                        
                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    }
                    break;
                case 2:
                    {
                        Forma_2_jucatori f = new Forma_2_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    } break;
                case 3:
                    {
                        Forma_3_jucatori f = new Forma_3_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    } break;
                case 4:
                    {
                    Forma_4_jucatori f = new Forma_4_jucatori();
                    f.Title = this.Title;
                    // f.Width = width;
                    //f.Height = height;
                    // f.Width = 800;
                    //f.Height = 800;

                    f.nume_campionat.Content = GlobalClass.numeCampionat;
                    f.categorie.Content = GlobalClass.categorie;
                    f.nume_categorie.Content = GlobalClass.numeCategorie;
                    f.data.Content = GlobalClass.dataCampionat;
                    f.Show();
                } break;
                case 5:
                    {
                        Forma_5_jucatori f = new Forma_5_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    } break;
                case 6:
                    {
                        Forma_6_jucatori f = new Forma_6_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    }
                    break;
                case 7:
                    {
                        Forma_7_jucatori f = new Forma_7_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    }
                    
                    break;
                case 8:
                    {
                        Forma_8_jucatori f = new Forma_8_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    } break;
                case 9:
                    {
                        Forma_9_jucatori f = new Forma_9_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    } break;
                case 10:
                    {
                        Forma_10_jucatori f = new Forma_10_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    } break;
                case 11:
                    {
                        Forma_11_jucatori f = new Forma_11_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    } break;
                case 12:
                    {
                        Forma_12_jucatori f = new Forma_12_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    } break;
                case 13:
                    {
                        Forma_13_jucatori f = new Forma_13_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    } break;
                case 14:
                    {
                        Forma_14_jucatori f = new Forma_14_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    } break;
                case 15:
                    {
                        Forma_15_jucatori f = new Forma_15_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    } break;
                case 16:
                    {
                        Forma_16_jucatori f = new Forma_16_jucatori();
                        f.Title = this.Title;
                        // f.Width = width;
                        //f.Height = height;
                        // f.Width = 800;
                        //f.Height = 800;

                        f.nume_campionat.Content = GlobalClass.numeCampionat;
                        f.categorie.Content = GlobalClass.categorie;
                        f.nume_categorie.Content = GlobalClass.numeCategorie;
                        f.data.Content = GlobalClass.dataCampionat;
                        f.Show();
                    } break;
                case 17: break;
                case 18: break;
                case 19: break;
                case 20: break;
                case 21: break;
                case 22: break;
                case 23: break;
                case 24: break;
                case 25: break;
                case 26: break;
                case 27: break;
                case 28: break;
                case 29: break;
                case 30: break;
                case 31: break;
                case 32: break;
                default: break;
            }
        }
    }
}
