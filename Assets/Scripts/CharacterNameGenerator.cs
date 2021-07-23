using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Functions to complete:
/// Create Names
/// - Generate Names
/// </summary>
public class CharacterNameGenerator : MonoBehaviour
{
    [Header("Possible first names")]
    private List<string> firstNames = new List<string>(); // These appear in the inspector, you should be assigning names to these in the inspector.
    [Header("Possible last names")]
    private List<string> lastNames = new List<string>();
    [Header("Possible nicknames")]
    private List<string> nicknames = new List<string>();
    [Header("Possible adjectives to describe the character")]
    private List<string> descriptors = new List<string>();


    /// <summary>
    /// Creates a list of names for all our characters to potentiall use.
    /// This get's called in the battle stater, before both teams call initTeams().
    /// </summary>
    public void CreateNames()
    {
        firstNames.Add; // need to fix.
        Debug.LogWarning("Create Names Called");
        // we probably want to set our 4 lists to some default values
    }

    /// <summary>
    /// Returns an Array of Character Names based on the number of namesNeeded.
    /// </summary>
    /// <param name="namesNeeded"></param>
    /// <returns></returns>
    public CharacterName[] ReturnTeamCharacterNames(int namesNeeded)
    {
        Debug.LogWarning("CharacterNameGenerator called, it needs to fill out the names array with unique randomly constructed character names");
        CharacterName[] names = new CharacterName[namesNeeded]; 
        CharacterName emptyName = new CharacterName(string.Empty, string.Empty, string.Empty, string.Empty);

        for (int i = 0; i < names.Length; i++)
        {
            //For every name we need to generate, we need to assign a random first name, last name, nickname and descriptor to each.
            //Below is an example of setting the first name of the emptyName variable to the string "Blank".
            emptyName.firstName = firstNames[Random.Range(0, firstNames.Count)]; // This randomises the first name.
            emptyName.lastName = lastNames[Random.Range(0, lastNames.Count)]; // This randomises the last name.
            emptyName.nickname = nicknames[Random.Range(0, nicknames.Count)]; // This randomises the nickname.
            emptyName.descriptor = descriptors[Random.Range(0, descriptors.Count)]; // This randomises the descriptors.
            names[i] = emptyName;
        }

        //Returns an array of names that we just created.
        return names;
    }
}