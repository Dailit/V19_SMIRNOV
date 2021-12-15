using System.Text.RegularExpressions;
class Program

{

    static void Main(string[] args)
    {
        Console.Write("Введите кол-во минут ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите текст ");
        var text = Console.ReadLine();        
        Console.WriteLine(ReplaceTime(text, n));

        Console.ReadKey();
    }

    private static string ReplaceTime(string sentence, int minutes)
    {
        var templ = @"\d{1,3}:\d{1,3}";
        var results = Regex.Matches(sentence, templ);
        for (var i = 0; i < results.Count; i++)
        {
            var hhss = results[i].Value.Split(':');
            var hh = Convert.ToInt32(hhss[0]);
            var mm = Convert.ToInt32(hhss[1]);
            if (hh >= 0 && hh < 24 && mm >= 0 && mm < 60)
            {
                var time = new TimeSpan(hh, mm, 0).Add(new TimeSpan(00, minutes, 0));
                sentence = Regex.Replace(sentence, templ, time.ToString(@"hh\:mm"));
            }
        }
        return sentence;
    }
}