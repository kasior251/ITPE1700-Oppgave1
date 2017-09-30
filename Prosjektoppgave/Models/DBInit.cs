using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prosjektoppgave.Models
{
    public class DBInit : DropCreateDatabaseAlways<DB>
    {
        protected override void Seed(DB context)
        {
            var routes = new List<Route>()
            {
                new Route { origin = "Oslo", destination = "Mancheser", price = 1099.99},
                new Route { origin = "Manchester", destination = "Oslo", price = 1099.99},
                new Route { origin = "Oslo", destination = "Berlin", price = 1099.99},
                new Route { origin = "Berlin", destination = "Oslo", price = 1099.99},
                new Route { origin = "Oslo", destination = "Bergen", price = 1099.99},
                new Route { origin = "Bergen", destination = "Oslo", price = 1099.99},
                new Route { origin = "Bergen", destination = "Berlin", price = 1099.99},
                new Route { origin = "Berlin", destination = "Bergen", price = 1099.99},
                new Route { origin = "Bergen", destination = "Brussels", price = 1099.99},
                new Route { origin = "Brussels", destination = "Bergen", price = 1099.99},
                new Route { origin = "Bergen", destination = "Alta", price = 1099.99},
                new Route { origin = "Alta", destination = "Bergen", price = 1099.99},
                new Route { origin = "Bergen", destination = "Munchen", price = 1099.99},
                new Route { origin = "Munchen", destination = "Bergen", price = 1099.99},
                new Route { origin = "Bergen", destination = "Warszawa", price = 1099.99},
                new Route { origin = "Warszawa", destination = "Bergen", price = 1099.99},
            };
            //før routes legges inn i tabellen må det tas til schedule
            var schedules = new List<Schedule>()
            {
                //Oslo - Manchester
                new Schedule { route = routes[1], departureDate = new DateTime(2017, 11, 01, 08, 00, 00),
                    arrivalDate = new DateTime(2017, 11, 01, 11, 00, 00), seatsLeft = 100 },
                new Schedule { route = routes[2], departureDate = new DateTime(2017, 11, 01, 12, 00, 00),
                    arrivalDate = new DateTime(2017, 11, 01, 15, 00, 00), seatsLeft = 100 },
                //Oslo - Berlin
                new Schedule { route = routes[3], departureDate = new DateTime(2017, 11, 01, 09, 00, 00),
                    arrivalDate = new DateTime(2017, 11, 01, 12, 00, 00), seatsLeft = 100 },
                new Schedule { route = routes[4], departureDate = new DateTime(2017, 11, 01, 13, 00, 00),
                    arrivalDate = new DateTime(2017, 11, 01, 16, 00, 00), seatsLeft = 100 },
                //Oslo - Bergen
                new Schedule { route = routes[5], departureDate = new DateTime(2017, 11, 01, 10, 00, 00),
                    arrivalDate = new DateTime(2017, 11, 01, 11, 30, 00), seatsLeft = 100 },
                new Schedule { route = routes[6], departureDate = new DateTime(2017, 11, 01, 20, 30, 00),
                    arrivalDate = new DateTime(2017, 11, 01, 22, 00, 00), seatsLeft = 100 },
                //Bergen - Berlin
                new Schedule { route = routes[7], departureDate = new DateTime(2017, 11, 01, 12, 30, 00),
                    arrivalDate = new DateTime(2017, 11, 01, 15, 30, 00), seatsLeft = 100 },
                new Schedule { route = routes[8], departureDate = new DateTime(2017, 11, 01, 16, 30, 00),
                    arrivalDate = new DateTime(2017, 11, 01, 19, 30, 00), seatsLeft = 100 },
                //Bergen - Brussels
                new Schedule { route = routes[9], departureDate = new DateTime(2017, 11, 01, 08, 00, 00),
                    arrivalDate = new DateTime(2017, 11, 01, 12, 00, 00), seatsLeft = 100 },
                new Schedule { route = routes[10], departureDate = new DateTime(2017, 11, 01, 13, 00, 00),
                    arrivalDate = new DateTime(2017, 11, 01, 17, 00, 00), seatsLeft = 100 },
                //Bergen - Alta
                new Schedule { route = routes[11], departureDate = new DateTime(2017, 11, 02, 08, 00, 00),
                    arrivalDate = new DateTime(2017, 11, 01, 09, 30, 00), seatsLeft = 100 },
                new Schedule { route = routes[12], departureDate = new DateTime(2017, 11, 01, 10, 30, 00),
                    arrivalDate = new DateTime(2017, 11, 01, 12, 00, 00), seatsLeft = 100 },
                //Bergen - Munchen
                new Schedule { route = routes[13], departureDate = new DateTime(2017, 11, 02, 13, 00, 00),
                    arrivalDate = new DateTime(2017, 11, 02, 16, 00, 00), seatsLeft = 100 },
                new Schedule { route = routes[14], departureDate = new DateTime(2017, 11, 21, 17, 00, 00),
                    arrivalDate = new DateTime(2017, 11, 02, 20, 00, 00), seatsLeft = 100 },
                //Bergen - Warszawa
                new Schedule { route = routes[13], departureDate = new DateTime(2017, 11, 02, 21, 00, 00),
                    arrivalDate = new DateTime(2017, 11, 03, 01, 00, 00), seatsLeft = 100 },
                new Schedule { route = routes[14], departureDate = new DateTime(2017, 11, 03, 07, 00, 00),
                    arrivalDate = new DateTime(2017, 11, 03, 11, 00, 00), seatsLeft = 100 },

            };

            //legg alle routene inn i databasen
            routes.ForEach(r => context.Routes.Add(r));
            //legg alle schedules inn i databasen
            schedules.ForEach(s => context.Schedules.Add(s));

            base.Seed(context);
        }
    }
}