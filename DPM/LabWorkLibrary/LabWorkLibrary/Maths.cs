namespace LabWorkLibrary
{
    /// <summary>
    /// Содержит константу и методы для математических операций
    /// </summary>
    public class Maths
    {
        /// <summary>
        /// Бинарный коэффициент
        /// </summary>
        public const int BinaryFactor = 1024;

        /// <summary>
        /// Вычислить сумму двух чисел
        /// </summary>
        /// <param name="value1">Первое слагаемое</param>
        /// <param name="value2">Второе слагаемое</param>
        /// <returns>Сумма двух чисел</returns>
        static public double Add(double value1, int value2)
        {
            return value1 + value2;
        }

        /// <summary>
        /// Вычислить разность двух чисел
        /// </summary>
        /// <param name="value1">Уменьшаемое</param>
        /// <param name="value2">Вычитаемое</param>
        /// <returns>Разность двух чисел</returns>
        static public double Subtract(double value1, int value2)
        {
            return value1 - value2;
        }

        /// <summary>
        /// Вычислить произведение двух чисел
        /// </summary>
        /// <param name="value1">Первый множитель</param>
        /// <param name="value2">Второй множитель</param>
        /// <returns>Произведение двух чисел</returns>
        static public double Multiply(double value1, int value2)
        {
            return value1 * value2;
        }

        /// <summary>
        /// Вычислить частное двух чисел
        /// </summary>
        /// <param name="value1">Делимое</param>
        /// <param name="value2">Делитель</param>
        /// <returns>Частное чисел</returns>
        /// <exception cref="DivideByZeroException">Нельзя делить на ноль</exception>
        static public double Divide(double value1, int value2)
        {
            if (value2 == 0)
                throw new DivideByZeroException("Деление на ноль");

            return value1 / value2;
        }

        /// <summary>
        /// Вычислить площадь прямоугольника
        /// </summary>
        /// <param name="length">Длина</param>
        /// <param name="width">Ширина</param>
        /// <returns>Площадь прямоугольника</returns>
        /// <exception cref="ArgumentOutOfRangeException">Нельзя использовать отрицательные значения</exception>
        static public double GetRectangleArea(double length, int width)
        {
            if (length < 0 || width < 0)
            {
                throw new ArgumentOutOfRangeException("Нельзя использовать отрицательные значения");
            }

            return length * width;
        }
    }
}

