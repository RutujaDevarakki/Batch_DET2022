using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("Book")]
public class Book
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

    public int BookID { get; set; }

    [Required]
    public string BookName { get; set; }

    [Required]
    public string author { get; set; }

    public int price { get; set; }


}
