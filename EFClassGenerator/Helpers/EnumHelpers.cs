namespace EFClassGenerator.Helpers
{
    public static class EnumHelpers
    {
        public static IList<T> EnumToList<T>()
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T isn't an enumerated type");

            IList<T> list = new List<T>();
            Type type = typeof(T);
            if (type != null)
            {
                Array enumValues = System.Enum.GetValues(type);
                foreach (T value in enumValues)
                {
                    list.Add(value);
                }
            }

            return list;
        }
    }
}