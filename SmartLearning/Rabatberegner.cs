namespace Uge1Rabat
{
    public class Rabatberegner
    {

        public double GetPrisEfterRabat(int antalVarer, double stykPris)
        {
            double bruttoPris = antalVarer * stykPris;
            double rabatprocent = 1;
            if (bruttoPris > 1000)
            {
                // Indkøb over 1000 kr. giver 3% rabat
                rabatprocent -= 0.03;
            }
            if (antalVarer > 10)
            {
                // Flere end 10 varer giver 2% rabat
                rabatprocent -= 0.02;
            }
            bruttoPris *= rabatprocent;
            return bruttoPris;
        }
    }
}
