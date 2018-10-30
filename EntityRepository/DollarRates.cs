using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityRepository
{
    public class DollarRates
    {
        public DollarRates()
        {

        }
        private List<Rates> _ratesList;

        public List<Rates> RatesList
        {
            get { return _ratesList; }
            set
            {
                if (value != _ratesList)
                {
                    _ratesList = value;

                }
                
            }
        }
        private string _Disclaimer;

        public string Disclaimer
        {
            get { return _Disclaimer; }
            set { _Disclaimer = value; }
        }
        private string _License;

        public string License
        {
            get { return _License; }
            set { _License = value; }
        }
        private string _Timestamp;

        public string Timestamp
        {
            get { return _Timestamp; }
            set { _Timestamp = value; }
        }
        private string _Base;

        public string Base
        {
            get { return _Base; }
            set { _Base = value; }
        }
        private Dictionary<string, decimal> _Rates;

        public Dictionary<string, decimal> Rates
        {
            get { return _Rates; }
            set
            {
                if (value != _Rates)
                {
                    _Rates = value;
                    FillListWithRates();
                }
                

            }
        }
        private void FillListWithRates()
        {
            List<Rates> rates = new List<Rates>();
            foreach (var item in Rates)
            {
                Rates rate = new Rates();
                rate.Country = item.Key;
                rate.Value = item.Value.ToString();
                rates.Add(rate);
            }
            RatesList = rates;
        }
    }
}
