using System;

namespace SRP
{
    class Program
    {
        static void Main()
        {
            Sector sectorNovelas = new Sector("Novelas", 3);

            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            sectorNovelas.ShelveBook(book1, 1);
            sectorNovelas.ShelveBook(book2 , 1);

        }
    }
}