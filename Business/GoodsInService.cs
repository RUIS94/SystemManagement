using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace Business
{
    public class GoodsInService
    {
        private readonly IGoodsInRepository _goodsInRepository;

        public GoodsInService(IGoodsInRepository goodsInRepository)
        {
            _goodsInRepository = goodsInRepository;
        }

        public async Task<List<GoodsIn>> GetAllGoodsInAsync()
        {
            return await _goodsInRepository.GetAllGoodsInAsync();
        }

        public async Task<bool> AddGoodsInAsync(GoodsIn goodsIn)
        {
            return await _goodsInRepository.AddGoodsInAsync(goodsIn);
        }

        public async Task<bool> UpdateGoodsInAsync(GoodsIn goodsIn)
        {
            return await _goodsInRepository.UpdateGoodsInAsync(goodsIn);
        }

        public async Task<bool> DeleteGoodsInAsync(string goodsInId)
        {
            return await _goodsInRepository.DeleteGoodsInAsync(goodsInId);
        }

        public async Task<GoodsIn> GetGoodsInByIdAsync(string goodsInId)
        {
            return await _goodsInRepository.GetGoodsInByIdAsync(goodsInId);
        }
    }
}