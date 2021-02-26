using GameLibrary;
using GameLibrary.daoImpl;
using GameLibrary.Interface;
using System;

namespace GameApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            DAOFactory DaoFactory = database.GetDAOFactory();
            TestData testData = new TestData();
            testData.GenerateTo(database);

            ConsoleView cView = new ConsoleView(DaoFactory);
            cView.Begin();
        }
    }
}
