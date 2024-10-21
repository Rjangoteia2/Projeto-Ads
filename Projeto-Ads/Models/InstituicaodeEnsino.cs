using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Ads.Models
{

    [Table("Instituição de Ensino")]

    public class InstituicaodeEnsino
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public int Cep { get; set; }

        public string cursos { get; set; }

        public string AvaliacaoMec { get; set; }

        public string AvaliacaoProfessor { get; set; }

        public string AvaliacaoAluno { get; set; }

        public string Comentario { get; set; }

        public int Preço { get; set; }

    }
}
