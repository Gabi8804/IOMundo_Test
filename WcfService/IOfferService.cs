using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOfferService
    {
        [OperationContract]
        List<Offer> SearchAvailability(RequestObject requestObject);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
  
    public class Offer
    {
        public Offer(DateTime checkInDate, int stayDurationNights, string personCombination,
            string service_Code, decimal price, decimal pricePerAdult, decimal pricePerChild,
            decimal strikePrice, decimal strikePricePerAdult, decimal strikePricePerChild, bool showStrikePrice)
        {
            CheckInDate = checkInDate;
            StayDurationNights = stayDurationNights;
            PersonCombination = personCombination;
            Service_Code = service_Code;
            Price = price;
            PricePerAdult = pricePerAdult;
            PricePerChild = pricePerChild;
            StrikePrice = strikePrice;
            StrikePricePerAdult = strikePricePerAdult;
            StrikePricePerChild = strikePricePerChild;
            ShowStrikePrice = showStrikePrice;
        }
    
        public int ID { get; set; }

        public DateTime CheckInDate { get; set; }
   
        public int StayDurationNights { get; set; }
  
        public string PersonCombination { get; set; }
        
        public string Service_Code { get; set; }
        
        public decimal Price { get; set; }
        
        public decimal PricePerAdult { get; set; }
        
        public decimal PricePerChild { get; set; }
        
        public decimal StrikePrice { get; set; }
        
        public decimal StrikePricePerAdult { get; set; }
        
        public decimal StrikePricePerChild { get; set; }
        
        public bool ShowStrikePrice { get; set; }

       
    }
    [DataContract]

    public class RequestObject
    {
        [DataMember]
        public DateTime DateForm { get; set; }
        [DataMember]
        public int Duration { get; set; }
        [DataMember]
        public int NumberOfPersons { get; set; }
        [DataMember]
        public Credentials Credentials { get; set; }
    }

    public class Credentials
    {
        public Credentials(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
