using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionOrder
{
    public class InfoComepetitie
    {
      public  int participanti;
       public string nume;
       public string categorie;
       public string tipCompetitie;
       public Participant[] participant = new Participant[32];
    }

    public class Participant
    {
        public string Nume;
        public string Club;
    }

    public class RandomTaken
    {
        public bool Taken;
        
    }
}
