//DAFTAR CATATAN
/*

1. Where()
2. Select()
3. Agregate : Min, Max, Count, Sum, Average
4. OrderBy() || OrderByDescending()
5. ThenBy()
6. Partition Query : Take, TakeWhile, Skip, SkipWhile
7. Convertion LINQ : toList(), toArray(), toLookUp(),
8. Element : First, FrtsOrDefault, Last, lastordefault, Single, SingleOrdefault, defaultEmpty
9. GroupBy menggunakan LINQ
10. Load XML menggunakan LINQ : Xelement, XAttribute, Descentans()
11. JOIN menggunakan LINQ : Join, Inner Join, Left Join, Right Join, Cross Join, 
12. UNION & Intersect



 */





//class Program
//{
//    static void Main()
//    {

//    }
//}
//class FindDuplicate
//{
//    public static int FindDuplicateLinq(int[] nums)
//    {
//        var qryDuplicate = nums.GroupBy(x => x)
//            .Where(w => w.Count() > 1)
//            .Select(s => s)
//            .ToList();

//        var result = qryDuplicate.FirstOrDefault();
//        return result.ElementAt(0);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] fibb = { 1, 1, 3, 2, 5, 6, };
//        int fibbCount = fibb.Count();
//        Console.WriteLine($"Count {fibbCount}");

//        //distinc yakni menampilkan angka yang tidak duplicate
//        IEnumerable<int> distincFibb = fibb.Distinct();
//        foreach(var item in distincFibb)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        //int[] fibb = { 1, 1, 2, 3, 5 };
//        //buat query tapi belum dieksekusi pleh compiler
//        //IEnumerable<int> fib = fibb.Where(x => x > 2); //tidak ada method lain lagi, makanya belum di eksekusi
//        //fibb[0] = 99;

//        //foreach(var item in fib) //compiler akan mengeksekusi ketika proses loop
//        //{
//        //    Console.WriteLine(item);
//        //}

//        //================================================================

//        //int[] fibb2 = { 1, 1, 2, 3, 5 };
//        ////membuat query dan langsung dieksekusi, karena ada method to Array()
//        //IEnumerable<int> num = fibb2.Where(w => w > 2).ToArray(); //langsung di eksekusi
//        //fibb2[0] = 99; //sehingga assignment ini tidak berpengaruh terhadap hasil 'num'

//        //foreach(var nu in num)
//        //{
//        //    Console.WriteLine($"{nu}");
//        //}

//        //=================================================================

//        //collection string countries
//        List<string> countries = new List<string>();
//        countries.Add ( "India");
//        countries.Add ( "USA");
//        countries.Add ( "Brasil");
//        countries.Add ( "Argentina");

//        //memilih tiap2 negara dengan menggunkan select
//        // clausa WHERE bisa mengandung logical operator, ex == != >= <= > < .
//        IEnumerable<string> result1 = countries.Select(c => c); //hanya menyeleksi / memilih tiap tiap elemen

//        //posisi anatara WHERE dan SELECT bisa ditukar/posisinya diubah, hasilnya sama saja
//        IEnumerable<string> result = countries.Select(c => c).Where(w => w.Contains("s")); //mengambil nilai dengan kondisi tertentu
//        foreach(var c in result1)
//        {
//            Console.WriteLine(c);
//        }

//        foreach (var c in result) // yang tampil adl countries yg mengandung huruf s didalamnya, WHERE == Case Sensitif | s != S.
//        {
//            Console.WriteLine(c);
//        }

//    }
//}

//class Program
//{
//    //AGREGATE , Min, Max , Sum, Count, Average
//    static void Main()
//    {
//        int[] nums = { 1, 2, 3, 4, 5, 7, 9 };

//        int min = nums.Min();
//        int max = nums.Max();
//        int count = nums.Count();
//        int sum = nums.Sum();
//        double avg = nums.Average();

//        Console.WriteLine($"Nilai Min         : {min}");
//        Console.WriteLine($"Nilai Max         : {max}");
//        Console.WriteLine($"Nilai Count       : {count}");
//        Console.WriteLine($"Nilai Total       : {sum}");
//        Console.WriteLine($"Nilai Rata - Rata : {avg}");
//    }
//}

