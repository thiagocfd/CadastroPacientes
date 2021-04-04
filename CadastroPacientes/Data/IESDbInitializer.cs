using CadastroPacientes.Models;
using System.Linq;


namespace CadastroPacientes.Data
{
    public class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();

            if (context.Pacientes.Any())
            {
                return;
            }

            var pacientes = new Paciente[]
            {
                new Paciente { Nome="Alexandre" },
                new Paciente { Nome="Carlos"}
            };

            foreach (Paciente p in pacientes)
            {
                context.Pacientes.Add(p);
            }
            context.SaveChanges();
        }
    }
}
