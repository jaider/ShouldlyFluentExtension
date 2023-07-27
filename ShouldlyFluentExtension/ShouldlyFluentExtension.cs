using Shouldly;

namespace ShouldlyFluentExtension;

public static class ShouldlyFluentExtension
{
    public static T ShouldBe<T, R>(this T obj, Func<T, R> propertySelector, R expectedValue)
    {
        propertySelector(obj).ShouldBe(expectedValue);
        return obj;
    }
}