using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CatalogoClientes.Dominio.Entidades
{
    [Table("Clientes")]
    public class Cliente
    {
        public int      ClienteId   { get; set; }
        [Required(ErrorMessage ="Informe o  nome do cliente!")]
        public string   Nome        { get; set; }
        [Required(ErrorMessage = "Informe o email do cliente")]
        public string   Email       { get; set; }
        [Required(ErrorMessage = "Informe o endereço do cliente")]
        public string   Endereco    { get; set; }
        public byte[]   Imagem      { get; set; }
        public string   ImagemTipo  { get; set; }
    }
}
