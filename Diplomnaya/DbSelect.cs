using System.Collections.Generic;
using System.Linq;

namespace Diplomnaya
{
    public class DbSelect
    {
        public List<ModelZakaz> SelectZakaz()
        {
            using (var sc = new SampleContext())
            {
                List<ModelZakaz> lmz = sc.Zakazs.Where(x => x.ZakazId >= 0).ToList();
                return lmz;
            }

        }
        public List<ModelCar> SelectCar(string ZakazNumber)
        {
            using (var sc = new SampleContext())
            {
                List<ModelCar> lmc = sc.Cars.Where(x => x.ZakazNumber == ZakazNumber).ToList();
                return lmc;
            }
        }
        public List<ModelClient> SelectClient(string ZakazNumber)
        {
            using (var sc = new SampleContext())
            {
                List<ModelClient> lmc = sc.Clients.Where(x => x.ZakazNumber == ZakazNumber).ToList();
                return lmc;
            }
        }
        public List<ModelWork> SelectWork(string ZakazNumber)
        {
            using (var sc = new SampleContext())
            {
                List<ModelWork> lmw = sc.Works.Where(x => x.ZakazNumber == ZakazNumber).ToList();
                return lmw;
            }
        }
        public List<ModelDetail> SelectDetail(string ZakazNumber)
        {
            using (var sc = new SampleContext())
            {
                List<ModelDetail> lmd = sc.Details.Where(x => x.ZakazNumber == ZakazNumber).ToList();
                return lmd;
            }
        }
        public List<ModelZakaz> SearchZakaz(string search)
        {
            using (SampleContext sc = new SampleContext())
            {
                var searchmodel = sc.Zakazs.Where(x => x.ZakazNumber == search).ToList();
                return searchmodel;
            }
        }
        public List<ModelClient> SearcClient(string search)
        {
            using (SampleContext sc = new SampleContext())
            {
                var searchFIO = sc.Clients.Where(x => x.FIO == search).ToList();
                return searchFIO;
            }
        }
        public List<ModelClient> SearcClient1(string search)
        {
            using (SampleContext sc = new SampleContext())
            {
                var searchFIO = sc.Clients.Where(x => x.ZakazNumber == search).ToList();
                return searchFIO;
            }
        }
        public string SearchPhone(string search)
        {
            using (SampleContext sc = new SampleContext())
            {
                var searchPhone = sc.Clients.Where(x => x.Phone == search).ToList();
                string str = "";
                foreach (var index in searchPhone)
                {
                    str = index.ZakazNumber;
                }
                return str;
            }
        }
        public string SearchGOS(string search)
        {
            using (SampleContext sc = new SampleContext())
            {
                var searchGOS = sc.Cars.Where(x => x.GOS == search).ToList();
                string str = "";
                foreach (var index in searchGOS)
                {
                    str = index.ZakazNumber;
                }
                return str;
            }
        }
        public string SearchWork(string search)
        {
            using (SampleContext sc = new SampleContext())
            {
                var searchwork = sc.Works.Where(x => x.NameWorks == search).ToList();
                string str = "";
                foreach (var index in searchwork)
                {
                    str = index.ZakazNumber;
                }
                return str;
            }
        }
        public string SearchDetail(string search)
        {
            using (SampleContext sc = new SampleContext())
            {
                var searchdetail = sc.Details.Where(x => x.NameDetails == search).ToList();
                string str = "";
                foreach (var index in searchdetail)
                {
                    str = index.ZakazNumber;
                }
                return str;
            }
        }
        public List<ModelCar> SearchCar(string search)
        {
            using (SampleContext sc = new SampleContext())
            {
                var searchdetail = sc.Cars.Where(x => x.ZakazNumber == search).ToList();
                return searchdetail;
            }
        }
        public string SearchModelCar(string search)
        {
            using (SampleContext sc = new SampleContext())
            {
                var searchcarmodel = sc.Cars.Where(x => x.Model == search).ToList();
                string str = "";
                foreach (var index in searchcarmodel)
                {
                    str = index.ZakazNumber;
                }
                return str;
            }
        }
        public string ZakazNumberClient(string search)
        {
            using (SampleContext sc = new SampleContext())
            {
                var zakaznumberclient = sc.Clients.Where(x => x.FIO == search).ToList();
                string str = "";
                foreach (var index in zakaznumberclient)
                {
                    str = index.ZakazNumber;
                }
                return str;
            }
        }
    }
}
