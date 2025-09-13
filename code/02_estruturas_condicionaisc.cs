public class EstruturasCondicionais
{
    // Operador ternário
    bool verificaParOuImpar1(int numero)
    {
        return numero % 2 == 0;
    }

    // If-else classico
    bool verificaParOuImpar2(int numero)
    {
        if (numero % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Switch-case
    int retornaProprioNumero(int numero)
    {
        switch (numero)
        {
            case < 10:
                Console.WriteLine("É uma unidade");
                return numero;
            case > 9 and < 100:
                Console.WriteLine("É uma dezena");
                return numero;
            default:
                Console.WriteLine("É maior que uma centena");
                return numero;

        }
    }

    // Switch-case com fall-through
    bool eVogal(char caractere)
    {
        switch (caractere)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("É vogal!");
                return true;
            default:
                Console.WriteLine("Não é vogal!");
                return false;
        }
    }
}