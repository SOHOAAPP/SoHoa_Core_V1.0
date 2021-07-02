using SoHoa.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoHoa.Domain.Models
{
    public class NguoiDung
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string TenNguoiDung { get; set; }
        [Required]
        public string TenDangNhap { get; set; }
        [Required]
        public string MatKhau { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Guid NhomQuyenId { get; set; }
        
    }
}
