using System;
using System.Text;

public class GenericList<T>
{
    private const int DefaultPlacesCount = 4;

    private T[] elementList;
    private int usedPlaces;

    public GenericList() : this(DefaultPlacesCount)
    {
    }
    
    public GenericList(int placesCount)
    {
        this.elementList = new T[placesCount];
        this.usedPlaces = 0;
    }

    public T this[int index]
    {
        get
        {
            if (index >= usedPlaces || index < 0)
            {
                throw new ArgumentException("Invalid cell index!");
            }
            return this.elementList[index];
        }
        set
        {
            if (index >= usedPlaces || index < 0)
            {
                throw new ArgumentException("Invalid cell index!");
            }
            this.elementList[index] = value;
        }
    }

    public int Count
    {
        get { return this.usedPlaces; }
        set { this.usedPlaces = value; }
    }

    public void Add(T newElement)
    {
        T[] newList = new T[usedPlaces * 2];
        if (this.usedPlaces >= this.elementList.Length)
        {
            for (int i = 0; i < elementList.Length; i++)
			{
			    newList[i] = elementList[i];
			}
            elementList = newList;
        }
        this.elementList[usedPlaces] = newElement;
        this.usedPlaces++;
    }

    public T Remove(int index)
    {
        if (index < 0 || index > this.usedPlaces)
        {
            throw new ArgumentOutOfRangeException("Invalid cell index!");
        }
        T removedElement = elementList[index];
        for (int i = index; i < usedPlaces - 1; i++)
		{
			this.elementList[i] = this.elementList[i + 1]; 
		}
        this.elementList[usedPlaces - 1] = default(T);
        this.usedPlaces--;

        return removedElement;
    }

    public T ValueOf(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException(String.Format(
            "Invalid index: {0}.", index));
        }
        T result = elementList[index];
        return result;
    }

    public int IndexOf(T valueOfElement)
    {
        for (int i = 0; i < elementList.Length; i++)
        {
            if (elementList[i].Equals(valueOfElement))
            {
                return i;
            }
        }
        return -1;
    }

    public void Insert(T element, int index)
    {
        if (index < 0 || index == null)
        {
            throw new ArgumentOutOfRangeException("Invalid cell index!");
        }
        this.usedPlaces++;
        
        T[] newList = elementList;
        if (Count == elementList.Length)
        {
            newList = new T[elementList.Length * 2];
            
        }
        Array.Copy(elementList, newList, index);
        Array.Copy(elementList, index, newList, index + 1, Count - index - 1);
        elementList[index] = element; 
        elementList = newList;
    }

    public void Clear()
    {
        for (int i = 0; i < elementList.Length; i++)
        {
            elementList[i] = default(T);
        }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < elementList.Length; i++)
        {
            result.Append(elementList[i]);
            result.Append(" ");
        }

        return result.ToString();
    }

    
}

