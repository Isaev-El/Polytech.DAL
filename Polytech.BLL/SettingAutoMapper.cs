using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

using Polytech.DAL.Model;
using Polytech.BLL.Model;

namespace Polytech.BLL
{
    public static class SettingAutoMapper
    {
        public static MapperConfiguration Init()
        {
          
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Client, ClientDTO>().ReverseMap();
                cfg.CreateMap<Account, AccountDTO>().ReverseMap();
                cfg.CreateMap<Address, AddressDTO>().ReverseMap();
            });
        }
    }
}
