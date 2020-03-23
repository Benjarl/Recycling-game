using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LabData;
using DataSync;

namespace TestGameFrame
{
    public class UserData : LabDataBase
    {
        public string UserName { get; set; }
        public string LevelName { get; set; }
        public string Mode { get; set; }
        public string CorrectRate { get; set; }
        public string WrongAnswer { get; set; }
        public string TimeAnswer { get; set; }

        public UserData(string name, string level, string mode, string right, string wrong, string timeans)
        {
            UserName = name;
            LevelName = level;
            Mode = mode;
            CorrectRate = right;
            WrongAnswer = wrong;
            TimeAnswer = timeans;
        }

    }
}
