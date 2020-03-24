namespace Regions
{
    public class InactiveTargetFramework
    {
        public void Foo()
        {
#if NETCOREAPP3_1
            #region Rho
            DoSomething();
            #endregion
#endif
            DoSomethingElse();


            #region Tau

#if NETCOREAPP3_1
            DoSomething();

#endif

            #endregion

            DoSomethingElse();

            #region Upsilon

#if NETCOREAPP3_1
            DoSomething();

#endif
            DoSomethingElse();

            #endregion


#if NETCOREAPP3_1
            DoSomething();
#endif
            DoSomethingElse();


            #region Sigma

#if NETCOREAPP3_1
#endregion
            DoSomething();
#endif
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