using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_nyomozas
{
    internal class Witness
    {
        private Person person_witness;
        private string confession;
        private DateOnly date_confession;

        public Witness(Person person_witness, string confession, DateOnly date_confession)
        {
            this.person_witness = person_witness;
            this.confession = confession;
            this.date_confession = date_confession;
        }

        public string Confession { get => confession; set => confession = value; }
        public DateOnly Date_confession { get => date_confession; set => date_confession = value; }
        internal Person Person_witness { get => person_witness; set => person_witness = value; }


        public override string ToString()
        {
            return $"Tanú: {this.person_witness}, vallomás: '{this.confession}', vallomás dátuma: {this.date_confession}";
        }

    }
}
