using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polytech.DAL;
using Polytech.BLL.Model;
using Polytech.DAL.Model;
using AutoMapper;

namespace Polytech.BLL
{
    public class ServiceAccount
    {
        private Repository<Account> repo = null;
        private ReturnResult<Account> result = null;
        private readonly IMapper _iMapper;

        public ServiceAccount(string path)
        {
            repo = new Repository<Account>(path);
            _iMapper = SettingAutoMapper.Init()
                .CreateMapper();
        }

        public List<AccountDTO> GetAllAccountClient(int ClientId)
        {
            result = repo.GetAllClients();

            result.ListData = result.ListData
                .Where(w => w.ClientId == ClientId)
                .ToList();

            return _iMapper.Map<List<AccountDTO>>(result.ListData);
        }
    }
}
