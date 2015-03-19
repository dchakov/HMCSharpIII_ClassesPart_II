using System;

namespace Problem11
{
    [Version("2.11")]

    class MainMethod
    {
        static void Main()
        {
            Type type = typeof(MainMethod);
            object[] attribute = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attribute)
            {
                Console.WriteLine("Version = {0}",item.Version);
            }
        }
    }
}
