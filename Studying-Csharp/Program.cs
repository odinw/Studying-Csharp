using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.Threading;

namespace Studying_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enum_IsDefine();
            //ForLoop_Special();
            //List_Remove();
            //List_DeepClone();
            //ToStringSymbol();
            //StringParsing();
            //DictionaryTryRemove();
            //ChangeMoney();
            //MathPow();

            string a = null;
            Console.WriteLine(a == "a"); // false
            Console.WriteLine(a == "null"); // false
            Console.WriteLine(a == null); // true

            //// System.NullReferenceException: 'Object reference not set to an instance of an object.'
            //NoIntance noIntance = null;
            //noIntance.GetException();
            //// no data, no exception
            //var data = new List<int> { 1, 2, 3, 4, 5 };
            //var dataWhere = data.Where(x => x.Equals(6));
            //var dataList = dataWhere.ToList();
            //// System.ArgumentNullException: 'Value cannot be null. '
            //List<int> dataNull = null;
            //dataNull.ToList();

            // 對時區符號做處理
            //string dbTime = "+08:00";
            //var a = dbTime.Replace("+", "");
            //var timeSpan = TimeSpan.Parse(a);
            ////.ToString("+#;-#;0");
            //Console.WriteLine(timeSpan);

            // 不同時區比較 已測是可以的 , maybe 背後都會轉成 UTC+0 來比
            //var now = DateTimeOffset.Parse("2022-01-11 10:00:00+08:00");
            //var limit = DateTimeOffset.Parse("2022-01-11 02:00:00+00:00");
            //if (now.Equals(limit))
            //    Console.WriteLine("now = limit");
            //if (now > limit)
            //    Console.WriteLine("now > limit");
            //if (now < limit)
            //    Console.WriteLine("now < limit");

            // 時區解析
            //Console.WriteLine(DateTimeOffset.UtcNow.Offset);
            //Console.WriteLine(DateTimeOffset.Now.Offset);
            //var dto_TimeZone_By_int = DateTimeOffset.Parse("2020-2-20 19:11:22.1234567"); // ok 不指定時區，就用預設時區
            //var dto = DateTimeOffset.Parse("2020-2-20 19:11:22.1234567+08:00");//ok 指定時區
            //var dto = DateTimeOffset.Parse("2020-2-20 19:11:22.1234567+-08:00"); // exception
            //var dto_timeZone_by_int = DateTimeOffset.Parse("2020-2-20 19:11:22.1234567+7"); // ok 指定時區
            //var dto_timeZone_by_int = DateTimeOffset.Parse("2020-2-20 19:11:22.1234567Z7"); // exception
            //var dto_timeZone_by_int = DateTimeOffset.Parse("2020-2-20 19:11:22.1234567Z08:00");// exception
            //var dto_timeZone_by_int = DateTimeOffset.Parse("2020-2-20 19:11:22.1234567Z08:00:00");// exception
            //Console.WriteLine(dto_timeZone_by_int);
            //Console.WriteLine(dto_timeZone_by_int.Offset);

            //var timeSpan = TimeSpan.Parse("-08:00:00");
            //var timeSpanHour = timeSpan.Hours;
            //var datetime_operation_with_timeSpan = db_DayStartTime + timeSpan;

            //// front-end parameters
            //var timeSpan = TimeSpan.Parse("-08:00");
            //var timeSpanHour = TimeSpan.Parse("08:00").Hours;
            ////var timeSpanHour_format = timeSpan.ToString("0:zz"); // excpetion
            //var timeSpanHour_format = timeSpanHour.ToString("+#;-#;0"); 
            //var db_DayStartTime = DateTime.Parse("2022-01-10 14:00:00");
            //var check = $"{db_DayStartTime}{timeSpanHour}";
            //var timeSpanHour_to_symbal = Math.Sign(timeSpanHour);
            //var dto_timeZone_by_timeSpan = DateTimeOffset.Parse($"{db_DayStartTime}{timeSpanHour_format}"); //exception: DateTimeOffset.Parse($"{DateTime}{TimeSpan}")
            ////var dto_timeZone_by_timeSpan = DateTimeOffset.Parse(datetime_operation_with_timeSpan.ToString());

            //// 簡寫 : 需驗證 時區範圍 12 到 -13
            //var 簡寫 = DateTimeOffset.Parse($"{db_DayStartTime}{TimeSpan.Parse("-13:00").Hours.ToString("+#;-#;0")}");
            //var 驗證UTC_0 = 簡寫.ToUniversalTime();

            //var aa = TimeSpan.Zero;
            //Console.WriteLine(TimeSpan.Zero);


            //check_timeSpan_default();
        }

        class NoIntance
        {
            public void GetException() { }
        }
        static void check_timeSpan_default(TimeSpan timeSpan = default)
        {
            Console.WriteLine(timeSpan);
        }

        static void List_DeepClone()
        {
            var original = new List<int> { 1, 3, 5 };
            var copy = original.Select(m => m).ToList();

            Console.WriteLine("init:");
            original.ForEach(m => Console.WriteLine($"original {m}"));
            copy.ForEach(m => Console.WriteLine($"copy {m}"));

            Console.WriteLine("original.Remove(3):");
            original.Remove(3);
            original.ForEach(m => Console.WriteLine($"original {m}"));
            copy.ForEach(m => Console.WriteLine($"copy {m}"));

            Console.WriteLine("copy.Add(7);:");
            copy.Add(7);
            original.ForEach(m => Console.WriteLine($"original {m}"));
            copy.ForEach(m => Console.WriteLine($"copy {m}"));
        }

        // List.Remove() & List.RemoveAt(), it will be change data structure
        static void List_Remove()
        {
            var list = new List<int> { 1, 3, 5, 7, 9};
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"before {i} : {list[i]}");

            list.Remove(5);

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"Remove(5) {i} : {list[i]}");

            list.RemoveAt(2);

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"RemoveAt(2) {i} : {list[i]}");
        }

        static void ForLoop_Special()
        {
            for (int i = 0, j = 1, k = 2; i < 1; i++)
                Console.WriteLine($"multivariable: {i}, {j}, {k}");

            // always false
            for (int i = 0; i < 0; i++)
                Console.WriteLine(i);

            for (int i = 0; false; i++)
                Console.WriteLine(i);

            int index = 0;

            // early define index
            for (index = 0; index < 0; index++)
                Console.WriteLine(index);

            // early define index & no default index
            for (; index < 0; index++)
                Console.WriteLine(index);

            // early define index & no default index & no default iteration 
            for (; index < 0;)
                Console.WriteLine(index);
            
            // it can work, but it is infinite loop 
            // for (;;) Console.WriteLine(index);
        }

        static void Enum_IsDefine()
        {
            Console.WriteLine(Enum.IsDefined(typeof(Status), 1));
            Console.WriteLine(Enum.IsDefined(typeof(Status), 5));

            // 強塞
            Status status = (Status)5;
            Console.WriteLine(Enum.IsDefined(typeof(Status), status));
        }

        static void ToStringSymbol() => Console.WriteLine((1231234.456).ToString("N0"));

        static void StringParsing()
        {
            // 字串解析 - 網址
            var url = "https://news.ycombinator.com/news?p=2";
            var find = "p=";
            var index = url.IndexOf(find) + find.Length;
            var target = url.Substring(index, 1);
            Console.WriteLine("index " + index);
            Console.WriteLine("target " + target);
        }

        static void DictionaryTryRemove()
        {
            ConcurrentDictionary<string, int> data = new ConcurrentDictionary<string, int>();

            data.TryAdd("1", 1);
            Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));

            data.TryAdd("1", 1);
            Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));

            data.TryAdd("2", 2);
            Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));

            data.TryRemove("2", out var remove2);
            Console.WriteLine(remove2);
            Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));

            data.TryRemove("3", out var remove3);
            Console.WriteLine(remove3);
            Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));

            data.TryAdd("5", 5);
            data.TryRemove("5", out var remove5);
            Console.WriteLine(remove5);
            Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));

            data.TryAdd("6", 60);
            data.TryRemove("6", out var remove6);
            Console.WriteLine(remove6);
            Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));

            ConcurrentDictionary<long, MyClass> dataMyClass = new ConcurrentDictionary<long, MyClass>();
            dataMyClass.TryAdd(1, new MyClass { Name = "Birdy", Age = 18});
            dataMyClass.TryAdd(2, new MyClass { Name = "Cody", Age = 20 });

            //Console.WriteLine(JsonConvert.SerializeObject(dataMyClass, Formatting.Indented));
            //dataMyClass.TryRemove(7, out var remove7);
            //Console.WriteLine("remove7 " + JsonConvert.SerializeObject(remove7));

            //dataMyClass.TryRemove(2, out var myClass2);
            //Console.WriteLine("myClass2 " + JsonConvert.SerializeObject(myClass2));
            //Console.WriteLine(JsonConvert.SerializeObject(dataMyClass, Formatting.Indented));


            Console.WriteLine("-- Clone ");
            // 不行，修改 clone，連原始值也會被改
            //var clone = dataMyClass.ToDictionary(entry => entry.Key, entry => entry.Value);
            //var clone = dataMyClass.Select(d => d).ToDictionary(entry => entry.Key, entry => entry.Value);
            //clone[1].Name += " New";

            // 型別會變
            //var clone = dataMyClass.ToArray().Clone();
            //clone[1].Name += " New";

            // 得到 null 不知怎麼使用
            //var clone = dataMyClass.ToArray().Clone() as ConcurrentDictionary<long, MyClass>; 

            // Json 可以
            Console.WriteLine(dataMyClass.GetType());
            var clone = JsonConvert.DeserializeObject<ConcurrentDictionary<long, MyClass>>(JsonConvert.SerializeObject(dataMyClass));

            clone[1].Name += " New";
            Console.WriteLine(JsonConvert.SerializeObject(clone, Formatting.Indented));
            Console.WriteLine("-- Original ");
            Console.WriteLine(JsonConvert.SerializeObject(dataMyClass, Formatting.Indented));
        }

        static void ChangeMoney()
        {
            List<int> ChipType = new List<int> {
                100, 500, 2000, 5000,
                10000, 50000, 100000, 200000
            };
            List<int> result = new List<int>();

            const int BetBase = 100;

            int BetMinRate = new Random(Guid.NewGuid().GetHashCode()).Next(1, 3000);
            int Target = BetMinRate * BetBase;


            Console.WriteLine($"Target {Target.ToString("N0")}");
            int target = Target;

            var chipType = ChipType.OrderByDescending(c => c);
            foreach (var chip in chipType)
            {
                var count = target / chip;
                result.Add(count);
                target -= chip * count;
                Console.WriteLine($"面額 {chip.ToString("N0")} x {count} 個");
            }
        }

        static void MathPow()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }

        class MyClass
        {
            public string Name;
            public int Age;
        }

        enum Status
        {
            Open = 1,
            Close = 2
        }
    }
}
