using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForumEtec.Models
{
    public class Resposta
    {
        public int RespostaId { get; set; }

        [StringLength(400)]
        public string DescricaoResposta { get; set; }

        public virtual Pergunta Pergunta { get; set; }

        public virtual Aluno Aluno { get; set; }
    }
}
