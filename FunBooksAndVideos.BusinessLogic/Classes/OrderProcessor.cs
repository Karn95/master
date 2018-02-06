using FunBooksAndVideos.BusinessLogic.Interfaces;
using FunBooksAndVideos.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.BusinessLogic.Classes
{
    public class OrderProcessor : IOrderProcessor
    {
        private readonly IPurchaseOrderGenerator _purchaseOrderGenerator;
        private readonly IShippingSlipGenerator _shippingSlipGenerator;
        private readonly IMembershipActivator _memberShipActivator;

        public OrderProcessor(IPurchaseOrderGenerator purchaseOrderGenerator, IShippingSlipGenerator shippingSlipGenerator, IMembershipActivator memberShipActivator)
        {
            _purchaseOrderGenerator = purchaseOrderGenerator;
            _shippingSlipGenerator = shippingSlipGenerator;
            _memberShipActivator = memberShipActivator;
        }

        public void ProcessOrder(Order order)
        {
            try
            {
                //Full execution can move to a template method if any of the behaviour want to override

                //This will chain through different member ship activator as each component is responsible for it on logic.
                //If membership activation will never behave polymorphically then we don't need to chain but logic will only be in one class
                _memberShipActivator.Activate(order);

                _purchaseOrderGenerator.Generate(order);

                _shippingSlipGenerator.Generate(order);

            }
            catch
            {
                //Exception handling goes here
                throw;
            }
        }
    }
}
