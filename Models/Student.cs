using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace lab_20_9.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        [Required(ErrorMessage ="Họ và tên phải được nhập")]
        [DisplayName("Họ và tên")]
        [StringLength(100,MinimumLength =4,ErrorMessage ="Họ tên tối thiểu 4 kí tự và tối đa 100 kí tự") ]
        public string? Name { get; set; } //Họ tên

        [Required(ErrorMessage ="Email bắt buộc được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail\.com$",ErrorMessage ="Email chưa đúng định dạng")]
        public string? Email { get; set; } //Email

        [StringLength(100,MinimumLength =8,ErrorMessage ="Mật khẩu tối đa 100 kí tự và tối thiểu 8 kí tự")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).+$", ErrorMessage = "Mật khẩu phải có ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt")]
        [Required(ErrorMessage ="Mật khẩu phải được nhập")]
        public string? Password { get; set; }//Mật khẩu

        [DisplayName("Ngành học")]
        [Required(ErrorMessage = "Ngành học phải được nhập")]
        public Branch? Branch { get; set; }//Ngành học

        [DisplayName("Giới tính")]
        [Required(ErrorMessage = "Giới tính phải được nhập")]
        public Gender? Gender { get; set; }//Giới tính

        [DisplayName("Chính quy")]
        public bool IsRegular { get; set; }//Hệ: true-chính qui, false-phi cq

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Địa chỉ phải được nhập")]
        [DisplayName("Địa chỉ")]
        public string? Address { get; set; }//Địa chỉ

        [Range(typeof(DateTime), "1/1/1963", "12/31/2005",ErrorMessage ="Tuổi từ 18 đến 60")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Ngày sinh phải được nhập")]
        [DisplayName("Ngày sinh")]
        public DateTime DateOfBorth { get; set; }//Ngày sinh

        [Required(ErrorMessage ="Điểm phải được nhập")]
        [Range(0.0,10.0,ErrorMessage ="Điểm >0 và <10")]
        [DisplayName("Điểm")]
        public double? Score { get; set; }
    }
}
