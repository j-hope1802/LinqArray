
// //task2
// int[] num={ 1,2,3,4,5};
// int sum=0;
// sum=num.Sum();
// System.Console.WriteLine(sum);

//task4
// var list=new List<int>(){1,8,3,4,5};
// list.Sort();
// var min=list.Take(3);
// System.Console.WriteLine(string.Join(' ',min));


// //task5
// var list =new List<int>(){2,4};
// var result=list.Average();
// System.Console.WriteLine((result));


// //task6
// var list =new List<int>(){1,2,9,5,6,9};
// list.Reverse();
// var result=list.Take(3);
// System.Console.WriteLine(string.Join(' ',result));



// //task7
// var list = new List<int>() { 1, 2, 3 };

// var result = list.Select(x => Math.Pow(x, 2));

// Console.WriteLine(string.Join(' ', result));



// //task8
// var list = new List<int>() { 1, 2, 3 };

// var result = list.Select(x => Math.Pow(x, 3));

// Console.WriteLine(string.Join(' ', result));


// //task9
// int n = 10;
// int start =1;
// int cnt=1;
// var list = new List<int>();
// while (cnt <= n)
// {
//     list.Add(start);
//     cnt++;
//     start += 2;
// }

// //task10
// int a = 10,even =2,cnt2=2;
// var list2 = new List<int>();
// while (cnt2<= a)
// {
//   list2.Add(even);
//   cnt2++;
//   even += 2;
// }

// Console.WriteLine(string.Join(' ',list2));

// //Task11
// var list = new List<int>(){2,5,3,9,63,9,8,7 };
// var aray = list.Where(x => x % 2 == 1);
// System.Console.WriteLine(string.Join(", ", aray)); 


// //task12
// var list = new List<int>(){13, 2, 5, 3, 11, 7 };
// var list2=list.Where(x => x%2==1).OrderBy(p=>p);
// System.Console.WriteLine(string.Join(" ", list2));

// //task13
// var list = new List<int>(){1 ,2 ,3 ,4, 5, 6, 7, 8 };
// var array =  list.Where(x => x % 2==1 ).Select(x => Math.Pow(x, 2));
// System.Console.WriteLine(string.Join(", ",array));

// // //task14
// var list = new List<int>(){1 ,2 ,3 ,4, 5};
// var array =  list.Where(x => x % 2==0 ).Select(x => Math.Pow(x, 2));
// System.Console.WriteLine(string.Join(", ",array));

// //task15
// var list = new List<int>(){1 ,2 ,3 ,4, 5, 6, 7, 8 };
// var array =  list.Where(x => x % 2==1 ).Select(x => Math.Pow(x, 3));
// System.Console.WriteLine(string.Join(", ",array));
