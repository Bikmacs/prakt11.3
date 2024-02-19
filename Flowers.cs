using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    class Flowers
    {
        private string name;

        public string Names { get; set; }
        public string tip { get; set; }
        public string Ottenok { get; set; }
        public string Country { get; set; }
        public int Price { get; set; }
        public int Heigh { get; set; }

        public int Kolv { get; set; }

        public string pris(string Names, string tip, string Ottenok, string Country, int Price, int heigh)
        {
            Flowers flowers = new Flowers();
            flowers.name = Names;
            flowers.tip = tip;
            flowers.Ottenok = Ottenok;
            flowers.Country = Country;
            flowers.Price = Price;
            flowers.Heigh = heigh;
            flowers.Kolv = Kolv;
            string inf = flowers.name + flowers.tip + flowers.Ottenok + flowers.Country + flowers.Price + flowers.Heigh;
            return inf;
        }

        public string info(string Names, string tip, string Ottenok, string Country, int Price, int heigh)
        {
            string inf = $"{Names} {tip} {Ottenok} {Country} {Price} {heigh}";
            return inf;
        }

        public string Cena(int Price, int kolv)
        {
            int ob = Price * kolv;
            return $"Цена: {ob}";
        }

        public string GetSaleInfo(int discountPercent)
        {
            double discountedPrice = Price - (Price * discountPercent / 10.0);
            return $"Скидка {discountPercent}%: Цена со скидкой - {discountedPrice}";

        }
    }
}
