using System;

namespace ClassBoxData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());


            try
            {
                var box = new Box(length, width, height);
                box.GetSurfaceArea();
                box.GetLateralSurfaceArea();
                box.GetVolume();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
