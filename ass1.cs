using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{

  public class Route
    {
        public class Router
        {
            public Double path { get; set; }

        }


    }

    public class Calculation
    {
        public Double BestRoute(List<Route.Router> root)
        {
            List<Double> AllValues = new List<double>();
            foreach (Route.Router router in root)
            {
                Double total = root.Sum(x => Convert.ToInt32(x));
                AllValues.Add(total);
            }
            Double Min = AllValues[0];
            for (int i = 0; i < AllValues.Count; i++)
            {
                if (AllValues[i] < Min)
                    Min = AllValues[i];
            }
            return Min;
        }

        private async Task<Double> BestCalc(List<Route.Router> root)
        {
            return await new Task<Double>(() =>
            {
                List<Double> Best = new List<Double>();
                foreach (Route.Router router in root)
                {
                    double total = 0;
                    total = root.Sum(x => Convert.ToInt32(x));
                    Best.Add(total);

                }
                Double Min = Best[0];
                for (var i = 0; i < Best.Count; i++)
                {
                    if (Best[i] < Min)
                        Min = Best[i];
                }
                Thread.Sleep(2000);
                return Min;
            });

        }
        public class ReadInputs
        {
            public Route CreateRoute()
            {
                return new Route();


            }
            public void AddRouter(Route.Router roter, List<Route.Router> root)
            {
                List<Route.Router> r = root;
                root.Add(roter);
            }


        }

        class RUN
        {
            static void Main(string[] arg)
            {
                List<Route.Router> roter = new List<Route.Router>();
                Route.Router roter1 = new Route.Router();
                Double p;
                int Numofrouters = 0;
                int nameof;
                int NumOfRoutes;


                Console.WriteLine("Enter The Number Of The Routes :  ");
                NumOfRoutes = Convert.ToInt32(Console.ReadLine());


                for (int j = 0; j < NumOfRoutes; j++)

                {

                    Console.WriteLine("Enter The Name Of The Route :  ");
                    nameof = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Enter The Number Of The Route :  " + nameof);
                    Numofrouters = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");

                    for (int i = 0; i < Numofrouters; i++)
                    {
                        p = Convert.ToDouble(Console.ReadLine());
                        roter1.path = p;
                        roter.Add(roter1);
                    }

                }




            }
        }


















    }
}