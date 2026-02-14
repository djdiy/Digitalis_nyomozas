using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Digitalis_nyomozas
{
    internal class Evidence
    {
        private int id;
        private string type;
        private string description;
        private int trustworthiness;

        public Evidence(int id, string type, string description, int trustworthiness)
        {
            this.id = id;
            this.type = type;
            this.description = description;
            this.trustworthiness = trustworthiness;
        }

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
        public int Trustworthiness { get => trustworthiness; set => trustworthiness = value; }



        public override string ToString()
        {
            return $"Azonosító: {this.id}, típus: {this.type}, leírás: {this.description}, megbízhatósági érték(1-5): {this.trustworthiness}";
        }
    
    
    }
}
