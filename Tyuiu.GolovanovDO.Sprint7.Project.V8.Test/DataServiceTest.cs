using Microsoft.Testing.Platform.Extensions.Messages;
using System.Text;
using Tyuiu.GolovanovDO.Sprint7.Project.V8.Lib;

namespace Tyuiu.GolovanovDO.Sprint7.Project.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private string testFile;
        private string testFileSave;
        private DataService ds;
        string[,] testArray;


        [TestInitialize]
        public void TestSetup()
        {
            ds = new DataService();
            testFile = "test_employees_" + Guid.NewGuid().ToString() + ".csv";
            testFileSave = "test_save_" + Guid.NewGuid().ToString() + ".csv";

            string fileContent =
            "001;Иванов;Александр;Сергеевич;15.05.1985;12;85000\n" +
            "002;Петров;Дмитрий;Александрович;22.11.1978;20;95000\n" +
            "003;Сидоров;Михаил;Владимирович;03.07.1990;8;65000\n" +
            "004;Кузнецов;Андрей;Игоревич;18.09.1982;15;90000\n" +
            "005;Смирнов;Сергей;Олегович;30.01.1995;5;55000";

            File.WriteAllText(testFile, fileContent, Encoding.UTF8);

            testArray = new string[,]{
                { "001", "Иванов", "Александр", "Сергеевич", "15.05.1985", "12", "85000"},
                { "002", "Петров", "Дмитрий", "Александрович", "22.11.1978", "20", "95000"},
                { "003", "Сидоров", "Михаил", "Владимирович", "03.07.1990", "8", "65000" },
                { "004", "Кузнецов", "Андрей","Игоревич", "18.09.1982", "15", "90000" },
                { "005", "Смирнов", "Сергей", "Олегович", "30.01.1995", "5", "55000" }
                                    };                                  
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (File.Exists(testFile))
                File.Delete(testFile);

            if (File.Exists(testFileSave))
                File.Delete(testFileSave);
        }

        [TestMethod]
        public void SaveToFile_Test()
        {       

            string[] waitLines = {"001;Иванов;Александр;Сергеевич;15.05.1985;12;85000",
                                      "002;Петров;Дмитрий;Александрович;22.11.1978;20;95000",
                                      "003;Сидоров;Михаил;Владимирович;03.07.1990;8;65000",
                                      "004;Кузнецов;Андрей;Игоревич;18.09.1982;15;90000",
                                      "005;Смирнов;Сергей;Олегович;30.01.1995;5;55000"
                                  };

            ds.SaveToFile(testFileSave, testArray);
            Assert.IsTrue(File.Exists(testFileSave));

            string[] actualLines = File.ReadAllLines(testFileSave, Encoding.UTF8);

            CollectionAssert.AreEqual(waitLines, actualLines);

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

        [TestMethod]
        public void MinYearExperience_Test()
        {
            int res = ds.MinYearExperience(testArray);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void MaxYearExperience_Test()
        {
            int res = ds.MaxYearExperience(testArray);
            Assert.AreEqual(20, res);
        }

        [TestMethod]
        public void AvgYearExperience_Test()
        {
            int res = ds.AvgYearExperience(testArray);
            Assert.AreEqual(12, res);   
        }

        [TestMethod]
        public void MinSalary_Test()
        {
            int res = ds.MinSalary(testArray);
            Assert.AreEqual(55000, res);
        }

        [TestMethod]
        public void MaxSalary_Test()
        {
            int res = ds.MaxSalary(testArray);
            Assert.AreEqual(95000, res);
        }

        [TestMethod]
        public void AvgSalary_Test()
        {
            int res = ds.AvgSalary(testArray);
            Assert.AreEqual(78000, res);
        }

        [TestMethod]
        public void Search_Test()
        {
            //Одно совпадение
            string[,] result_OneCoincidence = ds.Search(testArray, "Иванов");
            Assert.AreEqual(1, result_OneCoincidence.GetLength(0));
            Assert.AreEqual("001", result_OneCoincidence[0, 0]);
            Assert.AreEqual("Иванов", result_OneCoincidence[0, 1]);

            //Несколько совпадений
            string[,] result_TwoCoincidence = ds.Search(testArray, "О");
            Assert.AreEqual(5, result_TwoCoincidence.GetLength(0));

        }

        [TestMethod]
        public void GetFullName_Test()
        {
            string res = ds.GetFullName(testArray, 1);
            Assert.AreEqual("Петров Дмитрий Александрович", res);
        }

        [TestMethod]
        public void GetAllFullName_Test()
        {
            string[] res = ds.GetAllFullName(testArray);
            string[] wait = {
                "Иванов Александр Сергеевич",
                "Петров Дмитрий Александрович",
                "Сидоров Михаил Владимирович",
                "Кузнецов Андрей Игоревич",
                "Смирнов Сергей Олегович"
                            };
            CollectionAssert.AreEqual(wait,res);
        }

        [TestMethod]
        public void MostOldPeople_Test()
        {
            int res = ds.MostOldPeople(testArray);
            Assert.AreEqual(47, res);
        }

        [TestMethod]
        public void MostYoungPeople_Test()
        {
            int res = ds.MostYoungPeople(testArray);
            Assert.AreEqual(30, res);
        }

        [TestMethod]
        public void AvgPeopleAge_Test()
        {
            double res = ds.AvgPeopleAge(testArray);
            Assert.AreEqual(39.0, res);
        }
    }
}
