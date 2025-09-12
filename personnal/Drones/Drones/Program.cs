using Drones.Model;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet = new List<Drone>();
            List<Building> buildings = new List<Building>();
            fleet.Add(new Drone("1",100,100));
            fleet.Add(new Drone("2",100,250));
            fleet.Add(new Drone("3",100,290));
            fleet.Add(new Drone("4",100,300));
            fleet.Add(new Drone("5", 00, 90));
            buildings.Add(new Building(10, 10, 00, 90, Color.Red));

            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}