using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BitArray64 : IEnumerable<int>
{
    public ulong Number { get; set; }

    public BitArray64(ulong number)
    {
        this.Number = number;
    }

    public int this[int index]
    {
        get
        {
            if (index < 0 || index > 63)
            {
                throw new IndexOutOfRangeException("Index range is from 0 to 63!");
            }

            return (int)((this.Number >> index) & 1);
        }
    }
      
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 64; i++)
		{
			 yield return this[i];
		}
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public override bool Equals(object obj)
    {
        BitArray64 element = obj as BitArray64;

        if ((object)element == null)
        {
            return false;
        }

        if (!Object.Equals(this.Number, element.Number))
        {
            return false;
        }
        
        return true;
    }

    public static bool operator ==(BitArray64 elementOne, BitArray64 elementTwo)
    {
        return BitArray64.Equals(elementOne, elementTwo);
    }

    public static bool operator !=(BitArray64 elementOne, BitArray64 elementTwo)
    {
        return !BitArray64.Equals(elementOne, elementTwo);
    }

    public override int GetHashCode()
    {
        int result = 37;
        result = result * 83 + this.Number.GetHashCode();
        return result;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder(64);
        Console.WriteLine("The bits of the number are now reversed:");
        for (int i = 63; i >= 0; i--)
        {
            result.Append(this[i]);
        }
        return result.ToString();
    }
}

