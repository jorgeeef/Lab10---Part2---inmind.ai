namespace inmindAccademy.lab10.GeorgesFardissi;

public class StringFormatter
{
    public static string ToSnakeCase(string input)
    {
        return string.IsNullOrEmpty(input) ? input : string.Join("_", input.Split(' ')).ToLower();
    }

    public static string ToPascalCase(string input)
    {
        return string.IsNullOrEmpty(input) ? input : string.Join("", input.Split(' ').Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
    }

    public static string ToKebabCase(string input)
    {
        return string.IsNullOrEmpty(input) ? input : string.Join("-", input.Split(' ')).ToLower();
    }

    public static string ToCamelCase(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        string pascal = ToPascalCase(input);
        return char.ToLower(pascal[0]) + pascal.Substring(1);
    }
}