using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EA.Dotnet.TaskList.Application.ViewModels
{
    public class TarefaViewModel
    {
        public TarefaViewModel()
        {
            TarefaId = Guid.NewGuid();
        }

        [Key]
        public Guid TarefaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Título")]
        public string Titulo { get; set; }

        [DisplayName("Status?")]
        public bool Status { get; set; }

        [DisplayName("Descrição")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        public string Descricao { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Data Criação")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataCriacao { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Data Edição")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataEdicao { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Data Remoção")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataRemocao { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Data Conclusão")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataConclusao { get; set; }
    }
}
