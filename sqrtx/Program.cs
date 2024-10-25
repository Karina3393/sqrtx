namespace sqrtx
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            if (x == 0) return 0;

            int left = 1, right = x;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (mid == x / mid) return mid;
                else if (mid < x / mid) left = mid + 1;
                else right = mid - 1;
            }
            return right;
        }

        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine($"Квадратный корень из 4: {solution.MySqrt(4)}"); 
            Console.WriteLine($"Квадратный корень из 8: {solution.MySqrt(8)}"); 
            Console.WriteLine($"Квадратный корень из 0: {solution.MySqrt(0)}"); 
            Console.WriteLine($"Квадратный корень из 1: {solution.MySqrt(1)}"); 
            Console.WriteLine($"Квадратный корень из 16: {solution.MySqrt(16)}"); 
        }
    }
}