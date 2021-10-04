using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForumEtec.Models
{
    public class Pergunta
    {
        public int PerguntaId { get; set; }

        [StringLength(400)]
        public string DescricaoPergunta { get; set; }

        public string TituloPergunta { get; set; }

        public virtual Aluno Aluno { get; set; }

        public List<Resposta> Respostas { get; set; }
    }
}
