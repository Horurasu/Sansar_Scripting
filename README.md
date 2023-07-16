<h1 align="center"> - SANSAR GUIDE - </h1> 

<img
  src="/Images/SANSARLOGO.png"
  alt="image"
  title="Logo"
  style="display: inline-block; margin: 0 auto; max-width: 300px">
  

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
        - 2.2.5- [ARRAYS](#ARRAYS)
        - 2.2.7- [LOGICAL OPERATORS](#LOGICAL-OPERATORS)
	    - 2.2.8- [EDITOR PROPERTIES](#EDITOR-PROPERTIES)
	    - 2.2.9- [METHODS](#METHODS)
	    - 2.2.10- [SCRIPT STRUCTURE](#SCRIPT-STRUCTURE)
- 3.- [START TO PROGRAMMING](#START-TO-PROGRAMMING)
  - 3.1.- [IMPORT](#IMPORT)
  - 3.2.- [ADD A SCRIPT TO AN OBJECT](#ADD-A-SCRIPT-TO-AN-OBJECT)
  - 3.3.- [FUNCTION LOG](#FUNCTION-LOG)
     - 3.3.1- [CREATE A DEBUGGER](#CREATE-A-DEBUGGER)
  - 3.4.- [TAG NAME](#TAG-NAME)
  - 3.5.- [MESSAGES](#MESSAGES)
     - 3.5.1- [MESSAGE TO A SPECIFIC USER ](#MESSAGE-TO-A-SPECIFIC-USER )
     - 3.5.2- [MESSAGE TO ALL USERS](#MESSAGE-TO-ALL-USERS)
     - 3.5.3- [MODAL MESSAGE](#MODAL-MESSAGE)
  - 3.6.- [MY INTERACTION PROPERTY](#MY-INTERACTION)
  - 3.7.- [AMOUNT](#AMOUNT)
  - 3.8.- [MOVE OBJECTS](#MOVE-OBJECTS)
  - 3.9.- [ANIMATIONS](#ANIMATIONS)
  - 3.10.- [SOUNDS](#SOUNDS)
  - 3.11.- [MEDIA](#MEDIA)
  - 3.12.- [CALL CODE BY CLASSES](#CALL-CODE-BY-CLASSES)
- 4.- [SANSAR SCRIPT LIBRARY](#SANSAR-SCRIPT-LIBRARY)


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

> ANOTHER EXPLANATION OF THE CLASSES

I can explain more easy the classes for example when i have two departments to rent, i have the two building in the same piece of land, and i have a `REFRIGERATOR / MY VARIABLE`, if i put the refrigerator in the first `Building / ClassNumber1` the persons that live in the other building could not use the Refrigerator because i have it inside the other `Building / ClassNumber2` but if i put the Refrigerator in the garden, everybody can use it because all can access to it

```csharp


//piece of land that i have

public string Refrigerator; //the refrigerator in the  garden

public class ClassNumber1 : SceneObjectScript
{   
        //this building - class can access to the refrigerator, but if i have / declare the refrigerator here the class number 2 can access to it
}


public class ClassNumber2 : SceneObjectScript 
{   
        //this building - class can access to the refrigerator, but if i have / declare the refrigerator here the class number 1 can access to it
}

```

If we want both classes or scripts in the same `FILE` we have to use the `namespace` property, like in the next example:

```csharp
using Sansar;
using Sansar.Script;
using Sansar.Simulation;

namespace MyScripts // Here we can give it a name where the scripts will be stored
{
    public class ClassNumber1 : SceneObjectScript
    {   
        
    }

    public class ClassNumber2 : SceneObjectScript 
    {   
        
    }
}
```

 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

### VARIABLES

> In the classes we have a region that we can add or not where we declare the variable of the script, we have two types of variables `PUBLIC` and `PRIVATE` where depending which we choose, this can let change the content of the variable in the Sansar editor or not.

- `Private`:  A private variable is a variable that is only visible and accessible within the class in which it is declared.
 
- `Public`:  A public variable is a variable that is visible and accessible to all classes and scripts in the scene.

|Variable Types||Example|
|-|-|-|
|`string`|Used to store text or a sequence of characters.|"text"|
|`int`|Used to store integer numbers|5|
|`bool`|Used to store Boolean values (true or false)|true|
|`float`|Used to store floating-point numbers (which approximate real numbers)|1.5f|
|`double`|A double is a data type in C language that stores high-precision floating-point data or numbers in computer memory|2.85|
|`Vector`|Used to store a position or direction in three-dimensional space|Vector.Up|
|`Quaternion`|Used to store an orientation in three-dimensional space.|Quaternion.FromAngleAxis()|
|`Sansar.Color`|Structure that allows you to access, convert, and parse known colors in the system|1,0.8,0.5,1|
|`Interaction`|This is a variable that is used to represent an interaction between objects in the scene. It can be used to trigger events or actions when objects come into contact with each other.|MyInteraction|
|`ClusterResource`|This is a variable that is used to represent a resource that is shared among multiple objects in the scene. It can be used to store data or assets that are used by multiple objects.|ClusterResource|
|`SoundResource`|This is a variable that is used to represent a sound that is played in the scene. It can be used to play music or sound effects in response to events or actions.|SoundResource|

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

### ARRAYS

In `Sansar` we have a limit of properties to which we can access because we only can access to a maximum of `20` properties for each list, we should consider that `List not work with every variables` because some of them have other functions and only work with one of them

````csharp
public class ArraysExamples : SceneObjectScript
{
    #region EditorProperties

        //Public properties
            public List<bool> Bools;
            public List<int> Ints;
            public List<float> Floats;

    #endregion

    public override void Init() {

    }
}
````

### LOGICAL OPERATORS

A `LOGICAL OPERATOR` is a symbol or word used to connect two or more expressions such that the value of the compound expression produced depends only on that of the original expressions and on the meaning of the operator.

The Logical Operator are used inside the conditions of a code ( IF , WHILE, etc..)

| Operator | Description | Example |
| --- | --- | --- |
| && | Logical AND | if (x > 0 && y > 0) |
| \|\| | Logical OR | if (x > 0 \|\| y > 0) |
| ! | Logical NOT | if (!(x > 0)) |

> The operator `&&` is a operator that let us add more than one condition in a sentence 

> The operator `||` is a operator that let us consider two different options in a sentence

> The operator `!` is a operator that negates a condition in a sentence

> we can consider if we use `!=` we say that something that is different of what we have. for example:

````csharp
  
public string Number = 7;

if( Number != 10) // we check if the number is different of 10
{
    //we declare the number as 7 so the code will be execute because is different of 10
    ScenePrivate.Chat.MessageAllUsers(message);

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

But if we want write more than one script in the same file we can use the same structure that we saw in the `NAMESPACE Property`.

```csharp
using Sansar;
using Sansar.Script;
using Sansar.Simulation;

namespace MyScripts
{
    public class ClassNumber1 : SceneObjectScript
    {   
        #region EditorProperties

            //Public Variables
            
            //Private Variables

        #endregion
        
        public override init()
        {

        }
    }

    public class ClassNumber2 : SceneObjectScript 
    {   
        #region EditorProperties

            //Public Variables
            
            //Private Variables

        #endregion

        public override init()
        {

        }
    }
}
```

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

## MESSAGES

We can send two different message to the chat in sansar for example the first is send a message when we know the ID(the number of the player / identifier) and the second case is when we want to sent a message to al of the users in the experience

### MESSAGE TO A SPECIFIC USER 

> `Specific User Message` this message first we have to the ID of the player that interacted with the object or with the event in other cases.

````csharp
//Some parts of this code use content from the Sansar Knowledge Base. � 2022 Sansar, Inc. Licensed under the Creative Commons Attribution 4.0 International License (license summary available at https://creativecommons.org/licenses/by/4.0/ and complete license terms available at https://creativecommons.org/licenses/by/4.0/legalcode).

using Sansar;
using Sansar.Script;
using Sansar.Simulation;

public class HelloWorld : SceneObjectScript
{
    #region EditorProperties

      //Public Variables
        // Public Variables show in the object properties after being added to a script.
        [DefaultValue("Click Me!")]     // This interaction will have a default prompt of "Click Me!"
        public Interaction MyInteraction;    // An Interaction public property makes the script clickable.

        
        [Tooltip("Write the message that you want to show")] 
        [DisplayName("Message")]
        [DefaultValue("This is a message for who click in me :D")]
        public string message; //variable that contents the message

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
        agent.SendChat(message);
    }

}
````

 ### MESSAGE TO ALL USERS

> `Message to all Users` this case we only have to send the message to all of the players in the experience.

````csharp
//Some parts of this code use content from the Sansar Knowledge Base. � 2022 Sansar, Inc. Licensed under the Creative Commons Attribution 4.0 International License (license summary available at https://creativecommons.org/licenses/by/4.0/ and complete license terms available at https://creativecommons.org/licenses/by/4.0/legalcode).

using Sansar;
using Sansar.Script;
using Sansar.Simulation;

public class HelloWorld : SceneObjectScript
{
    #region EditorProperties

    //Public Variables
        // Public Variables show in the object properties after being added to a script.
        [DefaultValue("Click Me!")]     // This interaction will have a default prompt of "Click Me!"
        public Interaction MyInteraction;    // An Interaction public property makes the script clickable.

        [Tooltip("Write the message that you want to show")] 
        [DisplayName("Message")]
        [DefaultValue("This is a message for everyone, because someone click on the object :D")]
        public string message; //variable that contents the message

    #endregion

    // Init() is where the script is setup and is run when the script starts.
    public override void Init()
    {
        // Subscribe to interaction events to do something when the object is clicked.
        MyInteraction.Subscribe(OnClick);
    }

    public void OnClick(InteractionData data)
    {
        ScenePrivate.Chat.MessageAllUsers(message);
    }
}
````

> `Message to all Users when the experience starts` this case we only have to send the message to all of the players in the experience.

### MODAL MESSAGE

> `Modal Message` the modal messages show a modal to the avatar that show a message with buttons that have different options

````csharp
//Some parts of this code use content from the Sansar Knowledge Base. � 2022 Sansar, Inc. Licensed under the Creative Commons Attribution 4.0 International License (license summary available at https://creativecommons.org/licenses/by/4.0/ and complete license terms available at https://creativecommons.org/licenses/by/4.0/legalcode).

//necessary namespaces for the script to work
using Sansar;
using Sansar.Script;
using Sansar.Simulation;

public class ModalMessage : SceneObjectScript
{
    #region EditorProperties

        //Public Variables

            [Tooltip("Write the questions to show")] 
            [DisplayName("Question")] 
            [DefaultValue("Write your Question")]
            public string Question;

            [Tooltip("Write the first option")] 
            [DisplayName("First Option")] 
            [DefaultValue("A")]
            public string Option1;

            [Tooltip("Write the second option")] 
            [DisplayName("Second Option")] 
            [DefaultValue("B")]
            public string Option2;

            [Tooltip("Write the first answer for the questions")] 
            [DisplayName("First Answer")] 
            [DefaultValue("First Option Result")]
            public string Answer1;

            [Tooltip("Write the second answer for the questions")] 
            [DisplayName("Second Answer")] 
            [DefaultValue("Second Option Result")]
            public string Answer2;
            
            [DefaultValue("Click Me!")]
            public Interaction MyInteraction;

    #endregion

    // Init() is where the script is setup and is run when the script starts.
    public override void Init()
    {
        // Subscribe to interaction events to do something when the object is clicked.
        MyInteraction.Subscribe(Action);
    }

    public void Action(InteractionData data)
    {
        // Find the agent that clicked.
        AgentPrivate agent = ScenePrivate.FindAgent(data.AgentId);

        if (agent != null) 
        {   
            agent.Client.UI.ModalDialog.Show(Question, Option1, Option2, (opc) =>
            {
                if (agent.Client.UI.ModalDialog.Response == Answer1)
                    agent.SendChat(Answer1);
                else
                    agent.SendChat(Answer2);
            });
        }
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


## AMOUNT

To make a script for sansar that create a amount that is increasing or decreasing when i do click and object 

````csharp
using Sansar;
using Sansar.Script;
using Sansar.Simulation;
using System;

public class NumberCounter : SceneObjectScript
{

    #region Editor Properties

        // Public properties

            [Tooltip("Size of the steps that the code will perform")] 
            [DisplayName("Steps")]
            [DefaultValue(1.0f)]
            public float StepSize; // steps in which the script will advance

            [Tooltip("Give a name for the Interaction")] 
            [DisplayName("Name Interaction")]
            [DefaultValue("Click on me")]
            public Interaction MyInteraction; // the action that make the object clickeable 

            [Tooltip("Write the max number or the top")] 
            [DisplayName("Number Max")]
            [DefaultValue(10f)]
            public float Max; //number max-top

            [Tooltip("Write the min number or the down")] 
            [DisplayName("Number Min")]
            public float Min; // number min-bottom

            [Tooltip("Write the number where starts")] 
            [DisplayName("StartNumber")]
            [DefaultValue(0f)]
            public float StartNumber; //the number where the script will start- must be or between the max and min

        // Private variables

            private float CurrentNumber;
            private bool isIncreasing = true; // a variable that let know the script if the number is increasing

    #endregion

    public override void Init()
    {
        
        CurrentNumber = StartNumber; // we give the start number to the CurrentNumber
        if((StartNumber >= Min)&&(StartNumber <= Max)){ //If we want that the script start we have to check if the start number is a valid number 
            MyInteraction.Subscribe(OnClick); //if the Start Number is valid the script will call the function OnClick
        }

    public void OnClick(InteractionData data)
    {
        AgentPrivate agent = ScenePrivate.FindAgent(data.AgentId); //we have to
        // Increase or decrease the angle
        if (isIncreasing)
        {
            CurrentNumber += StepSize;
            {
                isIncreasing = false;
            }
        }
        else
        {
            CurrentNumber -= StepSize;
            if (CurrentNumber <= Min)
            {
                isIncreasing = true;
            }
        }
        string message = $"The current angle is {CurrentNumber} degrees.";
        agent.SendChat(message);
    }
}
````

 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

## MOVE OBJECTS

To move an object we have several options, we can make a script using code or we can use the script of movement that sansar give us in the libraries or in the codes that is already done in the files of sansar.

> FIRST OPTION

For this option we wil use the script in the `Sansar Script Library` , we can find it with the name `ScriptLibrary.mover`

<img
  src="/Images/moverscript.png"
  alt="image"
  title="moverscript"
  style="display: inline-block; margin: 0 auto; max-width: 300px">

At first part you might be intimidated but we will not use all the options for this part.

- `Move Event` Here we give a name for the action move the object to executed with other script or action in the scene
- `Reset Event` Here we give a name for the action that return the original position of the object
- `Position Offset` Here we choose the movement that the object will do 
- `Rotation Offset` Here we can choose a rotation if we want that the object rotate in the movement
- `Over time` The time it takes to perform the action

to move the object in this case we have to consider the orientation of the `Axis`

<img
  src="/Images/axiseditor.png"
  alt="image"
  title="axiseditor"
  style="display: inline-block; margin: 0 auto; max-width: 300px">

We can see that we have 3 axis, we can move those positions and rotations as we want.

 `AXIS EDITOR`
- `RED` in the scene editor is the `X-Axis`
- `GREEN` in the scene editor is the `Y-Axis`
- `BLUE` in the scene editor is the `Z-Axis`

If you have already used a program or somethings that work with objects in `3D` we to intuit that if we move the object from the Axis `Blue (Z)` this moves in the `Z Axis` but with this script in sansar that not works in that way, to move the object we have to change the position offset in the `Y` space (`to move the object where the arrow is pointing we have to write POSITIVE NUMBERS,to move it to the opposite direction we have to write , but this can change in some cases, i will show which option space move each of the Axis`).

<img
  src="/Images/positionset.png"
  alt="image"
  title="positionset"
  style="display: inline-block; margin: 0 auto; max-width: 300px">


> Position Offset in the script `X` moves the `X` axis of the editor    

> Position Offset in the script `Y` moves the `Z` axis of the editor

> Position Offset in the script `Z` moves the `Y` axis of the editor

If we want to rotate the object we have to consider something similar because if we want to rotate the `X axis from the editor` in the rotation offset we have to change the value of `Z` in the script, if we want to move the `Y axis from the editor` we have to change the value of `X`, and for the `Z axis form the editor` we change the value of `Y`.

<img
  src="/Images/rotationset.png"
  alt="image"
  title="rotationset"
  style="display: inline-block; margin: 0 auto; max-width: 300px">

> Rotation Offset in the script `X` moves the `Y` axis of the editor    

> Rotation Offset in the script `Y` moves the `Z` axis of the editor

> Rotation Offset in the script `Z` moves the `X` axis of the editor


We can buy the red button in the store or use another object to create the interaction between the button and the object, we have to set up the script, we have to add the `move` script to one object and the `InteractionManager` script to other object

> `IMPORTANT` we have ot make the object movable from scripts, we have to activate the option in the `Transform` area

BUTTON PROPERTIES - INTERACTION MANAGER SCRIPT 

- We will give a name for the event: `move` and another name for the reset event `move_reset` 

- The exercise try to do a elevator, so we have to change the position offset in the `Y` space to move the object in the `Z` axis of the editor

- The option Over time could be change it to make the movement more fast or slow but we will let it in 2

OBJECT - MOVE SCRIPT

- we have to use only two options, the first is the Interaction Prompt, the message that we write here will be show in the scene, so we will write `Click me to execute the movement`

- the other option is  `This Click -> move >> move_reset`,


> SECOND OPTION


> THIRD OPTION


 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

## ANIMATIONS

 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

## SOUNDS

We have some properties in Sansar to work with `Audios`, In the editor of sansar we can find the properties

<img
  src="/Images/SoundObject.png"
  alt="image"
  title="SoundObject"
  style="display: inline-block; margin: 0 auto; max-width: 300px">

We have 3 different types of sound emitters

- `Point` This type make that the sound comes from an specific point in the scene 
- `Cuboid` The cuboid let us change the shape of the object
- `Sphere`  This works like an area instead like a block

<img
  src="/Images/TypeSoundEmitters.png"
  alt="image"
  title="TypeSoundEmitters"
  style="display: inline-block; margin: 0 auto; max-width: 300px">

We can use different Sound Sources but in some we need to import the `files`, this is really similar to import an script.

<img
  src="/Images/ImportAudio.png"
  alt="image"
  title="ImportAudio"
  style="display: inline-block; margin: 0 auto; max-width: 300px">

This will show another window:

<img
  src="/Images/ImportWindow.png"
  alt="image"
  title="ImportWindow"
  style="display: inline-block; margin: 0 auto; max-width: 300px">

`Sound File`

This admit the audios in the formats: 
- .aif, aiff, .ambix, .wav, .flac, .it, .mid, .midi, .mod, .mp2, .mp3, .ogg, .s3m, .wav, .wma, .xm

`Name of item in inventory`

- We can rename object to preview in inventory

When we have a Sound Emitter in the scene we can find some options in their properties like the positions like the other objects.

But we can find another options belong to the Audios.

<img
  src="/Images/PropertiesSound.png"
  alt="image"
  title="PropertiesSound"
  style="display: inline-block; margin: 0 auto; max-width: 300px">

- `Sound` The first option let us change the Sound Source, we can use a stream source or choose the sound from the inventory importing the file.

- `Loudness` This let us to change the loudness of the audio

- `Emitter Shape` This let change the form of the emitter

- ` Size / Radius`   With this depending of the emitter let  change the structure of the object


 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

## MEDIA

 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)


## CALL CODE BY CLASSES

- We have to make that we can send a message that when is received execute another block of code that will be executed when the message is received

```csharp
using Sansar;
using Sansar.Script;
using Sansar.Simulation;
using System;


namespace MessagingScripts
{
    public class Emitter : SceneObjectScript
    {   
        #region Editor Properties

            //Public Variables
                [DefaultValue("Click Me!")]
                public Interaction MyInteraction; //this let the object clickable

            //Private Variables

        #endregion 

        public override void Init()
        {
            MyInteraction.Subscribe((InteractionData data) =>
            {
                PostScriptEvent("The_object_was_clicked");  //send the event that will be heard by the other class
            });
        }
    }

    public class Receiver : SceneObjectScript
    {
        #region Editor Properties

            //Public Variables
                [DefaultValue("Hello from the script")]
                public string message;  //message that will be sended to the Log to show if the code is working correctly

            //Private Variables

        #endregion 

        public override void Init()
        {       
            // the code wait that the event is sended to execute the code
            SubscribeToScriptEvent("The_object_was_clicked", (ScriptEventData data) =>
            {
                Log.Write(message);  //show the message in the log to check if this is working correctly
            });
        }

    }
}
```

We can use the code above to create a lot of different scripts, where we want that one class call another one to generate an action when an event occurs 

[` ▲ BACK TO TOP` ](#CONTENT-TABLE)

# SANSAR SCRIPT LIBRARY

In sansar we can write our owns script or use one that is already compiled and inside the environment, where we have two different `libraries of Scripts` we have the `Sansar Script Library` and the `Quest Script Library`, first we will see the Sansar Script Library, in these library we can find some Sansar Scripts that only with add a `Script` we can use them.

We also can find other script of Sansar but them are in code, we can find them in the docs where Sansar is installed.

> `C:\Program Files\Sansar\Client\ScriptApi\Examples`

We can compile the scripts to use them in sansar because all of them work correctly, we can use parts of those codes to create some new, the only things that most of that script have written is that you have to pus the rights and license is under the terms of the Creative Commons Attribution, and the work use content from the sansar knowledge base. 

Some scripts that we can found, look really similar than other script that we have in the library of scripts, some examples that we can find are: `MoverExamples` we can copy the code that we can find there and use to add another functions or whatever we want.  for example , the next code is a copy of the cope: `MoverExample1`:

```csharp
/* This content is licensed under the terms of the Creative Commons Attribution 4.0 International License.
 * When using this content, you must:
 * �    Acknowledge that the content is from the Sansar Knowledge Base.
 * �    Include our copyright notice: "2022 Sansar, Inc."
 * �    Indicate that the content is licensed under the Creative Commons Attribution-Share Alike 4.0 International License.
 * �    Include the URL for, or link to, the license summary at https://creativecommons.org/licenses/by-sa/4.0/deed.hi (and, if possible, to the complete license terms at https://creativecommons.org/licenses/by-sa/4.0/legalcode.
 * For example:
 * "This work uses content from the Sansar Knowledge Base. � 2018 Linden Research, Inc. Licensed under the Creative Commons Attribution 4.0 International License (license summary available at https://creativecommons.org/licenses/by/4.0/ and complete license terms available at https://creativecommons.org/licenses/by/4.0/legalcode)."
 */
using Sansar;
using Sansar.Script;
using Sansar.Simulation;
using System;

//
// MoverExample1:
//   This script makes an object move away when you click on it.
// 

public class MoverExample1 : SceneObjectScript
{
    // Public properties

    [DefaultValue("Move away!")]
    public Interaction MyInteraction;

    [DefaultValue(5.0f)]
    public float Distance;

    [DefaultValue(2.0f)]
    public double Seconds;

    // Logic!

    public override void Init()
    {
        // Subscribe to the interaction, meaning this next block of code will be executed when the object is clicked on
        MyInteraction.Subscribe((InteractionData data) =>
        {
            // Get the agent that clicked on this object
            var agent = ScenePrivate.FindAgent(data.AgentId);

            if (agent != null)
            {
                if (ObjectPrivate.IsMovable)
                {
                    // Calculate the XY difference from the agent to the object
                    Vector toObject = ObjectPrivate.Position - ScenePrivate.FindObject(agent.AgentInfo.ObjectId).Position;
                    toObject.Z = 0.0f;

                    // If there is an XY difference in position
                    if (toObject.LengthSquared() > 0.0f)
                    {
                        // Normalize the direction vector
                        toObject = toObject.Normalized();

                        // Smoothly move the object away from the agent by the specified distance
                        ObjectPrivate.Mover.AddTranslate(ObjectPrivate.Position + toObject * Distance, Seconds, MoveMode.Smoothstep);
                    }
                }
                else
                {
                    ShowNotMovableReason(agent);
                }
            }
        });
    }

    void ShowNotMovableReason(AgentPrivate agent)
    {
        string message = $"The MoverExample1 script can't move the object with the name \"{ObjectPrivate.Name}\".\n";

        bool notMovableFromScript = (ObjectPrivate.Mover == null);
        if (notMovableFromScript)
        {
            message += "\n";
            message += "The \"Movable From Script\" property is OFF.\n";
        }

        RigidBodyComponent rb;
        bool notKeyframedRigidBody = (ObjectPrivate.TryGetFirstComponent(out rb) && (rb.GetMotionType() != RigidBodyMotionType.MotionTypeKeyframed));
        if (notKeyframedRigidBody)
        {
            message += "\n";
            message += "The object does not have the \"Keyframed\" motion type. Physics objects must be set to \"Keyframed\" to be moved by script.";
        }

        agent.Client.UI.ModalDialog.Show(message, "Ok", "");
    }
}

```


We can see that most of the code have comments that explain what the code do in each line. an example that we can configure the code as we want could be:

> Using the code of `MoveExample1` we will make that when we click a button or an object push other object with the script above.



 [` ▲ BACK TO TOP` ](#CONTENT-TABLE)

