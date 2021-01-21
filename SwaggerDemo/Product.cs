using System;

namespace SwaggerDemo
{
    public class Product
    {
        public Guid Id { get; set; }
        public double Price { get; set; }
        public Status Status { get; set; }
        public SwaggerDemo.SomeLibrary.Status OtherStatus { get; set; }
    }

    public enum Status
    {
        Active,
        Inactive
    }
}