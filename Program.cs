namespace CalculateAreaExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please choose one shape: " +
                " \n - rectangle" +
                " \n - circle" +
                " \n - square");

            string userShape = Console.ReadLine();
            const double priceLabourPerHour = 86;
            const double maxFloorInstallPerHour = 20;

            switch (userShape)
            {
                case "rectangle":
                    
                    Console.WriteLine("Please enter the lenght of the room in feet: ");
                    double lenght = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the width of the room in feet: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the price per foot of flooring per feet: ");
                    double priceOfFlooring = Convert.ToDouble(Console.ReadLine());

                    double rectangleArea = lenght * width;
                    double totalPriceForMaterials = rectangleArea * priceOfFlooring;
                    Console.WriteLine("Total price for materials is: " + totalPriceForMaterials + " $.");

                    double necessaryTimeToInstallRectangle = rectangleArea / maxFloorInstallPerHour;
                    double totalPriceForLabourRectangle = priceLabourPerHour * necessaryTimeToInstallRectangle;

                    Console.WriteLine("The cost for labour is " + totalPriceForLabourRectangle + " $ and the team will finish in " + necessaryTimeToInstallRectangle + " hours");
                    break;

                case "circle":

                    Console.WriteLine("Please enter the radius of circle in feet: ");
                    double radiusCircle = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the price of flooring per foot: ");
                    double priceOfFlooringCircle = Convert.ToDouble(Console.ReadLine());

                    double circleArea = (radiusCircle * 2) * Math.PI;
                    double totalPriceForMaterialsCircle = circleArea * priceOfFlooringCircle;

                    Console.WriteLine("Total price for materials is: " + totalPriceForMaterialsCircle + "$");

                    double necessaryTimeToInstallCircle = circleArea / maxFloorInstallPerHour;
                    double totalPriceForLabourCircle = priceLabourPerHour * necessaryTimeToInstallCircle;

                    Console.WriteLine("The cost for labour is " + totalPriceForLabourCircle + "$ and the team will finish in " + necessaryTimeToInstallCircle);
                    break;

                case "square":

                    Console.WriteLine("Please enter the lenght of the room in feet: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the price of flooring per feet: ");
                    double priceOfFlooringSquare = Convert.ToDouble(Console.ReadLine());

                    double areaSquare = length * length;
                    double priceForMaterialsSquare = areaSquare * priceOfFlooringSquare;

                    Console.WriteLine("Total price for materials is: " + priceForMaterialsSquare + "$");

                    double necessaryTimeToInstallSquare = areaSquare / maxFloorInstallPerHour;
                    double totalPriceForLabourSquare = priceLabourPerHour * necessaryTimeToInstallSquare;

                    Console.WriteLine("The cost for labour is " + totalPriceForLabourSquare + "$ and the team will finish in " + necessaryTimeToInstallSquare);
                    break;      
            }
            
            Console.ReadLine();
            
        }
    }
}