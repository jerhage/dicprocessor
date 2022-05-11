using DicModels.XML;

namespace DicModels.Builders;

public class EquivalentBuilder
{
    public static Equivalent BuildEquivalent(EquivalentXml e)
    {
        Equivalent equivalent = new();
        equivalent.Feats = new List<Feat>();
        foreach (FeatXml featXml in e.FeatsXml)
        {
            Feat newFeat = FeatBuilder.BuildFeat(featXml);
            equivalent.Feats.Add(newFeat);
        }

        return equivalent;
    }
}