using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new DataBaseLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager,new List<ILoggerService> {new DataBaseLoggerService() , new FileLoggerService()});
            basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers);


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}