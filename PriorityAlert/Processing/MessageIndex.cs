using System.Collections.Generic;

namespace PriorityAlert
{
    public class MessageOriginator
    {
        public MessageOriginator(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { private set; get; }
        public string Name { private set; get; }
    }

    public class MessageAlertCode
    {
        public MessageAlertCode(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { private set; get; }
        public string Name { private set; get; }
    }

    public static class MessageTypes
    {
        public static List<MessageOriginator> Originators = new List<MessageOriginator>
        {
            new MessageOriginator("ALL", "0. Notify All"),
            new MessageOriginator("PYA", "1. Notify Administration Only"),
            new MessageOriginator("PYS", "2. Notify Staff and Above ⬆"),
            new MessageOriginator("PYE", "3. Notify Educators and Above ⬆"),
            new MessageOriginator("PYT", "4. Notify Students and Above ⬆"),
            //new MessageOriginator("DMO", "Demo Activation"),
            //new MessageOriginator("COA", "Announcement For Normal Usage"),
            //new MessageOriginator("SYA", "Announcement For Safety Usage"),
        };

        public static List<MessageAlertCode> AlertCodes = new List<MessageAlertCode>
        {
            // Common
            new MessageAlertCode("COM", "0. Common Announcement"),
            new MessageAlertCode("PTT", "1. Periodic Test"),

            // Severe Weather
            new MessageAlertCode("EEW", "2. Earthquake Warning"),
            new MessageAlertCode("FLS", "3. Flood Warning"),
            new MessageAlertCode("FZW", "4. Freeze Warning"),
            new MessageAlertCode("SWW", "5. Severe Weather Warning"),
            new MessageAlertCode("TOR", "6. Tornado Warning"),

            // Shelter and Evacuation
            new MessageAlertCode("DMO", "7. Silent Lockdown Warning"),
            new MessageAlertCode("SPW", "8. Shelter in Place Warning"),
            new MessageAlertCode("EVC", "9. Evacuation Warning"),
        };
    }

}
