using System;

public class Student : Human
{
    private double grade;
    
    public double Grade 
    { 
        get 
        {
            //if (this.grade < 2.0 || this.grade > 6.0)
            //{
            //    throw new ArgumentException("Incorrect! The grade range is from 2 to 6!!! ");
            //}     
            return this.grade; }
        set 
        {
            //if (this.grade < 2.0 || this.grade > 6.0)
            //{
            //    throw new ArgumentException("Incorrect! The grade range is from 2 to 6!!! ");
            //}
            this.grade = value;
        }
    }
}

