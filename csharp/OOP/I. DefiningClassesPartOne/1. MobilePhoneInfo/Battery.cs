using System;

public enum BatteryType
{
    LiIon,
    NiMH,
    NiCd,
    NiZn 
}

public class Battery
{
    private string model;
    private double? hoursIdle, hoursTalk;
    private BatteryType? type;

    public Battery(string model, double? hoursIdle, double? hoursTalk, BatteryType? type)
    {
        this.Model = model;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
        this.Type = type;
    }

    public Battery(string model, double? hoursIdle, double? hoursTalk)
        : this(model, hoursIdle, hoursTalk, null)
    {
    }

    public Battery(string model, double? hoursIdle) 
        : this(model, hoursIdle, null)
    {
    }

    public Battery(string model)
        : this(model, null)
    {
    }

    public Battery() 
        : this(null)
    {
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public double? HoursIdle
    {
        get { return this.hoursIdle; }
        set 
        { 
            if (value < 0)
            {
                throw new ArgumentException("Hours cannot be less than zero!!!");
            }
            this.hoursIdle = value; 
        }
    }

    public double? HoursTalk
    {
        get { return this.hoursTalk; }
        set 
        { 
            if (value < 0)
            {
                throw new ArgumentException("Hours cannot be less than zero!!!");
            }
            this.hoursTalk = value; 
        }
    }

    public BatteryType? Type
    {
        get { return this.type; }
        set { this.type = value; }
    }
}