//class Program
//{
//    //SORTING -- BubleSort. InsertionSort, 
//    //Ascending == OrderBy(lamnda)  
//    //Descending ==  OrderByDescending(lamnda)
//    static void Main()
//    {
//        int[] nums = { 7, 3, 4, 8, 1, 3, 9, 7, 4 };
//        var resultNum = nums.OrderByDescending(w => w);
//        foreach(var num in resultNum)
//        {
//            Console.Write(num);
//        }
//        Console.WriteLine();


//        List<Student> students = new List<Student>()
//        {
//            new Student(){Name = "Madara", Gender = "Male", Subjects = new List<string>{ "Kagebunshin", "Edo Tensei" } },
//        new Student() { Name = "Kakashi", Gender = "Male", Subjects = new List<string> { "Sharingan", "Chidori" } },
//            new Student(){Name = "Konan", Gender = "Female", Subjects = new List<string>{ "Edo Tensei", "Kertas Peledak" } }
//        };

//        Console.WriteLine("Before Sort");
//        foreach(var stud in students)
//        {
//            Console.WriteLine(stud.Name);
//        }

//        var sort = students.OrderBy(w => w.Name);
//        Console.WriteLine("After Sort Linq");
//        foreach(var stud in sort)
//        {
//            Console.WriteLine(stud.Name);
//        }

//    }
//}

//class Student
//{
//    public string Name { get; set; }
//    public string Gender { get; set; }
//    public List<string> Subjects { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Student> students = new List<Student>()
//        {
//            new Student{StudentId = 1, Name = "Madara", Gender = "Male"},
//            new Student{StudentId = 1, Name = "Itachi", Gender = "Male"},
//            new Student{StudentId = 2, Name = "Sakura", Gender = "Female"},

//        };

//        // melakukan sort order by Id terlebih dulu, kemudian order by name menggunakan ThenBy()
//        // SELECT * FROM Student ORDER BY StudentId, Name ASC
//        // Untuk Descending, bisa menggunakan ThenByDescending()
//        // dan posisinya bisa dibalik
//        var resultStudent = students.OrderBy(w => w.StudentId).ThenBy(x => x.Name);
//        foreach(var student in resultStudent)
//        {
//            Console.WriteLine($"{student.StudentId} - {student.Name}");
//        }

//        Console.WriteLine("==================================================");

//        var resultStudentDesc = students.OrderBy(w => w.StudentId).ThenByDescending(x => x.Name);
//        foreach(var student in resultStudentDesc)
//        {
//            Console.WriteLine($"{student.StudentId} - {student.Name}");
//        }

//    }
//}
//class Student
//{
//    public string Name { get; set; }
//    public int StudentId { get; set; }
//    public string Gender { get; set; }
//}

//class Program
//{
//Partision Query, Skip, Take,Takewhile
// partition query bisa dikombinasikan dengan linq lain, seperti orderby, thenby, baik ASC atau DESC
//Take == mengambil hasil tertentu. Misalnya mengambil 3 data teratas

//static void Main(string[] arg)
//{
//    string[] countries = { "USA", "England", "Brasil", "NKRI", "France" };
//    //SELECT TOP 3 FROM Countries, Mengambil 3 teratas dari countrie
//    IEnumerable<string> result = countries.Take(3);

//    foreach (var country in result)
//    {
//        Console.WriteLine(country);
//    }


//    //take while akan mengambil value ketika hasil while itu true.
//    //jika terjadi false, proses loop akan berhenti di hasil terakhir
//    string[] fruit = { "apple", "banana", "manggo", "grape", "watermelon" };
//    IEnumerable<string> result2 = fruit.TakeWhile(fruit => String.Compare("grape", fruit, true) != 0);
//    foreach (var a in result2)
//    {
//        Console.WriteLine(a);
//    }

//}

//static void Main(string[] arg)
//{
//    string[] countries = { "USA", "England", "Brasil", "NKRI", "France" };
//    //SELECT * FROM Countries (SELECT ROW_NUMBER() OVER(ORDER BY Country) as RowNum FROM Countries)
//    //AS  Tbl WHERE Country < RowNum,
//    //Melewati seleksi 3 terdepan dari countrie

//    IEnumerable<string> result = countries.Skip(3);

//    foreach (var country in result)
//    {
//        Console.WriteLine(country);
//    }



//}

//static void Main()
//{
//    string[] countries = { "USA", "Argentina", "Barsil", "Qatar", "England", "Korea", "Japan"};

//    //SELECT * FROM Countries
//    //ORDER BY [Fileds]
//    //OFFSET 3 ROW //skip
//    //FETCH NEXT 5 ROW ONLY //take

