using System;

class PeRson
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public Address PresentAddress { get; set; } // Here. Address is data type and PresentAddress is field name.
}
class Address
{
    public string HouseNumber { get; set; }
    public string RoadNumber { get; set; }
    public string Area { get; set; }
    public string PostCode { get; set; }
    public string District { get; set; }
}
class OneToOneAssociationRelationship
{
    public static void Main(string[] args)
    {
        Address address = new Address();
        address.HouseNumber = "H-101";
        address.RoadNumber = "R-101";
        address.Area = "Rayerbag";
        address.PostCode = "P-101";
        address.District = "Dhaka";

        PeRson person1 = new PeRson();
        person1.PresentAddress = address;

        string area = person1.PresentAddress.Area;
        string district = person1.PresentAddress.District;

        Console.WriteLine($"Area: {area}, District: {district}");

    }
}