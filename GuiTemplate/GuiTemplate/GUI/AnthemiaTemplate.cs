using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using GorillaNetworking;
using Photon.Pun;
using UnityEngine;
using static OVRPlugin;

namespace GuiTemplate
{
    [BepInPlugin("Lucian.Template","Template","1.0.0")]
    public class AnthemiaTemplate : BaseUnityPlugin
    {
        public string GUIName = "Template";
        private Color guiColor = Color.blue;
        private float colorTimer = 0f;
        private Rect windowRect = new Rect(60, 20, 500, 500);//Size of GUI
        public string GUIText = "On";
        void Update()//all RGB stuff
        {
            float r = Mathf.Abs(Mathf.Sin(colorTimer * 0.4f));
            float g = Mathf.Abs(Mathf.Sin(colorTimer * 0.5f));
            float b = Mathf.Abs(Mathf.Sin(colorTimer * 0.6f));
            guiColor = new Color(r, g, b);
            colorTimer += Time.deltaTime;
        }
        public void Start()
        {
            ColorUtility.TryParseHtmlString("#ffc1cc", out color1);//uses hex codes
            ColorUtility.TryParseHtmlString("#98FF98", out color2);
        }
        public bool youturnnedmeon = false;

        void OnGUI()
        {
            GUI.backgroundColor = guiColor;
            GUI.color = guiColor;
            if (GUI.Button(new Rect(20, 20, 100, 20), GUIText))
            {
                if (youturnnedmeon == false)
                {
                    GUIText = "Disable";
                    youturnnedmeon = true;
                }
                else
                {
                    GUIText = "Enable";
                    youturnnedmeon = false;
                }
            }
            if (youturnnedmeon)
            {
                windowRect = GUI.Window(10000, windowRect, MainGUI, GUIName);//opens GUI
            }
        }
        public int PageNum;
        public Color color1;
        public Color color2;
        public string Codetojoin = "";
        void MainGUI(int windowID)
        {
            GUI.contentColor = color1;//sets text color
            GUI.backgroundColor = color2;//sets button color
            //GUI.Color <- that sets every color
            int PageNumlol = PageNum + 1;//the real page number
            GUI.Label(new Rect(230, 20, 200, 20), "Page: " + PageNumlol);//page label
            switch (PageNum)
            {
                case 0://Page 1//



                    //Collum 1//
                    Codetojoin = GUI.TextArea(new Rect(20, 50, 100, 20), Codetojoin);
                    if (GUI.Button(new Rect(20, 80, 100, 20), "Join"))
                    {
                        PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(Codetojoin);
                    }

                    if (GUI.Button(new Rect(20, 110, 100, 20), "Join Random"))
                    {
                        PhotonNetwork.JoinRandomRoom();
                    }






                    //Collum 2//
                    if (GUI.Button(new Rect(200, 50, 100, 20), "Disconect"))
                    {
                        PhotonNetwork.Disconnect();
                    }

                    if (GUI.Button(new Rect(200, 80, 100, 20), "PlaceHolder"))
                    {

                    }

                    if (GUI.Button(new Rect(200, 110, 100, 20), "PlaceHolder"))
                    {

                    }




                    //Collum 3//
                    if (GUI.Button(new Rect(390, 50, 100, 20), "PlaceHolder"))
                    {

                    }

                    if (GUI.Button(new Rect(390, 80, 100, 20), "PlaceHolder"))
                    {

                    }

                    if (GUI.Button(new Rect(390, 110, 100, 20), "PlaceHolder"))
                    {

                    }



                    if (GUI.Button(new Rect(0, 450, 500, 20), ">>>>>>>"))//forward
                    {
                        PageNum++;
                    }
                    break;
                case 1://Page 2//






                    //Collum 1//
                    if (GUI.Button(new Rect(20, 50, 100, 20), "PlaceHolder"))
                    {

                    }
                    if (GUI.Button(new Rect(20, 80, 100, 20), "PlaceHolder"))
                    {

                    }

                    if (GUI.Button(new Rect(20, 110, 100, 20), "PlaceHolder"))
                    {

                    }






                    //Collum 2//
                    if (GUI.Button(new Rect(200, 50, 100, 20), "PlaceHolder"))
                    {

                    }

                    if (GUI.Button(new Rect(200, 80, 100, 20), "PlaceHolder"))
                    {

                    }

                    if (GUI.Button(new Rect(200, 110, 100, 20), "PlaceHolder"))
                    {

                    }




                    //Collum 3//
                    if (GUI.Button(new Rect(390, 50, 100, 20), "PlaceHolder"))
                    {

                    }

                    if (GUI.Button(new Rect(390, 80, 100, 20), "PlaceHolder"))
                    {

                    }

                    if (GUI.Button(new Rect(390, 110, 100, 20), "PlaceHolder"))
                    {

                    }




                    if (GUI.Button(new Rect(0, 450, 500, 20), ">>>>>>>"))//forward
                    {
                        PageNum++;
                    }
                    if (GUI.Button(new Rect(0, 470, 500, 20), "<<<<<<<"))//Backward
                    {
                        PageNum--;
                    }
                    break;
                case 2://Page 3//





                    //Collum 1//
                    if (GUI.Button(new Rect(20, 50, 100, 20), "PlaceHolder"))
                    {

                    }
                    if (GUI.Button(new Rect(20, 80, 100, 20), "PlaceHolder"))
                    {

                    }

                    if (GUI.Button(new Rect(20, 110, 100, 20), "PlaceHolder"))
                    {

                    }






                    //Collum 2//
                    if (GUI.Button(new Rect(200, 50, 100, 20), "PlaceHolder"))
                    {

                    }

                    if (GUI.Button(new Rect(200, 80, 100, 20), "PlaceHolder"))
                    {

                    }

                    if (GUI.Button(new Rect(200, 110, 100, 20), "PlaceHolder"))
                    {

                    }




                    //Collum 3//
                    if (GUI.Button(new Rect(390, 50, 100, 20), "PlaceHolder"))
                    {

                    }

                    if (GUI.Button(new Rect(390, 80, 100, 20), "PlaceHolder"))
                    {

                    }

                    if (GUI.Button(new Rect(390, 110, 100, 20), "PlaceHolder"))
                    {

                    }




                    if (GUI.Button(new Rect(0, 470, 500, 20), "<<<<<<<"))//Backward
                    {
                        PageNum--;
                    }

                    break;

            }
            GUI.DragWindow();
        }
    }
}
