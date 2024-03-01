using Business.Dtos.Request;
using Business.Dtos.Responses;
using Entites.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IBrandService
{
	CreatedBrandResponse Add(CreateBrandRequest createBrandRequest); //bana bir marka ver (Brand brand)-> request ben sana eklediğim marka döndüriyim (Brand Add).-> response

	List<GetAllBrandResponse> GetAll();

//veritabanı nesnelerini asla son kullanıcıya döndürmüyoruz veya ondan istemiyoruz.

	//responses and requests -> yanıtlar ve istekler.
}
