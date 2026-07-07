
namespace Calculator;

class Calculator
{
    static public int add(int a,int b) {return a + b;}
    static public decimal add(decimal a,decimal b) {return a + b;}
    static public double add(double a, double b) {return a + b;}
    static public int addList(List<int> addition )
    { 
        int result = 0;
        for (int i = 0; i > addition.Count; i++)
        {
            result += addition[i]; 
        }    
            return result;
        
    }

}
