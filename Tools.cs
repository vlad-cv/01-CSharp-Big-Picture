namespace _01_Csharp_Big_Picture;

internal class Tools
{
    public static void WorkingWithTypes()
    {
        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var typeInfo = numbers.GetType();


        do
        {
            Console.WriteLine($"Type: {typeInfo.FullName}");
            typeInfo = typeInfo.BaseType;
        }
        while (typeInfo != null);
    }

    public static void WorkingWithFunctionalFeatures()
    {
        // Using LINQ's Aggregate method to sum numbers in an array
        var number = new int[] { 1, 2, 3, 4 };
        Console.WriteLine(number.Aggregate(0, (total, num) => total + num));
    }
}

