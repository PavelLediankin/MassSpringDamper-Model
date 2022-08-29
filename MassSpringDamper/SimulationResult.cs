namespace MassSpringDamperModel
{
    public class SimulationResult
    {
        public readonly double Position;
        public readonly double Velocity;

        public SimulationResult(double position, double velocity)
        {
            Position = position;
            Velocity = velocity;
        }

        public override string ToString()
        {
            return $"X = {Position} \nV = {Velocity}";
        }
    }
}