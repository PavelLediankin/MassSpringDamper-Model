namespace MassSpringDamperModel
{
    public class WorkingSegment
    {
        public double StartPosition;
        public double EndPosition;

        public WorkingSegment()
        { 
        }

        public WorkingSegment(double startPosition, double endPosition)
        {
            StartPosition = startPosition;
            EndPosition = endPosition;
        }
    }
}