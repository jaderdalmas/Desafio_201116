using Desafio.Extension;

namespace Desafio.Model
{
    public class Sonda
    {
        public Sonda(int x = 0, int y = 0, EFront front = EFront.N)
        {
            Position = new Position(x, y);
            Front = front;
        }

        public Position Position { get; private set; }
        public EFront Front { get; private set; }

        public void Move(char move)
        {
            if (move == 'M')
                Position.Move(Front);
            else
                Front = Front.Move(move);
        }

        public override string ToString()
        {
            if (Position.IsInvalid())
                return "Invalid";

            return $"{Position} {Front}";
        }

        public string ToString(Position limit)
        {
            if (Position.IsInvalid(limit))
                return "Invalid";

            return $"{Position} {Front}";
        }
    }
}
