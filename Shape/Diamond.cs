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
    public string? EmailUser;

    public void Form()
    {
        WelcomeValid();
        DiamondShape();
        SendEmail();
    }
    
    public void WelcomeValid()
    {
        Console.WriteLine("Insira uma letra apartir de c para ter um lindo diamante");
        string input = Console.ReadLine().ToLower();
        // short - circuit
        while (input.Length != 1 || Char.IsDigit(Char.Parse(input)))
        {
            Console.WriteLine("Numeros ,simbolos ou mais de uma letra nao serao aceitos!!");
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
    public void DiamondShape()
    {
        int indexChar = Alphabet.IndexOf(InputUser);
        for (int i = 0; i <= indexChar; i++)
        {
            for(int a = 0; a < indexChar - i; a++ )
            {
                Console.Write(" "); //rodar 2 veiz
            }
            for(int b = 0; b < 2 * i + 1 ; b++ ) // min 1 vez
            {
                if( b == 0 || b == 2 * i)
                {
                    Console.Write(Alphabet[i]);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            for(int c = 0; c < indexChar - i; c++ )
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
            }
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
            }
            for(int a = 0; a < indexChar - i; a++ )
            {
                Console.Write(" ");  
            }
            Console.Write('\n');
        }
    }
    public void SendEmail()
    {
        Console.WriteLine("Gostaria de receber seu diamante por e-mail?");
        Console.WriteLine("Digite s para 'SIM' e n para 'Nao'...");
        string input = Console.ReadLine().ToLower();
        while (input != "s" && input != "n")
        {
            Console.WriteLine("Digite s para 'SIM' e n para 'Nao'...");
            input = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Por favor, informe seu e-mail");
        string emailUser = Console.ReadLine();
        EmailUser = emailUser;
    }

}

// porque indexOf NAO Aceita []char?