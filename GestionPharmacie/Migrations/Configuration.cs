namespace GestionPharmacie.Migrations
{
    using GestionPharmacie.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GestionPharmacie.Model_GestionPharmacie>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(GestionPharmacie.Model_GestionPharmacie context)
        {
            //  This method will be called after migrating to the latest version.
            //Labos Data
            context.Labos.AddOrUpdate(
                
                new Laboratory {
                    Name="LaboOfTangier", Adress="Tangier", Phonenumber="+2126XXXXXXXX", Email="contact@labo.com"
                },
                new Laboratory {
                    Name = "LaboHicham", Adress = "Rabat", Phonenumber = "+2126XXXXXXXX", Email = "contact@labo.com"
                },
                new Laboratory {
                    Name = "FreedomMeds", Adress = "Paris", Phonenumber = "+2126XXXXXXXX", Email = "contact@labo.com"
                },
                new Laboratory {
                    Name = "MedsOfFuture", Adress = "Fes", Phonenumber = "+2126XXXXXXXX", Email = "contact@labo.com"
                }
                );
            //Provider Data
            context.Provider.AddOrUpdate(
                new Provider {
                    Name="MedsUrgent", Adress="Tangier valflourie", Phonenumber = "+2126XXXXXXXX", Email = "contact@Provider.com"
                },

                new Provider {
                    Name = "Medicament Service", Adress = "Tangier Merchane", Phonenumber = "+2126XXXXXXXX", Email = "contact@Provider.com"
                }


                );


        }
    }
}
