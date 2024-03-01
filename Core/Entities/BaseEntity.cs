using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites;

public class BaseEntity <TId>
{
	public TId Id { get; set; }
	public DateTime CreatedDate { get; set; } //markayla ilgili kayıt ne zaman oluştu? 

	public DateTime? UpdatedDate { get; set; } //? = illa oluşturmak zorunda değilsin demektir.
	public DateTime? DeletedDate { get; set; }
}
