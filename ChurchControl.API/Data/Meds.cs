namespace ChurchControl.API.Data
{
    public class Meds : Pessoa
    {
        public int IdUnidade { get; set; }
        public DateTime Data { get; set; }
        public bool Batizado { get; set; }
        public bool DesejaSerVisitado { get; set; }
        public string Observacoes { get; set; }
        public string TipoConversao { get; set; }
        public DateTime? DataConversao { get; set; }
    }
}