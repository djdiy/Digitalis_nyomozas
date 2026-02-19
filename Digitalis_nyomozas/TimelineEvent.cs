using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_nyomozas
{
    internal class TimelineEvent
    {
        private DateTime date;
        private string description;

        public TimelineEvent(DateTime date, string description)
        {
            this.date = date;
            this.description = description;
        }

        public DateTime Date { get => date; set => date = value; }
        public string Description { get => description; set => description = value; }



        public override string ToString()
        {
            return $"Dátum: {this.date}, leírás: {this.description}";
        }
    }
}
