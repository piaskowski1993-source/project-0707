
namespace Calculator;

class Calculator
{
    static public int add(int a,int b) {return a + b;}
    static public decimal add(decimal a,decimal b) {return a + b;}
    static public double add(double a, double b) {return a + b;}
    static public int addList(List<int> addition )
    { 
        int result = 0;
        for (int i = 0; i < addition.Count; i++)
        {
            result += addition[i]; 
        }    
            return result;
        
    }
    static public int sub(int a, int b) {return a - b;}
    static public decimal sub(decimal a, decimal b) {return a - b;}
    static public double sub(double a, double b) {return a - b;}
    static public int subList(List<int> subtraction )
    {
        int result = 0;
        for (int i = 0; i < subtraction.Count; i++)
        {
            result -= subtraction[i];
        }
        return result;
    }

    static public int mult(int a, int b) {return a * b;}
    static public decimal mult(decimal a, decimal b) {return a * b;}
    static public double mult(double a, double b) {return a * b;}
    static public int multList(List<int> multiplication)
    {
        int result = multiplication[0];
        for (int i = 1; i < multiplication.Count; i++)
        {
        result *= multiplication[i];
        }
        return result;
    }

    static public int div(int a, int b) {return a / b;}
    static public decimal div(decimal a, decimal b) {return a / b;}
    static public double div(double a, double b) {return a / b;}

    static public int divList(List<int> division)
    {
        int result = division[0];
        for (int i = 1; i < division.Count; i++)
        {
            result /= division[i];
        } 
            return result;
        

    }
}
