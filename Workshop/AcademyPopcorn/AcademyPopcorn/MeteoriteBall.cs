using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        public new const string CollisionGroupString = "meteoriteBall";
        private char[,] trail = new char[,] { { '.' } };

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {

        }

        public override void Update()
        {
            base.Update();
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            return new List<TrailObject>()
            {
                new TrailObject(this.topLeft, trail, 3)
            };
        }

        public override string GetCollisionGroupString()
        {
            return MeteoriteBall.CollisionGroupString;
        }
    }
}
