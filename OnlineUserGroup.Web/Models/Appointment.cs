using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineUserGroup.Web.Models
{
    public class Appointment
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}