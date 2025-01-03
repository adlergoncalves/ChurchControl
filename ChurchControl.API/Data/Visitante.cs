namespace ChurchControl.API.Data
{
    public class Visitante : Pessoa
    {
        public int IdUnidade { get; set; }
        public DateTime DataVisita { get; set; }
        public bool DesejaSerVisitado { get; set; }
        public string Observacoes { get; set; }
    }

}