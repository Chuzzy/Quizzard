using System;

namespace Quizzard
{
    /// <summary>
    /// The type of question.
    /// </summary>
    enum QuestionType
    {
        /// <summary>
        /// A short answer consisting of a few words.
        /// </summary>
        ShortAnswer,
        /// <summary>
        /// A long answer consisting of a paragraph or two.
        /// </summary>
        LongAnswer,
        /// <summary>
        /// An integer answer.
        /// </summary>
        IntegerAnswer,
        /// <summary>
        /// A decmial answer.
        /// </summary>
        DecimalAnswer,
        /// <summary>
        /// A multiple choice question.
        /// </summary>
        MultipleChoice
    }
    /// <summary>
    /// The type of answer.
    /// </summary>
    enum AnswerType
    {
        /// <summary>
        /// This answer is correct.
        /// </summary>
        Accept,
        /// <summary>
        /// This answer is required.
        /// </summary>
        Required,
        /// <summary>
        /// This answer is incorrect.
        /// </summary>
        Deny
    }


    /// <summary>
    /// Represents a question.
    /// </summary>
    class Question
    {
        /// <summary>
        /// Get or set the text associated with the question.
        /// </summary>
        public string QuestionText { get; set; }
        /// <summary>
        /// Get or set the question type.
        /// </summary>
        public QuestionType Type { get; set; }
        /// <summary>
        /// Get or set valid answers to the question.
        /// </summary>
        public Answer Answers { get; set; }

        /// <summary>
        /// Initialise an empty question.
        /// </summary>
        public Question()
        {
            QuestionText = null;

        }

        /// <summary>
        /// Initialise a question with some text, assuming question type to be short answer.
        /// </summary>
        /// <param name="text">The question text associated with the question.</param>
        public Question(string text)
        {
            this.QuestionText = text;
            this.Type = QuestionType.ShortAnswer;
        }

        /// <summary>
        /// Initialise a question with some text and set the answer type.
        /// </summary>
        /// <param name="text">The question text associated with the question.</param>
        /// <param name="T">The question type.</param>
        public Question(string text, QuestionType T)
        {
            this.QuestionText = text;
            this.Type = T;
        }

    }
    /// <summary>
    /// Represents the answer to a question.
    /// </summary>
    class Answer
    {
        /// <summary>
        /// Get or set the text associated with the answer.
        /// </summary>
        public string AnswerText { get; set; }
        /// <summary>
        /// Get or set the answer type.
        /// </summary>
        public AnswerType Type { get; set; }


    }
}