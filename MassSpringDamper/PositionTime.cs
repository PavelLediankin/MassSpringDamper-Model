namespace MassSpringDamperModel
{
    public class PositionTime
    {
        public double Position;
        public double Time;

        public PositionTime()
        {
        }

        public PositionTime(double time, double position)
        {
            Time = time;
            Position = position;
        }
    }
}