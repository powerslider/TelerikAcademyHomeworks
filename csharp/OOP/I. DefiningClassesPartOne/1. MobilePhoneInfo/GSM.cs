using System;
using System.Collections.Generic;

class GSM
{
    private string model, manufacturer, owner;
    private double? price;
    private Battery battery;
    private Display display;
    private List<Call> callHistory;
    private static GSM iPhone4S = new GSM("4S", "Apple", "Ivan", 1000,
            new Battery("H223", 30, 20, BatteryType.NiCd), new Display(6, 64000000));

    public GSM(string model, string manufacturer, string owner,
        double? price, Battery battery, Display display)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Owner = owner;
        this.Price = price;
        this.Battery = battery;
        this.Display = display;
        this.CallHistory = new List<Call>();
    }

    public GSM(string model, string manufacturer, string owner,
        double? price, Battery battery) 
        : this(model, manufacturer, owner, price, battery, new Display())
    {
    }

    public GSM(string model, string manufacturer, string owner,
        double? price)
        : this(model, manufacturer, owner, price, new Battery())
    {
    }

    public GSM(string model, string manufacturer, string owner)
        : this(model,  manufacturer, owner, null)
    {
    }

    public GSM(string model, string manufacturer)
        : this(model, manufacturer, null)
    {
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set { this.manufacturer = value; }
    }

    public string Owner
    {
        get { return this.owner; }
        set { this.owner = value; }
    }

    public double? Price
    {
        get { return this.price; }
        set
        {
            if (this.price < 0)
            {
                throw new ArgumentException("The price must be a positive number!!!");          
            }
            this.price = value;           
        }
    }

    public Battery Battery
    {
        get { return this.battery; }
        set { this.battery = value; }
    }

    public Display Display
    {
        get { return this.display; }
        set { this.display = value; }
    }

    public static GSM IPhone4S
    {
        get { return iPhone4S; }
        set { iPhone4S = value; }
    }

    public List<Call> CallHistory { get; set; }

    public void AddCall(Call call)
    {
        CallHistory.Add(call);
    }

    public void DeleteCall(Call call)
    {
        CallHistory.Remove(call);
        
    }

    public void ClearCallHistory()
    {
        CallHistory.Clear();
    }

    public double CalcPriceOfCalls(double pricePerMin)
    {
        double minutes = 0;
        foreach (var call in CallHistory)
        {
            minutes += call.Duration;
        }
        return pricePerMin * (minutes / 60);
    }
    
    public override string ToString()
    {
        string GSMInfo = String.Format("Model: {0}\nManufacturer: {1}\nOwner: {2}\n" + 
                                       "Price: {3} lv.\n\nBattery Characteristics:\n" + 
                                       "- Hours Idle: {4}\n- Hours Talk: {5}\n- Type of battery: {6}"+
                                       "\n\nDisplay Characteristics:\n- Size: {7} inches\n- Number of colors: {8}\n", 
                                       this.Model, this.Manufacturer, this.Owner, this.Price, this.Battery.HoursIdle,
                                       this.Battery.HoursTalk, this.Battery.Type, this.Display.Size, this.Display.NumberOfColors);

        return GSMInfo;
    }
}

