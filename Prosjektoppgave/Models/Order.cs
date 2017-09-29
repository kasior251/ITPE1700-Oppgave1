using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prosjektoppgave.Models
{
    public class Order
    {
        public int id { get; set; }
        public DateTime dateOut { get; set; }
        public DateTime dateIn { get; set; }
        public int passengers { get; set; }
        public virtual Route route { get; set; }

}
}