//    //perintah setara dengan Native SQL diatas
//    IEnumerable<string> result = (from x in countries select x).Skip(3).Take(2).OrderBy(x => x);

//    foreach(var res in result)
//    {
//        Console.WriteLine(res);
//    }
//}

//    static void Main()
//    {
//        string[] countries = { "USA", "Argentina", "Barsil", "Qatar", "England", "Korea", "Japan" };

//        //SELECT * FROM Countries
//        //ORDER BY [Fileds]
//        //OFFSET 3 ROW //skip
//        //FETCH NEXT 5 ROW ONLY //take

//        //perintah setara dengan Native SQL diatas
//        IEnumerable<string> result = (from x in countries select x)
//                                    .Skip(3) //lewati 3 value pertama
//                                    .Take(2) //megambil 2 value setelahnya
//                                    .Where(x => x.Contains("a")) //mengambil value yang memiliki huruf a 
//                                    .OrderBy(x => x); //mengurutkan secara asc

//        foreach (var res in result)
//        {
//            Console.WriteLine(res);
//        }
//    }

//}

//class Program
//{
//Convertion LINQ
//toList(), toArray()

//static void Main()
//{
//    string[] countries = { "USA", "Argentina", "Brasil", "Qatar", "England", "Korea", "Japan" };

//    //convert to list
//    List<string> result = countries.ToList();
//    foreach (var str in result)
//    {
//        Console.WriteLine(str);
//    }
//}

//    static void Main()
//    {
//        List<string> countries = new List<string>();
//        countries.Add("USA");
//        countries.Add("UK");
//        countries.Add("Italy");
//        countries.Add("Belgium");
//        countries.Add("Netherland");

//        //convert to Array String
//        string[] result = (from x in countries select x).ToArray();

//        foreach (var str in result)
//        {
//            Console.WriteLine(str);
//        }
//    }
//}

//class Program
//{
//    //To LOOKUP
//    static void Main()
//    {
//        List<Employee> employees = new List<Employee>()
//        {
//            new Employee(){Name = "Rama", Department= "IT", Country = "Japan"},
//            new Employee(){Name = "Sari", Department= "HR", Country = "Mongolia"},
//            new Employee(){Name = "Dewi", Department= "IT", Country = "India"},
//            new Employee(){Name = "Restu", Department= "HR", Country = "Japan"},
//            new Employee(){Name = "Riski", Department= "Production", Country = "Malaysia"},
//            new Employee(){Name = "Tamara", Department= "Sales", Country = "Japan"},
//            new Employee(){Name = "Sakura", Department= "IT", Country = "Japan"},
//            new Employee(){Name = "Inne", Department= "Production", Country = "India"},
//            new Employee(){Name = "Reska", Department= "HR", Country = "Taiwan"},
//            new Employee(){Name = "Yunne", Department= "IT", Country = "Taiwan"},
//        };

//        //toLookup adl LINQ untuk melakukan group by key
//        var empLookUp = employees.ToLookup(w => w.Department); //look up by department, key == department

//        //Display
//        Console.WriteLine("Group Employee by Department");
//        Console.WriteLine("================================");
//        foreach(var dept in empLookUp)
//        {
//            Console.WriteLine(dept.Key); //key saat ini adalah per department
//            foreach(var emp in empLookUp[dept.Key]) //melakukan proses loop di department tsb utk menampilkan isi dr masing2 dept
//            {
//                Console.WriteLine($"{emp.Name} - {emp.Department} - {emp.Country}");
//            }
//            Console.WriteLine("-----------------------------------");
//        }
//    }
//}

//class Employee
//{
//    public string Name { get; set; }
//    public string Department { get; set; }
//    public string Country { get; set; }
//}


//class Program
//{
//    //ELEMENT LINQ
//    //First() == mengambil element pertama pada array atau collection lainnya 
//    //Last() == mengambil element terakhir pada array atau collection lainnya
//    //FirstOrDefault() == mengambil SATU element pertama, dan mengambil default value (0) jika tidak ada, bentuknya ARRAY tapi element ke 1
//    //LastOrDefault() == mengembalikan nilai terakhir dalam sequence, default value (0) jika tdk ada.
//    //Single == mengembalikan SATU element dalam suatu coll. Single tidak bisa mengambil 2 value yg sama yakni ERROR
//    //SingleOrDefault == sama seperti single, namun akn meretunr nilai default (0) ketika tdk ada
//    static void Main()
//    {
//        int[] obj = { 2, 4, 7, 4, 6, 3, 7 };
//        var first = (from x in obj select x).First();
//        var last = (from x in obj select x).Last();
//        var fd = (from x in obj select x).FirstOrDefault();
//        int single = (from x in obj select x).Single( w => w == 6);

