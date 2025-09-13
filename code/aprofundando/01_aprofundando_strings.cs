class AprofundandoStrings
{
    public static void aprofundandoStrings()
    {
        string textoString = "string";

        // Concatenação de Strings:
            // Com soma
        string concatenandoComSoma = "Para concatenar strings pode-se usar o operador" + " de soma";
            // Com chaves
        string concatenandoComChaves = $"Também é possível usar o cifrão antes do início da {textoString} para sinalizar ao interpretador que as chaves serão usadas para concatenação.";
            // Com sequência de chaves
        Console.WriteLine("A função writeline identifica inteiros entre chaves e concatena as variáveis em ordem. {0}s, {1}s e mais {2}s", textoString, textoString, textoString);

        // String Literal Verbatim:
        string stringVerbatim = @"Isso é uma string literal verbatim. Isso significa que todos os caracteres são interpretados como literais. Assim, o que seria uma quebra de linha com \n é interpretado como texto puro. Além disso, é possível
        quebrar
        linhas
        sem precisar de 
        marcadores especiais.";
    }
}