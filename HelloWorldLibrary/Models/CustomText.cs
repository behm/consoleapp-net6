namespace HelloWorldLibrary.Models;

internal class CustomText
{
    public string Language { get; set; }
    public Dictionary<string, string> Translations { get; set; } = new Dictionary<string, string>();
}
