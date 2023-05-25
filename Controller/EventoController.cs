using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos_MVC
{
    public class EventoController
    {
        Evento evento = new Evento();

        View view = new View();

         public void Listar()
        {
            List<Evento> eventos = evento.Ler();

            View v = new View();

            v.Listar(eventos);
        }

        public void CadastrarEventos()
        {
            View v = new View();

            evento.Inserir(v.Cadastrar());

            // Produto novoProduto = produtoView.Cadastrar();

            
        }
    }

    
       
}