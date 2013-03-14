using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            // add a few gift blocks
            for (int i = startCol; i < endCol; i++)
            {
                GiftBlock currBlock = new GiftBlock(new MatrixCoords(startRow + 1, i));

                engine.AddObject(currBlock);
            }

            Ball ball = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(ball);

            // test the meteorite ball
            //MeteoriteBall theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));

            //engine.AddObject(theBall);

            // test the unstoppable ball
            //UnstoppableBall unstoppable = new UnstoppableBall(new MatrixCoords(5, 5),
            //    new MatrixCoords(1, 1));

            //engine.AddObject(unstoppable);

            //Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            //engine.AddObject(theRacket);

            ShootingRacket shootingRacket = new ShootingRacket(new MatrixCoords(WorldRows - 1, WorldCols / 2));
            engine.AddObject(shootingRacket);

            // add left side
            int topMost = 2;
            int leftMost = 1;
            int sideHeight = 20;
            for (int i = topMost; i < sideHeight + topMost; i++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(i, leftMost)));
            }

            // add ceiling
            int ceilingWidth = 39;
            for (int i = leftMost; i < ceilingWidth; i++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(2, i)));
            }

            // add right side
            int rightMost = 38;
            for (int i = topMost; i < sideHeight + topMost; i++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(i, rightMost)));
            }

            // add exploding blocks
            topMost += 3;
            for (int i = topMost; i < sideHeight; i++)
            {
                engine.AddObject(new ExplodingBlock(new MatrixCoords(i, 25)));
            }

            // add gifts
            engine.AddObject(new Gift(new MatrixCoords(5, 5)));
            engine.AddObject(new Gift(new MatrixCoords(6, 9)));
            engine.AddObject(new Gift(new MatrixCoords(5, 14)));
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            MySuperEngine gameEngine = new MySuperEngine(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
