using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prosjektoppgave.Models
{
    public class Schedule
    {
        public int id { get; set; }

        public DateTime departureDate { get; set; }

        public DateTime arrivalDate { get; set; }

        public int seatsLeft { get; set; }

        public virtual Route route { get; set; }
    }
}