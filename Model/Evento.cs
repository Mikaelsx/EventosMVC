namespace Eventos_MVC
{
    public class Evento
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Data { get; set; }

        private string NOTE = "Database/Evento.csv";

        public Evento()
        {
            string pasta = NOTE.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(NOTE))
            {
                File.Create(NOTE);
            }
            
        }

        public List<Evento> Ler()
        {
            List<Evento> evento = new List<Evento>();

            string[] linhas = File.ReadAllLines(NOTE);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                Evento e = new Evento();

                e.Nome = atributos[0];
                e.Descricao = atributos[1];
                e.Data = atributos[2];
                
                evento.Add(e);
            }

            return evento;
        }

        public string prepararLinhasCSV(Evento e)
        {
            return $"{e.Nome};{e.Descricao};{e.Data}";
        }

        public void Inserir(Evento e)
        {
            string[] linhas = {prepararLinhasCSV(e)};

            File.AppendAllLines(NOTE, linhas);
        }
    }
}