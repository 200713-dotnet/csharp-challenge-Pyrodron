using System;
using Xunit;
using Palindrome.Domain;

// dotnet sln add **/*.csproj
// dotnet add Palindrome.Testing/Palindrome.Testing.csprojk reference Palindrome.Domain/Palindrome.Domain.csproj
// dotnet run -p Palindrome.Testing/Palindrome.Testing.csproj

namespace Palindrome.Testing {
    public class UnitTest1 {
      Class1 pc = new Class1();

        [Fact]
        public void Test1() {
          pc.IsPalindrome("aaaa");
          return;
        }
    }
}
