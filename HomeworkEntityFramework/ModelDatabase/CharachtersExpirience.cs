namespace HomeworkEntityFramework.ModelDatabase
{
    public class CharachtersExpirience
    {
        public int Id { get; private set; }

        public int CharactersId { get; private set; }

        public int ExpirienceId { get; private set; }

        public int Expirience { get; private set; }

        public void SetExpirienceId(int expirienceId) { 
            ExpirienceId = expirienceId; 
        }
    }
}
