class Loops
{
    // Loop for
    void loopFor()
    {
        // Com declaração de variável e definição de condições:
        for (int a = 0; a < 100; a++)
        {
            Console.WriteLine(a);
        }
        // Percorrendo uma lista:
        List<int> lista = [1, 2, 3, 4, 5, 6, 7];
        foreach (int a in lista)
        {
            Console.WriteLine(a);
        }
    }

    // Loop While
    void loopWhile()
    {
        int controlador = 0;
        while (controlador < 100)
        {
            Console.WriteLine(controlador);
            controlador--;
        }
    }

    // Loop do-while
    void loopDoWhile()
    {
        int controlador = 0;
        do
        {
            controlador--;
            Console.WriteLine("a");
        } while (controlador < 100);
    }

}