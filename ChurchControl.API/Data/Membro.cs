namespace ChurchControl.API.Data
{
    public class Membro : Pessoa
    {
        public int IdUnidade { get; set; }
        public string Status { get; set; }
        public string Conjuge { get; set; }
        public string NomeConjuge { get; set; }
        public bool MembroDaIgreja { get; set; }
        public bool ConjugeBatizado { get; set; }
        public string EstadoCivil { get; set; }
        public bool PossuiFilhos { get; set; }
        public string NomeUltimoPastor { get; set; }
        public string TelefoneUltimoPastor { get; set; }
        public bool MembroBatizado { get; set; }
        public bool ConcluiuCursoCapacitacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataDesligamento { get; set; }
        public string MotivoDesligamento { get; set; }
        public string Observacoes { get; set; }
    }
}