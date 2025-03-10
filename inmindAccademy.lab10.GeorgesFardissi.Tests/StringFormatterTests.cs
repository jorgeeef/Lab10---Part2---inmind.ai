using Xunit;

namespace inmindAccademy.lab10.GeorgesFardissi.Tests;

public class StringFormatterTests
{
    [Fact]
    public void ToSnakeCase_ShouldConvertToSnakeCase()
    {
        Assert.Equal("hello_world", StringFormatter.ToSnakeCase("Hello World"));
    }

    [Fact]
    public void ToPascalCase_ShouldConvertToPascalCase()
    {
        Assert.Equal("HelloWorld", StringFormatter.ToPascalCase("hello world"));
    }

    [Fact]
    public void ToKebabCase_ShouldConvertToKebabCase()
    {
        Assert.Equal("hello-world", StringFormatter.ToKebabCase("Hello World"));
    }

    [Fact]
    public void ToCamelCase_ShouldConvertToCamelCase()
    {
        Assert.Equal("helloWorld", StringFormatter.ToCamelCase("Hello World"));
    }
}