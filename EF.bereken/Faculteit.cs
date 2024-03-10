
namespace EF.bereken
{
    public class Faculteit
    {
        public ulong Bereken(uint getal)
        {
            ulong resultaat = 1;

            if (getal > 0)
            {
                do
                {
                    resultaat *= getal;

                    getal--;

                } while (getal > 1);
            }

            return resultaat;
        }
    }

}
