###### Unity: QuickButton Attribute
===========================

### Add coloured buttons that can call methods from the inspector, without resorting to right-click context menus.

Thanks for downloading QuickButton, I hope it saves you some time :)  If you have any questions/suggestions, grab me on twitter: @dcturner , or email me: mrdcturner@gmail.com

### Instructions

First, take a look at the scenes in the examples folder. That should give you a good idea of how QuickButtons look / behave. They are functionally identical to context-menu items in that they simply invoke a method without any parameters. However, I'm not a fan of right-clicking, and I wanted coloured buttons with customisable labels :)

To add a QuickButton to your gameObject, add the following code to your c# script;

**[QuickButton("gameObject name", "method name", "Button Label")]
public bool _ignoreMe;**

The parameters are as follows;

**"gameObject name"**  <-- The exact name of the gameObject you are targeting. Example: "Main Camera". (Case Sensitive)

**method name**  <--  The exact name of the method you wish to call. Example: "moveCamera"

**Button Label** <-- The text that appears on your button.

**optional 4th parameter:** <-- you can further customise your QuickButtons by choosing one of the preset QuickButtonColour values. Example: QuickButtonColour.Red.
If you don't specify a colour as the 4th parameter, the button will default to QuickButtonColour.dark.

You might be wondering what **"public bool _ignoreMe;"** is doing in there :)  Good Question!  
QuickButton is a type of PropertyDrawer, which tells Unity how to draw certain fields. You can change the appearence of booleans, strings, floats, integers, and a few other core data types. Unfortunately, I couldn't find a way of attaching a PropertyDrawer attribute to a method, which would have been ideal. So, in order to draw a QuickButton in the inspector, it has to be attached to a public core-dataType variable, such as a boolean. So for every QuickButton you wish to include in your script, you'll need to attach the QuickButton attribute to a unique variable. I tend to make booleans called _ignore1, _ignore2, _ignore3 etc. They don't do anything, think of them as junk variables that our QuickButtons are attached to. Remember, if you are only using the QuickButton for in-editor tasks, you can always wrap them in #if UNITY_EDITOR platform dependancies, so that they won't be compiled into your game code.

^ It's messier than I'd like, and I'll keep an eye out for a cleaner implementation in the future. Be sure to install the MonoDevelop QuickButton snippet in order to make things even easier...


### MonoDevelop Snippet
I have included a MonoDevelop snippet in the root of this repository: **QuickButton.template.xml**
Drop this file into **Library > MonoDevelop Folder > Snippets** 


Have fun!
