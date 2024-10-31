namespace Calculator;

public class Operator
{

    private String ErrorMessage = "Invalid operation.";

    public Operator () {
    }

    public double AddValues (double valueA, double valueB) {
        return valueA + valueB;
    }

    public double SubValues (double valueA, double valueB) {
        return valueA - valueB;
    }

    public double MulValues (double valueA, double valueB) {
        return valueA * valueB;
    }

    public double DivValues (double valueA, double valueB) {
        if (valueB == 0){
            Console.WriteLine($"{this.ErrorMessage}");
            return -1;
        } else {
            return valueA / valueB;
        }
    }

    public double ModValues (double valueA, double valueB) {
        if (valueB == 0){
            Console.WriteLine($"{this.ErrorMessage}");
            return -1;
        } else {
            return valueA % valueB;
        }
    }

}