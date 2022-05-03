
GenericList<int> genericList = new GenericList<int>();
genericList.Add(1); 
genericList.Add(5); 
genericList.Add(10); 
genericList.Add(6); 
genericList.Add(3); 
genericList.Add(9);
Console.WriteLine(genericList.returnItem(3));
Console.WriteLine("--------------------------------------");
List<int> list = genericList.returnSorted();
foreach (var item in list)
{
    Console.WriteLine(item);
}



public class GenericList<T> where T : struct
{

    private List<T> listotT; 
    public GenericList()
    {
        listotT = new List<T>();
    }

    public void Add(T item)
    {
        listotT.Add(item);

    }
    public T returnItem (int itemIndex)
    {
        return listotT[itemIndex];
    }
    public List<T> returnSorted()
    {
        return listotT.OrderByDescending(x => x).ToList(); 
    }

}