namespace ToetsVragen;
class ProgrammaWeer
{
    static async Task<string> GeefWeerberichtAsync()
    {
        var temperatuurTask = ThermoMeter.TemperatuurAsync();
        var windKrachtTask = WindSensor.WindKrachtAsync();

        await Task.WhenAll(temperatuurTask, windKrachtTask);

        var temperatuur = await temperatuurTask;
        var windKracht = await windKrachtTask;

        return "Het is " + temperatuur + " °C en de windkracht is " + windKracht + "Bft";
    }
    static async void Main(string[] args)
    {
        var weerbericht = await GeefWeerberichtAsync();
        Console.WriteLine(weerbericht);
    }
}

class ThermoMeter
{
    public static async Task<int> TemperatuurAsync()
    {
        await Task.Delay(1000);
        return 20;
    }
}

class WindSensor
{
    public static async Task<int> WindKrachtAsync()
    {
        await Task.Delay(1000);
        return 3;
    }
}