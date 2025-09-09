using PointsBet.Backend.Online.Code;
using static NUnit.Framework.Assert;
using NUnit.Framework;

namespace PointsBet.Backend.Online.Code.Test
{
    public class StringFormatterTest
    {

        [Test]
        public void Should_Return_EmptyString_When_EmptyArray_Is_Passed_With_NoQuotes()
        {
            var result = StringFormatter.ToCommaSepatatedList(new string[] { }, string.Empty);
            That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Should_Return_EmptyString_When_EmptyArray_Is_Passed_WithQuotes()
        {
            var result = StringFormatter.ToCommaSepatatedList(new string[] { }, "'");
            That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Should_Return_EmptyString_When_EmptyStringItem_With_NoQuotes()
        {
            var result = StringFormatter.ToCommaSepatatedList(new[] { string.Empty }, string.Empty);
            That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Should_Return_EmptyString_When_EmptyStringItem_WithQuotes()
        {
            var result = StringFormatter.ToCommaSepatatedList(new[] { string.Empty }, "'");
            That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Should_Return_SameItem_When_SingleItem_With_NoQuotes()
        {
            var result = StringFormatter.ToCommaSepatatedList(new[] { "apple" }, string.Empty);
            That(result, Is.EqualTo("apple"));
        }

        [Test]
        public void Should_Return_QuotedSameItem_When_SingleItem_WithQuotes()
        {
            var result = StringFormatter.ToCommaSepatatedList(new[] { "apple" }, "'");
            That(result, Is.EqualTo("'apple'"));
        }

        [Test]
        public void Should_Return_QuotedCommaSeparatedList_When_MultipleItems_WithQuotes()
        {
            var result = StringFormatter.ToCommaSepatatedList(new[] { "apple", "banana", "cherry" }, "\"");
            That(result, Is.EqualTo("\"apple\", \"banana\", \"cherry\""));
        }

        [Test]
        public void Should_Return_CommaSeparatedList_When_MultipleItems_NoQuotes()
        {
            var result = StringFormatter.ToCommaSepatatedList(new[] { "apple", "banana" }, string.Empty);
            That(result, Is.EqualTo("apple, banana"));
        }


        [Test]
        public void Should_Return_QuotedListWithEmpty_When_MixedEmptyAndNonEmptyItems()
        {
            var result = StringFormatter.ToCommaSepatatedList(new[] { "apple", "", "banana" }, "'");
            That(result, Is.EqualTo("'apple', '', 'banana'"));
        }

    }
}
