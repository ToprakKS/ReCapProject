using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {

        public List<RentalDetailDto> GetRentalDetails(int? rentalId = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                if (rentalId == null)
                {
                    var result = from r in context.Rentals
                                 join c in context.Cars
                                 on r.CarId equals c.Id                                
                                 join cstmr in context.Customers
                                 on r.CustomerId equals cstmr.CustomerId
                                 join u in context.Users
                                 on cstmr.UserId equals u.Id
                                 select new RentalDetailDto
                                 {
                                     RentalId = r.RentalId,
                                     CarId = c.Id,
                                     CustomerCompany = cstmr.CompanyName,
                                     CustomerMail = u.Email,
                                     CustomerName = u.FirstName,
                                     CustomerSurname = u.LastName,
                                     DailyRentPrice = c.DailyPrice,
                                     RentDate = r.RentDate,
                                     ReturnDate = r.ReturnDate
                                 };

                    return result.ToList();
                }
                else
                {
                    var result = from r in context.Rentals
                                 where r.RentalId == rentalId
                                 join c in context.Cars
                                 on r.CarId equals c.Id                                 
                                 join cstmr in context.Customers
                                 on r.CustomerId equals cstmr.CustomerId
                                 join u in context.Users
                                 on cstmr.UserId equals u.Id
                                 select new RentalDetailDto
                                 {
                                     RentalId = r.RentalId,                                     
                                     CarId = c.Id,                                     
                                     CustomerCompany = cstmr.CompanyName,
                                     CustomerMail = u.Email,
                                     CustomerName = u.FirstName,
                                     CustomerSurname = u.LastName,
                                     DailyRentPrice = c.DailyPrice,
                                     RentDate = r.RentDate,
                                     ReturnDate = r.ReturnDate
                                 };

                    return result.ToList();
                }
            }
        }
    }
}
