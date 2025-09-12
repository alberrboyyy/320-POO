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
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();
            fleet.Add(new Drone("1",100,100));
            fleet.Add(new Drone("2",100,250));
            fleet.Add(new Drone("3",100,290));
            fleet.Add(new Drone("4",100,300));
            fleet.Add(new Drone("5",100,90));

            // Démarrage
            Application.Run(new AirSpace(fleet));
        }
    }
}