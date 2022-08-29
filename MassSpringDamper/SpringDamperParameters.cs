
namespace MassSpringDamperModel
{
    public class SpringDamperParameters
    {
        public WorkingSegment WorkingSegment;
        /// <summary>
        /// Damping constant
        /// </summary>
        public double C;
        /// <summary>
        /// Stiffness of the spring
        /// </summary>
        public double K;

        public SpringDamperParameters()
        { 
        }

        public SpringDamperParameters(WorkingSegment workingSegment, double c, double k)
        {
            WorkingSegment = workingSegment;
            C = c;
            K = k;
        }

        public static SpringDamperParameters Parameters_base
            => new SpringDamperParameters(new WorkingSegment(0,0), 4, 2);
    }
}
