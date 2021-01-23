﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {   
            //
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();
            //
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            //
            List<ILoggerService> loggers = new List<ILoggerService>() { smsLoggerService, fileLoggerService, databaseLoggerService };
            //
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, esnafKrediManager };
            //basvuruManager.KrediOnBilgilenmesiYap(krediler);
            //
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(krediler,loggers);

        }
    }
}
