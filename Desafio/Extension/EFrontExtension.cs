using Desafio.Model;

namespace Desafio.Extension
{
    public static class EFrontExtension
    {
        public static EFront Move(this EFront front, char move)
        {
            var position = (int)front;

            switch (move)
            {
                case 'L':
                    position += 1;
                    if (position > 3) position -= 4;
                    break;
                case 'R':
                    position -= 1;
                    if (position < 0) position += 4;
                    break;
                default:
                    break;
            }

            return (EFront)position;
        }
    }
}
