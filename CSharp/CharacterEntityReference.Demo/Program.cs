using My.Text;

class Program
{
    public static void Main()
    {
        var text = "&quot;abcdef&quot;";
        var text2 = "\\";

        var result = CharacterEntityReference.ConvertFrom(text);
        var result2 = CharacterEntityReference.ConvertTo(text2, true);

        Console.WriteLine(result);
        Console.WriteLine(result2);
    }
}
