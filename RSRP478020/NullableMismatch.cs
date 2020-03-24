namespace RSRP478020
{
    // Start 1
#nullable enable
    internal class NullableMismatch<T> where T : class, new()
    {
        public T? TMethod(string s, string? s1)
        {
            return new T();
        }

        public T TMethod2(string s, string s1)
        {
            return new T();
        }

        // Finish 1
        #nullable disable
    }

    public class MismatchAroundMethod
    {
// Start 2
#nullable enable
        public void One()
        {
            //Finish 2
#nullable disable
        }

        public void Two()
        {
            // Start 3
#nullable enable
        }
        // Finish 3
#nullable disable

        // Start 4
#nullable enable
        public void Three()
        {
        }
        #nullable disable
        // Finish 4

        public void Four()
        {
            // Start 5 and Finish 5 on the next line
#nullable enable
#nullable disable
        }
    }

    public class MismatchAroundLocalFunctions
    {
        public void Foo()
        {
            // Start 6
#nullable enable
            void One()
            {
                // Finish 6
#nullable disable
            }

            void Two()
            {
                // Start 7
#nullable enable
            }
            // Finish 7
#nullable disable

            // Start 8
#nullable enable
            void Three()
            {
            }
            // Finish 8
#nullable disable

            void Four()
            {
                // Start 9 and Finish 9 on the next line
#nullable enable
#nullable disable
            }
        }
    }
}

namespace MismatchAroundNamespaces
{
    // Start 10
#nullable enable
    namespace One
    {
        // Finish 10
#nullable disable
    }

    namespace Two
    {
        // Start 11
#nullable enable
    }
    // Finish 11
#nullable disable

    // Start 12
#nullable enable
    namespace Three
    {
    }
    // Finish 12
#nullable disable

    namespace Four
    {
        // Start 13 and Finish 13 on the next line
#nullable enable
#nullable disable
    }
}