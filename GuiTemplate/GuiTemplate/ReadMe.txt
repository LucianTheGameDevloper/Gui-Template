===== Buttons ======
if (GUI.Button(new Rect(20, 20, 100, 20), "Button name"))
{
//what you want the button to do
}
just copy that and foreach button you have on the page just do this 
new Rect(20, 20 + 30, 100, 20)

for example if you have 3 buttons on the page it would look like this
new Rect(20, 20 + 30 + 30 + 30, 100, 20)
or you can do math and figure it out you skidder



===== Toggles ======
same thing as a button just create a bool

public bool toggleshowcase = false;
public void MainGUI(int WindowID)
{
toggleshowcase = GUI.Toggle(new Rect(20, 20, 100, 20), "Toggle show case");
if (toggleshowcase)
{
// do the code on repeat
}
}
just copy that and foreach Toggle you have on the page just do this 
new Rect(20, 20 + 30, 100, 20)

for example if you have 3 Toggles on the page it would look like this
new Rect(20, 20 + 30 + 30 + 30, 100, 20)
or you can do math and figure it out you skidder



this readme.txt is made by athema bbg