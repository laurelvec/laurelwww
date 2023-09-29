namespace Laurel_site.Utils;

using System;

public class MathChallenge
{
    private static readonly Random random = new Random();

    public string Question { get; private set; }
    public int CorrectAnswer { get; private set; }

    public MathChallenge()
    {
        GenerateChallenge();
    }

    private void GenerateChallenge()
    {
        int operand1 = random.Next(1, 10);  // Generate random operands
        int operand2 = random.Next(1, 10);
        char[] operators = { '+', '-', '*' };
        char selectedOperator = operators[random.Next(operators.Length)];  // Random operator

        switch (selectedOperator)
        {
            case '+':
                CorrectAnswer = operand1 + operand2;
                Question = $"{operand1} + {operand2} = ?";
                break;
            case '-':
                CorrectAnswer = operand1 - operand2;
                Question = $"{operand1} - {operand2} = ?";
                break;
            case '*':
                CorrectAnswer = operand1 * operand2;
                Question = $"{operand1} * {operand2} = ?";
                break;
        }
    }

    public bool IsCorrectAnswer(int userAnswer)
    {
        return userAnswer == CorrectAnswer;
    }
}
