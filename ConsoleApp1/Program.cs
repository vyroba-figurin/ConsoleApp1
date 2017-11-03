using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dom mojDom = new Dom("Activ 1", "aktivny", "nie", 3, 70.9f, 35.8f);
            mojDom.PoskytniInformacie();
            Console.WriteLine("Zastavana plocha je: {0}", mojDom.ZistiVyuzitelnostZastavanejPlochy());

            Console.WriteLine("\n");

            Dom susedovDom = new Dom("Activ 2", "aktivny", "nie", 3, 100.55f, 45.1f);
            susedovDom.PoskytniInformacie();
            //Console.WriteLine("Zastavana plocha je: {0}", susedovDom.ZistiVyuzitelnostZastavanejPlochy());

            Console.WriteLine("\n");

            Chata chata = new Chata("Velka chata", "aktivny", "nie", 4, 100.9f, 35.8f, "ano");
            chata.PoskytniInformacie();

            Console.WriteLine("\n");

            RekreacnyDom rekreacnyDom = new RekreacnyDom("Velky rekreacny dom", "aktivny", "nie", 4, 100.9f, 35.8f, "ano velku", true);
            rekreacnyDom.PoskytniInformacie();

            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
