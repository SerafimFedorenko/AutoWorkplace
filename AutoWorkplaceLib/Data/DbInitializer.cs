using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoWorkplaceLib.Models;

namespace AutoWorkplaceLib.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AutoWorkplaceContext db)
        {
            db.Database.EnsureCreated();

            if(db.IncomingMessages.Any())
            {
                return;
            }

            Random random = new Random();

            int inMessagesNumber = 100;
            int outMessagesNumber = 100;

            string[] sources = { "Электронная почта", "Бумажная почта", "СМДО" };

            foreach(string sourceName in sources)
            {
                Source source = new Source(sourceName);
                db.Sources.Add(source);
            }
            db.SaveChanges();

            for(int i = 0;i < inMessagesNumber;i++)
            {
                DateTime date = DateTime.Now - new TimeSpan(random.NextInt64(365 * 2));
                string sender = "Отправитель" + i.ToString();
                string recipient = "Адресат" + i.ToString();
                string adressee = "Адресант" + i.ToString();
                Source source = db.Sources.ToArray()[random.NextInt64(db.Sources.Count())];
                IncomingMessage inMessage = new IncomingMessage(date, sender, recipient, adressee, source);
                db.IncomingMessages.Add(inMessage);
            }
            db.SaveChanges();

            for (int i = 0; i < outMessagesNumber; i++)
            {
                string number = random.NextInt64(1, 100).ToString() + "-" + random.NextInt64(1, 100).ToString() + "-" + random.NextInt64(1, 100).ToString();
                DateTime date = DateTime.Now - new TimeSpan(random.NextInt64(365 * 2));
                string sender = "Адресант" + i.ToString();
                string recipient = "Получатель" + i.ToString();
                string adressee = "Адресат" + i.ToString();
                Source source = db.Sources.ToArray()[random.NextInt64(db.Sources.Count())];
                OutgoingMessage outMessage = new OutgoingMessage(date, number, sender, recipient, adressee, source);
                db.OutgoingMessages.Add(outMessage);
            }
            db.SaveChanges();
        }
    }
}
