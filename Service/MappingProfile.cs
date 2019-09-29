using AutoMapper;
using DAL.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<AbsenceTransactionTbl, AbsenceTransactionModel>().ReverseMap();
            CreateMap< IQueryable< AbsenceTransactionTbl>,IQueryable< AbsenceTransactionModel>>().ReverseMap();

            CreateMap<EmployeeTbl, EmployeeModel>().ReverseMap();
            CreateMap<SysRequestStatusTbl, SysRequestStatusModel>().ReverseMap();

            CreateMap<AccountNumberTbl, AccountModel>().ReverseMap();

            CreateMap<AdditionalPaymentTransactionTbl, AddionalPaymentHeModel>().ReverseMap();
            CreateMap<AdditionalPaymentTransactionDetailsTbl, AddionalPaymentDeModel>().ReverseMap();
        }
    }
}
