using FengShuiKoi.Reponsitories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiKoi.Services.IServices
{
    public interface IAvertise
    {
        Task<List<Avertise>> GetAllAvertise();
        Boolean DelAvertise(int Id);
        Boolean DelAvertise(Avertise Items);
        Boolean AddAvertise(Avertise Items);
        Boolean UpdAvertise(Avertise Items);
        Task<Avertise> GetAvertiseById(int Id);
    }
}
