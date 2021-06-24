using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartXLS;

namespace CompetionOrder
{
    public static class GlobalClass
    {
        public static WorkBook xlsfile = new WorkBook();
        public static string dataCampionat = "";
        public static string numeCampionat = "";
        public static string categorie = "";
        public static string numeCategorie = "";
        public static int nr_participanti = 0;
        public static Participant[] participanti = new Participant[100];
        public static Campionat campionat = new Campionat();


        public static void incarca_lista_participanti()
        {
            for(int i =0;i<nr_participanti;i++)
            {
                participanti[i] = new Participant();
                participanti[i].id = i;
                participanti[i].nume = xlsfile.getText(6 + i, 0);
                participanti[i].club = xlsfile.getText(6 + i, 1);
                participanti[i].greutate = xlsfile.getText(6 + i, 2);
                participanti[i].grad = xlsfile.getText(6 + i, 3);

            }
            switch(nr_participanti)
            {
                case 2: primul_tur_2(); break;
                case 3: primul_tur_3(); break;
                case 4: primul_tur_4(); break;
                case 5: primul_tur_5(); break;
                case 6: primul_tur_6(); break;
                case 7: primul_tur_7(); break;
                case 8: primul_tur_8(); break;
                case 9: primul_tur_9(); break;
                case 10: primul_tur_10(); break;
                case 11: primul_tur_11(); break;
                case 12: primul_tur_12(); break;
                case 13: primul_tur_13(); break;
                case 14: primul_tur_14(); break;
                case 15: primul_tur_15(); break;
                case 16: primul_tur_16(); break;
                
                default:break;
            }
        }
        public static void primul_tur_2()
        {
            campionat.tur[0].lupta[0].id_p1 = 0;
            campionat.tur[0].lupta[0].id_p2 = 1;
        }

