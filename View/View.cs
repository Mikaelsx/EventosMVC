
namespace Eventos_MVC
{
    public class View
    {
        public void Listar(List<Evento> evento)
        {
            foreach (var item in evento)
            {
                Console.WriteLine($"");
                Console.WriteLine($"{item.Nome}");
                Console.WriteLine($"{item.Descricao}");
                Console.WriteLine($"{item.Data}");
                Console.WriteLine($"");
            }
        }

        
        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"Informe o nome: ");
            novoEvento.Nome = Console.ReadLine();
            
            Console.WriteLine($"Informe a descrição: ");
            novoEvento.Descricao = Console.ReadLine();

            Console.WriteLine($"Informe a data: ");
            novoEvento.Data = Console.ReadLine()!;

            return novoEvento;
        }
    }
}