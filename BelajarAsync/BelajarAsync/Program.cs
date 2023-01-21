using System.Diagnostics;

namespace BelajarAsync
{
    #region example Asyncronus
    /*
    class Program
    {
        // declare empty class for demo purpose only
        internal class Bacon { }
        internal class Coffe { }
        internal class Egg { }
        internal class Juice { }
        internal class Toast { }
        static async Task Main(string[] args) //async
        {
            var cup = PourCoffeeAsync();
            Console.WriteLine("Coffe is ready");

            var eggs = FryEggAsync(2);
            Console.WriteLine("Eggs Are Ready");

            var bacon = FryBaconAsync(3);
            Console.WriteLine("Bacon is ready");

            //Toast toast = await MakeToastBreadAsync(3);
            var toast = MakeToastBreadAsync(3);

            
            //menunggu semua task yg diassign untuk menyelesaikan ekseskusinya
            //sama seperti menambahkan await didepan. di masing2 funct diatas (cup, egg, bacon, toast)

            Task.WaitAll(cup, eggs, bacon, toast); 

            //Toast toast = await ToastBreadAsync(3);
            //await ApplyButterAsync(toast);
            //await ApplyJamAsync(toast);
            //Console.WriteLine("Toast is ready");

            Juice jou = await PourOjAsync();
            Console.WriteLine("oj is  ready");
            Console.WriteLine("Breakfast is Ready");

        }

        private static async Task<Juice> PourOjAsync() //utk funct yg mengembalikan return, memakai async Task <Tipe return>
        {
            Console.WriteLine("Pouring Orange Juice");
            return await Task.Run(()=> new Juice());
        }

        private static async Task ApplyJamAsync (Toast toast) //utk funct void, hanya Task saja
        {
            Console.WriteLine("Putting jam on the toast");
        }

        private static async Task ApplyButterAsync(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        private static async Task <Toast> MakeToastBreadAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            await ApplyButterAsync(toast);
            await ApplyJamAsync(toast);

            return toast;
        }

        private static async Task <Toast> ToastBreadAsync(int slices)
        {
            for(var slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting slice of bread on the Toaster");
            }
            Console.WriteLine("Start Toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from Toaster");

            return await Task.Run(() => new Toast()); 
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"Putting {slices} slices of bacon in the pan");
            Console.WriteLine("Cooking fisrt side of bacon");
            Task.Delay(3000).Wait();
            for(var slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon..");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put Bacon on the plat");

            return await Task.Run(()=> new Bacon()) ;
        }

        private static async Task<Egg> FryEggAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan ...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"Cracking {howMany} Eggs...");
            Console.WriteLine("Cooking the eggs");
            Task.Delay(3000).Wait();
            Console.WriteLine("Putting egg on the plate");

            return await Task.Run(() => new Egg());
        }

        private static async Task PourCoffeeAsync()
        {
            //Console.WriteLine("Pouring Coffee");
            //return await Task.Run(()=> new Coffe());
            await Task.Run(() =>
            {
                Console.WriteLine("Pouring Coffee");
            });
        }
    }
    */
    #endregion

    class BelajarAsync
    {
        public static void Main()
        {
            //syncronus, method akan dijalankan satu per satu
            //asyncronus, semua method akan dijalankan, sehingga processor akan membuat thread sesuai dengan jumlah eksekusinya
            //DemoSynch();
            DemoAsynch();
        }

        public static void DemoSynch()
        {
            var watch = new Stopwatch();
            watch.Start();
            StartTask();
            TaskOne();
            TaskTwo();
            watch.Stop();

            Console.WriteLine($"Execute time is : {watch.ElapsedMilliseconds} ms");
        }
        private static void StartTask()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Start task");
        }
        private static void TaskOne()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Task One");
        }
        private static void TaskTwo()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Task Two");
        }

        public static async void DemoAsynch()
        {
                var watch = new Stopwatch();
                watch.Start();
                var startTask = StartTaskAsync();
                await startTask;
                var task1 = TaskOneAsync();
                var task2 = TaskTwoAsync();

                Task.WaitAll(startTask, task1, task2);
                watch.Stop();

                Console.WriteLine($"Execute time is : {watch.ElapsedMilliseconds} ms");
            
        }
        private static async Task StartTaskAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(6000);
                Console.WriteLine("Start task");
            });
            
        }
        private static async Task TaskOneAsync()
        {
            await Task.Run(() => {
                Thread.Sleep(3000);
                Console.WriteLine("Task One");
            });
            
        }
        private static async Task TaskTwoAsync()
        {
            await Task.Run(() => {
                Thread.Sleep(3000);
                Console.WriteLine("Task Two");
            });
        }
    }
}