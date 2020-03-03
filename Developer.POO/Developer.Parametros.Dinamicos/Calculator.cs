namespace Developer.Parametros.Dinamicos
{
    public static class Calculator
    {

        public static double Sum(params double[] values)
        {
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];

            return sum;
        }
    }
}
