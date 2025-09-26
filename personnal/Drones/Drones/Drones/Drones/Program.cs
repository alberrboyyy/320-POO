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

            // Cr?ation de la flotte de drones
            List<Drone> fleet = new List<Drone>();
            List<Building> buildings = new List<Building>();/*
            fleet.Add(new Drone(100, 100, 100, "1"));
            fleet.Add(new Drone(100, 100, 100, "2"));
            fleet.Add(new Drone(100, 100, 100, "3"));
            fleet.Add(new Drone(100, 100, 100, "4"));
            fleet.Add(new Drone(100, 100, 100, "5"));
            fleet.Add(new Drone(100, 100, 100, "6"));
            fleet.Add(new Drone(100, 100, 100, "7"));
            fleet.Add(new Drone(100, 100, 100, "8"));
            fleet.Add(new Drone(100, 100, 100, "9"));
            fleet.Add(new Drone(100, 100, 100, "10"));*/
            buildings.Add(new Building(10, 10, 00, 90, Color.Red));

            // D?marrage
            try
            {
                Application.Run(new AirSpace(fleet, buildings));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}