        public static void primul_tur_3()
        {
            Random random = new Random();
            // participant 1 
            for(int i = 0;i<1000;i++)
            {
                int id = random.Next(3);
                if(participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;
                    
                    break;
                }
            }
            //participant 2
            int id_valid2 = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(3);
                if (participanti[id].alocat == 0 && participanti[id].club != participanti[campionat.tur[0].lupta[0].id_p1].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid2= 1;
                    break;
                }
            }
            if (id_valid2 == 0)
            {

                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(3);
                    if (participanti[id].alocat == 0 )
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid2 = 1;
                        break;
                    }
                }
            
            
            }

            //participant 3
            for(int i=0;i<nr_participanti;i++)
            {
                if(participanti[i].alocat==0)
                { 
                campionat.tur[0].lupta[1].id_p1 = i;
                campionat.tur[0].lupta[1].id_castigator = i;
                campionat.tur[1].lupta[0].id_p2 = i;
                participanti[i].alocat = 1;
                break;
                }
                
            }
        
        
        }

        public static void primul_tur_4()
        {
            Random random = new Random();
            // participant 1 
            for(int i = 0;i<1000;i++)
            {
                int id = random.Next(nr_participanti);
                if(participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;
                    
                    break;
                }
            }
            //participant 2
            int id_valid2 = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[id].club != participanti[campionat.tur[0].lupta[0].id_p1].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid2= 1;
                    break;
                }
            }
            if (id_valid2 == 0)
            {

                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0 )
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid2 = 1;
                        break;
                    }
                }
            
            
            }

            //participant 3
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p1 = id;

                    break;
                }
            }
            //participant 4
            for(int i=0;i<nr_participanti;i++)
            {
                if(participanti[i].alocat==0)
                { 
                campionat.tur[0].lupta[1].id_p2 = i;           
                participanti[i].alocat = 1;
                break;
                }
                
            }
        
        
        }

        public static void primul_tur_5() 
        {

            Random random = new Random();
            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;

                    break;
                }
            }
            //participant 2
            int id_valid2 = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[id].club != participanti[campionat.tur[0].lupta[0].id_p1].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid2 = 1;
                    break;
                }
            }
            if (id_valid2 == 0)
            {

                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid2 = 1;
                        break;
                    }
                }


            }


            // participant 3
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p1 = id;
                    campionat.tur[0].lupta[1].id_castigator = id;
                    campionat.tur[1].lupta[0].id_p2 = id;

                    break;
                }
            }

            //participant 4
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p1 = id;
                    campionat.tur[0].lupta[2].id_castigator = id;
                    campionat.tur[1].lupta[1].id_p1 = id;
                    break;
                }
            }
            //participant 5
            for (int i = 0; i < nr_participanti; i++)
            {
                if (participanti[i].alocat == 0)
                {
                    campionat.tur[0].lupta[3].id_p1 = i;
                    campionat.tur[0].lupta[3].id_castigator = i;
                    campionat.tur[1].lupta[1].id_p2 = i;
                    participanti[i].alocat = 1;
                    break;
                }

            }
        
        }

        public static void primul_tur_6()
        {
            Random random = new Random();
            int id_valid = 0;
            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if(id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0 )
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 3
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p1 = id;
                    campionat.tur[0].lupta[1].id_castigator = id;
                    campionat.tur[1].lupta[0].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }


            // participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p1 = id;
                    id_valid = 1;
                    break;
                }
            }


            //participant 5
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }


            //participant 6
            for(int i =0;i<nr_participanti;i++)
                if(participanti[i].alocat == 0)
                {
                    participanti[i].alocat = 1;
                    campionat.tur[0].lupta[3].id_p1 = i;
                    campionat.tur[0].lupta[3].id_castigator = i;
                    campionat.tur[1].lupta[1].id_p2 = i;
                    id_valid = 1;
                    break;
                }

        }

        public static void primul_tur_7() 
        {

            Random random = new Random();
            int id_valid = 0;
            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[1].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p1 = id;

                    break;
                }
            }

            //participant 6
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[2].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            //participant 7
            for (int i = 0; i < nr_participanti; i++)
                if (participanti[i].alocat == 0)
                {
                    participanti[i].alocat = 1;
                    campionat.tur[0].lupta[3].id_p1 = i;
                    campionat.tur[0].lupta[3].id_castigator = i;
                    campionat.tur[1].lupta[1].id_p2 = i;
                    id_valid = 1;
                    break;
                }

        }

        public static void primul_tur_8()
        {

            Random random = new Random();
            int id_valid = 0;
            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[1].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p1 = id;

                    break;
                }
            }

            //participant 6
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[2].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 7 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p1 = id;

                    break;
                }
            }

            //participant 8
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[3].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

        }

        public static void primul_tur_9()
        {
            Random random = new Random();
            int id_valid = 0;
            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[1].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p1 = id;

                    break;
                }
            }

            //participant 6
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[2].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 7 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p1 = id;

                    break;
                }
            }

            //participant 8
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[3].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }



            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p1 = id;

                    break;
                }
            }

         
        }

        public static void primul_tur_10()
        {
            Random random = new Random();
            int id_valid = 0;
            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[1].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p1 = id;

                    break;
                }
            }

            //participant 6
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[2].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 7 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p1 = id;

                    break;
                }
            }

            //participant 8
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[3].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }



            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[4].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

          
        }

        public static void primul_tur_11()
        {
            Random random = new Random();
            int id_valid = 0;
            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[1].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p1 = id;

                    break;
                }
            }

            //participant 6
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[2].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 7 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p1 = id;

                    break;
                }
            }

            //participant 8
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[3].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }



            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[4].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[5].id_p1 = id;

                    break;
                }
            }

           
        }

        public static void primul_tur_12()
        {
            Random random = new Random();
            int id_valid = 0;
            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[1].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p1 = id;

                    break;
                }
            }

            //participant 6
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[2].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 7 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p1 = id;

                    break;
                }
            }

            //participant 8
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[3].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }



            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[4].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[5].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[5].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[5].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


          
        }

        public static void primul_tur_13()
        {
            Random random = new Random();
            int id_valid = 0;
            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[1].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p1 = id;

                    break;
                }
            }

            //participant 6
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[2].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 7 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p1 = id;

                    break;
                }
            }

            //participant 8
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[3].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }



            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[4].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[5].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[5].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[5].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[6].id_p1 = id;

                    break;
                }
            }

            
        }

        public static void primul_tur_14()
        {
            Random random = new Random();
            int id_valid = 0;
            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[1].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p1 = id;

                    break;
                }
            }

            //participant 6
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[2].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 7 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p1 = id;

                    break;
                }
            }

            //participant 8
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[3].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }



            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[4].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[5].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[5].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[5].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[6].id_p1 = id;

                    break;
                }
            }

            //participant 6
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[6].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[6].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            
        }

        public static void primul_tur_15()
        {
            Random random = new Random();
            int id_valid = 0;
            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[1].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p1 = id;

                    break;
                }
            }

            //participant 6
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[2].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 7 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p1 = id;

                    break;
                }
            }

            //participant 8
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[3].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }



            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[4].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[5].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[5].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[5].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[6].id_p1 = id;

                    break;
                }
            }

            //participant 6
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[6].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[6].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 7 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[7].id_p1 = id;

                    break;
                }
            }

          
        }

        public static void primul_tur_16()
        {

            Random random = new Random();
            int id_valid = 0;
            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[0].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[0].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[1].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[1].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p1 = id;

                    break;
                }
            }

            //participant 6
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[2].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[2].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 7 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p1 = id;

                    break;
                }
            }

            //participant 8
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[3].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[3].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


          
            // participant 1 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p1 = id;

                    break;
                }
            }

            //participant 2
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[0].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[4].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[4].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 3 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[5].id_p1 = id;

                    break;
                }
            }

            //participant 4
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[1].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[5].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[5].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }


            // participant 5 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[6].id_p1 = id;

                    break;
                }
            }

            //participant 6
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[6].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[6].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }

            // participant 7 
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[7].id_p1 = id;

                    break;
                }
            }

            //participant 8
            id_valid = 0;
            for (int i = 0; i < 1000; i++)
            {
                int id = random.Next(nr_participanti);
                if (participanti[id].alocat == 0 && participanti[campionat.tur[0].lupta[2].id_p1].club != participanti[id].club)
                {
                    participanti[id].alocat = 1;
                    campionat.tur[0].lupta[7].id_p2 = id;
                    id_valid = 1;
                    break;
                }
            }

            if (id_valid == 0)
            {
                for (int i = 0; i < 1000; i++)
                {
                    int id = random.Next(nr_participanti);
                    if (participanti[id].alocat == 0)
                    {
                        participanti[id].alocat = 1;
                        campionat.tur[0].lupta[7].id_p2 = id;
                        id_valid = 1;
                        break;
                    }
                }
            }





        }


    }


      
    

    public class Participant
    {
        public int id=0;
        public string nume="";
        public string club="";
        public string greutate="";
        public string grad="";
        public int alocat = 0;
    }

    public class Lupta
    {
        public int id_p1=99;
        public int id_p2=99;
        public int id_castigator=-1;
    }

    public class Tur
    {
        public Lupta[] lupta = new Lupta[100];
        public Tur()
        {
            for (int i = 0; i < 100; i++)
                lupta[i] = new Lupta();
        }
    }

    public class Campionat
    {
        public Tur[] tur = new Tur[100];
        public Campionat()
        {
            for (int i = 0; i < 100; i++)
                tur[i] = new Tur();
        }
    }

}
