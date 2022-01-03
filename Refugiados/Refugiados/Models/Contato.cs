using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Refugiados.Models
{
    public class Contato
    {
        [Key]
        public int Id_FaleConosco { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Informe um email válido...")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        [Display(Name = "Assunto")]
        [StringLength(100)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Assunto { get; set; }

        [Display(Name = "Dúvidas, Sugestões ou Elogios")]
        [StringLength(1000)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Mensagem { get; set; }

    }
}
