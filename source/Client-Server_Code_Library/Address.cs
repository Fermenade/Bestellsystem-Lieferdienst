using Newtonsoft.Json;

namespace Client_Server_Code_Library;

public class Address
{
    public int? AddressID;
    public string Country;
    public int ZipCode;
    public string City;
    public string Street;
    public int HouseNumber;
    public int? ApartmentNumber;

    [DatabaseConstructor]
    Address(int addressId, string country, int zippCode, string city, string street, int houseNumber, int apartmentNumber)
        : this(country, zippCode, city, street, houseNumber, apartmentNumber)
    {
        AddressID = addressId;
    }
    [JsonConstructor]
    Address(int? addressId, string country, int zippCode, string city, string street, int houseNumber, int? apartmentNumber)
    {
        AddressID = addressId;
        Country = country;
        ZipCode = zippCode;
        City = city;
        Street = street;
        HouseNumber = houseNumber;
        if (ApartmentNumber == -1)
            ApartmentNumber = apartmentNumber;
    }

    public Address(string country, int zipCode, string city, string street, int houseNumber, int apartmentNumber)
        : this(country, zipCode, city, street, houseNumber)
    {
        if (apartmentNumber == 0) throw new("Invalid apartment number");
        ApartmentNumber = apartmentNumber;
    }
    public Address(string country, int zipCode, string city, string street, int houseNumber)
    {
        if (country == "") throw new("Invalid country");
        Country = country;
        if (zipCode == 0) throw new("Invalid zipp number");
        ZipCode = zipCode;
        if (city == "") throw new("Invalid city");
        City = city;
        if (street == "") throw new("Invalid street");
        Street = street;
        if (houseNumber == 0) throw new("Invalid house number");
        HouseNumber = houseNumber;
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