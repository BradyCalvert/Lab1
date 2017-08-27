using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateFolders : MonoBehaviour {
  //add a menu to the toolbar in unity
  //create folders
  //add text document to explain foldre structure
  [MenuItem("Project Tools/Create Folders")]
 /* public static void DoSomething()
  {
    AssetDatabase.CreateFolder("Assets", "Materials");
    AssetDatabase.CreateFolder("Assets", "Scripts");
    AssetDatabase.CreateFolder("Assets", "Textures");
    AssetDatabase.CreateFolder("Assets", "Scenes");
    AssetDatabase.CreateFolder("Assets", "Prefabs");
    AssetDatabase.CreateFolder("Assets", "Animations");
    AssetDatabase.CreateFolder("Assets/Animations", "Animation Controllers");
    string fileLocation = Application.dataPath;
    System.IO.File.WriteAllText(fileLocation+"Readme.txt","Please place all raw textures in Textures folder.\n" +
      "Create materials in Materials folder.\n" +
      "Prefabs should go in the prefabs folder. Create a new folder inside of prefabs for each scene the prefab will reside in .\n"+
      "Scripts should go into the scripts folder. Create a new script for scrips that are a common function.\n"+
      "Scenes should be saved into the scenes folder. Create a new folder inside scenes for scenes that share a common function, such as Menu Scenes\n"+
      "Animation clips belong inside the Animations folder. create a new folder for each time of animation. Controllers are created from those clips and should go in the animation Controllers folder.");
    AssetDatabase.Refresh();
  }*/
  public static void OnYourOwn()
  {
    AssetDatabase.CreateFolder("Assets", "Dynamic Assets");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets", "Resources");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Animation Controllers");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Animations");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Animations", "Sources");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Effects");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Models");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Character");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Environment");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Prefabs");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Prefabs", "Common");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Sounds");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Sounds", "Music");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Sounds/Music", "Common");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Sounds", "SFX");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Sounds/SFX", "Common");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources", "Textures");
    AssetDatabase.CreateFolder("Assets/Dynamic Assets/Resources/Textures", "Common");
    AssetDatabase.CreateFolder("Assets", "Extentions");
    AssetDatabase.CreateFolder("Assets", "Gizmos");
    AssetDatabase.CreateFolder("Assets", "Plugins");
    AssetDatabase.CreateFolder("Assets", "Scripts");
    AssetDatabase.CreateFolder("Assets", "Shaders");
    AssetDatabase.CreateFolder("Assets", "Static Assets");
    AssetDatabase.CreateFolder("Assets/Static Assets", "Resources");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources", "Animation Controllers");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources", "Animations");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources/Animations", "Sources");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources", "Effects");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources", "Models");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources", "Character");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources", "Environment");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources", "Prefabs");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources/Prefabs", "Common");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources", "Sounds");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources/Sounds", "Music");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources/Sounds/Music", "Common");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources/Sounds", "SFX");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources/Sounds/SFX", "Common");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources", "Textures");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources/Textures", "Common");
    AssetDatabase.CreateFolder("Assets/Static Assets/Resources", "Testing");
    string fileLocation = Application.dataPath;
    System.IO.File.WriteAllText(fileLocation + "/Shaders" + "/Readme.txt", "Please place all raw textures in Textures folder.\n" +
      "Create materials in Materials folder.\n" +
      "Prefabs should go in the prefabs folder. Create a new folder inside of prefabs for each scene the prefab will reside in .\n" +
      "Scripts should go into the scripts folder. Create a new script for scrips that are a common function.\n" +
      "Scenes should be saved into the scenes folder. Create a new folder inside scenes for scenes that share a common function, such as Menu Scenes\n" +
      "Animation clips belong inside the Animations folder. create a new folder for each time of animation. Controllers are created from those clips and should go in the animation Controllers folder.");
    System.IO.File.WriteAllText(fileLocation + "/Scripts" + "/Readme.txt", "Please place all raw textures in Textures folder.\n" +
      "Create materials in Materials folder.\n" +
      "Prefabs should go in the prefabs folder. Create a new folder inside of prefabs for each scene the prefab will reside in .\n" +
      "Scripts should go into the scripts folder. Create a new script for scrips that are a common function.\n" +
      "Scenes should be saved into the scenes folder. Create a new folder inside scenes for scenes that share a common function, such as Menu Scenes\n" +
      "Animation clips belong inside the Animations folder. create a new folder for each time of animation. Controllers are created from those clips and should go in the animation Controllers folder.");
    System.IO.File.WriteAllText(fileLocation + "/Plugins" + "/Readme.txt", "Please place all raw textures in Textures folder.\n" +
      "Create materials in Materials folder.\n" +
      "Prefabs should go in the prefabs folder. Create a new folder inside of prefabs for each scene the prefab will reside in .\n" +
      "Scripts should go into the scripts folder. Create a new script for scrips that are a common function.\n" +
      "Scenes should be saved into the scenes folder. Create a new folder inside scenes for scenes that share a common function, such as Menu Scenes\n" +
      "Animation clips belong inside the Animations folder. create a new folder for each time of animation. Controllers are created from those clips and should go in the animation Controllers folder.");
    System.IO.File.WriteAllText(fileLocation + "/Gizmos" + "/Readme.txt", "Please place all raw textures in Textures folder.\n" +
      "Create materials in Materials folder.\n" +
      "Prefabs should go in the prefabs folder. Create a new folder inside of prefabs for each scene the prefab will reside in .\n" +
      "Scripts should go into the scripts folder. Create a new script for scrips that are a common function.\n" +
      "Scenes should be saved into the scenes folder. Create a new folder inside scenes for scenes that share a common function, such as Menu Scenes\n" +
      "Animation clips belong inside the Animations folder. create a new folder for each time of animation. Controllers are created from those clips and should go in the animation Controllers folder.");
    System.IO.File.WriteAllText(fileLocation + "/Extentions" + "/Readme.txt", "Please place all raw textures in Textures folder.\n" +
      "Create materials in Materials folder.\n" +
      "Prefabs should go in the prefabs folder. Create a new folder inside of prefabs for each scene the prefab will reside in .\n" +
      "Scripts should go into the scripts folder. Create a new script for scrips that are a common function.\n" +
      "Scenes should be saved into the scenes folder. Create a new folder inside scenes for scenes that share a common function, such as Menu Scenes\n" +
      "Animation clips belong inside the Animations folder. create a new folder for each time of animation. Controllers are created from those clips and should go in the animation Controllers folder.");
    System.IO.File.WriteAllText(fileLocation+"/Editor" + "/Readme.txt", "Please place all raw textures in Textures folder.\n" +
      "Create materials in Materials folder.\n" +
      "Prefabs should go in the prefabs folder. Create a new folder inside of prefabs for each scene the prefab will reside in .\n" +
      "Scripts should go into the scripts folder. Create a new script for scrips that are a common function.\n" +
      "Scenes should be saved into the scenes folder. Create a new folder inside scenes for scenes that share a common function, such as Menu Scenes\n" +
      "Animation clips belong inside the Animations folder. create a new folder for each time of animation. Controllers are created from those clips and should go in the animation Controllers folder.");
    AssetDatabase.Refresh();
  }

}
