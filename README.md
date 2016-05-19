<h1>Simple-Curve-Class-For-Unity</h1>

<p>A super simple curve class with its own inspector window.
Idea being you can feed in a percentage value and get a curve value at that percentage point.<br>
A use case would be, instead of moving toward an object at a consistent speed, you can manually edit its speed based on its distance(percentage) to its target.<br>
OR<br>
Change the difficulty of a game based on what level the player is on. Instead of a linear difficulty (0f to 1f), you can manually edit the difficulty with a curve. 

</p>
![screenshot](https://raw.githubusercontent.com/DaveSapien/Simple-Bounce-class-for-Unity-GameObjects/master/Screen-Shot.jpg)
<p>

Setup: 
Place the scripts into you project, make sure CurveManagerEditor.cs is in your "Editor" folder(or just use the one here).<p>
//---------------------------------------------------------------------------------------------<p>
//---------------------------------------------------------------------------------------------<p>
To use:
You will need two scripts to use this, the CurveManager.cs script and your own script that calls CurveManager. An example script (CurveManagerExample.cs) is provided.</p>

<p>1). Drag CurveManager.cs into your object and name it in the "name" field. You will need this later in your own script.</p>

<p>2). Drag your script into the game object (or CurveManagerExample.cs).</p>

<p>3). Edit the curve in the inspector, and call the curve value ( getCurve() ) as shown in CurveManagerExample.cs from your own script</p>

<p>4). Done.<p>
//---------------------------------------------------------------------------------------------<br>
//---------------------------------------------------------------------------------------------<p>


