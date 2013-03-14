using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class ShootingRacket : Racket
    {
        private bool shooting = false;

        public ShootingRacket(MatrixCoords topLeft)
            : base(topLeft, 6)
        {
            this.body = new char[,] { { '|', '=', '=', '=', '=', '|' } };
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return base.CanCollideWith(otherCollisionGroupString)
                || otherCollisionGroupString == "gift";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            base.RespondToCollision(collisionData);

            if (collisionData.hitObjectsCollisionGroupStrings.First() == "gift")
            {
                shooting = true;
            }
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (shooting)
            {
                shooting = false;

                return new List<GameObject>()
                {
                    new Bullet(new MatrixCoords(this.topLeft.Row, this.topLeft.Col + 2))
                };
            }

            return new List<GameObject>();
        }
    }
}
