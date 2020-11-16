using Desafio.Extension;

namespace Desafio.Model
{
    public class Sonda
    {
        public Sonda(int x = 0, int y = 0, EFront front = EFront.N)
        {
            X = x;
            Y = y;
            Front = front;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public EFront Front { get; private set; }

        public void Move(char move)
        {
            if (move == 'M')
                Move();
            else
                Front = Front.Move(move);
        }

        private void Move()
        {
            switch (Front)
            {
                case EFront.N:
                    X++;
                    break;
                case EFront.W:
                    Y--;
                    break;
                case EFront.S:
                    X--;
                    break;
                case EFront.E:
                    Y++;
                    break;
                default:
                    break;
            }
        }

        public string GetPosition()
        {
            return $"{X} {Y} {Front}";
        }
    }
}
