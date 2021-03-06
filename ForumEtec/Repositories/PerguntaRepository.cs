using ForumEtec.Context;
using ForumEtec.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumEtec.Repositories
{
    public class PerguntaRepository : IPerguntaRepository
    {
        AppDbContext _contexto;

        public PerguntaRepository(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Pergunta> Perguntas => _contexto.Perguntas.Include(c => c.Aluno.Respostas);

        public IEnumerable<Pergunta> PerguntasPesquisa(string pergunta)
        {
            return _contexto.Perguntas.Where(c => EF.Functions.Like(c.DescricaoPergunta, "%" + pergunta + "%"));
        }
    }
}
