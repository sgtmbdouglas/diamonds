namespace Form;

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


    public void Form()
    {
        Welcome();
        inputValidate();
        // olhar tabela ascii 2
        // {
        //     Console.WriteLine("letraaaaaa" + letra);
        // }
    }
    
    public int Welcome()
    {
        do
            {
                Console.WriteLine("insira uma letra apartir de c para ter um lindo diamante");
                var inputUser = char.Parse(Console.ReadLine().ToLower());
                var charConvert = Char.IsLetter(inputUser);
                Console.WriteLine(charConvert);
            }
            while (true);
    }

}