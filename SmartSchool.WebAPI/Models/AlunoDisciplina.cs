namespace SmartSchool.WebAPI.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina()
        {

        }
        public AlunoDisciplina(int aluniId, int disciplinaId)
        {
            this.AluniId = aluniId;
            this.DisciplinaId = disciplinaId;

        }
        public int AluniId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}