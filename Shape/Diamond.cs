// using Letterss;

namespace Form;

public class Diamond
{
    // public Letters Leters { get; set; }
    public char[] letra = new char[] {
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
        foreach (char letraa in letra)
        {
            Console.WriteLine("letra" + letraa);
        }
    }

}