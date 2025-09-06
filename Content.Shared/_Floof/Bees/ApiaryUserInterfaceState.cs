using Robust.Shared.Serialization;


namespace Content.Shared._Floof.Bees;

[Serializable, NetSerializable]
public sealed class ApiaryUserInterfaceState : BoundUserInterfaceState
{
    public float Progress;

    public ApiaryUserInterfaceState(float progress)
    {
        Progress = progress;
    }
}

