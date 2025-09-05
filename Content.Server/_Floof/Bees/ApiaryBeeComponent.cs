using Robust.Shared.Prototypes;

namespace Content.Server._Floof.Bees;


[RegisterComponent]
[Access(typeof(ApiaryBeeSystem))]
public sealed partial class ApiaryBeeComponent : Component
{
    /*
     * Genes:
     *  Genetic Stability
     *  Speed [Y]
     *  Traits
     *  Temper
     *  Productivity [Y]
     *  Activity [Y]
     *  Temperature Tolerance
     *  Endurance [Y]
     */

    /// <summary>
    ///     If not null, overrides the bee's initial health. Otherwise, the bee's initial health is set to the Endurance value.
    /// </summary>
    [DataField]
    public float? HealthOverride = null;



    /// <summary>
    ///     How productive the Bee is at making honey and byproducts.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float Productivity = 5f;

    /// <summary>
    ///     How often the bee leaves the apiary to pollinate plants.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float Activity = 5f;

    /// <summary>
    ///     How fast the Bee is outside the apiary.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float Speed = 5f;

}
