using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class GiftBlock : Block
    {
        public new const string CollisionGroupString = "giftBlock";

        public GiftBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = '~';
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "unstoppableBall"
                || otherCollisionGroupString == "ball"
                || otherCollisionGroupString == "meteoriteBall";
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if(IsDestroyed)
            {
                return new List<GameObject>()
                {
                    new Gift(this.topLeft)
                };
            }

            return new List<GameObject>();
        }

        public override string GetCollisionGroupString()
        {
            return GiftBlock.CollisionGroupString;
        }
    }
}
