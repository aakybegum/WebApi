using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses;

public class CreatedBrandResponse
{
    //oluşan markanın id sini verebiliriz. Çünkü şu marka oluştu diyecek ve link verecek frontend de. Ona basınca detayına gidicek.
    //detaya gidebilmesi için id  ye ihtiyaç var.

    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
}
