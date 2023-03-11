using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatrixCRUDTech.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName ="nvarchar(250)")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public string FullName { get; set; }

        [Column(TypeName ="varchar(50)")]
        [DisplayName("Matrícula")]
        public string EmpCode  { get; set; }

        [Column(TypeName ="varchar(100)")]
        [DisplayName("Cargo")]
        public string Position { get; set; }

        [Column(TypeName ="varchar(100)")]
        [DisplayName("Localização")]
        public string OfficeLocation   { get; set; }

    }
}
