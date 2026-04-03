using System.Collections.Generic;

interface IReadOnlyStorage<out T>
{
    IReadOnlyList<T> GetAllItems();
}
