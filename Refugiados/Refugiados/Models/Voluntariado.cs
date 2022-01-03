using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Refugiados.Models
{
    public class Voluntariado
    {
        [Key]
        public int Id_Voluntario { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string CPF { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Informe um email válido...")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        [Display(Name = "Conselho Profissional")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Conselho { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Uf_Conselho { get; set; }

        [Display(Name = "Nº Registro")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Numero_Conselho { get; set; }

        [Display(Name = "Especialidade")]
        [StringLength(1000)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Especialidade { get; set; }

        [Display(Name = "Como pode ajudar?")]
        [StringLength(1000)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Servicos { get; set; }

    }
}

