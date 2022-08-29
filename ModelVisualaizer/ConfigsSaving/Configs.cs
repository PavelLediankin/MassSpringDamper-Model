using System.Collections.Generic;
using MassSpringDamperModel;

namespace ModelVisualaizer
{
    public class PositionsConfig
    {
        public List<PositionTime> Positions;
    }

    public class SegmentsParametersConfig
    {
        public List<SpringDamperParameters> Parameters;
    }

    public class SettingsConfig
    {
        public double DeltaT;
        public double Start;
        public double Stop;

        public double Mass;
        public double Pos;
        public double V;
    }
}