using FunBooksAndVideos.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Repository.Interfaces
{
    public interface IMembershipActivateRepository
    {
        //Here it should be a good idea to pass a DTO instead of passing-
        //whole Order object
        bool Activate(Order order);
    }
}
