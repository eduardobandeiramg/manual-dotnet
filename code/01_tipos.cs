// Sendo uma linguagem puramente orientada a objetos, em C# não é possível declarar "top-level statements".
// Ou seja, tudo deve estar dentro de classes.
// Isso só é permitido dentro do arquivo Program.cs porque a linguagem entende que é neste arquivo específico que está o metodo main dentro da classe Program. 

// string valor = "conjunto de caracteres"; -> X

class Tipos
{
    // Tipos Primitivos Principais
    string conjuntoDeCaracteres = "conjunto de caracteres"; //DEVE estar entre aspas duplas
    char apenasUmCaractere = 'a'; //DEVE estar entre aspas simples
    bool booleano = true;
    int inteiro = 3;
    double valorFloat = 3.3;

    // Outros Tipos Primitivos:
    // float, etc etc etc

    string nome = "eduardo";
    string sobrenome = "bandeira";

    void imprimeNomeCompleto() {

        Console.WriteLine(nome + sobrenome);
    }

}