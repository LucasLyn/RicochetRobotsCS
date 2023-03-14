namespace Robots.UI {
    public class BoardDisplay {
        int rows; // Number of rows on the board
        int cols; // Number of columns on the board
        public String[,] board; // 2D Array to represent the board

        // Constructor
        public BoardDisplay(int rows, int cols) {
            this.rows = rows;
            this.cols = cols;

            // Initialize board with dimensions rows*cols
            board = new String[rows*2 + 1, cols*2 + 1];

            // Initialize the values in the 2D board Array
            for (int i = 0; i < rows*2 + 1; i++) {
                for (int j = 0; j < cols*2 + 1; j++) {
                    if (i % 2 == 0 && j % 2 == 0) {board[i, j] = "+";}
                    else if (i == 0 || i == rows*2) {board[i, j] = "--";}
                    else if (j == 0 || j == cols*2) {board[i, j] = "|";}
                    else if ((i % 2 == 1 || i % 2 == 0) && j % 2 == 1) {board[i, j] = "  ";}
                    else {board[i, j] = " ";} // Only 1 space here!
                }
            }
        }

        ///<summary>
        ///Get the amount of rows on the board.
        ///</summary>
        ///<returns>
        ///The amount of rows on the board.
        ///</returns>
        public int GetRows() {
            return rows;
        }

        ///<summary>
        ///Get the amount of columns on the board.
        ///</summary>
        ///<returns>
        ///The amount of columns on the board.
        ///</returns>
        public int GetCols() {
            return cols;
        }

        ///<summary>
        ///Set a BoardElement on the board.
        ///</summary>
        ///<param name = "row">
        ///The row to place the BoardElement on.
        ///</param>
        ///<param name = "col">
        ///The column to place the BoardElement on.
        ///</param>
        ///<param name = "content">
        ///The content String to place on the board.
        ///</param>
        public void SetElement(int row, int col, String content) {
            int r = row*2 - 1;
            int c = col*2 - 1;

            /* Replace board string with the given content
               only using the first 2 characters of the string */
            board[r, c] = content[..1];
        }

        ///<summary>
        ///Place a wall on the bottom of a tile.
        ///</summary>
        ///<param name = "row">
        ///The row to place the bottom wall on.
        ///</param>
        ///<param name = "col">
        ///The column to place the bottom wall on.
        ///</param>
        public void SetBottomWall(int row, int col) {
            int r = row*2;
            int c = col*2 - 1;

            if (r > rows*2 ||
                r <= 0 ||
                c > cols*2 - 1 ||
                c <= 0) {
                    board[rows*2, cols*2 - 1] = "--";
                } else {
                    board[r, c] = "--";
                }
        }

        ///<summary>
        ///Place a wall on the right side of a tile.
        ///</summary>
        ///<param name = "row">
        ///The row to place the vertical wall on.
        ///</param>
        ///<param name = "col">
        ///The column to place the vertical wall on.
        ///</param>
        public void SetRightWall(int row, int col) {
            int r = row*2 - 1;
            int c = col*2;

            if (r > rows*2 - 1||
                r <= 0 ||
                c > cols*2 ||
                c <= 0) {
                    board[rows*2 - 1, cols*2] = "|";
                } else {
                    board[r, c] = "|";
                }
        }

        ///<summary>
        ///Prints the board in the terminal.
        ///</summary>
        public void PrintBoard() {
            int r = rows*2 + 1;
            int c = cols*2 + 1;

            for (int i = 0; i < r; i++) {
                for (int j = 0; j < c; j++) {
                    Console.Write(board[i, j]);

                    // Add a newline if last column element is reached
                    if (j == c-1) {
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}