using System.Collections.Generic;

namespace MassSpringDamperModel
{
    public class MassSpringDamper
    {
        /// <summary>
        /// Damping constant
        /// </summary>
        public double C => currentVelocityParameters.Value.C;
        /// <summary>
        /// Stiffness of the spring currentPositionParameters
        /// </summary>
        public double K => currentPositionParameters.Value.K;

        public readonly double Mass;

        public double Position => position;
        public double Velocity => velocity;

        private double position;
        private double velocity;
        private double minPos;

        private readonly LinkedList<SpringDamperParameters> parameters;
        private LinkedListNode<SpringDamperParameters> currentPositionParameters;
        private LinkedListNode<SpringDamperParameters> currentVelocityParameters;

        public MassSpringDamper(LinkedList<SpringDamperParameters> parameters, double mass,
            double position = 0, double velocity = 0, double minPos = -1)
        {
            this.parameters = parameters;
            Mass = mass;
            this.position = position;
            this.velocity = velocity;
            this.minPos = minPos;
        }

        private double a21;
        private double a22;
        public IEnumerable<SimulationResult> Simulate(SimulationSettings settings)
        {
            var dt = settings.Dt;
            var start = settings.TimeStart;
            var stop = settings.TimeStop;
            var simulationLength = (int)((stop - start) / dt); 
            
            var a11 = 1;
            var a12 = dt;

            var pos = Position; // Initial Position
            var v = Velocity; // Initial Speed

            for (var k = 0; k < simulationLength + 1; k++)
            {
                FindCurrentParameters(dt);
                pos = GetPosition(a11, a12);
                v = GetVelocity();

                position = pos;
                velocity = v;
                yield return new SimulationResult(Position, Velocity);
            }
        }

        public IEnumerable<SimulationResult> Simulate(SimulationSettings settings, List<PositionTime> positions)
        {
            var timesPositions = new Dictionary<double, double>();

            var dt = settings.Dt;
            var start = settings.TimeStart;
            var stop = settings.TimeStop;
            var simulationLength = (int)((stop - start) / dt);

            foreach (var p in positions)
                timesPositions.Add(p.Time, p.Position);

            var a11 = 1;
            var a12 = dt;

            var pos = Position; // Initial Position
            var v = Velocity; // Initial Speed

            for (var k = 0; k < simulationLength + 1; k++)
            {
                FindCurrentParameters(dt);
                pos = GetPosition(a11, a12);
                v = GetVelocity();

                if (timesPositions.ContainsKey(k))
                {
                    var forcedPos = timesPositions[k];
                    if(position > forcedPos)
                    {
                        pos = forcedPos;
                        v = (position - forcedPos) / dt;
                    }
                }

                position = pos;
                velocity = v;
                yield return new SimulationResult(Position, Velocity);
            }
        }

        private double GetPosition(double a11, double a12)
        {
            var pos = a11 * Position + a12 * Velocity;
            if (pos < minPos)
                return minPos;
            return pos;
        }

        private double GetVelocity() 
            => a21 * Position + a22 * Velocity;

        private void FindCurrentParameters(double dt)
        {
            FindCurrentPositionParameters(dt);
            FindCurrentVelocityParameters(dt);
        }

        private void FindCurrentPositionParameters(double dt)
        {
            var shifted = false;
            if (currentPositionParameters == null)
            {
                currentPositionParameters = parameters.First;
                shifted = true;
            }

            var p1 = currentPositionParameters.Value.WorkingSegment.StartPosition;
            var p2 = currentPositionParameters.Value.WorkingSegment.EndPosition;

            if (position <= p1 && currentPositionParameters.Previous != null) // Opt ++  < min pos ..... <
            {
                currentPositionParameters = currentPositionParameters.Previous;
                FindCurrentPositionParameters(dt);
                shifted = true;
            }
            if (position > p2 && currentPositionParameters.Next != null)
            {
                currentPositionParameters = currentPositionParameters.Next;
                FindCurrentPositionParameters(dt);
                shifted = true;
            }

            if (shifted)
                a21 = -(dt * K) / Mass;
        }

        private void FindCurrentVelocityParameters(double dt)
        {
            var shifted = false;
            if (currentVelocityParameters == null)
            {
                currentVelocityParameters = parameters.First;
                shifted = true;
            }

            var v1 = currentVelocityParameters.Value.WorkingSegment.StartPosition;
            var v2 = currentVelocityParameters.Value.WorkingSegment.EndPosition;

            if (velocity <= v1 && currentVelocityParameters.Previous != null) // Opt ++  < min pos ..... <
            {
                currentVelocityParameters = currentVelocityParameters.Previous;
                FindCurrentVelocityParameters(dt);
                shifted = true;
            }
            if (velocity > v2 && currentVelocityParameters.Next != null)
            {
                currentVelocityParameters = currentVelocityParameters.Next;
                FindCurrentVelocityParameters(dt);
                shifted = true;
            }

            if (shifted)
                a22 = 1 - (dt * C) / Mass;
        }
    }
}
