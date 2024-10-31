namespace ContactsAdministration;

using System;
using System.IO;


class Program {
    
    static void Main () {

        Person p = new Person ("Random");

        Contact c1 = new("randomName1","randomSubname1","+asdasasd","asdasdasd@_asdas.com");
        Contact c2 = new ("randomName2","randomSubname2","+1111111","adasdasd@hotmail.com");
        Contact c3 = new ("randomName3","randomSubname3","+1111+111","a!_@hotmail.com");

        p.AddContact(c1);
        p.AddContact(c2);
        p.AddContact(c3);

        p.ShowContacts();

    }

}
