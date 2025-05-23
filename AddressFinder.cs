using System;
using System.Collections.Generic;

public class AddressFinder
{
    private Dictionary<string, string> addressbook;
    public AddressFinder(Dictionary<string, string> addressbook)
    {
        this.addressbook = addressbook;
    }
    
    public string FindPhonenumber(string name)
    {
        if (addressbook.ContainsKey(name))
        {
            return addressbook[name];
        }
        else
        {
            return "Phone number is not found.";
        }
    }
}