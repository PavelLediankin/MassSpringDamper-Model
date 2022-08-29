namespace MassSpringDamperModel
{
    public class SimulationSettings
    {
        public readonly double Dt;
        public readonly double TimeStart;
        public readonly double TimeStop;

        public SimulationSettings(double dt, double timeStart, double timeStop)
        {
            Dt = dt;
            TimeStart = timeStart;
            TimeStop = timeStop;
        }
    }
}