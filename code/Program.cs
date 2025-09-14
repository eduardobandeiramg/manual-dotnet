// Chamando a função com parâmetro de saída:
Funcoes objetoFuncoes = new Funcoes();
bool resultado = objetoFuncoes.eParRetornaDobro(5, out int dobro);
Console.WriteLine($"O valor retornado pela função é: {resultado} e o dobro é igual a {dobro}");

AprofundandoStrings.aprofundandoStrings();

Console.WriteLine(EstruturasDados.listaDeStrings);


// ** Lidando com classes e objetos **
    // Instanciando classes com construtores definidos:
Usuario usuario1 = new Usuario(nome: "Eduardo", id: "123", cpf: "123.456.789-00", dataNascimento: new DateTime(2000, 1, 1));
Usuario2 usuario2 = new Usuario2(nome: "Eduardo", "123", "123.456.789-00", dataNascimento: new DateTime(2000, 1, 1));

    // Instanciando classe sem construtor definido:
Usuario3 usuario3_1 = new Usuario3();
Usuario3 usuario3_2 = new Usuario3() { nome = "Eduardo" }; // Caso o atributo seja público, é possível defili-lo no momento da instanciação. É uma alternativa mais curta e direta à criar o objeto e depois atribuir valor ao atributo.

// Instanciando classe com atributos getters e setters
Usuario4 usuario4 = new Usuario4();
usuario4.nome = "Eduardo";
System.Console.WriteLine(usuario4.nome);
System.Console.WriteLine(usuario4.id);
//usuario4.id = "123"; -> Este código daria erro, pois não há setter definido para id

Usuario6 usuario6 = new Usuario6();
usuario6.Nome = "123";
System.Console.WriteLine(usuario6.Nome);