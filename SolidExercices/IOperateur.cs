namespace SolidExercices
{
    internal interface IOperateur
    {
        bool CanCalculate(string operation);
        decimal Calculate(string operation);
    }
}