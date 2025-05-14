namespace Bestellsystem_Lieferdienst.BL;

public class Address
{
    int? AddressID;
    public string Country;
    public int ZippCode;
    public string City;
    public string Street;
    public int HouseNumber;
    public int? ApartmentNumber;
    Address(int addressId, string country, int zippCode, string city, string street, int houseNumber, int apartmentNumber)
        : this(country, zippCode, city, street, houseNumber, apartmentNumber)
    {
        this.AddressID = addressId;
    }
    public Address(string country, int zipCode, string city, string street, int houseNumber, int apartmentNumber)
        : this(country, zipCode, city, street, houseNumber)
    {
        if (apartmentNumber == 0) throw new("Invalid apartment number");
        this.ApartmentNumber = apartmentNumber;
    }
    public Address(string country, int zippCode, string city, string street, int houseNumber)
    {
        if (country == "") throw new("Invalid country");
        this.Country = country;
        if (zippCode == 0) throw new("Invalid zipp number");
        this.ZippCode = zippCode;
        if (city == "") throw new("Invalid city");
        this.City = city;
        if (street == "") throw new("Invalid street");
        this.Street = street;
        if (houseNumber == 0) throw new("Invalid house number");
        this.HouseNumber = houseNumber;
    }

    public override string ToString()
    {
        List<string> str = new List<string>();
        str.Add($"'{Country}'");
        str.Add($"'{ZippCode}'");
        str.Add($"'{City}'");
        str.Add($"'{Street}'");
        str.Add($"'{HouseNumber}'");
        if (ApartmentNumber != null)
            str.Add($"'{ApartmentNumber}'");
        return string.Join(",", str);
    }
}