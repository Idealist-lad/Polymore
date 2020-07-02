using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymor.PolyClasses;

namespace Polymor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your choice"); // Take input from the user
            var choice = Console.ReadLine();

            AccountThumbnailBase BaseCaller = CreateThumbnailer(choice); // Create an object

            BaseCaller.GetThumbnail(); // Call the method of the child class via base-parent class 


        }

        private static AccountThumbnailBase CreateThumbnailer(string choice)
        {
            switch (choice) // Choice to call video method or image method / A new instance will be called basedon the choice made by the user
            {
                case "I":
                case "i":
                    return new ThumbNailImage();
                    
                case "v":
                case "V":
                        return new ThumbNailVideo();
                    
                default:
                    throw new Exception("the choice you made is invalid");
            }
            
        }
    }
}
