using System;// Means that we can use classes from the System namespace.
using System.Linq;
namespace HelloWorld{ // namespace is used to organize your code, and it is a container for classes and other namespaces.
    internal class FormalHelloWorld{ // Every line of code that runs in C# must be inside a class. 
        private static void Main(string[] args){
            /* This is a 
            multi-line comment */
            int myNum = 5;
            long myLongNum = 15000000000L; // Note that you should end the value with an "L".
            float myFloatNum = 5.75F; // Note that you should end with the letter "F".
            const double myDoubleNum = 5.99D; // Note that you should end the value with a "D".
            char myLetter = 'D'; // Characters must be surrounded by single quotes ''.
            bool myBool = true;
            string myText = "Hello";

            /*  Implicit Casting (automatically) - converting a smaller type to a larger type size
                char -> int -> long -> float -> double 
                
                Explicit Casting (manually) - converting a larger type to a smaller size type
                    double -> float -> long -> int -> char
                */
            myNum = (int) myDoubleNum;

            // Type conversion methods

            myText = Convert.ToString(myNum);
            Console.WriteLine(myText+" The string length is "+myText.Length);

            // Math namespace

            Console.WriteLine(Math.Max((float)myNum,myFloatNum));

            // String interpolation
            string outText=$"The two numbers are {myNum} and {myDoubleNum}";
            Console.WriteLine(outText);

            //Range operator
            string name = "John Doe";

            string lastName = name[4..];

            // Print the result
            Console.WriteLine(lastName);

            // Switch
            switch(myNum) 
                {
                case 1:
                    // code block
                    break; // Note we need to add the break statement and the end of a case.
                case 2:
                    // code block
                    break;
                default:
                    // code block
                    break;
                }

            // foreach loop
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string i in cars) 
            {
            Console.WriteLine(i);
            }

            // Arrays
            int[] myArray = {10, 20, 30, 40};
            //Array's max(using System.Linq namespace)
            Console.WriteLine(myArray.Max());

            // you should note that if you declare an array and initialize it later, you have to use the new keyword:

            // Declare an array
            string[] diff_cars;

            // Add values, using new
            diff_cars = new string[] {"Volvo", "BMW", "Ford"};

            // Add values without using new (this will cause an error)
            // diff_cars = {"Volvo", "BMW", "Ford"};

            // Sorting
            Array.Sort(cars); // Inplace sorting.

            foreach (string c in cars){
                Console.WriteLine(c);
            }

            // Two-D array
            int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
            Console.WriteLine(numbers[0,2]);

            foreach(int n in numbers){ // Single element iterator.
                Console.WriteLine(n);
            }

            // Double forloop
            for (int i = 0; i < numbers.GetLength(0); i++) 
                { 
                    for (int j = 0; j < numbers.GetLength(1); j++) 
                    { 
                        Console.WriteLine($"The number ({i},{j}) is {numbers[i, j]}"); 
                    } 
            }  

            // Dictionary
            // Creating a HashMap with keys of type string and values of type int
            Dictionary<string, int> ageMap = new()
            {
                { "Alice", 25 },
                { "Bob", 30 }
            };

            int aliceAge = ageMap["Alice"]; // Retrieves the value associated with the key "Alice"

            if (ageMap.ContainsKey("Bob"))
            {
                // Perform operations when "Bob" exists in the HashMap
                Console.WriteLine("Bob exists!");
            }
            ageMap.Remove("Alice"); // Removes the entry with the key "Alice"

            // Key-value pair iteration
            foreach (var pair in ageMap)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair. Value}");
            }

            // HashSet
            HashSet<string> myhash1 = [];
            
            // Add the elements in HashSet
            // Using Add method
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");
    
            // Creating another HashSet
            // Using HashSet class
            HashSet<string> myhash2 = new HashSet<string>();
    
            // Add the elements in HashSet
            // Using Add method
            myhash2.Add("PHP");
            myhash2.Add("C++");
            myhash2.Add("Perl");
            myhash2.Add("Java");
    
            // Using IntersectWith method
            myhash1.IntersectWith(myhash2);
            foreach(var ele in myhash1)
            {
                Console.WriteLine(ele);
            }

            // C# List
            List<int> listNumbers = [1, 2, 3, 4, 5];
            int indexToRemove = 2; // remove the third element (index 2)

            listNumbers.RemoveAt(indexToRemove); // remove the element at index 2
            listNumbers.Insert(indexToRemove,999); // Insert a new element at index 2

            // print the updated list
            foreach (int number in listNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            // ^ and .. 
            foreach (var n in listNumbers[1..3])
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            
            foreach (var n in listNumbers[1..^1])
            {
                Console.WriteLine(n);
            }


            Console.WriteLine();
            
            foreach (var n in listNumbers[^3..])
            {
                Console.WriteLine(n);
            }

            listNumbers.Reverse();
            Console.WriteLine();
            
            foreach (var n in listNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}