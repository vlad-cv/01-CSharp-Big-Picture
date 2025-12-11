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
}

