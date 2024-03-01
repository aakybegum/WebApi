using Business.Abstracts;
using Business.Dtos.Request;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entites.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class BrandManager : IBrandService
{
	private readonly IBrandDal _brandDal; //Bu, genellikle bağımlılıkların enjekte edilerek sınıflar arasında bağımlılıkların azaltılması ve
						 //kodun daha esnek ve test edilebilir hale getirilmesi amacıyla yapılan bir pratiktir.

						 //Yani, BrandManager sınıfı, IBrandDal aracılığıyla veritabanı işlemlerini gerçekleştirir.
						 //Ancak, BrandManager sınıfı, IBrandDal'ın somut bir uygulamasına değil, sadece arayüzüne (interface) bağımlıdır.
						 //Bu sayede, IBrandDal'ı uygulayan farklı sınıfların (örneğin, SQLBrandDal, MongoBrandDal gibi) BrandManager ile kullanılması sağlanabilir.
						 //Bu da kodun esnekliğini artırır ve farklı veritabanlarına geçiş yapma veya test senaryoları oluşturma gibi durumları kolaylaştırır.
	
	//constructor
	public BrandManager(IBrandDal brandDal)
	{
		_brandDal = brandDal;
	}

	public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
	{
		//business rules
		//mapping -->automapper
		Brand brand = new();
		brand.Name = createBrandRequest.Name;
		brand.CreatedDate = DateTime.Now;
		
		_brandDal.Add(brand);

		CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
		createdBrandResponse.Name = brand.Name;
		createdBrandResponse.Id = 4;
		createdBrandResponse.CreatedDate = brand.CreatedDate;

		return createdBrandResponse;

		//mapping;
		//gelen requesti (30)
		//veritabanı nesneme çeviriyorum (34-36)
		//ona ekliyorum (38)
		//veritabanından gelenide response çevirip onu döndürüyorum (40-45)
	}

	public List<GetAllBrandResponse> GetAll() //burda veritabanına gidip ordaki dataları okutup döndürücez.
	{
		List<Brand> brands =  _brandDal.GetAll(); //burada bize marka listelerini veritabanındaki haliyle veriyor.
												  //Ama biz interfacede List<GetAllBrandResponse> döndüreceğimizi söyledik.
		
		List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();

		foreach (var brand in brands) //her markayı tek tek dolaşıp mapliyor ve listeye ekliyor.
		{
			GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
			getAllBrandResponse.Name = brand.Name;
			getAllBrandResponse.Id = brand.Id;
			getAllBrandResponse.CreatedDate = brand.CreatedDate;

			getAllBrandResponses.Add(getAllBrandResponse);

		}

		return getAllBrandResponses;
	}
}
