using Xunit;
using System.IO;
using System;
using FluentAssertions;

namespace Form.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Deve Validar se a entrada e um caractere valido")]
    [InlineData("3\njh\n*\nJ", 4)]
    [InlineData("c", 1)]
    public void TestValidEntry(string entry, int expectLines)
    {
        using(var output = new StringWriter())
        {
            using( var input = new StringReader(entry))
            {
                Console.SetOut(output);
                Console.SetIn(input);
                var instanceDiamond = new Diamond();
                instanceDiamond.WelcomeValid();
                var response = output.ToString().Trim().Split('\n');
                response.Length.Should().Be(expectLines);
            }
        }
    }

    [Theory(DisplayName = "Deve Validar a mensagem retornada em caso de erro no input do usuario")]
    [InlineData("3\nj", "Numeros ,simbolos ou mais de uma letra nao serao aceitos!!")]
    [InlineData("b\nc", "Por favor, digite um 'Uma' letra a partir da letra c!!")]
    public void TestMessage(string entry, string expectMessage)
    {
        using(var output = new StringWriter())
        {
            using( var input = new StringReader(entry))
            {
                Console.SetOut(output);
                Console.SetIn(input);
                var instanceDiamond = new Diamond();
                instanceDiamond.WelcomeValid();
                var response = output.ToString().Trim().Split('\n');
                response[1].Should().Be(expectMessage);
            }
        }
    }
}