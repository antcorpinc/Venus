using System;
using System.ComponentModel.DataAnnotations;
using Venus.Core.Contracts;

namespace Venus.Model
{
    public class Society : IIdentifiableModel<Guid>
    {

        public Society() {

        }

        [Key]
        public Guid Id {get;set;}
        [Required]
        public string Name {get;set;}
        public string Description {get;set;}
        [Required]
        public string AddressLine1 {get;set;}
        public string AddressLine2 {get;set;}
        public string Locality {get;set;}
        [Required]
        public string City {get;set;}
        [Required]
        public string State {get;set;}
        [Required]
        public string PinCode {get;set;}
        public string PhoneNumber {get;set;}
        public string AdditionalPhoneNumber {get;set;}
        public bool Disabled { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}