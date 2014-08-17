using System;
using System.Collections.Generic;

class Call
{
    private DateTime dateAndTime;
    private string dialedPhoneNumber = "";
    private double duration = 0;
    private List<Call> callHistory;

    public DateTime DateAndTime { get; set; }
    public string DialedPhoneNumber { get; set; }
    public double Duration { get; set; }
    public List<Call> CallHistory { get; set; }

    public Call(string dialedPhoneNumber, double duration)
    {
        this.DateAndTime = DateTime.Now;
        this.DialedPhoneNumber = dialedPhoneNumber;
        this.Duration = duration;
    }
}

