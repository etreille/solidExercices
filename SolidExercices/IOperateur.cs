namespace SolidExercices
{
    public interface IOperateur
    {
        bool CanCalculate(string operation);
        decimal Calculate(string operation);
    }
}