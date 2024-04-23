using ProjectCinema.Menus;
using ProjectCinema.Banco;
using ProjectCinema.Modelos;

var context = new Connection();
var produtoDAL = new DAL<Item>(context);


Dictionary<int, Menu> opcoes = new()
{
    { 1, new MenuRegistrarProduto() },
    { 2, new MenuMostrarProdutosRegistrados() },
    { 3, new MenuConsultarPreco() },
    { 4, new MenuAlterarPreco() },
    { 5, new MenuRemoverItem() },
    { 0, new MenuSair() }
};


void ExibirMenu()
{
    Console.Clear();
    Console.WriteLine("Bem vindo(a) ao ProjectC");
    Console.WriteLine("\n1. Registrar produto");
    Console.WriteLine("2. Mostrar todos os produtos em estoque");
    Console.WriteLine("3. Consultar preço do produto");
    Console.WriteLine("4. Alterar preço do produto");
    Console.WriteLine("5. Remover produto");
    Console.WriteLine("0. Sair.");

    Console.WriteLine("\nO que você deseja fazer?: ");
    string opcaoDesejada = Console.ReadLine()!;
    int opcaoNum = int.Parse(opcaoDesejada);
    
    if (opcoes.ContainsKey(opcaoNum))
    {
        Menu menuExibido = opcoes[opcaoNum];
        menuExibido.Executar(produtoDAL);
        if (opcaoNum > 0) ExibirMenu();

    }
    else
    {
        Console.WriteLine("A opção escolhida é inválida");
    }
}

ExibirMenu();

