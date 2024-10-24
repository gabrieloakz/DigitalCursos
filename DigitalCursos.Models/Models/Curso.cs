using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCursos.Models.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string NomeCurso { get; set; }
        public string Descrição { get; set; }
        public int Creditos { get; set; }
        public DateTime Inicio { get; set; }
        public decimal Propina { get; set; }
        public string Logo { get; set; }

        public Collection<Aluno> Alunos { get; set; }
    }
}
