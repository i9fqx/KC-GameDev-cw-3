using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day3 : MonoBehaviour
{
    //hero stuff
string HeroName = "Aizen";
int HeroPower = 85;


//Villain stuff
string VillainName = "Black Goku";
int VillainPower = 100;

float playerspeed = 3.5f; 
    // Start is called before the first frame update
    void Start()
    {
      if (HeroPower > VillainPower) 
        {
        print (HeroName + " is stronger than Villain power ");
        }
        else if (HeroPower == VillainPower)
        {
                print(HeroName + " equals " + VillainName);
            
        }
        else 
        
        {print(VillainName + "is stronger than Hero ");}
      setspeed(2.5f);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
                void setspeed(float speed) {
            
             print(playerspeed);
             playerspeed = speed;
             print(playerspeed);
            
         }
}

//teacher taleb on top !!!!!! and teacher talal on top !!!!!!
//teacher taleb on top !!!!!! and teacher talal on top !!!!!!
//teacher taleb on top !!!!!! and teacher talal on top !!!!!!
//teacher taleb on top !!!!!! and teacher talal on top !!!!!!
//teacher taleb on top !!!!!! and teacher talal on top !!!!!! 
//teacher taleb on top !!!!!! and teacher talal on top !!!!!!
//teacher taleb on top !!!!!! and teacher talal on top !!!!!!
//teacher taleb on top !!!!!! and teacher talal on top !!!!!!




         
        

       

 









