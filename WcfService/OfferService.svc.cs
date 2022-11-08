using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    
    public class OfferService : IOfferService
    {
        public List<Offer> SearchAvailability(RequestObject requestObject)
        {
            Offer offer1 = new Offer(DateTime.Now, 2, "1A", "a", 10, 10, 3, 8, 8, 2, false);
            Offer offer2 = new Offer(DateTime.Now, 3, "1B", "b", 10, 10, 3, 8, 8, 2, false);
            Offer offer3 = new Offer(DateTime.Now, 2, "1C", "c", 10, 10, 3, 8, 8, 2, false);
            Offer offer4 = new Offer(DateTime.Now, 2, "1D", "d", 10, 10, 3, 8, 8, 2, false);

            List<Offer> offers = new List<Offer>();

            offers.Add(offer1);
            offers.Add(offer2);
            offers.Add(offer3);
            offers.Add(offer4);

            Credentials credentials = new Credentials("TestUN", "TestPW");

            List<Offer> offerList = new List<Offer>();

            foreach (Offer offer in offers)
            {
                if (requestObject.Duration == offer.StayDurationNights && requestObject.Credentials == credentials)
                {
                    offerList.Add(offer);
                }
            }

            return offerList;
        }
    }
}
