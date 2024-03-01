using Entites.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface IBrandDal
{
	void Add(Brand brand); //marka ekleme işlemi

	List<Brand> GetAll(); //tüm markaları listeleme.
}
