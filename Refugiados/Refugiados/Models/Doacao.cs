using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Refugiados.Models
{
    public class Doacao
    {
        [Key]
        public int Id_Doacao { get; set; }


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Doadora { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Informe um email válido...")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        /*Para exibir corretamente a data, o valor deve ser formatado como AAAA-MM-DD
        * 
             A [RFC 3339] definida pelo W3C diz o seguinte:
             “Uma data completa válida conforme definido no [RFC 3339], com a qualificação adicional
             de que o componente do ano tem quatro ou mais dígitos que representam um número maior que 0.”
        *
        Ou seja, é necessário formatar este campo data para adequar o seu funcionamento.
        Caso a página estiver sendo exibida em um browser sem suporte a HTML5 o problema não ocorrerá, porém 
        de qualquer forma necessita ser tratado, afinal todos os browsers atuais possuem esse suporte.

        Para corrigir o problema será usado o atributo DisplayFormat, uma classe do DataAnnotations que 
        especifica como que um dado dinamicamente criado deve ser exibido.
         */

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [Required]
        public DateTime? Data_Nascimento { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Telefone { get; set; }

        [Display(Name = "Informe sua doação")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Doar { get; set; }


    }
}

