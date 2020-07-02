using System;

namespace Polymor.PolyClasses
{
    class ThumbNailImage : AccountThumbnailBase
    {
        protected override void GetData()
        {
            GetThumbnail();
            Console.WriteLine("ThumbNailImage GetMetaData");
        }

    }
}