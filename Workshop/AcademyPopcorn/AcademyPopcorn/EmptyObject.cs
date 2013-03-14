using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class EmptyObject : GameObject
    {
        public EmptyObject(MatrixCoords topLeft)
            : base(topLeft, new char[,] {{ ' '}})
        {

        }

        public override void Update()
        {
            
        }
    }
}
