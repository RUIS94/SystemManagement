namespace Model
{
    public class IsValid
    {
        public bool NullVal(params string[] values)
        {
            foreach (var value in values)
            {
                if (string.IsNullOrEmpty(value))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
