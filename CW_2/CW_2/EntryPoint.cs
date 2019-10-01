namespace CW_2
{
    /// <summary>
    /// Main class
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Entry Point
        /// </summary>
        static void Main()
        {
            University bsu = new University();
            Department rpct = new Faculty("RPCT", "Minsk", "Kurchatova", "5");
            Department rpctCopy = new Faculty("RPCT", "Minsk", "Kurchatova", "5");
            Department management = new Management("Management","Moscow","Pushkina","Colotushkina");
            Department managementButDifferentType = new Institute("Management", "Moscow", "Pushkina", "Colotushkina");
            bsu.DisplayDepartments();
            bsu.AddDepartment(rpct);
            bsu.AddDepartment(rpctCopy);
            bsu.AddDepartment(management);
            bsu.AddDepartment(managementButDifferentType);
            bsu.DisplayDepartments();
        }
    }
}
