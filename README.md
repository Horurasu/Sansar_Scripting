# SANSAR 

## CONTENT TABLE

- 1.- [INTRODUCTION](#INTRODUCTION) 
	- 1.1.- [WHAT IS SANSAR](#WHAT-IS-SANSAR)
	- 1.2.- [WHY PROGRAMMING IN C# LANGUAGE](#WHY-PROGRAMMING-IN-CSHARP-LANGUAGE)
- 2.- [INTRODUCTION TO PROGRAMMING](#INTRODUCTION-TO-SANSAR-PROGRAMMING)|
	- 2.1.- [VISUAL STUDIO CODE CONFIGURATION](#VISUAL-STUDIO-CODE-CONFIG)
	- 2.2.- [BASIC CONCEPTS](#BASIC-CONCEPTS)
	    - 2.2.1- [SANSAR NAMESPACES OR LIBRARIES](#SANSAR-NAMESPACES-OR-LIBRARIES)
	    - 2.2.1- [AGENTPRIVATE AND AGENTPUBLIC](#AGENTPRIVATE-AND-AGENTPUBLIC)
	    - 2.2.1- [CLASSES](#CLASSES)
	    - 2.2.1- [VARIABLES](#VARIABLES)
	    - 2.2.1- [EDITOR PROPERTIES](#EDITOR-PROPERTIES)
	    - 2.2.1- [METHODS](#METHODS)
	    - 2.2.1- [SCRIPT STRUCTURE](#SCRIPT-STRUCTURE)



# INTRODUCTION

> If you're interested in creating interactive experiences in Sansar, scripting is an essential skill to learn. Scripts allow us to make interactive and reactive content in Sansar. They are written in C# and are designed to be easy to use, even for beginners. Whether you're looking to create a simple interactive object or a complex game, scripting is the key to unlocking the full potential of Sansar. In this guide, we'll cover the basics of scripting in Sansar, including how to use the Script API, how to create triggers, and how to test and refine your scripts. By the end of this guide, you'll have the knowledge and skills you need to start creating your own custom behaviors and interactive experiences in Sansar.


 [` ▲ BACK TO TOP` ](#SANSAR)

## WHAT IS SANSAR

Sansar is a 3D virtual world platform developed by Linden Lab, the same company that created Second Life. 

> <p style="text-align: justify;">The platform allows users to create and explore virtual worlds, interact with other users, and participate in live events. Sansar describes itself as a social virtual reality platform, where users can create their own avatars and customize their experience in the virtual world. The platform supports virtual reality headsets such as the Oculus Rift and HTC Vive, as well as desktop browsing. Sansar also offers content creation tools so users can design and build their own virtual worlds. The platform launched in 2017 and has been described as the "heir" to Second Life.</p>

<SUB> [` ▲ BACK TO TOP` ](#SANSAR) </SUB>

## WHY PROGRAMMING IN CSHARP LANGUAGE

<p style="text-align: justify;"> Sansar uses `C#`  as a programming language to create scripts that control the behavior of objects in the virtual world. C# is a modern, secure, object-oriented programming language (OOP) developed by Microsoft. C# is a high-level language used in the development of Windows apps, web apps, games, mobile apps, and more. C# is easy to learn and powerful, offering a wide variety of built-in data types, as well as the ability to create custom data types. C# is also compatible with Microsoft's .NET platform, allowing developers to build applications that run on a wide variety of devices and operating systems. In short, Sansar uses C# as its programming language because of its ease of use, its security, and its ability to create high-quality and scalable applications. </p>

> The `File` where you write your script should have the extension  `.cs` , this means that is a C# file and can be import to sansar:   `MySansarScript.cs`

If you already have a Script for Sansar you can jump to the [import](#IMPORT) part to upload you script to sansar.

<SUB> [` ▲ BACK TO TOP` ](#SANSAR) </SUB>

# INTRODUCTION TO SANSAR PROGRAMMING 

## VISUAL STUDIO CODE CONFIG

The IDE that work better to write scripts for Sansar is VsCode to write script with sansar, you can follow the guide in the next link.

||Link|
|-|-|
|Config Visual Studio Code|[EvoAv/VsCodeConfig](https://github.com/darwinrecreant/sansar-scripting-guide/blob/master/docs/vscode.md)|
    
<em>*The references guides is not our authorship</em>

<SUB> [` ▲ BACK TO TOP` ](#SANSAR) </SUB>

## BASIC CONCEPTS

The basics of programming in Sansar are similar to those of any other programming language. Some of these concepts include:

- `Variables:` Variables are containers that store values, such as numbers or text strings. In Sansar, variables can be used to store information about the virtual world, such as the position of an object or the state of an avatar.

- `Functions:` Functions are blocks of code that perform a specific task. In Sansar, functions can be used to control the behavior of objects in the virtual world, such as the response of an object when it is clicked.

- `Events:` Events are actions that occur in the virtual world, such as clicking on an object or moving an avatar. In Sansar, events can be used to trigger features and control the behavior of objects in response to user actions.

- `Control Structures:` Control structures are blocks of code that control the flow of execution of a program. In Sansar, control structures can be used to control the behavior of objects in response to user actions.

In short, the basics of programming in Sansar include variables, functions, events, and control structures. These concepts are fundamental to the creation of Sansar scripts that control the behavior of objects in the virtual world.

<SUB> [` ▲ BACK TO TOP` ](#SANSAR) </SUB>


### SANSAR NAMESPACES OR LIBRARIES

> The first part of the structure of the code is the references to the libraries that the script need to work that are the following (because if we don´t have one of them in the script, at the compiling moment can not identify some functions or similar):

```csharp
//The more common are:

using Sansar;
using Sansar.Script;
using Sansar.Simulation;


//There are others namespaces, some of them are:

using Sansar.Testing;
using Sansar.Utility;

using System.Collections.Generic;
using System;


```

- `Sansar library include:`

|Sansar||
|-|-|
|`Mathf`|The main Sansar namespace includes the base math constants and functions in Mathf and a few types for working with colors (Color), rotations (Quaternion) and vectors (Vector).|
|`Color`|This is a type that is used for working with colors. It represents a color in RGBA format, where each component is a float value between 0 and 1. It includes methods for creating, modifying, and comparing colors|
|`Quaternion`|This is a type that is used for working with rotations. It represents a rotation in 3D space as a four-component vector. It includes methods for creating, modifying, and applying rotations|
|`Vector`|This is a type that is used for working with vectors. It represents a vector in 3D space as a three-component vector. It includes methods for creating, modifying, and performing operations on vectors, such as dot product and cross product|

- `Sansar.Script library include:`

|Sansar.Script||
|-|-|
|`Log.Write`|Show messages in the console of sansar (open the console: Ctrl + D).|
|`ComponentId `|Component that identify a part of and object|
|`ObjectId`|Component that identify an object|
|`SessionId `|Component that identify a user that enter to the experience|
|`ICoroutine `|State-machine-style functions that can be suspended, resumed, and executed cooperatively by yielding|
|`Timer `|Time for an event or events.|

- `Sansar.Simulation library include:`

|Sansar.Simulation||
|-|-|
|`AgentPrivate `|Used to store text or a sequence of characters.|
|`AgentPrivate.Client`|Used to store integer numbers|
|`AgentPrivate.Client.UI.ModalDialog`|Used to store Boolean values (true or false)|
|`ObjectPrivate`|Used to store floating-point numbers (which approximate real numbers)|
|`ObjectPrivate.Mover`|Used to store a position or direction in three-dimensional space|
|`ScenePrivate`|Used to store an orientation in three-dimensional space.|
|`ScenePrivate.Chat`|This component allows scripts to send chat messages to the chat window in the Sansar client.|
|`AnimationComponent`|This component allows scripts to control animations on objects in the scene. It provides methods for playing, stopping, and pausing animations.|
|`AudioComponent`|This component allows scripts to play sounds and music in the scene. It provides methods for playing, stopping, and pausing audio.|
|`LightComponent`|This component allows scripts to control lights in the scene. It provides methods for turning lights on and off, changing their color and intensity, and setting their position and rotation.|
|`RigidBodyComponent`|This component allows scripts to control the physics of objects in the scene. It provides methods for applying forces and torques to objects, as well as setting their mass and friction.|

Here is included one more important: 

### SceneObjectScript

This class is the base class for all scripts that are attached to objects in the scene. It provides access to the object that the script is attached to, as well as other components that are attached to the object.

<SUB> [` ▲ BACK TO TOP` ](#SANSAR) </SUB>

### AGENTPRIVATE AND AGENTPUBLIC

> In Sansar scripting, there are two classes for interacting with avatars in the scene: `AgentPrivate` and `AgentPublic`. Here are the differences and uses of each:

- `AgentPrivate`: This is the main class for interacting with avatars visiting your scene. It provides access to the avatar's position, hand positions, and other information. It can also be used to play sounds, send direct messages, and handle input. The AgentInfo struct includes the unique AvatarUuid to identify a player. The `AgentPrivate` class is used for interactions that should only be visible to the avatar performing the action, such as playing a sound effect when the avatar presses a button.

- `AgentPublic`: This class is used for interactions that should be visible to all avatars in the scene. It provides access to the avatar's position, but not to their hand positions or other private information. It can be used to broadcast messages, play sounds, and handle input. The `AgentPublic` class is used for interactions that should be visible to all avatars in the scene, such as playing music that all avatars can hear.

Overall, the `AgentPrivate` and `AgentPublic` classes are used to interact with avatars in different ways depending on the desired visibility of the interaction. If you want to learn more about Sansar scripting, you can check out the resources in

<SUB> [` ▲ BACK TO TOP` ](#SANSAR) </SUB>

### CLASSES

The next part that we can see are the `Classes` where we can have more than one class where extend [SceneObjectScript](#SceneObjectScript) to create a script that can be used on content that is natively in the scene. This is the primary script type in Sansar.

```csharp
public class ClassNumber1 : SceneObjectScript
{   

}


public class ClassNumber2 : SceneObjectScript
{   

}
```
<SUB> [` ▲ BACK TO TOP` ](#SANSAR) </SUB>

### VARIABLES

> In the classes we have a region that we can add or not where we declare the variable of the script, we have two types of variables `PUBLIC` and `PRIVATE` where depending which we choose, this can let change the content of the variable in the Sansar editor or not.

- `Private`:  A private variable is a variable that is only visible and accessible within the class in which it is declared.
 
- `Public`:  A public variable is a variable that is visible and accessible to all classes and scripts in the scene.

|Variable Types||Example|
|-|-|-|
|`string`|Used to store text or a sequence of characters.|text|
|`int`|Used to store integer numbers|5|
|`bool`|Used to store Boolean values (true or false)|true|
|`float`|Used to store floating-point numbers (which approximate real numbers)|1.5f|
|`Vector`|Used to store a position or direction in three-dimensional space|Vector.Up|
|`Quaternion`|Used to store an orientation in three-dimensional space.|Quaternion.FromAngleAxis()|
|`Interaction`|This is a variable that is used to represent an interaction between objects in the scene. It can be used to trigger events or actions when objects come into contact with each other.|MyInteraction|
|`ClusterResource`|This is a variable that is used to represent a resource that is shared among multiple objects in the scene. It can be used to store data or assets that are used by multiple objects.|MyInteraction|
|`SoundResource`|This is a variable that is used to represent a sound that is played in the scene. It can be used to play music or sound effects in response to events or actions.|MyInteraction|

````csharp
public class Variables : SceneObjectScript
{   
    #region EditorProperties

        private string Message1= "hello1";

        public string Message2= "hello2";

    #endregion
}
````

<SUB> [` ▲ BACK TO TOP` ](#SANSAR) </SUB>

### EDITOR PROPERTIES

> For the variables we have some `parameters` that we can use to show in the editor, this properties work with the public variable mostly because we change the publics in the editor:

|Variable Properties||
|-|-|
|`Tooltip`|Show a message that can help the person what have to do with that variable in the editor or what do |
|`DisplayName`|Show a message, that refers about what is the variable |
|`DefaultValue`|Give the variable a default value (this one can change with the type of variable, can be variables of character or numerical) |
|`Range`|Is used to specify a range of values that a variable can take |


````csharp
  [Tooltip("Help Message")] 
  
  [DisplayName("My Variable")] 
  
  [DefaultValue("Hello")]

  [Range(-2.0f, 2.0f)]
````
<SUB> [` ▲ BACK TO TOP` ](#SANSAR) </SUB>

### METHODS

> In each class that we have in the script we have to add a function void called `Init()`. We have to do this because wen the script is read, the first things that is search is the void init() because that mean with what the script starts.

````csharp
public override void Init()
{
    
}
````

<SUB> [` ▲ BACK TO TOP` ](#SANSAR) </SUB>

### SCRIPT STRUCTURE


With all of the part above we have the most basic initial structure of a script for sansar, can resume a simple script structure like this

````csharp
using Sansar;
using Sansar.Script;
using Sansar.Simulation;

public class CodeStructure : SceneObjectScript
{
    #region EditorProperties

    
    #endregion

    public override void Init()
    {
        
    }

}
````
<SUB> [` ▲ BACK TO TOP` ](#SANSAR) </SUB>
















## IMPORT

When we have a script for sansar in `.cs` we already can import it to the scene, at the top we have the window `Scene` where we have options like:

<img
  src="/Images/ImagensGithubMenuOptionImport.png"
  alt="Alt text"
  title="Optional title"
  style="display: inline-block; margin: 0 auto; max-width: 300px">
  

- ABOUT THIS SCENE - TOOLS - `IMPORT` - VISIBILITY - OPTIONS - CAMERAS

The option that we need is `import` , this option will show a windows name as `Import Script` where we can choose the script from the docs and we can give it a name for the inventory

> We can import files with the extension `.CS` and `.JSON`

## FUNCTION LOG 

We can use the function `Log.Write()` to show information, messages, errors in the console to corroborate that work correctly. we can see it in the next example

|Log Types||
|-|-|
|`Log.Write("");`|Show a message in Default Color|
|`Log.Write(LogLevel.Warning, "");`|Show a message in Yellow Color|
|`Log.Write(LogLevel.Error, "");`|Show a message in Red Color|

````csharp
using Sansar;
using Sansar.Script;
using Sansar.Simulation;

//In the code we will declare two variables, one public and one private to print the information in the log of sansar

public class LogMessage : SceneObjectScript
{/
    #region EditorProperties

        //Public Variables
            [Tooltip("Help Message")] 
            [DisplayName("My Variable")]
            [DefaultValue("Hello Public")]
            public string Public = "";

        //Private Variables
            
            private string  Private= "Hello Private";
    
    #endregion

    public override void Init()
    {
        Log.Write(Public);

        Log.Write(Private);

        Log.Write("Message send to the log");

        Log.Write(LogLevel.Warning, "Warning message log");

        Log.Write(LogLevel.Error, "Error message log");
    }
}
````

<SUB> [` ▲ BACK TO TOP` ](#SANSAR) </SUB>










# OTHER LINKS

||Links|
|-|-|
|Sansar script guide|[EvoAv/ScriptGuide](https://github.com/darwinrecreant/sansar-scripting-guide)|

<em>*The references guides is not our authorship</em>


