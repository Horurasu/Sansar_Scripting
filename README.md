<img
  src="/Images/SANSARLOGO.png"
  alt="image"
  title="Menu"
  style="display: inline-block; margin: 0 auto; max-width: 300px">
  
<h1 align="center"> SANSAR GUIDE  </h1> 

## CONTENT TABLE

- 1.- [INTRODUCTION](#INTRODUCTION) 
	- 1.1.- [WHAT IS SANSAR](#WHAT-IS-SANSAR)
	- 1.2.- [WHY PROGRAMMING IN C# LANGUAGE](#WHY-PROGRAMMING-IN-CSHARP-LANGUAGE)
- 2.- [INTRODUCTION TO PROGRAMMING](#INTRODUCTION-TO-SANSAR-PROGRAMMING)
	- 2.1.- [VISUAL STUDIO CODE CONFIGURATION](#VISUAL-STUDIO-CODE-CONFIG)
	- 2.2.- [BASIC CONCEPTS](#BASIC-CONCEPTS)
	    - 2.2.1- [SANSAR NAMESPACES OR LIBRARIES](#SANSAR-NAMESPACES-OR-LIBRARIES)
	    - 2.2.2- [AGENTPRIVATE AND AGENTPUBLIC](#AGENTPRIVATE-AND-AGENTPUBLIC)
	    - 2.2.3- [CLASSES](#CLASSES)
	    - 2.2.4- [VARIABLES](#VARIABLES)
	    - 2.2.5- [EDITOR PROPERTIES](#EDITOR-PROPERTIES)
	    - 2.2.6- [METHODS](#METHODS)
	    - 2.2.7- [SCRIPT STRUCTURE](#SCRIPT-STRUCTURE)
- 3.- [START TO PROGRAMMING](#START-TO-PROGRAMMING)
	- 3.1.- [IMPORT](#IMPORT)
  - 3.2.- [ADD A SCRIPT TO AN OBJECT](#ADD-A-SCRIPT-TO-AN-OBJECT)
  - 3.3.- [FUNCTION LOG](#FUNCTION-LOG)
  	  - 3.3.1- [CREATE A DEBUGGER](#CREATE-A-DEBUGGER)
  - 3.4.- [MY INTERACTION PROPERTY](#MY-INTERACTION)
  - 3.5.- [TAG NAME](#TAG-NAME)







### OTHER LINKS

||Links|
|-|-|
|Sansar script guide|[EvoAv/ScriptGuide](https://github.com/darwinrecreant/sansar-scripting-guide)|
|Sansar script guide|[MojoD/ScriptGuide](https://github.com/mojoD/sansar-script)|

<em>*The references guides is not our authorship</em>


# INTRODUCTION

> If you're interested in creating interactive experiences in Sansar, scripting is an essential skill to learn. Scripts allow us to make interactive and reactive content in Sansar. They are written in C# and are designed to be easy to use, even for beginners. Whether you're looking to create a simple interactive object or a complex game, scripting is the key to unlocking the full potential of Sansar. In this guide, we'll cover the basics of scripting in Sansar, including how to use the Script API, how to create triggers, and how to test and refine your scripts. By the end of this guide, you'll have the knowledge and skills you need to start creating your own custom behaviors and interactive experiences in Sansar.


 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

## WHAT IS SANSAR

Sansar is a 3D virtual world platform developed by Linden Lab, the same company that created Second Life. 

> <p style="text-align: justify;">The platform allows users to create and explore virtual worlds, interact with other users, and participate in live events. Sansar describes itself as a social virtual reality platform, where users can create their own avatars and customize their experience in the virtual world. The platform supports virtual reality headsets such as the Oculus Rift and HTC Vive, as well as desktop browsing. Sansar also offers content creation tools so users can design and build their own virtual worlds. The platform launched in 2017 and has been described as the "heir" to Second Life.</p>

 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

## WHY PROGRAMMING IN CSHARP LANGUAGE

<p style="text-align: justify;"> Sansar uses `C#`  as a programming language to create scripts that control the behavior of objects in the virtual world. C# is a modern, secure, object-oriented programming language (OOP) developed by Microsoft. C# is a high-level language used in the development of Windows apps, web apps, games, mobile apps, and more. C# is easy to learn and powerful, offering a wide variety of built-in data types, as well as the ability to create custom data types. C# is also compatible with Microsoft's .NET platform, allowing developers to build applications that run on a wide variety of devices and operating systems. In short, Sansar uses C# as its programming language because of its ease of use, its security, and its ability to create high-quality and scalable applications. </p>

> The `File` where you write your script should have the extension  `.cs` , this means that is a C# file and can be import to sansar:   `MySansarScript.cs`

If you already have a Script for Sansar you can jump to the [import](#IMPORT) part to upload you script to sansar.

 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

# INTRODUCTION TO SANSAR PROGRAMMING 

## VISUAL STUDIO CODE CONFIG

The IDE that work better to write scripts for Sansar is VsCode to write script with sansar, you can follow the guide in the next link.

||Link|
|-|-|
|Config Visual Studio Code|[EvoAv/VsCodeConfig](https://github.com/darwinrecreant/sansar-scripting-guide/blob/master/docs/vscode.md)|
    
<em>*The references guides is not our authorship</em>

 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

## BASIC CONCEPTS

The basics of programming in Sansar are similar to those of any other programming language. Some of these concepts include:

- `Variables:` Variables are containers that store values, such as numbers or text strings. In Sansar, variables can be used to store information about the virtual world, such as the position of an object or the state of an avatar.

- `Functions:` Functions are blocks of code that perform a specific task. In Sansar, functions can be used to control the behavior of objects in the virtual world, such as the response of an object when it is clicked.

- `Events:` Events are actions that occur in the virtual world, such as clicking on an object or moving an avatar. In Sansar, events can be used to trigger features and control the behavior of objects in response to user actions.

- `Control Structures:` Control structures are blocks of code that control the flow of execution of a program. In Sansar, control structures can be used to control the behavior of objects in response to user actions.

In short, the basics of programming in Sansar include variables, functions, events, and control structures. These concepts are fundamental to the creation of Sansar scripts that control the behavior of objects in the virtual world.

 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)


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

 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

### AGENTPRIVATE AND AGENTPUBLIC

> In Sansar scripting, there are two classes for interacting with avatars in the scene: `AgentPrivate` and `AgentPublic`. Here are the differences and uses of each:

- `AgentPrivate`: This is the main class for interacting with avatars visiting your scene. It provides access to the avatar's position, hand positions, and other information. It can also be used to play sounds, send direct messages, and handle input. The AgentInfo structure includes the unique AvatarUuid to identify a player. The `AgentPrivate` class is used for interactions that should only be visible to the avatar performing the action, such as playing a sound effect when the avatar presses a button.

- `AgentPublic`: This class is used for interactions that should be visible to all avatars in the scene. It provides access to the avatar's position, but not to their hand positions or other private information. It can be used to broadcast messages, play sounds, and handle input. The `AgentPublic` class is used for interactions that should be visible to all avatars in the scene, such as playing music that all avatars can hear.

Overall, the `AgentPrivate` and `AgentPublic` classes are used to interact with avatars in different ways depending on the desired visibility of the interaction. If you want to learn more about Sansar scripting, you can check out the resources in

 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

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
 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

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

 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

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
 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

### METHODS

> In each class that we have in the script we have to add a function void called `Init()`. We have to do this because wen the script is read, the first things that is search is the void init() because that mean with what the script starts.

````csharp
public override void Init()
{
    
}CREATE A DEBUGGER
````

 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

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


 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

# START TO PROGRAMMING 

To start we can see something before to start, when sansar is installed we can find in the documents some examples that we can use to see how some functions work, we can find them in (only  if we have sansar installed in the default route): 

> `C:\Program Files\Sansar\Client\ScriptApi\Examples`

You can make a copy of the `Folder`to create our WorkSpace where we will make our scripts.

 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

## IMPORT

> The first STEP is create and enter in a world

In Sansar we have in the left a menu, where have several options, here we have a `Magical Wand` that say `Create`

<img
  src="/Images/ImagensGithubMenu.png"
  alt="image"
  title="Menu"
  style="display: inline-block; margin: 0 auto; max-width: 300px">

That shows a window named  `My Worlds`

<img
  src="/Images/ImagensGithubWorldCreation.png"
  alt="image"
  title="MenuWorldCreation"
  style="display: inline-block; margin: 0 auto; max-width: 300px">

If you already have worlds or is the first one, you can click in the `Pencil` that show a message `Edit Scene` to enter at the world

<img
  src="/Images/ImagensGithubEditScene.png"
  alt="image"
  title="EditScene"
  style="display: inline-block; margin: 0 auto; max-width: 300px">


When we have a script for sansar in `.cs` we already can import it to the scene, at the top we have the window `Scene` where we have options like:

<img
  src="/Images/ImagensGithubMenuOptionImport.png"
  alt="image"
  title="MenuImport"
  style="display: inline-block; margin: 0 auto; max-width: 300px">
  

The option that we need is `import` , this option will show a window name as `Import Script` where we can choose the script from the docs and we can give it a name for the inventory

> We can import files with the extension `.CS` and `.JSON`

<img
  src="/Images/ImagensGithubImportWindows.png"
  alt="image"
  title="ImportWindow"
  style="display: inline-block; margin: 0 auto; max-width: 300px">

`Choose file` This window let us select the script from our PC.

`Log`  This windows show us if the code have some problem when is compiled

If the `Code` does not present any problem this will be added to the `Inventory Panel`

<img
  src="/Images/ImagensGithubInventory.png"
  alt="image"
  title="InventoryWindows"
  style="display: inline-block; margin: 0 auto; max-width: 300px">
 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)


## ADD A SCRIPT TO AN OBJECT

When we are in the editor of sansar, we have different forms to add a script to an object

<img
  src="/Images/AddScript.png"
  alt="image"
  title="Scripts"
  style="display: inline-block; margin: 0 auto; max-width: 300px">

> `CASE A`  in this case we can use the click right to show a menu that have a part called  `Add` this part let us to  to add different functions and things to the object, we also can add a `Script` in this part

> `CASE B` in this case we can take the script from the inventory to put it in the object 

> `CASE C` in this case is a little different because, this work when we already have a script in the object, in the panel of Properties we can change the script that we already have to change it for another one

> `CASE D` in this case we  can add a script from the `Scene Objects`  panel 


 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)


## FUNCTION LOG 

### CREATE A DEBUGGER

Inside of sansar we have the function `Log` this can let us make a debugger to find the error when the script is working, most of the script does not have this part but could be really useful to find the functions or part that is not working correctly

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



 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

## TAG NAME
If we want have a type of `Tag` in sansar we can use the property `Interaction`

````csharp
//necessary namespaces for the script to work
using Sansar;
using Sansar.Script;
using Sansar.Simulation;

//principal class 
public class TagName : SceneObjectScript
{   
    //public fields show in the object properties after being added to a script.
    #region Editor Properties 

        [DefaultValue("Name Object")] //here you can write whatever you want that will show in Sansar
        public Interaction TagName;

    #endregion

    //Method called when the script is initialized
    public override void Init()
    {
        
    }
}
````

[` ▲ BACK TO TOP` ](#CONTENT-TABLE)


## MY INTERACTION

How make a object interactable, an object that let me do click in it, for example to show a message or a modal in the screen or something like that.

````csharp
using Sansar;
using Sansar.Script;
using Sansar.Simulation;

public class HelloWorld : SceneObjectScript
{
    #region EditorProperties

      //Public Variables
        // Public Variables show in the object properties after being added to a script.
        [DefaultValue("Click Me!")]     // This interaction will have a default prompt of "Click Me!"
        public Interaction MyInteraction;         // An Interaction public property makes the script clickable.

    #endregion

    // Init() is where the script is setup and is run when the script starts.
    public override void Init()
    {
        // Subscribe to interaction events to do something when the object is clicked.
        MyInteraction.Subscribe(OnClick);
    }

    public void OnClick(InteractionData data)
    {
        // Find the agent that clicked.
        AgentPrivate agent = ScenePrivate.FindAgent(data.AgentId);

        // Send them a message.
        agent.SendChat("Hello! Thanks for clicking me.");
    }

}
//Some parts of this code use content from the Sansar Knowledge Base. � 2022 Sansar, Inc. Licensed under the Creative Commons Attribution 4.0 International License (license summary available at https://creativecommons.org/licenses/by/4.0/ and complete license terms available at https://creativecommons.org/licenses/by/4.0/legalcode).
````


 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)



