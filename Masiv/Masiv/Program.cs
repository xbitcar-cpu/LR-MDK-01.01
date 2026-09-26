using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Masiv
{
    internal class Program
    {
        static int count = 0;
        static Stopwatch stopwatch = new Stopwatch();

        static int linearsteps = 0;
        static int binaryStes = 0;
        static void Main()
        {
            int[] num = { 1000, 92, 3, 48, 5, 69, 75, 84, 9, 710 };
            stopwatch.Start();
            Permute(num, 0);
            stopwatch.Stop();

            Console.WriteLine($"Всего перестановок: {count}");
            Console.WriteLine($"Время: {stopwatch.Elapsed.TotalSeconds:F2} сек.");

            Console.WriteLine("-------------");
            int target = 100;
            Console.WriteLine($"Ищем число: {target}");
            stopwatch.Restart();
            linearsteps = 0;
            int linearIndex = LinearSearch(num, target);
            stopwatch.Stop();
            Console.WriteLine($"[Полный перебор] индекс = {linearIndex}, сравнение {linearsteps}, время = {stopwatch.Elapsed.TotalMilliseconds:F4} mc");

            stopwatch.Restart();
            binaryStes = 0;
            int binaryIndex = Binary(num, target);
            stopwatch.Stop();
            Console.WriteLine($"[Бинарный поиск] индекс = {binaryIndex}, сравнение = {binaryStes}, время = {stopwatch.Elapsed.TotalMilliseconds:F4} мс");

            Console.WriteLine($"Выигрыш бинарного поиска по сравнениям: в {linearsteps / (double)binaryStes:F1} раза");
        }
        static void Permute(int[] num, int l)
        {
            if (l == num.Length)
            {
                count++;
                Console.WriteLine($"{count,8}: [ {string.Join(", ", num)} ]");
                return;
            }
            for(int i = l; i < num.Length; i++)
            {
                Swap(num, l, i);
                Permute(num,l+1);
                Swap(num, l , i);
            }
        }

        static int LinearSearch(int[] a, int target)
        {
            for (int i = 0; i < a.Length; i++)
            {
                linearsteps++;
                if (a[i] == target) return i;
            }
            return -1;
        }

        static int Binary(int[] a, int target)
        {
            int left = 0, right = a.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                binaryStes++;
                if (a[mid] == target) return mid;
                if (a[mid] < target) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
        static void Swap(int[] a, int i, int j)
        {
            int t = a[i]; a[i] = a[j]; a[j] = t;
        }
    }
}
