using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class UnpassableBlock : IndestructibleBlock
    {
        public new const string CollisionGroupString = "unpassableBlock";

        public UnpassableBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        {
            this.body = new char[,] { { '-' } };
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            //base.RespondToCollision(collisionData);
        }

        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
    }
}
