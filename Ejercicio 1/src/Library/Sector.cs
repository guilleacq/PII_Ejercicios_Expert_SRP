using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        private List<Shelf> shelves = new List<Shelf>();
        private string sectorName;

        public Sector(string name)
        {
            sectorName = name;
        }

        public void ShelveBook(Book book, int shelfNumber)
        {
            //Buscar el shelf con el shelfNumber y llamar a su shelvebook
        }
    }
}