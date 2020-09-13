using System;
using System.Collections.Generic;
using Xunit;

namespace Test.First.Test
{
    public class UnitTestQuestions
    {
        [Theory]
        [InlineData(44, 0, 7.9, 347.60)]
        [InlineData(50, 34, 32.7, 1653.53)]
        [InlineData(34, 8, 2.9, 98.99)]
        public void Should_Return_Salary_According_Their_WorkedHours_And_Price(double workHours, double minutesWorking, double workPrice, double expectedSalary)
        {
            //Given
            var questionTest1 = new QuestionsTest();

            //When
            var result = questionTest1.Question1(workHours, minutesWorking, workPrice);

            //Then
            Assert.Equal(expectedSalary, result);
        }

        [Theory]
        [InlineData(new string[] {"a", "b", "s", "a", "Finalizar", "a"}, "absa")]
        [InlineData(new string[] {"e", "z", "h", "g", "s", "a", "t", "k", "Finalizar"}, "ezhgsatk")]
        [InlineData(new string[] {"a", "r", "c", "j", "Finalizar", "f"}, "arcj")]
        public void Should_Return_A_Word_According_Given_Letters(string[] letters, string expectedWord)
        {
            //Given
            var questionTest2 = new QuestionsTest();

            //When
            var result = questionTest2.Question2(letters);

            //Then
            Assert.Equal(expectedWord, result);
        }

        [Fact]
        public void Should_Return_Single_Mens_Name()
        {
            //Given
            var questionTest3 = new QuestionsTest();
            var interviwers = new (string name, string isSingle)[]
            {
                ("marcos", "sim"), ("rodrigo", "não"), ("Charles", "sim"), ("April", "Não"), ("Britney", "sim")
            };

            //When
            var result = questionTest3.Question3(interviwers);

            //Then
            Assert.Equal("marcos, Charles, Britney", result);
        }

        [Theory]
        [InlineData(1998, "Você é maior de idade!")]
        [InlineData(2012, "Você é menor de idade!")]
        [InlineData(2001, "Você é maior de idade!")]
        [InlineData(2003, "Você é menor de idade!")]
        public void Should_Return_Whether_You_Are_Older_Or_Not(int year, string expectedAnswer)
        {
            //Given
            var questionTest4 = new QuestionsTest();

            //When
            var result = questionTest4.Question4(year);

            //Then
            Assert.Equal(expectedAnswer, result);
        }

        [Fact]
        public void Should_Return_The_Numbers_That_Are_Not_Null()
        {
            //Given
            var questionTest5 = new QuestionsTest();
            var numbers = new double?[]{
                2,34,5,6,null,3, 4, 3, 5 
            };

            //When
            var result = questionTest5.Question5(numbers);
            var expectedNumbers = new List<double>(){
                2,34,5,6,3, 4, 3, 5 
            };
            //Then
            for (int i = 0; i < expectedNumbers.Count; i++)
            {
                Assert.Equal(expectedNumbers[i], result[i]);
            }
        }

        [Fact]
        public void Should_Return_The_Arrange_Of_Given_Salaries()
        {
            //Given
            var questionTest6 = new QuestionsTest();
            var salaries = new List<double>{
                1923.98, 3425.98, 1423.80, 1235.7, 3459.1, 4756.2, -2342, 7, 0, -1234 
            };

            //When
            var result = questionTest6.Question6(salaries);
            
            //Then
            Assert.Equal(2318.82, result);
        }

        [Theory]
        [InlineData(new int[]{42, 11, 34, 42, 25, 27, 28}, 28.57)]
        [InlineData(new int[]{-42, -12, 53, 42, 42, 42, 43}, 42.86)]
        [InlineData(new int[]{32, -11, 36, 42, 25, 27, 28}, 14.29)]
        [InlineData(new int[]{42, 42, 42, 42}, 100.00)]
        public void Should_Return_Percentage_Of_Catarinense_In_The_Interviwers_List(int[] code, double expectedResult)
        {
            //Given
            var questionTest7 = new QuestionsTest();

            //When
            var result = questionTest7.Question7(code);

            //Then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_Return_The_Students_Name_Who_Studies_Full_Time()
        {
            //Given
            var questionTest8 = new QuestionsTest();
            var students = new string[2, 5]
            {
                {"marcos", "guilherme", "silva", "vitor", "christian"},
                {"marcos", "vitor", "magda", "euller", "sabrina"}
                
            };
            //When
            var result = questionTest8.Question8(students);
            
            //Then
            Assert.Equal("marcos, vitor", result);
        }

    }
}
