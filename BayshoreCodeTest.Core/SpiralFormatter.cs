namespace BayshoreCodeTest.Core
{
    public static class SpiralFormatter
    {
        public static int[,] CalculateSpiral(int input)
        {
            int matrixSize = 1,
                totalElements = input + 1;

            while (matrixSize * matrixSize < totalElements)
                   matrixSize++;

            var matrix = new int[matrixSize, matrixSize];

            //

            int colStart = matrixSize - 1,
                currCol = matrixSize - 1,
                colIterAmt = matrixSize,
                colCounter = 1;

            bool colDirectionLeft = true,
                 colFirstIter = true;

            int rowStart = 0,
                currRow = 0,
                rowIterAmt = matrixSize - 1,
                rowCounter = 1;

            bool rowDirectionDown = true,
                 rowFirstIter = true;

            bool isTraversingColumn = true;

            //

            GenerateMatrix(matrix, matrixSize,
                           colStart, currCol, colIterAmt, colCounter,
                           colDirectionLeft, colFirstIter,
                           rowStart, currRow, rowIterAmt, rowCounter,
                           rowDirectionDown, rowFirstIter,
                           isTraversingColumn);

            return matrix;
        }

        private static void GenerateMatrix(int[,] matrix, int matrixSize,
                                           int colStart, int currCol, int colIterAmt, int colCounter,
                                           bool colDirectionLeft, bool colFirstIter,
                                           int rowStart, int currRow, int rowIterAmt, int rowCounter,
                                           bool rowDirectionDown, bool rowFirstIter,
                                           bool isTraversingColumn)
        {
            for (int printCounter = (matrixSize * matrixSize) - 1; printCounter > 0; printCounter--)
            {
                if (isTraversingColumn)
                {
                    if (colFirstIter == true)
                    {
                        currCol = colStart;
                        colFirstIter = false;
                    }

                    matrix[currRow, currCol] = printCounter;

                    if (colCounter == colIterAmt)
                    {
                        colStart = colDirectionLeft ? currCol + 1 : currCol - 1;
                        colFirstIter = true;
                        colIterAmt--;
                        colCounter = 1;

                        rowStart = colDirectionLeft ? currRow + 1 : currRow - 1;

                        colDirectionLeft = !colDirectionLeft;
                        isTraversingColumn = false;
                    }

                    else
                    {
                        currCol = colDirectionLeft ? currCol - 1 : currCol + 1;

                        colCounter++;
                    }
                }

                else
                {
                    if (rowFirstIter == true)
                    {
                        currRow = rowStart;
                        rowFirstIter = false;
                    }

                    matrix[currRow, currCol] = printCounter;

                    if (rowCounter == rowIterAmt)
                    {
                        rowStart = rowDirectionDown ? currCol - 1 : currCol + 1;
                        rowFirstIter = true;
                        rowIterAmt--;
                        rowCounter = 1;

                        rowDirectionDown = !rowDirectionDown;
                        isTraversingColumn = true;
                    }

                    else
                    {
                        currRow = rowDirectionDown ? currRow + 1 : currRow - 1;

                        rowCounter++;
                    }
                }
            }
        }
    }
}
