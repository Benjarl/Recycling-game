using DataSync;

public class UserData : LabDataBase
{
    public string UserName { get; set; }
    public string LevelName { get; set; }
    public string Mode { get; set; }
    public string CorrectRate { get; set; }
    public string WrongAnswer { get; set; }

    public UserData(string name, string level , string mode, string right, string wrong)
    {
        UserName = name;
        LevelName = level;
        Mode = mode;
        CorrectRate = right;
        WrongAnswer = wrong;
    }

    public UserData()
    {

    }
}
