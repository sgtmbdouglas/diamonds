namespace Form;
// using System;

public class Diamond
{
    public char[] alphabet = new char[] {
        'a',
        'b',
        'c',
        'd',
        'e',
        'f', 
        'g',
        'h',
        'i',
        'j',  //10    elemento
        'k',  //10    index
        'l',
        'm',
        'n',
        'o',
        'p',
        'q',
        'r',
        's',
        't',  // 20   elemento
        'u',  //20    index
        'v',
        'w',
        'x',
        'y',
        'z',
        };
    public char InputUser;
    // public IEnumerable<char>
    public bool IsChar = false;


    public void Form()
    {
        WelcomeValid();
        // FindLeter();
    }
    
    public void WelcomeValid()
    {
        Console.WriteLine("Insira uma letra apartir de c para ter um lindo diamante");
        // var inputUser = Console.ReadLine().ToLower();

        var input = Console.ReadLine().ToLower();
        // short - circuit
        while (input.Length != 1 || Char.IsDigit(Char.Parse(input)))
        {
            Console.WriteLine("Numeros ,simbolos ou mais de uma letra nao serao aceitos!!");
        // Console.Write("Type again!\n");
            input = Console.ReadLine()!;
        }
        InputUser = Char.Parse(input);
        if(InputUser == 'a' || InputUser == 'b' || InputUser == 'c')
            {
                Console.WriteLine("Por favor, digite um 'Uma' letra a partir da letra c!!");
                WelcomeValid();
            }
        //     while(Char.IsLetter(Char.Parse(inputUser)))
    }
    public void FindLeter()
    {
    }

}