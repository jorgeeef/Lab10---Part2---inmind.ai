namespace inmindAccademy.lab10.GeorgesFardissi;

public class StringStatistics
{
    public static int CountWords(string input)
    {
        return string.IsNullOrWhiteSpace(input) ? 0 : input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static int CountCharacters(string input)
    {
        return input?.Length ?? 0;
    }

    public static string MostCommonWord(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return string.Empty;

        var words = input.ToLower().Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.GroupBy(word => word)
            .OrderByDescending(group => group.Count())
            .FirstOrDefault()?.Key ?? string.Empty;
    }
}