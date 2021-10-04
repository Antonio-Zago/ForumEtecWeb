using ForumEtec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumEtec.Repositories
{
    public interface IPerguntaRepository
    {
        public IEnumerable<Pergunta> Perguntas { get; }
    }
}
