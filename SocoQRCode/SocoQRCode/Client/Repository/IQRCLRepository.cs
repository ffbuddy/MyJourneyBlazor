using SocoQRCode.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocoQRCode.Client.Repository
{
    public interface IQRCLRepository
    {
        Task CreateQRCode(QRCL qrcl);
        Task<List<QRCL>> GetQRCode();
        Task<QRCL> GetQRCode(int Id);
        Task UpdateQRCode(QRCL qrcl);
        Task DeleteQRCode(int Id);

    }
}
