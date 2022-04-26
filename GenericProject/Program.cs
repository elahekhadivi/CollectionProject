public class GenericList<T> where T : struct
{
	
    private List<T> listotT = new List<T>();
    public void Add(T item, List<T> listofT)
    {
        listofT.Add(item);

    }
    public T returnItem (int itemIndex)
    {
        return listotT[itemIndex];
    }
    public List<T> returnSorted(List<T> listofT)
    {
        return listotT.OrderByDescending(o => o);
    }

}