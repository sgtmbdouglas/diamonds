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
    [InlineData("b\nc", "Por favor, digite uma letra a partir da letra c!!")]
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

    [Theory(DisplayName = "Deve Validar se o diamante inicia com A letra a e termina com a letra A")]
    [InlineData('C', "A", 6)]
    [InlineData('G', "A", 14)]

    public void TestDiamondShape(char entry, string expectMessage, int expectLines)
    {
        using(var output = new StringWriter())
        {
                Console.SetOut(output);
                var instanceDiamond = new Diamond();
                instanceDiamond.InputUser = entry;
                instanceDiamond.DiamondShape();
                var response = output.ToString().Split('\n');
                response[0].Should().Contain(expectMessage);
                response.Length.Should().Be(expectLines);
                response[^2].Should().Contain(expectMessage);
        }
    }

    [Theory(DisplayName = "Deve Validar se o usuario fez um input diferente de s(SIM) ou n(NAO")]
    [InlineData("d\nh\ns", "Digite s para 'SIM' e n para 'Nao'...")]
    [InlineData("j\nm\nn", "Digite s para 'SIM' e n para 'Nao'...")]
    public void TestSendEmailValidInput(string entry, string expectMessage)
    {
        using(var output = new StringWriter())
        {
            using( var input = new StringReader(entry))
            {
                Console.SetOut(output);
                Console.SetIn(input);
                var instanceDiamond = new Diamond();
                instanceDiamond.SendEmail();
                var response = output.ToString().Trim().Split('\n');
                response[1].Should().Be(expectMessage);
            }
        }
    }


    [Theory(DisplayName = "Deve Validar se o e-mail foi enviado")]
    [InlineData("s", "Rafael@gmail.com", "Um e-mail foi enviado para Rafael@gmail.com")]
    [InlineData("s", "Richarlisson@hotmail.com", "Um e-mail foi enviado para Richarlisson@hotmail.com")]
    public void TestSendEmail(string choice, string email, string expectMessage)
    {
        using(var output = new StringWriter())
        {
            var entry = choice + "\n" + email;
            using( var input = new StringReader(entry))
            {
                Console.SetOut(output);
                Console.SetIn(input);
                var instanceDiamond = new Diamond();
                instanceDiamond.SendEmail();
                var response = output.ToString().Trim().Split('\n');
                response[^1].Should().Be(expectMessage);
            }
        }
    }
}
