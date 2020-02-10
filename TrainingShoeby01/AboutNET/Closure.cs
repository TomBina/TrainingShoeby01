using System;

namespace TrainingShoeby01.IL
{
    public class Closure
    {
        public string Company = "Divide";

        public Action PrintName =>
            () => { Console.WriteLine(Company); };
    }
}
