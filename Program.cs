using System;

namespace MattSnowWTW
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emails = { "matthew.j.snow@gmail.com", "matthewjsnow@gmail.com", "Matthew.J.Snow@gmail.com", "hello@willistowerswatson.com", "hello+bob@willistowerswatson.com", "Michael.Vrooman@extendedhealth.com", "Ronald.Hollberg@extendedhealth.com", "Joel.Searcy@extendedhealth.com", "Justin.Mayhew@extendedhealth.com" };
            var solution = new Solution();
            var numberOfUniqueEmailAddresses = solution.NumberOfUniqueEmailAddresses(emails);
            Console.WriteLine($"The Number of Unique Emails is: {numberOfUniqueEmailAddresses}");
            var xLeftToRightDiagonalsGame = new TicTacToe(8);
            for (int i = 0; i < 7; ++i)
            {
                xLeftToRightDiagonalsGame.PlacePiece(i,i,1);
            }
            Console.WriteLine(xLeftToRightDiagonalsGame.PlacePiece(7,7,1));

            var yRightToLeftDiagonalsGame = new TicTacToe(5);
            for (int i = 0; i < 4; ++i)
            {
                yRightToLeftDiagonalsGame.PlacePiece(i, 4 - i, 2);
            }
            Console.WriteLine(yRightToLeftDiagonalsGame.PlacePiece(4, 0, 2));

        }
    }
}