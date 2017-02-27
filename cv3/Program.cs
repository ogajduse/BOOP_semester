using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv3 {
    class Matrix {
        private double[,] matrix;

        public Matrix(double[,] inputMatrix) {
            this.matrix = inputMatrix;
            this.ColumnSize = inputMatrix.GetLength(1);
            this.RowSize = inputMatrix.GetLength(0);
        }

        private int ColumnSize {
            get;
            set;
        }

        private int RowSize {
            get;
            set;
        }


        public static Matrix operator +(Matrix a, Matrix b) {
            double[,] resultMatrix = new double[a.RowSize, a.ColumnSize];
            for (int rowIndex = 0; rowIndex < a.RowSize; rowIndex++) {
                for (int columnIndex = 0; columnIndex < a.ColumnSize; columnIndex++) {
                    resultMatrix[rowIndex, columnIndex] = a.matrix[rowIndex, columnIndex]
                                                        + b.matrix[rowIndex, columnIndex];
                }
            }
            return new Matrix(resultMatrix);
        }

        public static Matrix operator -(Matrix a, Matrix b) {
            double[,] resultMatrix = new double[a.RowSize, a.ColumnSize];
            for (int rowIndex = 0; rowIndex < a.RowSize; rowIndex++) {
                for (int columnIndex = 0; columnIndex < a.ColumnSize; columnIndex++) {
                    resultMatrix[rowIndex, columnIndex] = a.matrix[rowIndex, columnIndex]
                                                        - b.matrix[rowIndex, columnIndex];
                }
            }
            return new Matrix(resultMatrix);
        }

        public static Matrix operator -(Matrix a) {
            double[,] resultMatrix = new double[a.RowSize, a.ColumnSize];
            for (int rowIndex = 0; rowIndex < a.RowSize; rowIndex++) {
                for (int columnIndex = 0; columnIndex < a.ColumnSize; columnIndex++) {
                    resultMatrix[rowIndex, columnIndex] = -a.matrix[rowIndex, columnIndex];
                }
            }
            return new Matrix(resultMatrix);
        }

        public static Matrix operator *(Matrix a, Matrix b) {
            if (a.ColumnSize != b.RowSize) {
                throw new Exception("Dimension of matrix do not match");
            }

            double[,] resultMatrix = new double[a.RowSize, b.ColumnSize];

            for (int rowIndex = 0; rowIndex < a.RowSize; rowIndex++) {
                for (int columnIndex = 0; columnIndex < b.ColumnSize; columnIndex++) {
                    double suma = 0;
                    for (int sumIndex = 0; sumIndex < a.ColumnSize; sumIndex++) {
                        suma += a.matrix[rowIndex, sumIndex] * b.matrix[sumIndex, columnIndex];
                    }
                    resultMatrix[rowIndex, columnIndex] = suma;
                }
            }

            return new Matrix(resultMatrix);
        }

        public override string ToString() {
            string result = "";
            for (int rowIndex = 0; rowIndex < RowSize; rowIndex++) {
                for (int columnIndex = 0; columnIndex < ColumnSize; columnIndex++) {
                    result += matrix[rowIndex, columnIndex].ToString() + " ";
                }
                result += "\n";
            }
            return result;
        }

        public static bool operator ==(Matrix a, Matrix b) {
            if (a.RowSize != b.RowSize || a.ColumnSize != b.ColumnSize) {
                return false;
            }

            for (int rowIndex = 0; rowIndex < a.RowSize; rowIndex++) {
                for (int columnIndex = 0; columnIndex < a.ColumnSize; columnIndex++) {
                    if (a.matrix[rowIndex, columnIndex] != b.matrix[rowIndex, columnIndex]) {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator !=(Matrix a, Matrix b) {
            return !(a == b);
        }

        public double GetDeterminant() {
            if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) < 1 ||
                matrix.GetLength(1) < 1 || matrix.GetLength(1) > 3 || matrix.GetLength(1) > 3)
                throw new ArgumentException("Matrix is not squared or has bad size!");

            switch (matrix.GetLength(0)) {
                case 1:
                    return matrix[0, 0];
                case 2:
                    return (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]);
                case 3:
                    return (matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
                            matrix[0, 1] * matrix[1, 2] * matrix[2, 0] +
                            matrix[0, 2] * matrix[1, 0] * matrix[2, 1] -
                            matrix[0, 2] * matrix[1, 1] * matrix[2, 0] -
                            matrix[0, 1] * matrix[1, 0] * matrix[2, 2] -
                            matrix[0, 0] * matrix[1, 2] * matrix[2, 1]);
                default:
                    return 0;
            }
        }

    }
}
