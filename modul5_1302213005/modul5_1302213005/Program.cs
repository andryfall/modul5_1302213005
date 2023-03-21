// See https://aka.ms/new-console-template for more information

internal class program
{
    static void Main(string[] args)
    {
        Penjumlahan.JumlahTigaAngka<double>(13.0, 0.2, 3.0);
    }
}
public class Penjumlahan
{
    public static void JumlahTigaAngka<T>(T input1, T input2, T input3) {
        dynamic i1, i2, i3;
        i1 = input1;
        i2 = input2;
        i3 = input3;

        Console.WriteLine(i1+i2+i3);

    } 
}