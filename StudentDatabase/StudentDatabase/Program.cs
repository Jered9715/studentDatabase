//Welcome user to the student database
using System.Reflection;

Console.WriteLine("Welcome to the Student Database!");

//Create student name array; all length of array based off this
string[] studentNameDatabase = new string[8] {"Max","Dani","Brandon","Courtney",
    "Thomas","Drake","Nina","Andrew"};
//Create hometown array; make sure index order matches previous
string[] studentHomeTown = new string[8] { "Ferndale", "Lansing",
    "Waterford", "Waterford", "Rochester", "Troy", "Lake Orion"
    , "Grand Rapids" };
//Create Favorite Food array; make sure index order matches previous
string[] studentFavoriteFood = new string[8] { "Breaded Pork", "Pizza", 
    "Cheese Burger", "Beef Stew", "Pierogi", "Steak", "Ramen", "Sushi" };

//Need to figure out how to not have the two array lengths hard coded

//Tell user they can search students
Console.WriteLine("With this tool you can look up a student and learn a fun fact" +
    " about them.");
//Tell user they will be given the option to learn more about the student selected
Console.Write("Before going forward would you like to see the list" +
    " of students?  (y/n): ");
//give user option to see a list of the students
string userInput = Console.ReadLine();
if (userInput.ToLower().Trim() == "y")
{
    PrintStudentNameList(studentNameDatabase);
}


//while loop starts
bool userEngagement = true;

while (userEngagement == true)
{

    //ask user if they would like to look up by number
    Console.Write("What Student would you like to learn about? " +
        "(Enter Number): ");

    //store index number to allow for reference to pull other info
    int studentNumber = int.Parse(Console.ReadLine());
    if (studentNumber >= 1 && studentNumber <= studentNameDatabase.Length)
    {
        //display you chose x student
        Console.WriteLine($"You chose {studentNameDatabase
            [StudentNumberToIndex(studentNumber)]}.");

        //ask user if they want to know hometown or favorite food
        Console.WriteLine("Would you like to learn about their Hometown or " +
            " Favorite Food?");
        Console.Write("Please type the info. you would like to learn: ");
        string infoChoice = Console.ReadLine();

        if (infoChoice.ToLower().Trim() == "hometown")
        {
            Console.WriteLine($"The town that they grew up in is" +
                $" {studentHomeTown[StudentNumberToIndex(studentNumber)]}.");
        }
        else if (infoChoice.ToLower().Trim() == "favorite food")
        {
            Console.WriteLine($"Their favorite food is " +
                $"{studentFavoriteFood[StudentNumberToIndex(studentNumber)]}");
        }
        else
        {
        Console.WriteLine("Im sorry that is not a valid choice.");
        }
        //diplay relevant request using student name as sentence

    }
    else
    {
        Console.WriteLine("Im sorry that is not a valid student number.");
    }
    //ask if the user would like to look up another student 
    Console.WriteLine("Would you like to learn about another student? " +
        "(y/n): ");
    userInput = Console.ReadLine();
    if (userInput.ToLower().Trim() == "y")
    {
        Console.WriteLine("Awesome!");
    }
    else if(userInput.ToLower().Trim() == "n")
    {
        Console.WriteLine("Goodbye!");
        userEngagement = false;
    }
    else
    {
    Console.WriteLine("I dont recognize that input. Please launch" +
        " the program again if you want to look up another student");
        userEngagement = false;
    }
}



//method for looping trough student name list
void PrintStudentNameList(string[] array)
{
    int studentNumber = 1;
    foreach (string item in array)
    {
        Console.WriteLine($"#{studentNumber} {item}");
        studentNumber++;
    }
}
//Method for student Number(index number - 1)
int StudentNumberToIndex(int studentNumber)
{
    return studentNumber - 1;
}
//method for array length

int ArrayLength(string[] array)
{
    int arrayLength = studentNameDatabase.Length;
    return arrayLength;
}