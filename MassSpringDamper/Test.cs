using System.Collections.Generic;
using NUnit.Framework;

namespace MassSpringDamperModel
{
    [TestFixture]
    public class Test
    {
        /*
        [Test]
        public void T1()
        {
            var settings = new SimulationSettings(0.1, 0, 10);
            var model = new MassSpringDamper();
            var res = new List<SimulationResult>();
            //var force = GetForce().GetEnumerator();
            res.Add(new SimulationResult(0, 0));
            foreach (var result in model.Simulate(settings))
            {
                res.Add(result);
            }
            
        }
        */
        public IEnumerable<double> GetForce()
        {
            while (true)
            {
                yield return 100;
                yield return 110;
                yield return 115;
                yield return 112;
                yield return 105;

            }
        }
    }
}