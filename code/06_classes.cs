// Classe padrão com construtor definido dentro do seu corpo
public class Usuario
{
    private string _nome;
    private string _id;
    private string _cpf;
    private DateTime _dataNascimento;

    public Usuario(string nome, string id, string cpf, DateTime dataNascimento)
    {
        _nome = nome;
        _id = id;
        _cpf = cpf;
        _dataNascimento = dataNascimento;

    }

}

// Classe com construtor definido junto à definição. 
// Os parâmetros ficam disponíveis por todo o corpo da classe, podendo sere utilizados tanto para inicializar atributos como para serem parametros de métodos da classe.
public class Usuario2(string nome, string id, string cpf, DateTime dataNascimento)
{

    private string nome = nome;
    private string _id = id;
    private string _cpf = cpf;
    private DateTime _dataNascimento = dataNascimento;
}

// Classe sem construtor definido
public class Usuario3
{
    public string? nome;
    public string? id;
    public string? cpf;
    public DateTime? dataNascimento;
}

// Classe com estrutura pronta para getters e setters:
public class Usuario4()
{
    public string? nome
    { get; set; } // Pode-se definir que alguns atributos podem ser acessados para leitura e escrita. Para isso, deixa-se ele público e explicita-se quais vão ser as operações permitidas. Como esperado de um método setter, é possível definir processamentos e validações para uma ação de escrita. Na prática, o que acontece é que são criados métodos com o mesmo nome do atributo.
    public string? id { get; } // Pode-se definir que alguns atributos podem ser acessados para leitura. Para isso, deixa-se ele público e explicita-se quais vão ser as operações permitidas. 
    public string? cpf { get; }
    public DateTime? dataNascimento { get; }
}

// Classe que utiliza getters e setters dos atributos de acordo com a convenção da linguagem
class Usuario5
{
    // A forma convencional é manter os atributos da classe PRIVADOS...
    private string? _nome;
    private string? _id;
    private string? _cpf;
    private DateTime? _dataNascimento;

    // E deixar público apenas as propriedades, nome que se dá à 'interface' de acesso dos atributos da classe.
    // Convencionou-se nomear as propriedades com o mesmo nome dos atributos e primeira letra maiúscula.
    public string? Nome { get; set; }
}

// Classe que utiliza propriedades com detalhes de implementação
class Usuario6
{
    // Atributos de classe (privados):
    private string? _nome;
    private string? _id;
    private string? _cpf;
    private DateTime _dataNascimento;

    // Propriedade do atributo nome:
    public string? Nome
    {
        get
        {
            return _nome;
            return $"O nome do usuário é: {_nome}";
        }
        set
        {
            if (value is string)
            {
                _nome = value;
            }
            else
            {
                System.Console.WriteLine("Nome precisa ser uma string!");
            }
        }
    }

    // Propriedade do atributo id (neste caso, como a propriedade será somente de leitura, pode-se usar uma arrow function para ficar mais conciso):
    public string? Id => _id;
    public string? Cpf => $"O CPF do usuário é: {_cpf}";
}

// se tiver só um atributo opcional sem construtor da pra usar o operador de construcao de objeto? Testar
// por que propriedades respeitam o aberto-fechado? -> historico chat
// como usar required e por que nao pode ser privado