////Note :
////Pd kasus diatas, firstordefault bisa melakukan seleksi ke angka 4 dan 7 dg hanya mereturn satu value saja, yakni value pertamanya 
////Sedangkan Single akan error jika melakukan seleksi ke angka 4 dan 7. Dan error jg ketika tdk memberikan lamda pada query-nya

//        Console.WriteLine($"ini element pertama : {first}");
//        Console.WriteLine($"ini element terakhir : {last}");
//        Console.WriteLine($"ini First Or Default : {fd}");
//        Console.WriteLine($"ini Single : {single}");
//    }
//}

//class Pogram
//{
//    //defualtEmpty
//    static void Main()
//    {
//        int[] objA = { 1, 1, 4, 5, 5, 6, 7, };
//        int[] objB = { };

//        var resultA = objA.DefaultIfEmpty();
//        var resultB = objB.DefaultIfEmpty();

//        Console.WriteLine("List dengan Nilai");
//        foreach(var res in resultA)
//        {
//            Console.WriteLine(res);
//        }

//        Console.WriteLine("List Tanpa Nilai");
//        foreach (var res in resultB)
//        {
//            Console.WriteLine(res);
//        }
//    }
//}


//class Program
//{
//    //GROUP BY
//    static void Main()
//    {
//        List<Student> students = new List<Student>()
//        {
//            new Student(){Name = "Madara", Gender = "Male", City="Konoha"},
//            new Student(){Name = "Kakuzu", Gender = "Male", City="Konoha"},
//            new Student(){Name = "Kabuto", Gender = "Male", City="Konoha"},
//            new Student(){Name = "Orochimaru", Gender = "Male", City="Konoha"},
//            new Student(){Name = "Tsunade", Gender = "Female", City="Konoha"},
//            new Student(){Name = "Kurenai", Gender = "Female", City="Konoha"},
//            new Student(){Name = "Hinata", Gender = "Female", City="Konoha"},
//            new Student(){Name = "Naruto", Gender = "Male", City="Konoha"},
//        };

//        var studentGroup = from student in students   //group by hampir sama dengan lookup
//                           group student by student.Gender;

//        foreach(var studentItem in studentGroup)
//        {
//            Console.WriteLine(studentItem.Key);
//            foreach(var student in studentItem)
//            {
//                Console.WriteLine($"{student.Name} - {student.City}");
//            }
//            Console.WriteLine("---------------------------");
//        }
//    }
//}

//class Student
//{
//    public string Name { get; set; }
//    public string Gender { get; set; }
//    public string City { get; set; }
//}



//LOAD XML ke LINQ
//using System.Xml.Linq;

//class Program
//{
//    static void Main()
//    {
//        var xml = @"
//                    <ingredients>
//                        <ingredient name='Milk' quantity='200' price='5000' />
//                        <ingredient name='Sugar' quantity='10' price='10000' />
//                        <ingredient name='Salt' quantity='100' price='2000' />
//                        <ingredient name='Coffee' quantity='150' price='3000' />
//                    </ingredients>
//                    ";

//        XElement xElement = XElement.Parse(xml);

//        XElement Milk = xElement.Descendants("ingredient").First(x => x.Attribute("name").Value == "Milk");

//        XAttribute namaAtribute = Milk.Attribute("name");
//        XAttribute priceAttribute = Milk.Attribute("price");
//        string priceMilk = priceAttribute.Value;
//        XAttribute qty = Milk.Attributes().Skip(1).First();

//        Console.WriteLine(qty);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Ingerdients[] ingerdients =
//        {
//            new Ingerdients{Name = "Sugar", Calories = 200},
//            new Ingerdients{Name = "Egg", Calories = 50},
//            new Ingerdients{Name = "Milk", Calories = 80},
//            new Ingerdients{Name = "Salt", Calories = 90},
//        };


//        IEnumerable<string> ingredientss = ingerdients.Where(x => x.Calories > 80)
//                                                    .OrderBy(x => x.Name)
//                                                    .Select(y => y.Name);

