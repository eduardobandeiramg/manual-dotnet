public class Funcoes
{
    // Função padrão sem retorno
    void funcaoSemRetorno(string parametroString, int parametroInteiroOpcional = 2)
    {
        // No C#, todos os atributos são nomeados e podem ser chamados explicitando seus nomes ou não.
    }

    // Função padrão com retorno
    string funcaoComRetorno()
    {
        return "retorno";
    }

    // Função com parâmetro de saída
    public bool eParRetornaDobro(int numero, out int dobro)
    {
        // O out trata-se de um valor "extra" que a função retorna além do seu retorno padrão, que pode ser acessado ao chamar a função.
        dobro = numero * 2;
        return numero % 2 == 0 ? true : false;
    }
}