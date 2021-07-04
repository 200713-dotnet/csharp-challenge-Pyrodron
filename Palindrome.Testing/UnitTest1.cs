using System;
using Xunit;
using Palindrome.Domain;

// dotnet sln add **/*.csproj
// dotnet add Palindrome.Testing/Palindrome.Testing.csprojk reference Palindrome.Domain/Palindrome.Domain.csproj
// dotnet run -p Palindrome.Testing/Palindrome.Testing.csproj
// git add .
// git commit -m ""
// git push

namespace Palindrome.Testing {
    public class UnitTest1 {
      Class1 pc = new Class1();

        [Fact]
        public void Test1() {
          Assert.True(pc.IsPalindrome("aaaa"), "Test1 failed");
        }

        [Fact]
        public void Test2() {
          Assert.True(!pc.IsPalindrome("AaAa"), "Test2 failed");
        }

        [Fact]
        public void Test3() {
          Assert.True(pc.IsPalindrome("AaaA"), "Test3 failed");
        }

        [Fact]
        public void Test4() {
          Assert.True(pc.IsPalindrome("02022020"), "Test4 failed");
        }

        [Fact]
        public void Test5() {
          Assert.True(pc.IsPalindrome("tattarrattat"), "Test5 failed");
        }
    }
}
