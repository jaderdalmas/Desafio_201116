using Desafio.Model;

namespace Desafio.Extension
{
    public static class PositionExtension
    {
        public static bool OutOfLimit(this Position position, Position limit)
        {
            return position.X > limit.X || position.Y > limit.Y;
        }
    }
}
