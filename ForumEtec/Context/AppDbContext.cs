using ForumEtec.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumEtec.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Pergunta> Perguntas { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Resposta> Respostas { get; set; }


    }
}
