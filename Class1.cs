using System;

namespace ClassLibrary1
{
    public class Class1
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void MethodA()
        {
            try
            {
                MethodB();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void MethodB()
        {
            throw new DivideByZeroException();
        }
    }
}
