using System;

namespace VariablesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // A variable is bucket in the computer's
            // memory that can hold a value of a specific
            // size (data type).  Once you fill the bucket
            // with a value, you can access the value
            // in the bucket by simply using the name
            // you created.

            // You declare a variable like this:
            string myVariable;

            // string is the data type.
            // myVariable is an identifier / name I just
            // came up with.  I can use any word that is
            // not already used by C# (reserved keyword).

            // You set the value of the variable using 
            // an assignment operator:
            myVariable = "Bob";

            // Here I assigned the literal string: Bob
            // to myVariable.  The double-quotes are
            // important -- I literally want that string
            // of characters stored in the variable.


            // Alternatively, I can both declare AND INITIALIZE
            // a variable in one step (you'll see this a lot):
            // string myVariable = "Bob";

            // I can retrieve the value by using the
            // variable name.
            Console.WriteLine(myVariable);

            // And I can change / overwrite the value by 
            // re-assigning it:
            // myVariable = "Conrad";
            // Console.WriteLine(myVariable);

            // Variables only live inside of the code
            // block in which they're defined.  The
            // technical term for that is "scope".
            // That's not a problem just yet, but later 
            // when we start divvying our code into multiple
            // methods, we'll need to keep that in mind.

        }
    }
}
