
for(; ;) {

}

int bigInt = int.MaxValue;
Console.WriteLine(bigInt);
bigInt++;
Console.WriteLine(bigInt);



//string strNumber = "2345";

//int anInt = 0;

//bool CanConvert = int.TryParse(strNumber, out anInt);

//if(!CanConvert) {
//    Console.WriteLine("The string could not be converted!");
//} else {
//    Console.WriteLine($"The converted value is {anInt}");
//}







// Fizz/Buzz

#region Fizz/Buzz

//for (int idx = 1; idx <= 100; idx++) {

//    if(idx % 5 == 0 && idx % 3 == 0) {
//        Console.Write("FizzBuzz ");
//        continue;
//    }
//    if (idx % 3 == 0) {
//        Console.Write("Fizz ");
//        continue;
//    }
//    if (idx % 5 == 0) {
//        Console.Write("Buzz ");
//        continue;
//    }
//    Console.Write($"{idx} ");
//}


#endregion















//int[] NewScores = { 130, 460, 975, 169, 134,
//                    413, 436, 241, 598, 811,
//                    589, 726, 933, 906, 326,
//                    966, 861, 679, 797, 362,
//                    885, 551, 277, 997, 841 };

//int sum = 0;

// Sum if evenly divisible by 3
// Sum if evenly divisible by 5 or 7
//foreach(int nbr in NewScores) {
//for(int idx = 1; idx <= 100; idx++) { 

//    if(idx % 5 == 0) { 
//        sum += idx;
//        continue;
//    }
//    if(idx % 7 == 0) { 
//        sum += idx;
//    }


//}

//Console.WriteLine($"Sum is {sum}");











// for()

//int i = 1000000;
//int sum = 0;

//for(int i = 1000000; i > 0; i--) {
//    if (i % 2 == 0) {
//        continue;
//    }
//    sum += i;
//}

//do {
//    sum += i;
//    i--;
//} 
//while (i > 0);

//int i = 1000000
//while (i > 0) {
//    sum += i;
//    i--;
//}
//Console.WriteLine($"Sum of number 1 to 100 is {sum}");

//var stateCode = "IN";
//var city = "Cincinnati";
//string salesperson = String.Empty;

//salesperson = stateCode switch {
//    "OH" => "Karl",
//    "MI" => "Karl",
//    "KY" => "Sam",
//    "IN" => "Ian",
//    _    => "Greg"
//};

//switch(stateCode) {
//    case "OH":
//        Console.WriteLine("Ohio");
//        break;
//    case "KY":
//        Console.WriteLine("Kentucky");
//        break;
//    case "IN":
//        Console.WriteLine("Indiana");
//        break;
//    default:
//        Console.WriteLine("It is not a tristate state");
//        break;
//}


//if (state == "OH") {
//    Console.WriteLine("State is Ohio");
//    if(city == "Cincinnati") {
//        Console.WriteLine("City is Cincinnati");
//    } else if (city == "Columbus") {
//        Console.WriteLine("City is Columbus");
//    } else {
//        Console.WriteLine("City is Cleveland");
//    }
//} else if (state == "KY") {
//    Console.WriteLine("State is Kentucky");
//} else {
//    Console.WriteLine("State is not Ohio or Kentucky");
//}


//=========================================
//var boolean = true;

//if (boolean) {
//    Console.WriteLine("Boolean is true!");
//} else {
//    Console.WriteLine("Boolean is false!");
//}