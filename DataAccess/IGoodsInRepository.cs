using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public interface IGoodsInRepository
    {
        Task<List<GoodsIn>> GetAllGoodsInAsync(); 
        Task<GoodsIn> GetGoodsInByIdAsync(string goodsInId); 
        Task<bool> AddGoodsInAsync(GoodsIn goodsIn);    
        Task<bool> UpdateGoodsInAsync(GoodsIn goodsIn); 
        Task<bool> DeleteGoodsInAsync(string goodsInId);
    }
}
