namespace Wizard
{
    public class Toverstaf : IToverstaf
    {
        public int HoeveelheidEnergie { get; private set; }

        public Toverstaf()
        {
            HoeveelheidEnergie = 10;
        }

        public Toverstaf(int energie)
        {
            HoeveelheidEnergie = 100;
        }

        public void Links()
        {
            HoeveelheidEnergie--;
        }

        public void Rechts()
        {
            HoeveelheidEnergie--;
        }

        public void Omhoog()
        {
            HoeveelheidEnergie--;
        }

        public void Omlaag()
        {
            HoeveelheidEnergie--;
        }
    }
}
