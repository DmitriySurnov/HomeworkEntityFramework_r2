namespace HomeworkEntityFramework
{
    public class InformationOfPlayer
    {
        public string NamePlayer { get; private set; }

        public string NameClass { get; private set; }

        public int Expirience { get; private set; }

        public int CurrentLevel { get; private set; }

        public InformationOfPlayer(string namePlayer, int expirience, int currentLevel, string nameClass)
        {
            NamePlayer = namePlayer;
            NameClass = nameClass;
            Expirience = expirience;
            CurrentLevel = currentLevel;
        }
    }
}
