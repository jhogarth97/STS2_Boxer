using BaseLib.Abstracts;
using BaseLib.Extensions;
using Boxer.BoxerCode.Extensions;
using Godot;

namespace Boxer.BoxerCode.Powers;

public abstract class BoxerPower : CustomPowerModel
{
    //Loads from Boxer/images/powers/your_power.png
    public override string CustomPackedIconPath => $"{Id.Entry.RemovePrefix().ToLowerInvariant()}.png".PowerImagePath();
    public override string CustomBigIconPath => $"{Id.Entry.RemovePrefix().ToLowerInvariant()}.png".BigPowerImagePath();
}