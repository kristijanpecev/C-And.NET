// See https://aka.ms/new-console-template for more information
//#error version

//Console.WriteLine("Hello, World!");


/*Random i = new Random();
int a = i.Next(0, 100);
Random e = new Random();
int b = e.Next(0, 100);

int result = a + b;

if (result < 100) {
    Console.WriteLine("The result is " + result + " , Under 100");
}
else {
    Console.WriteLine("The result is " + result + " , Above 100");
}
*/

using System.Reflection;
Assembly? assembly = Assembly.GetEntryAssembly();
if (assembly == null) return;

foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    //Load the assembly so we can read its details
    Assembly a = Assembly.Load(name);
    //Declare a variable to count the number of methods
    int methodCount = 0;
    //Loop through all the types in the assembly
    foreach (TypeInfo t in a.DefinedTypes)
    {
        //Add up the counts of methods
        methodCount += t.GetMethods().Count();
    }
    //Output the count of types and their methods
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount, arg2: name.Name);       
}

char letter = 'A';
char digit = '1';
char symbol = '$';
char userChoice = Console.ReadKey().KeyChar;

Console.WriteLine($"{nameof(letter)} : {letter} \r\n " +
    $"{nameof(digit)} : {digit} \r\n " +
    $"{nameof(symbol)} : {symbol} \r\n " +
    $"{nameof(userChoice)} : {userChoice} \r\n ");

//For text, multiple letters, such as Bob, are stored as a string type and 
string firstName = "Bob";
string lastName = "Smith";
string phoneNumber = "(215) 555-4256";

Console.WriteLine($"{nameof(firstName)} : {firstName} \r\n" +
    $"{nameof(lastName)} : {lastName} \r\n" +
    $"{nameof(phoneNumber)} : {phoneNumber} \r\n" );

string fullNameWithTabSeparator = "Bob\tSmith";

Console.WriteLine(fullNameWithTabSeparator);

string filePath = "C:\\television\\sony\\bravia.txt";
string filePath2 = @"C:\television\sony\bravia.txt";

Console.WriteLine($"{filePath} \r\n {filePath2}");