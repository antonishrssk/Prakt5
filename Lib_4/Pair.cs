namespace Lib_4
{
    public class Pair
    {
        public int P1 { get; set; } // Первое число пары
        public int P2 { get; set; } // Второе число пары

        /// <summary>
        /// Сравнивает две пары чисел: пара 1 больше пары 2, если 1-е число больше 2-го числа пары 1 или 1-е число равно 2-му числу пары 1 и 1-е число больше 2-го числа пары 2
        /// </summary>
        /// <param name="first">Пара 1</param>
        /// <param name="second">Пара 2</param>
        /// <returns>Булевое значение</returns>
        public static bool Compare(Pair first, Pair second)
        {
            if (first.P1 > first.P2 || first.P1 == first.P2 && second.P1 > second.P2) return true;
            else return false;
        }

        /// <summary>
        /// Устанавливает значения для пары чисел
        /// </summary>
        /// <param name="pair">Пара чисел</param>
        /// <param name="p1">Первое число</param>
        /// <param name="p2">Второе число</param>
        public static void SetParams(Pair pair, int p1, int p2)
        {
            pair.P1 = p1;
            pair.P2 = p2;
        }

        /// <summary>
        /// Устанавливает значения для двух пар
        /// </summary>
        /// <param name="pair1">Пара 1</param>
        /// <param name="p1">Первое число в паре 1</param>
        /// <param name="p2">Второе число в паре 1</param>
        /// <param name="pair2">Пара 2</param>
        /// <param name="q1">Первое число в паре 2</param>
        /// <param name="q2">Второе число в паре 2</param>
        public static void SetParams(Pair pair1, int p1, int p2, Pair pair2, int q1, int q2)
        {
            pair1.P1 = p1;
            pair1.P2 = p2;
            pair2.P1 = q1;
            pair2.P2 = q2;
        }
    }
}
