using System;
using Xunit;
using Language;

namespace ConsoleApplication
{
    public class LanguageTests
    {
        [Fact]
        public void should_return_french(){
            Assert.Equal("Bonjour le monde", new Language.Localise().Translate("fr"));
        }
    }
}
