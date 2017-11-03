using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Chata : Dom
    {
        private string spolocenskaMienstnost;

        public Chata(string nazov, string typ, string poschodia, int obytneMiestnosti, float uzitkovaPlocha, float zastavanaPlocha, string spolocenskaMienstnost) : base(nazov, typ, poschodia, obytneMiestnosti, uzitkovaPlocha, zastavanaPlocha)
        {
            this.spolocenskaMienstnost = spolocenskaMienstnost;
        }

        public new void PoskytniInformacie()
        {
            Console.WriteLine("Parametre chaty:");
            Console.WriteLine("Nazov: {0} \nTyp: {1} \nPoschodie: {2}", nazov, typ, poschodia);

            Console.WriteLine("Spolocenska miestnost v chate: {0}", spolocenskaMienstnost);
            Test();
        }

        public override void VypisTyp()
        {
            base.VypisTyp();
        }

        private new void Test()
        {
            Console.WriteLine("test overrided");
        }



    }
}
