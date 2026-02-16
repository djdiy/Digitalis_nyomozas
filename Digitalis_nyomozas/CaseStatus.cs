using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_nyomozas
{
    internal class CaseStatus
    {
        private string status;

        public CaseStatus(string status)
        {
            this.status = status;
        }

        public string Status { get => status; set => status = value; }



        public void allapotvaltozas(string newStatus)
        {
            Status = newStatus;
        }

        public override string ToString()
        {
            return $"Jelenlegi státusz: {this.status}";
        }
    }
}
