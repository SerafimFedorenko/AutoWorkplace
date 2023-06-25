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
        public static void Initialize()
        {
            AutoWorkplaceContext db = new AutoWorkplaceContext();
            db.Database.EnsureCreated();

            if(db.IncomingMessages.Any())
            {
                return;
            }

            Random random = new Random();

            int inMessagesNumber = 50;
            int outMessagesNumber = 50;

            string[] sources = { "Электронная почта", "Бумажная почта", "СМДО" };

            foreach(string sourceName in sources)
            {
                Source source = new Source()
                {
                    Name = sourceName,
                };
                db.Sources.Add(source);
            }
            db.SaveChanges();
            
            for (int i = 0;i < inMessagesNumber;i++)
            {
                DateTime date = DateTime.Now - new TimeSpan((int)random.NextInt64(365 * 5), 0, 0, 0);
                string sender = "От кого" + i.ToString();
                string recipient = "Получатель" + i.ToString();
                string adressee = "Кому" + i.ToString();
                int sourceId = db.Sources.ToArray()[random.NextInt64(db.Sources.Count())].Id;
                IncomingMessage inMessage = new IncomingMessage(date, sender, recipient, adressee, sourceId);
                db.IncomingMessages.Add(inMessage);
            }
            db.SaveChanges();

            for (int i = 0; i < outMessagesNumber; i++)
            {
                string number = random.NextInt64(1, 100).ToString() + "-" + random.NextInt64(1, 100).ToString() + "-" + random.NextInt64(1, 100).ToString();
                DateTime date = DateTime.Now - new TimeSpan((int)random.NextInt64(365 * 5),0,0,0);
                string sender = "От кого" + i.ToString();
                string recipient = "Получатель" + i.ToString();
                string adressee = "Кому" + i.ToString();
                int sourceId = db.Sources.ToArray()[random.NextInt64(db.Sources.Count())].Id; ;
                OutgoingMessage outMessage = new OutgoingMessage(date, number, sender, recipient, adressee, sourceId);
                db.OutgoingMessages.Add(outMessage);
            }
            db.SaveChanges();
        }
    }
}
