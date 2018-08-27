# SceneAgnostic
Data and Events layer based on ScriptableObjects

Currently there are 2 main features:
1. Events
2. Variables

# Events
Create *ProjectEvent* asset and you can call *Raise()* method on it from where you need (unity events or inside a script). Then you can add many *ProjectEventListener* components to your GameObjects in any scene, these listeners will subscribe automatically to the referenced *ProjectEvent*.


# Variables
These are simply a set of primitive data types wrapped as *ScriptableObjects*. This way you can reference the same data containter from different places in your project. If you need these variables persist in differen scenes you can reference them in some *DoNotDestroyOnLoad" GameObject* in your preload scene. 
