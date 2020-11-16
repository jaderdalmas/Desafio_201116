using Desafio.Extension;

namespace Desafio.Model
{
    public class Position
    {
        public Position(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public void Move(EFront front)
        {
            switch (front)
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

        public bool IsInvalid(Position limit = null) => X < 0 || Y < 0 || this.OutOfLimit(limit);

        public override string ToString()
        {
            if (IsInvalid())
                return "Invalid";

            return $"{X} {Y}";
        }

        public string ToString(Position limit)
        {
            if (IsInvalid(limit))
                return "Invalid";

            return $"{X} {Y}";
        }
    }
}
