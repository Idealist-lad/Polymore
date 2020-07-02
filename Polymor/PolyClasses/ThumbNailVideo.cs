using System;

namespace Polymor.PolyClasses
{
    class ThumbNailVideo : AccountThumbnailBase
    {
        protected override void GetData()
        {
            GetThumbnail();
            Console.WriteLine("ThumbNailVideo GetMetaData \n" +
                              "************************************ \n\n\n" +
                              "this could be the account fort video games or movies");

        }

    }
}