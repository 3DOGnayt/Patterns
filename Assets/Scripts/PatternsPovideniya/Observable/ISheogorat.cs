namespace Assets.Scripts.PatternsPovideniya.Observable
{
    interface ISheogorat
    {
        void AddProsiashy(IProsiashy o);
        void RemoveProsiashy(IProsiashy o);
        void Notify();
    }
}