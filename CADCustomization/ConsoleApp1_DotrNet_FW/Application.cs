using System;

namespace Autodesk
{

#if DEBUG
    namespace AutoCAD
    {
        class Application
        {
            static void Main()
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
#else
    namespace Inventor
    {
        class Application
        {
            static void Main()
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
#endif
}



