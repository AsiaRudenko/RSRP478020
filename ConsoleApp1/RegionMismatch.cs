namespace RSRP478020
{
    #region Beta

    internal class RegionMismatch<T> where T : class, new()
    {
        public T TMethod2(string s, string s1)
        {
            return new T();
        }

        public T TMethod(string s, string s1)
        {
            return new T();
        }

        // TODO shouldn't be removed on cleanup

        #endregion
    }

    public class MismatchAroundMethod
    {
        #region Gamma

        public void One()
        {

            #endregion
        }

        public void Two()
        {
            #region Delta

        }

        #endregion

        #region Epsilon

        public void Three()
        {
        }

        #endregion

        public void Four()
        {
            #region Zeta

            #endregion
        }
    }

    public class MismatchAroundLocalFunctions
    {
        public void Foo()
        {
            #region Eta

            void One()
            {

                #endregion
            }

            void Two()
            {
                #region Theta

            }

            #endregion

            #region Iota

            void Three()
            {
            }

            #endregion

            void Four()
            {
                #region Kappa

                #endregion
            }
        }
    }
}

namespace MismatchAroundNamespaces
{
    #region Lambda

    namespace One
    {

        #endregion }

        namespace Two
        {
            #region Mu

        }

        #endregion

        #region Nu

        namespace Three
        {
        }

        #endregion

        namespace Four
        {
            #region Xi

            #endregion
        }
    }
}