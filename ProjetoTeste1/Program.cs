Console.WriteLine("****Bem vindo à sua lista de tarefas!****");
Console.WriteLine("Qual opção você deseja selecionar?");
Console.WriteLine("1 - Inserir tarefa");
Console.WriteLine("2 - Apagar tarefa");
Console.WriteLine("3 - Mostrar tarefas");
Console.WriteLine("4 - Sair");

int escolhaDoUsuario;

List<string> tarefas = [];

do
{
    Console.WriteLine("Escolha uma opção:");

    string entrada = Console.ReadLine();

    if (int.TryParse(entrada, out escolhaDoUsuario))
    {
        switch (escolhaDoUsuario)
        {
            case 1:
                TipoDeEscolha(escolhaDoUsuario);
                string adicionarTarefa = Console.ReadLine();
                while (adicionarTarefa.Length == 0)
                {
                    Console.WriteLine("Digite algo, por favor.");
                    adicionarTarefa = Console.ReadLine();
                }
                tarefas.Add(adicionarTarefa);
                Console.WriteLine("Tarefa adicionada com sucesso!");
                break;
            case 2:
                if (tarefas.Count == 0)
                {
                    Console.WriteLine("Não há nenhuma tarefa para apagar.");
                }
                else
                {
                    TipoDeEscolha(escolhaDoUsuario);
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        Console.WriteLine($"{i} - {tarefas[i]}");
                    }
                    int removerTarefa = int.Parse(Console.ReadLine());
                    while (removerTarefa > tarefas.Count && removerTarefa < tarefas.Count)
                    {
                        Console.WriteLine("Informe uma tarefa válida.");
                        removerTarefa = int.Parse(Console.ReadLine());
                    }
                    tarefas.Remove(tarefas[removerTarefa]);
                    Console.WriteLine("Tarefa removida com sucesso!");
                }
                break;
            case 3:
                TipoDeEscolha(escolhaDoUsuario);
                if (tarefas.Count == 0)
                {
                    Console.WriteLine("Não há nenhuma tarefa.");
                }
                for(int i = 0; i < tarefas.Count; i++)
                {
                  Console.WriteLine($"{i} - {tarefas[i]}");
                }
                break;
            default:
                escolhaDoUsuario = 4;
                break;
        }


    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
    }

} while (escolhaDoUsuario != 4 || escolhaDoUsuario == 0);



static void TipoDeEscolha(int escolha)
{
    switch (escolha)
    {
        case 1:
            Console.WriteLine("Insira a tarefa:");
            break;
        case 2:
            Console.WriteLine("Qual tarefa deseja apagar?");
            break;
        case 3:
            Console.WriteLine("Tarefas inseridas:");
            break;
        default:
            Console.WriteLine("Saindo do programa...");
            break;
    }
}
