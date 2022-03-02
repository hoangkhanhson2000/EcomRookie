namespace Rookie.Ecom.Contracts.Constants
{
    public static class ValidationRules
    {
        public static class CommonRules
        {
            public const int MinLenghCharactersForText = 0;
            public const int MaxLenghCharactersForText = 255;
        }

        public static class CategoryRules
        {
            public const int MinLenghCharactersForName = 0;
            public const int MaxLenghCharactersForName = 50;

            public const int MinLenghCharactersForDesc = 0;
            public const int MaxLenghCharactersForDesc = 100;
        }
        public static class ProductRules
        {
            public const int MinLenghCharactersForName = 0;
            public const int MaxLenghCharactersForName = 50;

            public const int MinLenghCharactersForDesc = 0;
            public const int MaxLenghCharactersForDesc = 100;
        }
        public static class UserRules
        {
            public const int MinLenghCharactersForFirstName = 0;
            public const int MaxLenghCharactersForFirstName = 50;

            public const int MinLenghCharactersForLastName = 0;
            public const int MaxLenghCharactersForLastName = 50;

            public const int MinLenghCharactersForEmail = 0;
            public const int MaxLenghCharactersForEmail = 100;
        }
    }
}
