using System;

class BuildingCodes
{
    public int buildindId;
    public string buildingCode;
    public string buildingLocation;

    public BuildingCodes(int id, string code, string location)
    {
        buildindId = id;
        buildingCode = code;
        buildingLocation = location;
    }

    public BuildingCodes()
    {
    }

    List<BuildingCodes> buildingCodes = new List<BuildingCodes>();

    public void AddBuildingCode(int id, string code, string location)
    {
        buildingCodes.Add(new BuildingCodes(id, code, location));
    }

    public void DisplayBuildingCodes()
    {
        foreach (BuildingCodes buildingCode in buildingCodes)
        {
            Console.WriteLine("Building ID: " + buildingCode.buildindId);
            Console.WriteLine("Building Code: " + buildingCode.buildingCode);
            Console.WriteLine("Building Location: " + buildingCode.buildingLocation);
            Console.WriteLine("---------------------------------------------------");
        }
    }
}

class Program 
{ 
    static void Main()
    {
        BuildingCodes buildingCodes = new BuildingCodes();

        for (int i = 0; i < 10; i++)
        {
            buildingCodes.AddBuildingCode(
                Faker.RandomNumber.Next(1, 100),
                Faker.RandomNumber.Next(1, 100).ToString(),
                Faker.Company.Name()
            );
        }

        Console.WriteLine("Descending Order of Building Codes");

        buildingCodes.DisplayBuildingCodes();
        
    }
}