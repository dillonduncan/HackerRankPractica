namespace HackerRankPractica.Repasos
{
    public record Jugador(string Nombre, string Posicion, int Valoracion, string Equipo, int Velocidad, int Tiro);
    public class RepasoDatosLINQ
    {
        public record Anonimo(string Nombre, int Potencial);

        public void Ejecutar()
        {
            var plantilla = new List<Jugador>
            {
                new Jugador("Luis Díaz", "DEL", 88, "Liverpool", 91, 84),
                new Jugador("Carlos Bacca", "DEL", 79, "Junior", 75, 82),
                new Jugador("Lamine Yamal", "DEL", 85, "Barcelona", 89, 81),
                new Jugador("Pedri", "MED", 87, "Barcelona", 78, 79),
                new Jugador("James Rodríguez", "MED", 83, "Rayo Vallecano", 65, 85),
                new Jugador("Jermein Peña", "DEF", 74, "Junior", 72, 45),
                new Jugador("Ronald Araújo", "DEF", 86, "Barcelona", 82, 50),
                new Jugador("Willer Ditta", "DEF", 76, "Cruz Azul", 78, 40)
            };
            //Delanteros con val mayor a 80
            Console.WriteLine("Delanteros con valoracion > 80:");
            plantilla.Where(j => j.Posicion == "DEL" && j.Valoracion > 80)
                .OrderByDescending(j => j.Valoracion)
                .ToList()
                .ForEach(j => Console.WriteLine($"{j.Nombre} - {j.Valoracion}"));

            //Coleccion de mediocampistas
            Console.WriteLine("\nPotencial Ofensivo de los Mediocampistas:");
            List<Jugador> mediocampistas = plantilla.Where(j => j.Posicion == "MED").ToList();
            var anonimos = mediocampistas.Select(j => new Anonimo(j.Nombre, (j.Valoracion + j.Velocidad + j.Tiro) / 3));
            anonimos.ToList().ForEach(a => Console.WriteLine($"{a.Nombre} - {a.Potencial}"));


        }

    }
}
