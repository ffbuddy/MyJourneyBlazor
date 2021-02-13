
using SocoQRCode.Client.Helpers;
using SocoQRCode.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocoQRCode.Client.Repository
{
    public class QRCLRepository : IQRCLRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/QRCode";

        public QRCLRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<QRCL>> GetQRCode()
        {
            var response = await httpService.Get<List<QRCL>>(url);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<QRCL> GetQRCode(int Id)
        {
            var response = await httpService.Get<QRCL> ($"{url}/{Id}");

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task CreateQRCode(QRCL qrcl)
        {
            var response = await httpService.Post(url, qrcl);      
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
               
            }
        }

        public async Task UpdateQRCode(QRCL qrcl)
        {
            var response = await httpService.Put(url, qrcl);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());

            }
        }

        public async Task DeleteQRCode(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());


            }
            
        }
    }
}

