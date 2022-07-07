using System;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace BaseLoader
{
    class Hacks : MonoBehaviour
    {
        public static Camera MainCamera = null;
        public static float Timer = 0f;


        public void start()
        {
            
        }

        public void update()
        {
            if (Input.GetKeyDown(KeyCode.End)) // Kill hacks on "End" key pressed
            {
                Loader.unload();
            }

            // 5 Second timer to loop entities and objects to return to lists
            Timer += Time.deltaTime; 
            if (Timer >= 5f) 
            {
                Timer = 0f;

                MainCamera = Camera.main;
 
            }


            
        }

        public void OnGUI()
        {
            
        }

        public void DrawESP(Vector3 objfootPos, Vector3 objheadPos, Color objColor, String name)
        {
            //Draw Basic ESP Method from Vector3 W2S input
            float height = objheadPos.y - objfootPos.y;
            float widthOffset = 2f;
            float width = height / widthOffset;

            Render.DrawString(new Vector2(objfootPos.x - (width / 2), (float)Screen.height - objfootPos.y - height), $"{name}");
            GUI.Label(new Rect(objfootPos.x - (width / 2), (float)Screen.height - objfootPos.y - height, width, height), name);
        }

    }
}
