namespace Assets.Scripts.PatternsPovideniya.Iterator
{
    interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}
