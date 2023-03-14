using Robots.UI;

namespace Robots {
    public class Program {
        public static void Main(String[] args) {
            int r = 3;
            int c = 3;

            BoardDisplay BD = new BoardDisplay(r, c);

            BD.PrintBoard();
        }
    }
}