//        foreach( var ing in ingredientss)
//        {
//            Console.WriteLine(ing);
//        }

//    }
//}

//class Ingerdients
//{
//    public string Name { get; set; }
//    public int Calories { get; set; }
//}

//======================================================

//class Program
//{
//    static void Main()
//    {
//        Ingerdients[] ingredients =
//        {
//            new Ingerdients{Name = "Sugar", Calories = 100},
//            new Ingerdients{Name = "Egg", Calories = 50},
//            new Ingerdients{Name = "Milk", Calories = 80},
//            new Ingerdients{Name = "Salt", Calories = 90},
//            new Ingerdients{Name = "Butter", Calories = 90},
//        };



//        IEnumerable<Ingerdients> hiCalorie =
//            from i in ingredients //FROM Ingredients
//            select new //SELECT OriginalIngredients, Isdairy, dan IsHighCalorie
//            {
//                OiriginalIngredient = i,
//                IsDairy = i.Name == "Milk" || i.Name == "Sugar",
//                isHighCalorie = i.Calories >= 80,
//            }
//            into temp //INTO Temp
//            where temp.IsDairy && temp.isHighCalorie //WHERE
//            select temp.OiriginalIngredient; //SELECT

//        foreach(var ingredient in hiCalorie)
//        {
//            Console.WriteLine(ingredient.Name);
//        }

//    }
//}

//class Ingerdients
//{
//    public string Name { get; set; }
//    public int Calories { get; set; }
//}

//=====================================================================
//|                               JOIN                                |
//=====================================================================
//class Program
//{
//    //Inner Join
//    static void Main()
//    {
//        Recipe[] recipes =
//        {
//            new Recipe{Id = 1,Name = "Mashed Potato"},
//            new Recipe{Id = 2,Name = "Crispy Duck"},
//            new Recipe{Id = 3,Name = "Sachertote"},
//        };

//        Review[] reviews =
//        {
//            new Review{RecipeId = 1, ReviewText = "Tasty !"},
//            new Review{RecipeId = 1, ReviewText = "Not Bad "},
//            new Review{RecipeId = 1, ReviewText = "Pretty Good !"},
//            new Review{RecipeId = 2, ReviewText = "Too Hard !"},
//            new Review{RecipeId = 2, ReviewText = "Loved It"},

//        };

//        var query = from recipe in recipes
//                    join review in reviews on recipe.Id equals review.RecipeId
//                    select new //SELECT FIELDS
//                    {
//                        RecipeName = recipe.Name,
//                        RecipeReview = review.ReviewText
//                    };
//        foreach(var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'",item.RecipeName, item.RecipeReview);
//        }

//    }
//}

//class Program
//{
//    //Left Join
//    //akan mengambil semua field tabel kiri, ketika null maka akan di assign nilai tertentu
//    static void Main()
//    {
//        Recipe[] recipes =
//        {
//            new Recipe{Id = 1,Name = "Mashed Potato"},
//            new Recipe{Id = 2,Name = "Crispy Duck"},
//            new Recipe{Id = 3,Name = "Sachertote"},
//        };

//        Review[] reviews =
//        {
//            new Review{RecipeId = 1, ReviewText = "Tasty !"},
//            new Review{RecipeId = 1, ReviewText = "Not Bad "},
//            new Review{RecipeId = 1, ReviewText = "Pretty Good !"},
//            new Review{RecipeId = 2, ReviewText = "Too Hard !"},
//            new Review{RecipeId = 2, ReviewText = "Loved It"},

//        };

//        var query = from recipe in recipes
//                    join review in reviews on recipe.Id equals review.RecipeId into ReviewGroup
//                    from rg in ReviewGroup.DefaultIfEmpty()
//                    select new 
//                    {
//                        RecipeName = recipe.Name,
//                        RecipeReview = rg == null ? "No Review" : rg.ReviewText
//                    };
//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }

//    }
//}

//class Program
//{
//    //Right Join
//    //akan mengambil semua field tabel kiri, ketika null maka akan di assign nilai tertentu
//    static void Main()
//    {
//        Recipe[] recipes =
//        {
//            new Recipe{Id = 1,Name = "Mashed Potato"},
//            new Recipe{Id = 2,Name = "Crispy Duck"},
//            new Recipe{Id = 3,Name = "Sachertote"},
//        };

