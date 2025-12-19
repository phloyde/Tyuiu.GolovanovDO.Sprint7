using Microsoft.Testing.Platform.Extensions.Messages;
using System.Text;
using Tyuiu.GolovanovDO.Sprint7.Project.V8.Lib;

namespace Tyuiu.GolovanovDO.Sprint7.Project.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        string[,] testArray;
        public string testFile = "test_employees.csv";
        [TestInitialize]
        public void TestSetup()
        {   
            string testFile = "test_employees.csv";
            string fileContent =
        "001;Иванов;Александр;Сергеевич;15.05.1985;12;85000;;\n" +
        "002;Петров;Дмитрий;Александрович;22.11.1978;20;95000;;\n" +
        "003;Сидоров;Михаил;Владимирович;03.07.1990;8;65000;;\n" +
        "004;Кузнецов;Андрей;Игоревич;18.09.1982;15;90000;;\n" +
        "005;Смирнов;Сергей;Олегович;30.01.1995;5;55000;;";

            File.WriteAllText(testFile, fileContent, Encoding.UTF8);


            testArray = new string[,]
            {
                { "001;Иванов;Александр;Сергеевич;15.05.1985;12;85000" },
                { "002;Петров;Дмитрий;Александрович;22.11.1978;20;95000"},
                { "003;Сидоров;Михаил;Владимирович;03.07.1990;8;65000" },
                { "004;Кузнецов;Андрей;Игоревич;18.09.1982;15;90000" },
                { "005;Смирнов;Сергей;Олегович;30.01.1995;5;55000" }
            };
        }


        [TestMethod]
        public void LoadFromFile_Test()
        {
            string[,] wait ={
                {"001", "Иванов", "Александр", "Сергеевич", "15.05.1985", "12", "85000"},
                { "002", "Петров", "Дмитрий", "Александрович", "22.11.1978", "20", "95000"},
                { "003", "Сидоров", "Михаил", "Владимирович", "03.07.1990", "8", "65000" },
                { "004", "Кузнецов", "Андрей","Игоревич", "18.09.1982", "15", "90000" },
                { "005", "Смирнов", "Сергей", "Олегович", "30.01.1995", "5", "55000" }
                            };

            string[,] result = ds.LoadFromFile(testFile);

            CollectionAssert.AreEqual(wait, result);

        }
    }
}
