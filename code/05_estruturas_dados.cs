class EstruturasDados
{
    // Listas
    static public List<string> listaSacolao = new List<string> () { "banana", "mamão", "uva" };
    static public List<string> listaFarmacia = new List<string> ();
    List<dynamic> listaDinamica = new List<dynamic>();
    public static string[] listaDeStrings = { "primeiro", "segundo", "terceiro" };

    void adicionarItemListaFarmacia(string item)
    {
        listaFarmacia.Add(item);
    }

    // Mapas/Dicionários
    Dictionary<dynamic, dynamic> dicionarioVazio = new Dictionary<dynamic, dynamic>();
    Dictionary<string, int> dicionarioInicializado = new Dictionary<string, int> () { {"Eduardo", 27}, {"Ernesto", 46} };
}