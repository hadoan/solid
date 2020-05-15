using NameSorter.Services;
using Xunit;
using Shouldly;

namespace NameSorter.Tests
{
    public class NameConverterTest
    {
        [Fact]
        public void Name_Blank_Not_Valid_Converter()
        {
            var nameValidation = new NameValidation();
            nameValidation.IsValidName("").ShouldBeFalse();
        }

        [Fact]
        public void Name_SingleName_Not_Valid_Converter()
        {
            var nameValidation = new NameValidation();
            nameValidation.IsValidName("Ha").ShouldBeFalse();
        }

        [Fact]
        public void Name_4GivenNames_Not_Valid_Converter()
        {
            var nameValidation = new NameValidation();
            nameValidation.IsValidName("This is not valid name").ShouldBeFalse();
        }

        [Fact]
        public void Name_3GivenNames_Valid_Converter()
        {
            var nameValidation = new NameValidation();
            nameValidation.IsValidName("This is valid name").ShouldBeTrue();
        }
    }
}
