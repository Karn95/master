using FunBooksAndVideos.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.BusinessLogic.Interfaces
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Order lineItems);
    }
}
