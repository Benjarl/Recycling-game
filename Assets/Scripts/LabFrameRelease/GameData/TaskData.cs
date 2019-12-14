using DataSync;

public class TaskData : LabDataBase
{
    public string LevelName { get; set; }
    public int Mode { get; set; }
    public int Time { get; set; }
    public string Trashnumber { get; set; }

    public  TaskData(string level, int mode, int time, string trashnumber)
    {
        LevelName = level;
        Mode = mode;
        Time = time;
        Trashnumber = trashnumber;
    }

    public  TaskData()
    {
        
    }
}
