using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Lab4._3_
{
    class Cloakroom
    {
        private string lastname;
        private string deliverydate;
        private string timeofstorage;
        private string inventorynumber;
        private string thing;

        public Cloakroom()
        {
     

        }
        public Cloakroom(string lastname, string deliverydate, string timeofstorage, string  inventorynumber, string thing)
        {
            this.lastname = lastname;
            this.deliverydate = deliverydate;
            this.timeofstorage = timeofstorage;
            this.inventorynumber = inventorynumber;
            this.thing = thing;
        }
        public string Lastname  
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Deliverydate
        {
            get { return deliverydate; }
            set { deliverydate = value; }
        }
        public string Timeofstorage
        {
            get { return timeofstorage; }
            set { timeofstorage = value; }

        }
        public string Inventorynumber
        {
            get { return inventorynumber; }
            set { inventorynumber = value; }
        }
        public string Thing
        {
            get { return thing; }
            set { thing = value; }
        }
        public override string ToString()
        {
            return this.lastname + "|" + this.deliverydate + "|" + this.timeofstorage + "|" + this.inventorynumber + "|" + this.thing;
        }

    }
}
