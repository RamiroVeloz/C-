namespace ContactsAdministration;

using System.Linq;
using System.Text.RegularExpressions;
public class Contact
{
    private String Name = "Default";
    private String Subname = "Default";
    private String Phone = "None";
    private String Email = "None";

    public Contact (String someName, String someSubname, String somePhone, String someEmail) {
        this.Name = someName;
        this.Subname = someSubname;
        if (!this.ValidatePhoneNumber(somePhone)) {
            Console.WriteLine($"Invalid phone number for contact {this.Name}, {this.Subname}");
        }
        if ( this.ValidateEmail(someEmail)) {
            Console.WriteLine($"Invalid mail for contact {this.Name}, {this.Subname}");
        }
    }

    public override String ToString () {
        String aux = $" Name: {this.Name} - Subname: {this.Subname}\n Phone: {this.Phone}\n Email: {this.Email}";
        return aux;
    }

    public String GetNombre () {
        return this.Name;
    }

    public String GetSubname () {
        return this.Subname;
    }

    public String GetPhone () {
        return this.Phone;
    }

    public String GetEmail () {
        return this.Email;
    }

    public void SetNombre (String someName) {
        this.Name = someName;
    }

    public void SetSubname (String someSubname) {
        this.Subname = someSubname;
    }

    public bool ValidatePhoneNumber (String p) {

        char[] numList = "0123456789".ToCharArray();

        if (p.Length <= 15 && p[0] == '+') {
            if ( p[1..].All(  c => numList.Contains(c) )) {
                this.Phone = p;
                return true;
            }
        }
        return false;
    }

    public bool ValidateEmail (String e) {

        var dom = e.Split('@');

        if (dom.Length != 2) {
            return false;
        }

        string charList = @"^[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        if (Regex.IsMatch(dom[1], charList)) {
            this.Email = e;
            return true;
        } else {
            return false;
        }

    }


}
