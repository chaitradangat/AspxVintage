namespace AspxVintage.WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WCFService.svc or WCFService.svc.cs at the Solution Explorer and start debugging.
    public class WCFService : IWCFService
    {
        public void DoWork()
        {

        }

        public string GetData()
        {
            return "Hello WCF!";
        }

    }
}
