using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForumEtec.Models
{
    public class Curso
    {
        public int CursoId { get; set; }

        [StringLength(50)]
        public string NomeCurso { get; set; }

        public List<Aluno> Alunos { get; set; }
    }
}
