using System.Collections.Generic;
using MassSpringDamperModel;

namespace ModelVisualaizer
{
    public class PositionsAdder
    {
        public readonly List<PositionTime> Positions;

        public PositionsAdder(List<PositionTime> positions)
        {
            Positions = positions;
        }

        public void AddPosition(double position, double time)
        {
            Positions.Add(new PositionTime(time, position));
        }
    }
}
