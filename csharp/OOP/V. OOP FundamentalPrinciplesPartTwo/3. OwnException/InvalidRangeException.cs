using System;


class InvalidRangeException<T> : ApplicationException
{
    public T Min { get; set; }
    public T Max { get; set; }
    public T OutOfRange{ get; set; }

    public InvalidRangeException()
    {
    }

    public InvalidRangeException(string message, Exception innerException = null)
        : this(message, default(T), innerException)
    {
    }

    public InvalidRangeException(string message, T outOfRange, Exception innerException = null)
        : this(message, outOfRange, default(T), default(T), innerException)
    {
    }

    public InvalidRangeException(string message, T outOfRange, T min, T max, Exception innerException = null)
        : base(message, innerException)
    {
        this.OutOfRange = outOfRange;
        this.Min = min;
        this.Max = max;
    }
}


