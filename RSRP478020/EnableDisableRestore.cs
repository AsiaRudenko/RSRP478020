namespace RSRP478020
{
    public class EnableDisableRestore
    {
        public void Foo()
        {
#nullable enable
            DoSomething();
#nullable disable
            DoSomethingElse();
#nullable restore
            TakeABreak();
        }

        private void TakeABreak()
        {
        }

        private void DoSomethingElse()
        {
        }

        private void DoSomething()
        {
        }
    }
}