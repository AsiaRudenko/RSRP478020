namespace Regions
{
    public class InactiveTargetFramework
    {
        public void Foo()
        {
#if NETCOREAPP3_1
#nullable enable
            DoSomething();
#endif
            DoSomethingElse();

#if NETCOREAPP3_1
#nullable restore
            DoSomething();
#endif
            DoSomethingElse();

#if NETCOREAPP3_1
#nullable enable
            DoSomething();
#nullable disable
#endif
            DoSomethingElse();

#if NETCOREAPP3_1
#nullable enable
            DoSomething();
#endif
#nullable disable
            DoSomethingElse();

#nullable enable
#if NETCOREAPP3_1
#nullable disable
            DoSomething();
#endif
            DoSomethingElse();

#nullable enable
#if NETCOREAPP3_1
            DoSomething();
#endif
#nullable disable
            DoSomethingElse();
        }

        private void DoSomethingElse()
        {
        }

        private void DoSomething()
        {
        }
    }
}