//        Review[] reviews =
//        {
//            new Review{RecipeId = 1, ReviewText = "Tasty !"},
//            new Review{RecipeId = 1, ReviewText = "Not Bad "},
//            new Review{RecipeId = 1, ReviewText = "Pretty Good !"},
//            new Review{RecipeId = 2, ReviewText = "Too Hard !"},
//            new Review{RecipeId = 2, ReviewText = "Loved It"},

//        };

//        //SELECT RecipeName, ReviewText FROM Review
//        // RIGHT JOIN Recipe ON RecipeId = Review.RecipeId 

//        //Right Join bisa dibuat dengan men-switch dataset dari left join dalam LINQ

//        var query = from review in reviews
//                    join recipe in recipes 
//                    on review.RecipeId equals recipe.Id into RecipeGroup
//                    from rc in RecipeGroup.DefaultIfEmpty()
//                    select new
//                    {
//                        RecipeReview = review.ReviewText,
//                        RecipeName = rc == null ? "No Recipe" : rc.Name
//                    };
//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }

//    }
//}

//class Program
//{
//    //Cross join, yakni perkalian dua buah tabel antara kanan dikali ke kiri
//    static void Main()
//    {
//        Recipe[] recipes =
//        {
//            new Recipe{Id = 1,Name = "Mashed Potato"},
//            new Recipe{Id = 2,Name = "Crispy Duck"},
//            new Recipe{Id = 3,Name = "Sachertote"},
//        };

//        Review[] reviews =
//        {
//            new Review{RecipeId = 1, ReviewText = "Tasty !"},
//            new Review{RecipeId = 1, ReviewText = "Not Bad "},
//            new Review{RecipeId = 1, ReviewText = "Pretty Good !"},
//            new Review{RecipeId = 2, ReviewText = "Too Hard !"},
//            new Review{RecipeId = 2, ReviewText = "Loved It"},

//        };

//        var query = from recipe in recipes
//                    from review in reviews


//                    select new
//                    {
//                        RecipeName = recipe.Name,
//                        RecipeReview = review.ReviewText,
//                    };
//        foreach (var item in query)
//        {
//            Console.WriteLine("{0} - '{1}'", item.RecipeName, item.RecipeReview);
//        }

//    }
//}
//class Recipe
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}
//class Review
//{
//    public int RecipeId { get; set; }
//    public string ReviewText { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var people1 = new[]
//        {
//            new{Id = 11, Name = "Madara", City = "Amegakure"},
//            new{Id = 97, Name = "Sasuke", City = "Kumo"},
//            new{Id = 67, Name = "Itachi", City = "Suna"},
//            new{Id = 55, Name = "Fugaku", City = "Konoha"},
//            new{Id = 10, Name = "Obito", City = "Konoha"},
//        };

//        var people2 = new[]
//        {
//             new{Id = 11, Name = "Kaguya", City = "Suna"},
//            new{Id = 97, Name = "Minato", City = "Kumo"},
//            new{Id = 67, Name = "Naruto", City = "Suna"},
//            new{Id = 55, Name = "Kakashi", City = "Oto"},
//            new{Id = 10, Name = "Fugaku", City = "Suna"},
//        };

//        //UNION Secara performance itu JELEK / BURUK, jangan dipakai kecuali terpaksa

//        var result = people1.Union(people2);
//        foreach(var people in result)
//        {
//            Console.WriteLine($"{people.Name} - {people.City}");
//        }
//    }
//}

class Program
{
    static void Main()
    {
        var people1 = new[]
        {
            new{Id = 11, Name = "Madara", City = "Amegakure"},
            new{Id = 97, Name = "Sasuke", City = "Kumo"},
            new{Id = 67, Name = "Itachi", City = "Suna"},
            new{Id = 55, Name = "Fugaku", City = "Konoha"},
            new{Id = 10, Name = "Obito", City = "Konoha"},
        };

        var people2 = new[]
        {
             new{Id = 11, Name = "Kaguya", City = "Suna"},
            new{Id = 97, Name = "Minato", City = "Kumo"},
            new{Id = 67, Name = "Naruto", City = "Suna"},
            new{Id = 55, Name = "Kakashi", City = "Oto"},
            new{Id = 55, Name = "Fugaku", City = "Konoha"},
        };

        //UNION Secara performance itu JELEK / BURUK, jangan dipakai kecuali terpaksa

        var result = people1.Intersect(people2);
        foreach (var people in result)
        {
            Console.WriteLine($"{people.Name} - {people.City}");
        }
    }
}