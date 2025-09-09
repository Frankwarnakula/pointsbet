using PointsBet.Backend.Online.Code;
using static NUnit.Framework.Assert;
using NUnit.Framework;

namespace PointsBet.Backend.Online.Code.Test
{
    public class StringFormatterTest
    {

        [Test]
        public void Should_Return_EmptyString_When_EmptyArray_Is_Passed_With_Empty_Quote()
        {
            var result = StringFormatter.ToCommaSepatatedList(new string[] { }, string.Empty);
            That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Should_Return_EmptyString_When_EmptyArray_Is_Passed_With_Quote()
        {
            var result = StringFormatter.ToCommaSepatatedList(new string[] { }, "'");
            That(result, Is.EqualTo(string.Empty));
        }

    }
}
