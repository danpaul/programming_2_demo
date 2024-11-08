
namespace class_review
{

    // Example usage:
    //     MyMath.caclulateArea(5);
    //
    //     Note that since this class uses only static methods, it is not necessary to 
    //      create an instance of the class to use it.

    internal class MyMath
    {
        public static double PI = 3.14;
        public static double calculateArea(double radius)
        {
            return radius * radius * PI;
        }
    }

}
