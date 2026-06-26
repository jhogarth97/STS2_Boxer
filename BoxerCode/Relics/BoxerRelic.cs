using BaseLib.Abstracts;
using BaseLib.Extensions;
using BaseLib.Utils;
using Boxer.BoxerCode.Character;
using Boxer.BoxerCode.Extensions;
using Godot;

namespace Boxer.BoxerCode.Relics;

[Pool(typeof(BoxerRelicPool))]
public abstract class BoxerRelic : CustomRelicModel
{
    public override string PackedIconPath => $"{Id.Entry.RemovePrefix().ToLowerInvariant()}.png".RelicImagePath();

    protected override string PackedIconOutlinePath =>
        $"{Id.Entry.RemovePrefix().ToLowerInvariant()}_outline.png".RelicImagePath();

    protected override string BigIconPath => $"{Id.Entry.RemovePrefix().ToLowerInvariant()}.png".BigRelicImagePath();
}