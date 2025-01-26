// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// string[] names = { "Rowena", "Robin", "Bao" };


// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// Console.WriteLine(names.Length);

// int[] inventory = { 200, 450, 225, 175, 220 };
// int sum =0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running Total: {sum})");

// }
// Console.WriteLine($"We have {sum} items in inventory.");




// string [] fraudlant= {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
// foreach (string order in fraudlant)
// {
//    if(order.StartsWith("B"))
//     {
//          Console.WriteLine(order);
//     }
// }

// Random dice = new();
// int roll = dice.Next(1, 100);
// Console.Clear();
// Console.WriteLine(roll);
// Console.Clear();

// Random dice = new();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");


// Console.WriteLine("Generating 10 random numbers:");

// Random rnd = new();

// for (uint ctr = 1; ctr <= 10; ctr++)
//     Console.WriteLine($"{rnd.Next(95, 100),15:N0}");

// int firstValue = 500;
// int secondValue = 600;
// int largerValue;
// largerValue = Math.Max(firstValue, secondValue);


// Console.WriteLine(largerValue);

// Random dice = new();

// int rtotal = 0;
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1,7);
// int roll3 = dice.Next(1,7);
// int total = roll1 + roll2+ roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         rtotal = total + 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         rtotal =total+2;
//     }
// }

// if (rtotal==0)
// {
//      Console.WriteLine($"The total points: {total}");
//      }
//      else
//      {
//      Console.WriteLine($"The total points after a bonus: {rtotal}");
// }

//  if (rtotal>total)
//  {
//      if (rtotal>14)
//  {
//      if (total>14)
//  {
//      Console.WriteLine("You win! Even not adding a bonus");
//  }else{
//      Console.WriteLine("You win! After a bonus");
//  }
//  }
//      else
//      {
//           Console.WriteLine("Sorry, you lose.Even after a bonus");
//  }
//  }
//  else{
//     if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
// }    
    
//  }

//  if (rtotal>total || total>14)
//  {
//      Console.WriteLine("You win!");
//  }
//  else
//  {
//      Console.WriteLine("Sorry, you lose.Even after a bonus");
//  }


// if (total > 14)
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
// }






// string message = "HEllo Nibika ! How are you??- By Arun ";
// bool result = message.Contains("Nibika");
// Console.WriteLine(result);

// if(message.Contains("Arun"))
// {
//      Console.WriteLine("The message contains Arun");
// }
// else{
//      Console.WriteLine("The message does not contain Arun");
// }



// Random random = new();
// int daysUntilExpiration = random.Next(12);
// // int discountPercentage = 0;


// if (daysUntilExpiration<=5)
// {
//      Console.WriteLine(@$"Your subscription expires in {daysUntilExpiration} days.
// Renew now and save 10%!");
     
// }
// else if(daysUntilExpiration<=10)
// {
//      Console.WriteLine(@$"Your subscription expires in {daysUntilExpiration} days.
// Renew now!");
// }
// else if(daysUntilExpiration>=1)
// {
//      Console.WriteLine($@"Your subscription expires within a day!
// Renew now and save 20%!");
// }
// else if(daysUntilExpiration==0)
// {
//      Console.WriteLine("Your subscription has expired.");
// }
// else
// {
//      Console.WriteLine();
// }



// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");

//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }



// initialize variables - graded assignments 
// int currentAssignments = 5;

// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// // Student names
// string[] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};

// foreach (string name in studentNames)
// {
//     if (name == "Sophia")
//     {
//         int sophiaSum = 0;
//         decimal sophiaScore;

//         foreach (int score in sophiaScores)
//         {
//             // add the exam score to the sum
//             sophiaSum += score;
//         }

//         sophiaScore = (decimal)(sophiaSum) / currentAssignments;

//         Console.WriteLine("Student\t\tGrade\n");
//         Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
//     }
// }

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();



// initialize variables - graded assignments
// int examAssignments = 5;

// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// // Student names
// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// int[] studentScores = new int[10];

// string currentStudentLetterGrade = "";

// // Write the Report Header to the console
// Console.WriteLine("Student\t\tGrade\n");

// foreach (string name in studentNames)
// {
//     string currentStudent = name;

