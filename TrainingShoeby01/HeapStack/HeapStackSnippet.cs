namespace TrainingShoeby01.HeapStack
{
    public class HeapStackSnippet
    {
        public static Result Multiply(float x, float y)
        {
            var result = new Result(x + y);

            return result;
        }        
    }

    public class Result
    {
        public float Sum { get; }

        public Result(float sum)
        {
            Sum = sum;
        }
    }
}