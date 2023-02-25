namespace CalculateAreaExercise
{
    internal class Program
    {

        const double PRICE_LABOUR_PER_HOUR = 86;
        const double MAX_FLOOR_INSTALL_PER_HOUR = 20;
        static void Main(string[] args)
        {

            Console.WriteLine("Please choose one shape by entering the corresponding number: " +
                " \n 1 - rectangle" +
                " \n 2 - circle" +
                " \n 3 - square");

            int userInput = Convert.ToInt16(Console.ReadLine());
            

            switch (userInput)
            {
                case 1:

                    Console.WriteLine("Please enter the lenght of the room in feet: ");
                    double lenght = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the width of the room in feet: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the price per foot of flooring per feet: ");
                    double priceOfFlooring = Convert.ToDouble(Console.ReadLine());

                    double rectangleArea = lenght * width;
                    double totalPriceForMaterials = rectangleArea * priceOfFlooring;
                    Console.WriteLine("Total price for materials is: " + totalPriceForMaterials + " $.");

                    double necessaryTimeToInstallRectangle = rectangleArea / MAX_FLOOR_INSTALL_PER_HOUR;
                    double totalPriceForLabourRectangle = PRICE_LABOUR_PER_HOUR * necessaryTimeToInstallRectangle;

                    Console.WriteLine("The cost for labour is " + totalPriceForLabourRectangle + " $ and the team will finish in " + necessaryTimeToInstallRectangle + " hours");
                    break;

                case 2:

                    Console.WriteLine("Please enter the radius of circle in feet: ");
                    double radiusCircle = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the price of flooring per foot: ");
                    double priceOfFlooringCircle = Convert.ToDouble(Console.ReadLine());

                    double circleArea = (radiusCircle * 2) * Math.PI;
                    double totalPriceForMaterialsCircle = circleArea * priceOfFlooringCircle;

                    Console.WriteLine("Total price for materials is: " + totalPriceForMaterialsCircle + "$");

                    double necessaryTimeToInstallCircle = circleArea / MAX_FLOOR_INSTALL_PER_HOUR;
                    double totalPriceForLabourCircle = PRICE_LABOUR_PER_HOUR * necessaryTimeToInstallCircle;

                    Console.WriteLine("The cost for labour is " + totalPriceForLabourCircle + "$ and the team will finish in " + necessaryTimeToInstallCircle);
                    break;

                case 3:

                    Console.WriteLine("Please enter the lenght of the room in feet: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the price of flooring per feet: ");
                    double priceOfFlooringSquare = Convert.ToDouble(Console.ReadLine());

                    double areaSquare = length * length;
                    double priceForMaterialsSquare = areaSquare * priceOfFlooringSquare;

                    Console.WriteLine("Total price for materials is: " + priceForMaterialsSquare + "$");

                    double necessaryTimeToInstallSquare = areaSquare / MAX_FLOOR_INSTALL_PER_HOUR;
                    double totalPriceForLabourSquare = PRICE_LABOUR_PER_HOUR * necessaryTimeToInstallSquare;

                    Console.WriteLine("The cost for labour is " + totalPriceForLabourSquare + "$ and the team will finish in " + necessaryTimeToInstallSquare);
                    break;
            }

            Console.ReadLine();

        }
    }
}