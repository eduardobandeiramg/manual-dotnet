class EstruturasDados
{
    // Arrays
    static public int[] arrayInteiros = { 2, 4, 6, 8, 10 };
    // arrays são muito limitados. Têm tamanho fixo definido no momento da inicialização e não é possível adicionar ou remover valores.
    static public int[] arrayInteiros2 = [5]; // Pode-se atribuir valores depois. -> arrayInteiros[0] = 1; arrayInteiros[1] = 2 ...

    // Listas
    static public List<string> listaSacolao = new List<string>() { "banana", "mamão", "uva" };
    static public List<string> listaFarmacia = new List<string>();
    List<dynamic> listaDinamica = new List<dynamic>();
    public static string[] listaDeStrings = { "primeiro", "segundo", "terceiro" };

    void adicionarItemListaFarmacia(string item)
    {
        listaFarmacia.Add(item);
    }

    // Listas Encadeadas
    LinkedList<int> listaEncadeada = new LinkedList<int>();

    // Filas (FIFO)
    public static Queue<int> fila = new Queue<int>();

    // Pilhas (LIFO)
    public static Stack<int> pilha = new Stack<int>();

    // Mapas/Dicionários
    public static Dictionary<dynamic, dynamic> dicionarioVazio = new Dictionary<dynamic, dynamic>();
    public static Dictionary<string, int> dicionarioInicializado = new Dictionary<string, int>() { { "Eduardo", 27 }, { "Ernesto", 46 } };

    // Dicionários Ordenados (pela chave)
    SortedDictionary<string, int> dicionarioOrdenado = new SortedDictionary<string, int>();
    
    // Conjuntos
    HashSet<int> conjunto = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7 };

    // Conjuntos Ordenados
    SortedSet<int> conjuntoOrdenado = new SortedSet<int>() { 7, 8, 3, 4, 1, 9, 11 };

}