using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForumEtec.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        [StringLength(50)]
        public string NomeAluno { get; set; }

        public DateTime NascimentoAluno { get; set; }

        public int SemestreAluno { get; set; }

        public virtual Curso Curso { get; set; }

        public List<Pergunta> Perguntas { get; set; }

        public List<Resposta> Respostas { get; set; }
    }
}
