//Виведіть усі числа від 10 до 50 через кому
Console.WriteLine(string.Join(",", Enumerable.Range(10, 41)));

//Виведіть лише ті числа від 10 до 50, які можна поділити на 3
Console.WriteLine(string.Join(",", Enumerable.Range(10, 41).Where(x => x % 3 == 0)));

//Виведіть слово "Linq" 10 разів
Console.WriteLine(string.Join(" ", Enumerable.Repeat("Linq", 10)));

//Вивести всі слова з буквою «а» в рядку «aaa;abb;ccc;dap»
Console.WriteLine(string.Join(";", "aaa;abb;ccc;dap".Split(';').Where(x => x.Contains('a'))));

//Виведіть кількість літер «а» у словах з цією літерою в рядку «aaa;abb;ccc;dap» через кому
Console.WriteLine(string.Join(",", "aaa;abb;ccc;dap".Split(';').Select(x => x.Count(c => c == 'a'))));

//Вивести true, якщо слово "abb" існує в рядку "aaa;xabbx;abb;ccc;dap", інакше false
Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').Contains("abb"));

//Отримати найдовше слово в рядку "aaa;xabbx;abb;ccc;dap"
Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').OrderByDescending(x => x.Length).First());

//Обчислити середню довжину слова в рядку "aaa;xabbx;abb;ccc;dap"
Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').Average(x => x.Length));

//Вивести найкоротше слово в рядку "aaa;xabbx;abb;ccc;dap;zh" у зворотному порядку
Console.WriteLine(new string("aaa;xabbx;abb;ccc;dap;zh".Split(';').OrderBy(x => x.Length).First().Reverse().ToArray()));

//Вивести true, якщо в першому слові, яке починається з "aa", усі літери "b" (За винятком "аа"), інакше false "baaa;aabb;aaa;xabbx;abb;ccc;dap;zh"
Console.WriteLine("baaa;aabb;aaa;xabbx;abb;ccc;dap;zh".Split(';').FirstOrDefault(x => x.StartsWith("aa"))?.All(c => c == 'b') ?? false);

//Вивести останнє слово в послідовності, за винятком перших двох елементів, які закінчуються на "bb" (використовуйте послідовність із 10 завдання)
Console.WriteLine("baaa;aabb;aaa;xabbx;abb;ccc;dap;zh".Split(';').Skip(2).Where(x => x.EndsWith("bb")).LastOrDefault());
