using NUnit.Framework;

namespace ExerciseHelpers
{
    public static class ObjectExtensions
    {
        private const string ReplaceMethodMsg = "Replace the method call \".___()\" with the appropriate method to complete the exercise.";

        public static dynamic ___(this object obj, params object[] inputs)
        {
            throw new AssertionException(ReplaceMethodMsg);
        }
    }
}
