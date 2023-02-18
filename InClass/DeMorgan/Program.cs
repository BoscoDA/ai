namespace DeMorgan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var propositionList = new List<Proposition>();

            //Proposition prop = new Proposition(true, true);
            //propositionList.Add(prop);
            //Proposition prop2 = new Proposition(true, false);
            //propositionList.Add(prop2);

            //Proposition prop3 = new Proposition(false, true);
            //propositionList.Add(prop);
            //Proposition prop4 = new Proposition(false, false);
            //propositionList.Add(prop2);

            ////!(p&q) = !p | !q
            //foreach(var pr in propositionList)
            //{
            //    Console.WriteLine($"Evaluating p = {pr.p} and q = {pr.q}");
            //    bool a = !(pr.p && pr.q);
            //    bool b = !pr.p || !pr.q;

            //    bool c = a == b;

            //    Console.WriteLine($"Result = {c}, for evaluating p = {pr.p} and q = {pr.q}");
            //}

            //var propositionList = new List<Proposition>();

            //Proposition prop = new Proposition(true, true, true);
            //propositionList.Add(prop);
            //Proposition prop2 = new Proposition(true, false, false);
            //propositionList.Add(prop2);

            //Proposition prop3 = new Proposition(false, true, true);
            //propositionList.Add(prop);
            //Proposition prop4 = new Proposition(false, false, true);
            //propositionList.Add(prop2);

            ////((!p) | q
            //foreach (var pr in propositionList)
            //{
            //    Console.WriteLine($"Evaluating p = {pr.p} and q = {pr.q} and expected result = {pr.result}");
            //    bool a = !pr.p;
            //    bool b = pr.q;

            //    bool c = a || b;

            //    Console.WriteLine($"For p = {pr.p} and q = {pr.q}, result = {c}");
            //}

            var propositionList = new List<Proposition>();

            Proposition prop = new Proposition(true, true, true);
            propositionList.Add(prop);
            Proposition prop2 = new Proposition(true, false, false);
            propositionList.Add(prop2);

            Proposition prop3 = new Proposition(false, true, true);
            propositionList.Add(prop);
            Proposition prop4 = new Proposition(false, false, true);
            propositionList.Add(prop2);

            //((!p) | q
            foreach (var pr in propositionList)
            {
                Console.WriteLine($"Evaluating p = {pr.p} and q = {pr.q} and expected result = {pr.result}");
                
                if((pr.GetP() * pr.getQ()) > 0)
                {
                    Console.WriteLine($"p = {pr.p} and q = {pr.q} evaluated to {true}");
                }
                else
                {
                    Console.WriteLine($"p = {pr.p} and q = {pr.q} evaluated to {true}");
                }

                Console.WriteLine($"For p = {pr.p} and q = {pr.q}, result = {c}");
            }

            Console.ReadKey();
        }
    }
}