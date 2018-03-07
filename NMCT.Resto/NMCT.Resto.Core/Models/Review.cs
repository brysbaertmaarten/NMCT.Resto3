using System;

namespace NMCT.Resto.Core.Model
{
    public class Review
    {
        public string UserName { get; set; }
        public double Score { get; set; }
        public string Comment { get; set; }

        public long TimeStampOfVisit { get; set; }

        /// <summary>
        /// translates datetime to unix timestamp and vice versa
        /// </summary>
        //public DateTime DateOfVisit
        //{
        //    get { return DateTimeOffset.FromUnixTimeSeconds(TimeStampOfVisit).ToLocalTime().UtcDateTime; }
        //    set { TimeStampOfVisit = ((DateTimeOffset)DateTime.SpecifyKind(value, DateTimeKind.Local)).ToUnixTimeSeconds(); }
        //}
    }
}
