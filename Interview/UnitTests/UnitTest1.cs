
using System.Data;
using TechnicalInterview;

namespace UnitTests;

[TestClass]
public class UnitTest1
{
    // 1. Given the user input is empty when calculating the sum then it should return zero.
    [TestMethod]
    public void calculating_sum_with_empty_input()
    {
        var calculator = new Calculator();
        var sum = calculator.Sum();
        Assert.AreEqual( sum, 0 );
    }


    // 2. Given the user input is one number when calculating the sum then it should return the same number. (example "3" should equal 3)
    [TestMethod]
    public void calculating_string_to_int() {
        var calculator2 = new Calculator();
        var result = calculator2.Sum("3");

        Assert.AreEqual( 3, result );
    }
    
    // 3. Given the user input is two numbers when calculating the sum then it should return the sum of those numbers. 
    //(example "1,2" should equal 3)
    [TestMethod]
    public void calculating_sum_with_two_numbers(){
        var calculator = new Calculator();
        var result = calculator.Sum("1,3");
        Assert.AreEqual(result, 4);
    }


    // 4. Given the user input is an unknown amount of numbers when calculating the sum then it should return the sum of all the numbers. 
    //(example "1,2,3" should equal 6)
    [TestMethod]
    public void calculating_sum_with_n_numbers() {
        var calculator = new Calculator();
        var result = calculator.Sum("2,5,6");
        Assert.AreEqual( 13, result );
    }

    // 5. Given the user input is multiple numbers with new line and comma delimiters when calculating the sum then it should return the sum of all the numbers. 
    //(example "1\n2,3" should equal 6)
    [TestMethod]
    public void calculating_sum_with_new_line_separator(){
        var calculator = new Calculator();
        var result = calculator.Sum("1\n2,3");
        Assert.AreEqual(result,6);
    }

    

// 6. Given the user input is multiple numbers with a custom single-character delimiter when calculating the sum then it should return the sum of all the numbers. (example “//;\n1;2” should return 3)
// 7. Given the user input contains one negative number when calculating the sum then it should throw an exception "negatives not allowed: x" (where x is the negative number).
// 8. Given the user input contains multiple negative numbers mixed with positive numbers when calculating the sum then it should throw an exception "negatives not allowed: x, y, z" (where x, y, z are only the negative numbers).
// 9. Given the user input contains numbers larger than 1000 when calculating the sum it should only sum the numbers less than 1001. (example 2 + 1001 = 2)
// 10. Given the user input is multiple numbers with a custom multi-character delimiter when calculating the sum then it should return the sum of all the numbers. (example: “//[***]\n1**_2_**3” should return 6)
// 11. Given the user input is multiple numbers with multiple custom delimiters when calculating the sum then it should return the sum of all the numbers. (example “//[\*][%]\n1\*2%3” should return 6)

}