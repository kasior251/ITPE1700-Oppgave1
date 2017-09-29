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
            var route1 = new Route
            {
                origin = "Oslo",
                destination = "Mancheser",
                price = 1099.99
            };
            var route1a = new Route
            {
                origin = "Manchester",
                destination = "Oslo",
                price = 1099.99
            };

            var route2 = new Route
            {
                origin = "Oslo",
                destination = "Berlin",
                price = 1099.99
            };

            var route2a = new Route
            {
                origin = "Berlin",
                destination = "Oslo",
                price = 1099.99
            };

            var route3 = new Route
            {
                origin = "Oslo",
                destination = "Tromsø",
                price = 1099.99
            };

            var route3a = new Route
            {
                origin = "Tromsø",
                destination = "Oslo",
                price = 1099.99
            };

            var route4 = new Route
            {
                origin = "Bergen",
                destination = "Berlin",
                price = 1099.99
            };

            var route4a = new Route
            {
                origin = "Berlin",
                destination = "Bergen",
                price = 1099.99
            };

            var route5 = new Route
            {
                origin = "Bergen",
                destination = "Brussels",
                price = 1099.99
            };

            var route5a = new Route
            {
                origin = "Brussels",
                destination = "Bergen",
                price = 1099.99
            };

            var route6 = new Route
            {
                origin = "Bergen",
                destination = "Alta",
                price = 1099.99
            };

            var route6a = new Route
            {
                origin = "Alta",
                destination = "Bergen",
                price = 1099.99
            };


            var route7 = new Route
            {
                origin = "Bergen",
                destination = "Munchen",
                price = 1099.99
            };

            var route7a = new Route
            {
                origin = "Munchen",
                destination = "Bergen",
                price = 1099.99
            };

            var route8 = new Route
            {
                origin = "Bergen",
                destination = "Warszawa",
                price = 1099.99
            };

            var route8a = new Route
            {
                origin = "Warszawa",
                destination = "Bergen",
                price = 1099.99
            };

            //legg alle routene inn i databasen
            context.Routes.Add(route1);
            context.Routes.Add(route1a);
            context.Routes.Add(route2);
            context.Routes.Add(route2a);
            context.Routes.Add(route3);
            context.Routes.Add(route3a);
            context.Routes.Add(route4);
            context.Routes.Add(route4a);
            context.Routes.Add(route5);
            context.Routes.Add(route5a);
            context.Routes.Add(route6);
            context.Routes.Add(route6a);
            context.Routes.Add(route7);
            context.Routes.Add(route7a);
            context.Routes.Add(route8);
            context.Routes.Add(route8a);
            base.Seed(context);
        }
    }
}