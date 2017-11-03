using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Dom
    {
        protected string nazov, typ, poschodia;
        private int obytneMiestnosti;
        private float uzitkovaPlocha, zastavanaPlocha;

        public Dom()
        {
        }

        public Dom(string nazov, string typ, string poschodia, int obytneMiestnosti, float uzitkovaPlocha, float zastavanaPlocha)
        {
            this.nazov = nazov;
            this.typ = typ;
            this.poschodia = poschodia;
            this.obytneMiestnosti = obytneMiestnosti;
            this.uzitkovaPlocha = uzitkovaPlocha;
            this.zastavanaPlocha = zastavanaPlocha;
        }

        public void PoskytniInformacie()
        {
            Console.WriteLine("Parametre domu:");
            Console.WriteLine("Nazov: {0} \nTyp: {1} \nPoschodie: {2}", nazov, typ, poschodia);
        }

        public float ZistiVyuzitelnostZastavanejPlochy()
        {
            return (zastavanaPlocha / uzitkovaPlocha) * 100;
        }

        public virtual void VypisTyp()
        {
            Console.WriteLine("Dom");
        }

        protected void Test()
        {
            Console.WriteLine("test source");
        }
    }
}