//     if (currentStudent == "Sophia")
//        studentScores = sophiaScores;

//     else if (currentStudent == "Andrew")
//         studentScores = andrewScores;

//     else if (currentStudent == "Emma")
//         studentScores = emmaScores;

//     else if (currentStudent == "Logan")
//         studentScores = loganScores;

//     // initialize/reset the sum of scored assignments
//     int sumAssignmentScores = 0;

//     // initialize/reset the calculated average of exam + extra credit scores
//     decimal currentStudentGrade = 0;

//     // initialize/reset a counter for the number of assignment 
//     int gradedAssignments = 0;

//     // loop through the scores array and complete calculations for currentStudent
//     foreach (int score in studentScores)
//     {
//         // increment the assignment counter
//         gradedAssignments += 1;

//         if (gradedAssignments <= examAssignments)
//             // add the exam score to the sum
//             sumAssignmentScores += score;

//         else
//             // add the extra credit points to the sum - bonus points equal to 10% of an exam score
//             sumAssignmentScores += score / 10;
//     }

//     currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

//     if (currentStudentGrade >= 97)
//         currentStudentLetterGrade = "A+";

//     else if (currentStudentGrade >= 93)
//         currentStudentLetterGrade = "A";

//     else if (currentStudentGrade >= 90)
//         currentStudentLetterGrade = "A-";

//     else if (currentStudentGrade >= 87)
//         currentStudentLetterGrade = "B+";

//     else if (currentStudentGrade >= 83)
//         currentStudentLetterGrade = "B";

//     else if (currentStudentGrade >= 80)
//         currentStudentLetterGrade = "B-";

//     else if (currentStudentGrade >= 77)
//         currentStudentLetterGrade = "C+";

//     else if (currentStudentGrade >= 73)
//         currentStudentLetterGrade = "C";

//     else if (currentStudentGrade >= 70)
//         currentStudentLetterGrade = "C-";

//     else if (currentStudentGrade >= 67)
//         currentStudentLetterGrade = "D+";

//     else if (currentStudentGrade >= 63)
//         currentStudentLetterGrade = "D";

//     else if (currentStudentGrade >= 60)
//         currentStudentLetterGrade = "D-";

//     else
//         currentStudentLetterGrade = "F";

//     //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
//     Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
// }

// // required for running in VS Code (keeps the Output windows open to view results)
// Console.WriteLine("\n\rPress the Enter key to continue");
// Console.ReadLine();


// string value1 = "a";
// string value2 = "A";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");


// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("dog"));


// int a = 7;
// int b = 6;
// Console.WriteLine(a != b); // output: True
// string s1 = "Hello";
// string s2 = "Hello";
// Console.WriteLine(s1 == s2); // output: False



// string myName = "Arun";
// if(myName == "Arun")
// {
//      Console.WriteLine("Hello Arun");
//      }
//      else
//      {
//      Console.WriteLine("Hello Stranger");
//      }

//      Console.WriteLine("Press the Enter key to continue");
//      Console.ReadLine();



// //yedi sales amount 1000 vanda badi xa vane 100 discount dinu natra 50 dinu
// int saleAmount  = 999;
// int discount = saleAmount > 1000 ? 100:50;
// Console.WriteLine($"Discount: {discount}");


// int saleAmount = 500;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


//Paila sikeko lai implement gareko
// Random dice = new();
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if(total>14 ? true : false)
// {
//      Console.WriteLine($"You win! {total} is greater than 14.");
// }
// else
// {
//      Console.WriteLine("Sorry, you lose.");
// }

// string head = "Head";
// string tail = "Tail";
// Random coin = new();
// string flip = coin.Next(0, 2) == 0 ? head : tail;
// Console.WriteLine(flip);

// Random coin = new();
// int flip = coin.Next(0,2);
// Console.WriteLine(flip ==0 ? "Head" : "Tail");



// Random coin = new();
// Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");



// string permission = "Admin|Manager";
// int level = 19;

// if (permission.Contains("Admin") && level > 55 ? true : false)
// {
//     Console.WriteLine("Welcome, Super Admin User.");
// }
// else if (permission.Contains("Manager") && level >= 20 ? true : false)
// {
//     Console.WriteLine("Contact an Admin for access.");
// }
// else if (permission.Contains("Admin") && level <= 55 ? true : false)
// {
//     Console.WriteLine("Welcome, Admin user.");
// }
// else if(permission.Contains("Manager") && level < 20 ? true : false)
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }
// else
// {
//      Console.WriteLine("");
// }




