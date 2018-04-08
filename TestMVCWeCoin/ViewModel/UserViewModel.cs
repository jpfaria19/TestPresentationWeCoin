
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Net.Mime;
using System.Web.ModelBinding;
using TestMVCWeCoin.Models;

namespace TestMVCWeCoin.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            Posts = new List<Post>();
        }

        [Key]
        public int UserId { get; set; }

        [Required]
        [DisplayName("Imagem")]
        [DataType(DataType.ImageUrl)]
        public String ImgURL { get; set; }

        [Required(ErrorMessage = "Nome precisa ser preenchido.")]
        [MinLength(3, ErrorMessage = "Nome precisar ter pelo menos 3 caracteres")]
        [MaxLength(200, ErrorMessage = "Nome precisa ter menos de 200 caracteres")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Sobrenome precisa ser preenchido.")]
        [MinLength(3, ErrorMessage = "Sobrenome precisar ter pelo menos 3 caracteres")]
        [MaxLength(200, ErrorMessage = "Sobrenome precisa ter menos de 200 caracteres")]
        public String Sobrenome { get; set; }

        [Required(ErrorMessage = "Email precisa ser preenchido.")]
        [MinLength(7, ErrorMessage = "Email precisar ter pelo menos 7 caracteres")]
        [MaxLength(200, ErrorMessage = "Email precisa ter menos de 200 caracteres")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public String Email { get; set; }

        [DisplayName("Marcando este campo você aceita minerar para nós.")]
        [Range(typeof(bool), "false", "false", ErrorMessage = "Você precisa marcar este campo para finalizar este cadastro.")]
        public bool TermsAndConditions { get; set; }

        public List<Post> Posts { get; set; }
    }
}