using FunBooksAndVideos.BusinessLogic.Interfaces;
using FunBooksAndVideos.Model.Entities;
using FunBooksAndVideos.Model.Interfaces;
using FunBooksAndVideos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.BusinessLogic.Classes
{
    //This class works only if the activation logic for-
    //BookMemership, VideoMembership and PremiumMembership is not polymorphic
    //If polymorphic then I have implemented a chain of responsibility
    //which will chain to find a responsible class (BookMemberShipActivator.cs, VideoMemberShipActivator.cs, PremiumMemberShipActivator.cs)
    //I haven't written unit test for this as I have written this class just to how the design would be if membership is not polymorphic
    public class MembershipActivator : IMembershipActivator
    {
        private readonly IMembershipActivateRepository _membershipActivateRepository;
        public MembershipActivator(IMembershipActivateRepository membershipActivateRepository)
        {
            _membershipActivateRepository = membershipActivateRepository;
        }
        public bool Activate(Order order)
        {
            if (order.ItemLines.Where(a => a is INonPhysicalProduct).Count() > 0)
            {
                return _membershipActivateRepository.Activate(order);
            }
            return default(bool);
        }
    }
}
