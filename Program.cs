namespace CalculateAreaExercise
{
    internal class Program
    {

        const double PRICE_LABOUR = 86;
        const double FLOOR_INSTALL_PER_HOUR = 20;
        static void Main(string[] args)
        {

            Console.WriteLine("Please choose one shape by entering the corresponding number: " +
                " \n 1 - rectangle" +
                " \n 2 - circle" +
                " \n 3 - square");
            int shapeChosen = Convert.ToInt16(Console.ReadLine());

            
            

            double area = 0;
            

            switch (shapeChosen)
            {
                case 1:

                    Console.WriteLine("Please enter the lenght of the room in feet: ");
                    double lenght = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter the width of the room in feet: ");
                    double width = Convert.ToDouble(Console.ReadLine());

                    area = lenght * width;

                                       
                    break;

                case 2:

                    Console.WriteLine("Please enter the radius of circle in feet: ");
                    double radiusCircle = Convert.ToDouble(Console.ReadLine());

                    area = (radiusCircle * 2) * Math.PI;
                                    
                    break;

                case 3:

                    Console.WriteLine("Please enter the lenght of the room in feet: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    
                    area = length * length;
                   
                    break;
                 
            }
            Console.WriteLine("Please enter the price of flooring/feet²: ");
            double priceFlooring = Convert.ToDouble(Console.ReadLine());

            double priceMaterials = area * priceFlooring;
            Console.WriteLine("Total price to cover the flooring of the room is $" + priceMaterials);

            double labourHours = area / FLOOR_INSTALL_PER_HOUR;
            double labourCost = labourHours * PRICE_LABOUR;
            double totalCost = priceMaterials + labourCost;
            Console.WriteLine("The team can install the flooring in " + labourHours + " hours. " +
                "\nThe total labour cost for this project would be $" + labourCost  +
                "\nThe total cost for the hole project including materials and labour costs would be $" + totalCost);


            Console.ReadLine();

        }     
    }
}