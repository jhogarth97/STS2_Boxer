using BaseLib.Abstracts;
using BaseLib.Utils;
using Boxer.BoxerCode.Character;

namespace Boxer.BoxerCode.Potions;

[Pool(typeof(BoxerPotionPool))]
public abstract class BoxerPotion : CustomPotionModel;