using System;
using System.ComponentModel.DataAnnotations;
public class OrderStatus
{
    //[Table("OrderStatus")]
    public OrderStatus()
    { }

                public int Id { get; set; }
    [Required]
    public int StatusId { get; set; }
    [Required]
	[MaxLength(20)]
	public string? statusname { get; set; }	

}
