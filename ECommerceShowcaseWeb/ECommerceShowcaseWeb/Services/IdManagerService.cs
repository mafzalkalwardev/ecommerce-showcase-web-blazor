namespace ECommerceShowcaseWeb.Services
{
    public class IdManagerService
    {
        private readonly HashSet<string> _usedIds = new HashSet<string>();
        private readonly Random _random = new Random();

        public string GenerateUniqueCustomerId()
        {
            string newId;
            do
            {
                newId = _random.Next(1000, 10000).ToString();
            } while (_usedIds.Contains(newId));

            _usedIds.Add(newId);
            return newId;
        }
    }
}