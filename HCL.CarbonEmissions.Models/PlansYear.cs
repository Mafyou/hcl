namespace HCL.CarbonEmissions.Models;

public class PlansYear
{
    public int Id { get; set; }
    public List<PlansTemplate> PlansApplied { get; set; } = new()
    {
        new PlansTemplate { Id = 1, Name = "Achat Thermostat", ReductionWH = 280 },
        new PlansTemplate { Id = 2, Name = "Achat LED", ReductionWH = 100 },
        new PlansTemplate { Id = 3, Name = "Gaget 5 étoiles", ReductionWH = 300 },
        new PlansTemplate { Id = 4, Name = "Termostat moins 2°", ReductionWH = 260 },
        new PlansTemplate { Id = 5, Name = "Solaire", ReductionWH = 500 },
        new PlansTemplate { Id = 6, Name = "Standby", ReductionWH = 150 }

    };
    public int Year { get; set; }
}