using Newtonsoft.Json;

namespace Client_Server_Code_Library;

public class Address
{
    [DatabaseAutoIncrementID]
    public long? AddressID;
    public string Country;
    public int PostZip;
    public string City;
    public string Street;
    public int HouseNr;
    public int? ApartmentNr;

    [DatabaseConstructor]
    Address(int addressId, string country, int zipp, string city, string street, int houseNr, int apartmentNr)
        : this(country, zipp, city, street, houseNr, apartmentNr)
    {
        AddressID = addressId;
    }
    [JsonConstructor]
    Address(int? addressId, string country, int zipp, string city, string street, int houseNr, int? apartmentNr)
    {
        AddressID = addressId;
        Country = country;
        PostZip = zipp;
        City = city;
        Street = street;
        HouseNr = houseNr;
        ApartmentNr = apartmentNr;
    }

    public Address(string country, int postZip, string city, string street, int houseNr, int apartmentNr)
        : this(country, postZip, city, street, houseNr)
    {
        if (apartmentNr == 0) throw new("Invalid apartment number");
        ApartmentNr = apartmentNr;
    }
    public Address(string country, int postZip, string city, string street, int houseNr)
    {
        if (country == "") throw new("Invalid country");
        Country = country;
        if (postZip == 0) throw new("Invalid zipp number");
        PostZip = postZip;
        if (city == "") throw new("Invalid city");
        City = city;
        if (street == "") throw new("Invalid street");
        Street = street;
        if (houseNr == 0) throw new("Invalid house number");
        HouseNr = houseNr;
    }

    public static Address CreateAddress(string country, string zipCode, string city, string street, string houseNumber, string? apartmentNumber)
    {
        if (!int.TryParse(zipCode, out int ZipCode))
        {
            throw new ArgumentException($"Invalid zip code: {zipCode}. Zip code must be a number.");
        }

        if (!int.TryParse(houseNumber, out int HouseNumber))
        {
            throw new ArgumentException($"Invalid house number: {houseNumber}. House number must be a number.");
        }

        if (apartmentNumber != "")
        {
            if (!int.TryParse(apartmentNumber, out int ApartmentNumber))
            {
                throw new ArgumentException($"Invalid house number: {houseNumber}. House number must be a number.");
            }
            return new Address(country, ZipCode, city, street, HouseNumber, ApartmentNumber);
        }

        return new Address(country, ZipCode, city, street, HouseNumber);
    }

    public override string ToString()
    {
        return JsonSerialize.Serialize(this);
    }
}