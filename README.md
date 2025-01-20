# NeuroXR_API_Unity
This is an API for communication between Unity project and NeuroXR software. (Get NeuroXR software: https://www.neuroxr.io/get-started)<br />

It contains two folders:<br />
Unity_Plugins -> contents that need to be added to your Unity project<br />
sample -> a Unity project shows you how to apply the API in Unity<br />

## How to use the API<br />
1. In your Unity project, create a two folders "Editor" and "Plugins", if you don't have them in your Assets folder.<br />
2. Put [CustomInspector.cs](https://github.com/neuroxr/NeuroXR_API_Unity_Release/blob/1b29f358e85b84684d565de240e9741e28a26cb4/Unity_Plugins/CustomInspector.cs) into the Editor folder.<br />
3. Put [NeuroXR_API_Unity.dll](https://github.com/neuroxr/NeuroXR_API_Unity_Release/blob/1b29f358e85b84684d565de240e9741e28a26cb4/Unity_Plugins/NeuroXR_API_Unity.dll) and [SuperSimpleTcp.dll](https://github.com/neuroxr/NeuroXR_API_Unity_Release/blob/1b29f358e85b84684d565de240e9741e28a26cb4/Unity_Plugins/SuperSimpleTcp.dll) into the Plugins folder.<br />
4. Create a GameObject in Unity and add the .cs file in NeuroXR_API_Unity.dll to it. Now you should be able to see this in the inspector: <br />
![7646623ce14646a2dec5650c6332129](https://github.com/user-attachments/assets/bd340027-071b-4bbd-a54e-bc5d8c4ff889)
5. Follow the instructions in the inspector to set necessary stuffs and connect with NeuroXR software.
