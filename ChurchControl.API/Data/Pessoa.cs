namespace ChurchControl.API.Data
{
    public class Pessoa
    {
        public int Id { get; set; } // Chave primária
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateOnly? DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public DateTime UltimaAtualizacao { get; set; } = DateTime.UtcNow;
    }

}