namespace FizzBuzz;
/*
<summary>
    Simple TDD FizzBuzz practice
    Target= less than 15 minutes
</summary>
*/
public class FizzBuzzExercise
{
    /*
    <summary>
        FizzBuzz is a method that checks the divisibility of an integer.
    </summary>
    <param name="i">the integer to check</param>
    <returns>
        "Fizz" if the argument is divisible by 3,
        "Buzz" if the argument is divisible by 5,
        "FizzBuzz" if the argument is divisible by 8,
        an empty string else.
    </returns>
    */
    public string FizzBuzz(int i)
    {
        if (i % 3 == 0 && i % 5 == 0 && i % 8 == 0)
            return "FizzBuzzFinish";
        else if (i % 3 == 0 && i % 5 == 0)
            return "FizzBuzz";
        else if (i % 3 == 0)
            return "Fizz";
        else if (i % 5 == 0)
            return "Buzz";
        else if (i % 8 == 0)
            return "finish";
        else return "";
    }
}