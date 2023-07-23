namespace Clinica.Entities
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? CRM { get; set; }
        public string Especialidade { get; set; }
        public string? CPF { get; set; }
    }
}
