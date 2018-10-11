using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_ListasGraficos
{
    class Aluno
    {
        public String Nome { get; set; }
        public Double Nota { get; set; }

        public Aluno(String nome, Double nota)
        {
            Nome = nome;
            Nota = nota;
        }
    }
}
