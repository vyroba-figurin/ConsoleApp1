using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class RekreacnyDom : Chata
    {
        private bool bazen;

        public RekreacnyDom(string nazov, string typ, string poschodia, int obytneMiestnosti, float uzitkovaPlocha, float zastavanaPlocha, string spolocenskaMienstnost, bool bazen) : base(nazov, typ, poschodia, obytneMiestnosti, uzitkovaPlocha, zastavanaPlocha, spolocenskaMienstnost)
        {
            this.bazen = bazen;
        }

        public new void PoskytniInformacie()
        {
            Console.WriteLine("Parametre rekr. domu:");
            Console.WriteLine("Nazov: {0} \nTyp: {1} \nPoschodie: {2}", nazov, typ, poschodia);
            Test();
        }
    }
}
