namespace GameLibrary.daoImpl
{
    public class TestData
    {
        public void GenerateTo(Database database)
        {
            database.Cars.Clear();
            database.Details.Clear();

            Engine e1 = new Engine("V8", 0.5, 12, 8, 0.1);
            Engine e2 = new Engine("V6", 0.5, 10, 8, 0.1);
            Engine e3 = new Engine("V12", 0.5, 15, 8, 0.1);

            Accumulator a1 = new Accumulator(60, 0.6, 15, 8, 0.1);
            Accumulator a2 = new Accumulator(80, 0.6, 20, 15, 0.1);
            Accumulator a3 = new Accumulator(70, 0.6, 18, 10, 0.1);

            Disks d1 = new Disks(13, 0.5, 10, 8, 0.1);
            Disks d2 = new Disks(16, 0.5, 12, 9, 0.1);
            Disks d3 = new Disks(18, 0.5, 14, 10, 0.1);

            database.Details.Add(e1.Id, e1);
            database.Details.Add(e2.Id, e2);
            database.Details.Add(e3.Id, e3);

            database.Details.Add(a1.Id, a1);
            database.Details.Add(a2.Id, a2);
            database.Details.Add(a3.Id, a3);

            database.Details.Add(d1.Id, d1);
            database.Details.Add(d2.Id, d2);
            database.Details.Add(d3.Id, d3);
        }
    }
}
