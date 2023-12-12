using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace GildedRoseTests;

[UseReporter(typeof(DiffReporter))]
public static class ApprovalTest
{
    private static readonly string[] Args = { "30" };

    [Test]
    public static void ThirtyDays()
    {
        var fakeOutput = new StringBuilder();

        Console.SetOut(new StringWriter(fakeOutput));
        Console.SetIn(new StringReader($"a{Environment.NewLine}"));

        TextTestFixture.Main(Args);

        var output = fakeOutput.ToString();

        Approvals.Verify(output);
    }
}