// string permission = "Admin|Manager";
// int level = 5;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }
 

// //yedi hamle value paila initialize garenau vane tyo if bahira ko Console.WriteLine() ma error auncha 
// int value = 0;
// bool arun = true;
// if(arun)
// {    
//      Console.WriteLine(value);
     
// }

// value = 200;
// Console.WriteLine(value);



// string name = "bob";
// if (name == "bob") Console.WriteLine("Found Bob");
// else if (name == "steve") Console.WriteLine("Found Steve");
// else Console.WriteLine("Found Chuck");


// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0; // Declared and initialized outside the loop
// bool found = false; // Declared outside the loop

// foreach (int number in numbers)
// {
//     total += number; // Accumulate sum

//     if (number == 42)
//     {
//         found = true; // Update found flag
//     }
// }

// if (found) 
// {
//     Console.WriteLine("Set contains 42");
// }

// Console.WriteLine($"Total: {total}");


// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title;

// switch (employeeLevel)
// {
//     case 100:
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");


// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//      case "01":
//          type = "Sweat shirt";
//          break;
//      case "02":
//          type = "T-Shirt";
//          break;
//      case "03":         
//          type = "Sweat pants";
//          break;
//      default:
//          type = "Other";
//          break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");


// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } else if (product[0] == "02")
// {
//     type = "T-Shirt";
// } else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }

// Console.WriteLine($"Product: {size} {color} {type}");



// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }



// string[] names = { "Rowena", "Ravinder", "John", "Michael", "Sara", "Arun" };
// for (int i = names.Length - 1; i >= 0; i--)

// {
//     Console.WriteLine(names[i]);
// }

// for (int j = 0; j < names.Length; j++)
// {
//     Console.WriteLine(names[j]);
// }

// string[] names = { "Rowena", "Ravinder", "John", "Michael", "Sara", "Arun" };
// for (int i = 0; i<names.Length;i++)
// {
//     if (names[i]=="John")
//     {
//         names[i] = "Nibika";
//     }
// }

// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }


// //yesle chai for loop sath sathai if else condition ni check garxa ra print garxa
// string[] words = {"Fizz", "Buzz", "FizzBuzz"};

// for(int i =1; i <= 100; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine($" {i} - {words[2]}");
//     }
//     else if (i % 5 == 0)
//     {
//         Console.WriteLine($"{i} - {words[1]}");
//     }
//     else if (i % 3 == 0)
//     {
//         Console.WriteLine($"{i} - {words[0]}");
//     }
//     else
//     {
//         Console.WriteLine(i);
//     }
// }

// Random random = new();
// int current = random.Next(1, 111);

// // do{
// //     current = random.Next(1,111);
// //     Console.WriteLine(current);
// // } while (current!=100);

// while(current >= 2)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 111);
    
// }
// Console.WriteLine($"Last Number : {current}");

// Random random = new();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

//Simple hero monoster game using while loop and random number from class Random.

// int hero;
// int monster;

// Random random = new();
// int heroHealth = 100;
// int monsterHealth = 100;

// while (heroHealth >= 0 && monsterHealth >= 0)
// {
//     hero = random.Next(0, 11);
    

//     monster = random.Next(0, 11);
    
    
//     heroHealth -= monster;

//     Console.WriteLine($"Hero was damaged by {monster} health and now has {heroHealth} health.");
//     // Console.WriteLine($"Monster rolls: {monster}");
    
//     // Console.WriteLine($"Hero Health: {heroHealth}");
    
//     monsterHealth -= hero;
//     Console.WriteLine($"Monster was damaged by {hero} health and now has {monsterHealth} health.");
//     // Console.WriteLine($"Hero rolls: {hero}");
//     // Console.WriteLine($"Monster Health: {monsterHealth}");
    

// }

// if (heroHealth >= 0 && monsterHealth <= 0)
// {
//     Console.WriteLine("Hero wins!");
// }
// else
// {
//     Console.WriteLine("Monster wins!");
// }
