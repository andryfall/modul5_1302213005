// See https://aka.ms/new-console-template for more information

internal class program
{
    static void Main(string[] args)
    {
        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.AddNewData(13.0);
        data.AddNewData(2.0);
        data.AddNewData(5.0);
        data.PrintAllData();
    }
}
public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase() {
        storedData= new List<T>();
        inputDates= new List<DateTime>();
    }

    public void AddNewData(T input)
    {
        storedData.Add(input);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 1; i <= storedData.Count; i++)
        {
            Console.WriteLine("Data " + i + " berisi: " + storedData[i-1] + ", yang disimpan pada waktu UTC: " + inputDates[i-1]);
        }
    }
}