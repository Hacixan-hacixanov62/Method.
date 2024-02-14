// # DesinPraktikasi.

//void ShowText()
//{
//    Console.WriteLine("hgg");

//}

//void Test()
//{

//}
////ShowText();

//void ShowText()
//{
//    Console.WriteLine( "Welcome PB101");

//}

//ShowText();

//void Sum()
////{
//int a = 5;
//int b = 10;
//int sum = a + b;
//    Console.WriteLine(sum);
//}
//Sum();


//string SumOfNumbers()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    return "salam";
//}

//string result = SumOfNumbers();

//Console.WriteLine(result);




//void Sum(int num1, int num2)
//{
//    int sum = num1 + num2;
////    Console.WriteLine(sum);
////}

//void SumofEvenNumbers(int[] elems, int number)
//{
//    int sum = 0;
//    foreach (var item in elems)
//    {
//        if (item % 2 == 0)
//        {
//            sum += item;
//        }
//    }

//    int result = sum + number;
//    Console.WriteLine(result);

//}

//int[] nums = { 1, 2, 3, 4 };

//SumofEvenNumbers(nums, 5);


//int[] nums2 = { 1, 2, 3, 40, 70 };

//SumofEvenNumbers(nums2, 10);



//int SumOfEvenNumbers(int[] elems, int number)
//{
//    int sum = 0;

//    foreach (var item in elems)
//    {
//        if (item % 2 == 0)
//        {
//            sum += item;
//        }
//    }

//    int result = sum + number;

//    return result;



//}

//int[] nums = { 1, 2, 3, 4 };

//var result = SumOfEvenNumbers(nums,5 );

// Console.WriteLine(result);



//Console.WriteLine("Add your name  :");

//string name = Console.ReadLine();

//Console.WriteLine("Add your surname :");

//string surname = Console.ReadLine();

//Console.WriteLine(name + "-" + surname);

////int a = 5;

////Console.WriteLine(a.GetType());

////Console.WriteLine(surname.GetType());

//Console.WriteLine("Add frist number:");
//string num1 = Console.ReadLine();

//Console.WriteLine("Add second number:");
//string num2 = Console.ReadLine();

//var result = num1 + num2;

//Console.WriteLine(result);



//Console.WriteLine("Add frist number:");
//int num1 = int.Parse (Console.ReadLine());

//Console.WriteLine("Add second number:");
//int num2 = int.Parse (Console.ReadLine());

//int result = num1 + num2;

//Console.WriteLine(result);

//int[] GetDatas (params int[] nums)
//{
//    return nums;

//}


//var result = GetDatas(1, 2, 3, 4, 5, 6);

//foreach ( var item in result)
//{
//    Console.WriteLine(item);

//}


//int[] GetDatas(int num, params int[] nums)
//{
//    return nums;

//}


//var result = GetDatas(1, 2, 3, 4, 5, 6);

//foreach (var item in result)
//{
//    Console.WriteLine(item);

//}


//int[] GetDatas(int num1, int num2, params int[] nums)
//{
//    return nums;

//}


//var result = GetDatas(1, 2, 3, 4, 5, 6);

//foreach (var item in result)
//{
//    Console.WriteLine(item);

//}


// bu muemalli qaldi  ????????

//int[] SumOfDatas(int num1, int num2, params int[] nums)
//{
//    int sumNumbers = num1 + num2;

//    int sumOfArreyItems = 0;

//    foreach (var item in nums)
//    {
//        sumOfArreyItems += item;
//    }
//    int result = sumNumbers + sumOfArreyItems;

//    return result;


//var result = SumOfDatas(1, 2, 3, 4, 5, 6);  

//Console.WriteLine(result);



//string  GetName( string name)
//{
//    return name;
//}



//Console.WriteLine(GetName("Hacker"));



//string GetName(string name ="XXX")
//{
//    return name;
//}



//Console.WriteLine(GetName("Ismayil"));



//string GetName(string name = "XXX")
//{
//    return name;
//}

//string name = " ";

//Console.WriteLine(GetName(Console.ReadLine ()));



//string GetName(string name = "XXX")
//{
//    return name;
//}

//Name: string name = Console.ReadLine();

//if (name == "")
//{
//    Console.WriteLine(GetName());
//    goto Name;
//}
//else
//{
//    Console.WriteLine(GetName(name));
//}


// # login adinda method olacaq, return Type olmalidir.Method parametr olaraq username ve pasword qebul ededcek. Eger username Cavid123
// ve pasword cavid123_ beraberdirse ekranda "Login Succses " yazilsin , eks halda "Email or password wrong" yazilsin .


//string Login(string username, string password)
//{
//    if (username == "Cavid123" && password == "cavid123_")
//    {
//        return "Login sucessful";
//    }
//    else
//    {
//        return "Username or password wrong";
//    }
//}
//    Console.WriteLine( "Uswrname:  ");
//string username = Console.ReadLine();

//Console.WriteLine("Password:  ");
//string password = Console.ReadLine();

//string result = Login(username, password);

//Console.WriteLine(result);




//string Login(string username, string password)
//{
//    string message;
//    if (username == "Cavid123" && password == "cavid123_")
//    {
//        message= "Login sucessful";
//    }
//    else
//    {
//        message= "Username or password wrong";
//    }
//    return message;
//}

//  Inputs: Console.WriteLine("Uswrname:  ");
//string username = Console.ReadLine();

//Console.WriteLine("Password:  ");
//string password = Console.ReadLine();

//if (username == "" || password=="")
//{
//    Console.WriteLine("Inputs cannot be empty");
//    goto Inputs;
//}

//string result = Login(username, password);

//Console.WriteLine(result);




//string Login(string username, string password)
//{
//    string message;
//    if (username == "Cavid123" && password == "cavid123_")
//    {
//        message = "Login sucessful";
//    }
//    else
//    {
//        message = "Username or password wrong";
//    }
//    return message;
//}

//Inputs: Console.WriteLine("Uswrname:  ");
//string username = Console.ReadLine();

//Console.WriteLine("Password:  ");
//string password = Console.ReadLine();

//if(IsValid(username, password))
//{
//    Console.WriteLine("Inputs cannot be empty");
//    goto Inputs;
//}

//string result =  Login(username, password);

//Console.WriteLine(result);


//bool IsValid(string username,string password)
//{
//    if (username == "" || password == "")
//    {
//        return false;
//    }
//    return true;
//}