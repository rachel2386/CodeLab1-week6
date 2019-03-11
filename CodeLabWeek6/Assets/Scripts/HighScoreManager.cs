using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class HighScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<string> hsNames;
    public List<int> hsScores;
    int num = 10;
    void Start()
    {
        string filePath = Application.dataPath + "/highScore.txt";
        if (!File.Exists(filePath))
        {
            string output = "";
            
            for (int i = 0; i < num; i++)
            {
                output += "Matt:" + (10-i) + '\n';
            }
            Debug.Log("output" + output);
            File.WriteAllText(filePath,output);
           // output = "Matt:10\nMatt:9"; // \n to create new line 
        }

        string[] inputLines = File.ReadAllLines(filePath); //read by \n
        for (int i = 0; i < inputLines.Length; i++)
        {
            string line = inputLines[i]; // "Matt:10"
            string[] splitLine = line.Split(':');// "Matt" | "10"
            string name = splitLine[0];//"Matt"
            int score = Int32.Parse(splitLine[1]);
            hsNames.Add(name); //put name in my list of names
            hsScores.Add(score);
            

        }


    }

// Update is called once per frame
    void Update()
    {
        
    }
}
