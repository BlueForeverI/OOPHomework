using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class ExplodingBlock : Block
    {
        public new const string CollisionGroupString = "explodingBlock";

        public ExplodingBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        {
            this.body[0, 0] = '*';
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "unstoppableBall"
                || otherCollisionGroupString == "ball"
                || otherCollisionGroupString == "meteoriteBall";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
            this.ProduceObjects();
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.IsDestroyed)
            {
                return new List<GameObject>()
                {
                    new EmptyObject(this.topLeft),
                    new EmptyObject(new MatrixCoords(this.topLeft.Row + 1, this.topLeft.Col)),
                    new EmptyObject(new MatrixCoords(this.topLeft.Row + 1, this.topLeft.Col + 1)),
                    new EmptyObject(new MatrixCoords(this.topLeft.Row + 1, this.topLeft.Col - 1)),
                    new EmptyObject(new MatrixCoords(this.topLeft.Row - 1, this.topLeft.Col)),
                    new EmptyObject(new MatrixCoords(this.topLeft.Row - 1, this.topLeft.Col + 1)),
                    new EmptyObject(new MatrixCoords(this.topLeft.Row - 1, this.topLeft.Col - 1)),
                    new EmptyObject(new MatrixCoords(this.topLeft.Row, this.topLeft.Col + 1)),
                    new EmptyObject(new MatrixCoords(this.topLeft.Row, this.topLeft.Col - 1))
                };
            }

            return new List<GameObject>();
        }

        public override string GetCollisionGroupString()
        {
            return ExplodingBlock.CollisionGroupString;
        }
    }
}
