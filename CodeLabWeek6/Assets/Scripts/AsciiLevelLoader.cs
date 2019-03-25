using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.SceneManagement;

public class AsciiLevelLoader : MonoBehaviour
{
    private string filePath;
    // Start is called before the first frame update
    void Start()
    {
        filePath = Application.dataPath + "/level0.txt";
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath,"X");
        }
        
        string[] inputLines = File.ReadAllLines(filePath);
        
        for (int y = 0; y < inputLines.Length; y++)
        {
            string line = inputLines[y];
           for (int x= 0; x <line.Length; x++)
           {
            
//               if (line[x] == 'X')
//               {
//                    GameObject newWall = Instantiate(Resources.Load("Wall") as GameObject);
//                   newWall.transform.position = new Vector2(x-line.Length/2, (inputLines.Length/2 - y));
//                  
//               }
//               if (line[x] == 'P')
//               {
//                   GameObject newPlayer = Instantiate(Resources.Load("Player") as GameObject);
//                   newPlayer.transform.position = new Vector2(x-line.Length/2, (inputLines.Length/2 - y));
//                  
//               }
//               if (line[x] == 'T')
//               {
//                   GameObject newTrap = Instantiate(Resources.Load("Trap") as GameObject);
//                   newTrap.transform.position = new Vector2(x-line.Length/2, (inputLines.Length/2 - y));
//                  
//               }
//               if (line[x] == 'G')
//               {
//                   GameObject newGoal = Instantiate(Resources.Load("Goal") as GameObject);
//                   newGoal.transform.position = new Vector2(x-line.Length/2, (inputLines.Length/2 - y));
//                  
//               }

               GameObject tile;
               switch (line[x])
               {
                   case'X':
                      tile = Instantiate(Resources.Load("Wall") as GameObject);
                       break;
                   case'P':
                       tile =Instantiate(Resources.Load("Player") as GameObject);
                       break;
                   case'G':
                       tile =Instantiate(Resources.Load<GameObject>("Goal") );
                       break;
                   case'T':
                       tile =  Instantiate(Resources.Load<GameObject>("Trap"));
                       break;
                   case'M':
                       tile =  Instantiate(Resources.Load<GameObject>("MovingTrap"));
                       break;
                   default:
                       tile = null;
                       break;
                       
               }

               if (tile != null)
               {
                   tile.transform.position = new Vector2(x-line.Length/2, (inputLines.Length/2 - y));
               }

           }
        }
        
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
            SceneManager.LoadScene(0);
    }

    
}
