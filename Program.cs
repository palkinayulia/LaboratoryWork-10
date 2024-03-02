namespace Лабораторная_работа__10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Watch clock1 = new Watch();
            clock1.Show();
            Watch clock2 = new Watch("casio", 2015);
            clock2.Show();

            DigitalWatch clock3 = new DigitalWatch();
            clock3.Show();
            DigitalWatch clock4 = new DigitalWatch("clocks", 2000, "led");
            clock4.Show();

            AnalogWatch clock5 = new AnalogWatch();
            clock5.Show();
            AnalogWatch clock6 = new AnalogWatch("pop", 2017, "classic");
            clock6.Show();

            SmartWatch clock7 = new SmartWatch();
            clock7.Show();
            SmartWatch clock8 = new SmartWatch("wow", 1900, "android", true);
            clock8.Show();

            Watch[] arr = {clock1 ,clock2 ,clock3 ,clock4 ,clock5 ,clock6, clock7, clock8 };
            foreach (Watch item in arr) { item.Show(); }
        }
    }
}
