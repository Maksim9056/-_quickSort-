namespace ConsoleApp8
{
    internal class Program
    {

        public static List<int> quickSort(List<int> arr)
        {
            List<int> less = new List<int>();

            List<int> pivotList = new List<int>();

            List<int> more = new List<int>();
            //arr длину  меньше или равно 1
            if (arr.Count <= 1)
                //возращаем значение
                return arr;

            else
            {
                //Первый элемент присваеваем
                int pivot = arr[0];
                //Проходимся по циклу foreach int присваевает значенние arr списка по 0 значению далее перегоняет по остальным значения
                foreach (int i in arr)
                {
                    //Если первый pivot первый элемент больше значения i то добавляем его в список less через МЕТОД Add()
                    if (i < pivot)
                        less.Add(i);
                    //если i больше то список значения  первого элемента то добавляем его в mor через МЕТОД Add()
                    else if (i > pivot)
                        more.Add(i);
                    //если первый элемент больше  добавляем его в список pivotList через МЕТОД Add()
                    else

                        pivotList.Add(i);
                }
                //проганяем этот less для отсортировко потом присваеваем значение
                less = quickSort(less);

                // more для отсортировко потом присваеваем значение
                more = quickSort(more);

                List<int> result = new List<int>();

                //Метод AddRange()
                // Adds the elements of the given collection to the end of this list. If
                // required, the capacity of the list is increased to twice the previous
                // capacity or the new size, whichever is larger.
               
                result.AddRange(less);

                result.AddRange(pivotList);

                result.AddRange(more);

                //Взращаем результат
                return result;
            }
        }

        public static void PrintArray(List<int> arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        static void Main(string[] args)
        {
            try
            {
                List<int> arr = new List<int>() { 4, 65, 2, -31, 0, 99, 83, 782, 1 };
                List<int> sortedArr = quickSort(arr);
                PrintArray(sortedArr);
               Console.ReadLine();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}