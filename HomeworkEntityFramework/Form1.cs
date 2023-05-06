using HomeworkEntityFramework.ModelDatabase;

namespace HomeworkEntityFramework
{
    public partial class Form1 : Form
    {

        private readonly int maxLevel;

        private readonly int minLevel;
        public Form1()
        {
            InitializeComponent();
            using var db = new DataBase();
            {
                comboBoxChoosePlayer.Items.AddRange(db.Characters.Select(x => x.Name).ToArray());
                maxLevel = db.Expirience.Max(x => x.CurrentLevel);
                minLevel = db.Expirience.Min(x => x.CurrentLevel);
            }

        }

        private void ChangesInEnabledButton(int currentLevel)
        {
            buttonLowerLevel.Enabled = !(currentLevel == minLevel);
            buttonRaiseLevel.Enabled = !(currentLevel == maxLevel);
        }

        private void ClearlistBox()
        {
            listBoxSkills.Items.Clear();
        }

        private void OutputOfPlayerInformation()
        {
            ClearlistBox();
            InformationOfPlayer informationOfPlayer = GettingOfPlayerInformation(comboBoxChoosePlayer.Text);
            textBoxPlayerName.Text = informationOfPlayer.NamePlayer;
            textBoxLevel.Text = informationOfPlayer.CurrentLevel.ToString();
            textBoxExperience.Text = informationOfPlayer.Expirience.ToString();
            textBoxClassName.Text = informationOfPlayer.NameClass;
            listBoxSkills.Items.AddRange(GettingInformationAboutPlayerSkills(informationOfPlayer.CurrentLevel, informationOfPlayer.NameClass));
            ChangesInEnabledButton(informationOfPlayer.CurrentLevel);
        }

        private static string[] GettingInformationAboutPlayerSkills(int currentLevel, string nameClass)
        {
            using var db = new DataBase();
            {
                return db.CharacterClassBuild
                    .Where(x => x.CharactersClassId == db.CharactersClass
                            .First(y => y.NameClass == nameClass)
                            .Id)
                    .Select(x => new
                    {
                        x.SpellId,
                        db.Spell.First(y => y.Id == x.SpellId).NameSpell,
                        db.Spell.First(y => y.Id == x.SpellId).ExpirienceId
                    })
                    .Where(x => x.ExpirienceId <= db.Expirience
                                    .First(z => z.CurrentLevel == currentLevel)
                                    .Id)
                    .Select(x => x.NameSpell)
                    .ToArray();
            }
        }


        private static InformationOfPlayer GettingOfPlayerInformation(string namePlayer)
        {
            using var db = new DataBase();
            {
                return db.Characters
                   .Where(x => x.Name == namePlayer)
                   .Select(x => new
                   {
                       x.Name,
                       db.CharachtersExpirience.First(y => y.CharactersId == x.Id).Expirience,
                       db.Expirience.First(z => z.Id == db.CharachtersExpirience
                           .First(y => y.CharactersId == x.Id).ExpirienceId).CurrentLevel,
                       db.CharactersClass.First(y => y.Id == x.CharactersClassId).NameClass
                   })
                   .Select(x => new InformationOfPlayer(x.Name, x.Expirience, x.CurrentLevel, x.NameClass))
                   .First();
            }
        }

        private void ComboBoxChoosePlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutputOfPlayerInformation();
        }

        private static CharachtersExpirience GetCharachtersExpirience(string namePlayer)
        {
            using var db = new DataBase();
            {
                return db.CharachtersExpirience
                    .Where(x => x.CharactersId == db.Characters
                        .First(y => y.Name == namePlayer)
                        .Id)
                    .First();
            }
        }

        private void ButtonRaiseLevel_Click(object sender, EventArgs e)
        {
            int numberLevel = int.Parse(textBoxLevel.Text);
            numberLevel++;
            LevelChanges(textBoxPlayerName.Text, numberLevel);
        }

        private void LevelChanges(string namePlayer, int numberNewLevel)
        {
            CharachtersExpirience charachtersExpirience = GetCharachtersExpirience(namePlayer);
            using var db = new DataBase();
            {
                charachtersExpirience.SetExpirienceId(db.Expirience.First(x => x.CurrentLevel == numberNewLevel).Id);
                db.CharachtersExpirience.Update(charachtersExpirience);
                db.SaveChanges();
                OutputOfPlayerInformation();
            }
        }

        private void ButtonLowerLevel_Click(object sender, EventArgs e)
        {
            int numberLevel = int.Parse(textBoxLevel.Text);
            numberLevel--;
            LevelChanges(textBoxPlayerName.Text, numberLevel);
        }
    }
}