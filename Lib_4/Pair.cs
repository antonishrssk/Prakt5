namespace Lib_4
{
    public class Pair
    {
        public int P1 { get; set; } // ������ ����� ����
        public int P2 { get; set; } // ������ ����� ����

        /// <summary>
        /// ���������� ��� ���� �����: ���� 1 ������ ���� 2, ���� 1-� ����� ������ 2-�� ����� ���� 1 ��� 1-� ����� ����� 2-�� ����� ���� 1 � 1-� ����� ������ 2-�� ����� ���� 2
        /// </summary>
        /// <param name="first">���� 1</param>
        /// <param name="second">���� 2</param>
        /// <returns>������� ��������</returns>
        public static bool Compare(Pair first, Pair second)
        {
            if (first.P1 > first.P2 || first.P1 == first.P2 && second.P1 > second.P2) return true;
            else return false;
        }

        /// <summary>
        /// ������������� �������� ��� ���� �����
        /// </summary>
        /// <param name="pair">���� �����</param>
        /// <param name="p1">������ �����</param>
        /// <param name="p2">������ �����</param>
        public static void SetParams(Pair pair, int p1, int p2)
        {
            pair.P1 = p1;
            pair.P2 = p2;
        }

        /// <summary>
        /// ������������� �������� ��� ���� ���
        /// </summary>
        /// <param name="pair1">���� 1</param>
        /// <param name="p1">������ ����� � ���� 1</param>
        /// <param name="p2">������ ����� � ���� 1</param>
        /// <param name="pair2">���� 2</param>
        /// <param name="q1">������ ����� � ���� 2</param>
        /// <param name="q2">������ ����� � ���� 2</param>
        public static void SetParams(Pair pair1, int p1, int p2, Pair pair2, int q1, int q2)
        {
            pair1.P1 = p1;
            pair1.P2 = p2;
            pair2.P1 = q1;
            pair2.P2 = q2;
        }
    }
}
