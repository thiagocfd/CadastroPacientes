using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPacientes.Models
{
    public class Paciente
    {
        public long? PacienteID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Diagnostico { get; set; }
        public string QueixaPrincipal { get; set; }
    }
}
