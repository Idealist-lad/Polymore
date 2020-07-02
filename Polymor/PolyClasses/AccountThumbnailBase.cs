using System;

namespace Polymor.PolyClasses
{
    abstract class AccountThumbnailBase
    {
        protected abstract void GetData();
       
        public  void GetThumbnail()
        {
            GetData();
            Console.WriteLine("AccountThumbnailBase is getting data the object caller\n\n" +
                              "*****************************************************\n\n" +
                              "Used class to access the child classes");
        }

    }
}