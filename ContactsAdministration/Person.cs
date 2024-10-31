namespace ContactsAdministration;
using System.Collections.Generic;

public class Person
{
    private String Name;
    private readonly List<Contact> Contacts;

    public Person (String someName) {
        this.Name = someName;
        this.Contacts = new List<Contact> ();
    }

    public void AddContact (Contact c) {
        this.Contacts.Add(c);
    }

    public void ShowContacts () {
        foreach (Contact c in this.Contacts) {
            Console.WriteLine(c.ToString());
        }
    }

    public bool FindContact (Contact c) {
        if (this.Contacts.Contains(c)) {
            return true;
        }
        return false;
    }

    public bool DeleteContact (Contact c) {
        if (this.FindContact(c)) {
            this.Contacts.Remove(c);
            return true;
        }
        return false;
    }

}
