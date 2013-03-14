using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class UnstoppableBall : Ball
    {
        public new const string CollisionGroupString = "unstoppableBall";

        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
            this.body = new char[,] { { 'x' } };
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "indestructibleBlock" 
                || otherCollisionGroupString == "racket"
                || otherCollisionGroupString == "unpassableBlock";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            foreach (var collisionString in collisionData.hitObjectsCollisionGroupStrings)
            {
                if (this.CanCollideWith(collisionString))
                {
                    if (collisionData.CollisionForceDirection.Row * this.Speed.Row < 0)
                    {
                        this.Speed.Row *= -1;
                    }
                    if (collisionData.CollisionForceDirection.Col * this.Speed.Col < 0)
                    {
                        this.Speed.Col *= -1;
                    }
                }
                else
                {
                    this.ProduceObjects();
                }
            }
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            return new List<GameObject>()
            {
                new EmptyObject(this.topLeft)
            };
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }
    }
}
