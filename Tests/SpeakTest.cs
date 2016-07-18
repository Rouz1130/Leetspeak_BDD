using Xunit;
using System.Collections.Generic;

namespace Leetspeak
{
  public class LeetspeakTest
  {
    // [Fact]
    // public void Translate_StringToArray_true()
    // {
    //   Speak testPhrase = new Speak() {};
    //   string actualPhrase = "Persian";
    //   Assert.Equal(actualPhrase, testPhrase.Translate("Persian"));
    // }

    // [Fact]
    // public void Translate_ChangeEToThree_true()
    // {
    //   Speak testPhrase = new Speak() {};
    //   string actualPhrase = "P3rsian";
    //   Assert.Equal(actualPhrase, testPhrase.Translate("Persian"));
    // }

    [Fact]
    public void Translate_ChangeOToZero_true()
    {
      Speak testPhrase = new Speak() {};
      string actualPhrase = "0rang";
      Assert.Equal(actualPhrase, testPhrase.Translate("orang"));
    }

    [Fact]
    public void Translate_ChangeCapitalIToOne_true()
    {
      Speak testPhrase = new Speak() {};
      string actualPhrase = "1r0n";
      Assert.Equal(actualPhrase, testPhrase.Translate("Iron"));
    }

    [Fact]
    public void Translate_ChangeStoZ_true()
    {
      Speak testPhrase = new Speak() {};
      string actualPhrase = "Suzp3ct";
      Assert.Equal(actualPhrase, testPhrase.Translate("Suspect"));
    }
  }
}
