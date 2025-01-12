using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evo.Models
{
    [Table("api_doc")]

    public class Request
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("category")]
        public string Category { get; set; }

        [Column("method")]
        public string Method { get; set; }


        [Column("description")]
        public string Description { get; set; }

        [Column("url")]
        public string Url { get; set; }

        [Column("json")]
        public string json { get; set; }

        [Column("p_response")]
        public String p_response {  get; set; }

        [Column("n_response")]
        public String n_response { get; set; }

        [Column("p_response_code")]
        public String p_response_code { get; set; }

        [Column("n_response_code")]
        public String n_response_code { get; set; }

    }
}
