namespace HackerRankPractica.Repasos
{
    public class Basicos
    {
        public void Ejercicio()
        {
            Console.Write("Ingresa nombre del ejercicio: ");
            string ejercicio = Console.ReadLine();
            Console.Write("Ingresa el numero de repeticiones: ");
            int reps = int.Parse(Console.ReadLine());
            Console.WriteLine("Ejercicio: " + ejercicio + "\nRepeticiones: " + reps);
            if (reps > 12)
            {
                Console.WriteLine("Sube el peso");
            }
            else if (reps < 8)
            {
                Console.WriteLine("Baja el peso");
            }
        }

    }
}
