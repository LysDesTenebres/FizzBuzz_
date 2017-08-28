using NUnit.Framework;

namespace ExerciseHelpers
{
    /// <summary>
    /// Base class used to add 'empty answer' functionality to an exercise.
    /// Used by your teacher. Do not change this class.
    /// </summary>
    public class ExerciseBase
    {
        private const string EmptyAnswerMsg = "Replace \"___\" with your answer to complete the exercise.";

        protected static dynamic ____
        {
            get
            {
                throw new AssertionException(EmptyAnswerMsg);
            }
        }

        protected static void ___(params object[] inputs)
        {
            throw new AssertionException(EmptyAnswerMsg);
        }

        protected static dynamic _____(params object[] inputs)
        {
            throw new AssertionException(EmptyAnswerMsg);
        }
    }
}
