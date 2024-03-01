using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Abstracts;

public class Brand : BaseEntity<int>
{

	public string Name { get; set; }

}
