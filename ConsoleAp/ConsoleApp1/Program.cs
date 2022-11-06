namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            ManagerClass schoolManagement = ManagerClass.getInstance();
            try
            {
                while (true)
                {
                    Console.Clear();
                    schoolManagement.MainMenu();
                    Console.WriteLine("Enter your choice: ");
                    int menuChoice = Convert.ToInt32(Console.ReadLine());
                    switch (menuChoice)
                    {
                        case 1:
                            schoolManagement.MenuView();
                            schoolManagement.controlView();
                            break;
                        case 2:
                            schoolManagement.MenuAdd();
                            schoolManagement.controlCreate();
                            break;
                        case 3:
                            schoolManagement.MenuUpdate();
                            schoolManagement.ControllUpdate();
                            break;
                        case 4:
                            schoolManagement.MenuFind();
                            schoolManagement.controlFind();
                            break;
                        case 5:
                            schoolManagement.MenuDelete();
                            schoolManagement.controlDelete();
                            break;
                        case 6:
                            return;
                        default:
                            Console.WriteLine("Invalid input!!!");
                            break;


                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
}
