using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appStore.Models.UsuarioModel
{
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public UsuarioPhone NumeroContato { get; set; }
        public UsuarioEndereco Endereco { get; set; }
        public string UrlImage { get; set; }
        public int Nivelacesso { get; set; }
        public int Status { get; set; }
        public DateTime? DataRegistro { get; set; }

    }

    public class UsuarioPhone
    {
        [Key]
        public int Id { get; set; }
        public string Pais { get; set; }
        public string Area { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
    }

    public class UsuarioEndereco
    {
        [Key]
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Localidade { get; set; }
        public string Cidade { get; set; }
        public string EstadoSigla { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
    }
}
