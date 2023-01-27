namespace Form;
// using System;

public class Diamond
{
    public List<char> Alphabet = new(){
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
        FindLeter();
    }
    
    public void WelcomeValid()
    {
        Console.WriteLine("Insira uma letra apartir de c para ter um lindo diamante");
        // var inputUser = Console.ReadLine().ToLower();

        string input = Console.ReadLine().ToLower();
        // short - circuit
        while (input.Length != 1 || Char.IsDigit(Char.Parse(input)))
        {
            Console.WriteLine("Numeros ,simbolos ou mais de uma letra nao serao aceitos!!");
        // Console.Write("Type again!\n");
            input = Console.ReadLine()!;
        }
        InputUser = Char.Parse(input);
        if(InputUser == 'a' || InputUser == 'b')
            {
                Console.WriteLine("Por favor, digite um 'Uma' letra a partir da letra c!!");
                WelcomeValid();
            }
        //     while(Char.IsLetter(Char.Parse(inputUser)))
    }
    public void FindLeter()
    {
        int indexChar = Alphabet.IndexOf(InputUser);
        // Console.WriteLine(indexChar);
        for (int i = 0; i <= indexChar; i++)
        {
            for(int a = 0; a < indexChar - i; a++ )
            {
                Console.Write(" ");
                // Console.Write("segundo for === saiu = ");
            }
            // Console.WriteLine(i);
            for(int b = 0; b < 2 * i + 1 ; b++ )
            {
                if( b == 0 || b == 2 * i)
                {
                    Console.Write(Alphabet[i]);
                }
                else
                {
                    Console.Write(" ");
                }
                // Console.Write(Alphabet[i]);
                // Console.WriteLine("\n");
            }
            for(int a = 0; a < indexChar - i; a++ )
            {
                Console.Write(" ");  
            }
            Console.Write('\n');
        }
        for (int i = indexChar -1; i >= 0; i--)
        {
            for(int a = 0; a < indexChar - i; a++ )
            {
                Console.Write(" ");
                // Console.Write("segundo for === saiu = ");
            }
            // Console.WriteLine(i);
            for(int b = 0; b < 2 * i + 1 ; b++ )
            {
                if( b == 0 || b == 2 * i)
                {
                    Console.Write(Alphabet[i]);
                }
                else
                {
                    Console.Write(" ");
                }
                // Console.Write(Alphabet[i]);
                // Console.WriteLine("\n");
            }
            for(int a = 0; a < indexChar - i; a++ )
            {
                Console.Write(" ");  
            }
            Console.Write('\n');
        }
    }

}

// porque indexOf NAO Aceita []char?
// qual a diferenca entre writeLine e write