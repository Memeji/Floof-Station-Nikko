namespace Content.Server._Floof.Bees;


[RegisterComponent]
[Access(typeof(ApiarySystem))]
public sealed partial class ApiaryComponent : Component
{
    [DataField]
    public bool Ejecting; //Is makign Bee?
    [DataField]
    public float EjectAccumulator = 0f; //Timer for making Bee.
    [DataField]
    public float EjectDelay = 0.6f; //Delay before making Bee
    [DataField]
    public string? NextBeeToEject;
    [DataField]
    public string? ProgressResult = "FoodHoneyComb";
    [DataField]
    public int Progress = 0;
    [DataField]
    public int MaxProgress = 10;

}
