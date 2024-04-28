using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public static class SaveData
{
    public const string TEST_USER = "testUser";
    private const string SAVE_FILE_NAME = "petStatsData.json";
    private const string USERS_KEY = "users";

    public static void AddUser(User user, bool isUpdate = false)
    {
        Dictionary<string, User> users = GetUsers();
        string username = user.username;

        if (!isUpdate && users.ContainsKey(username))
        {
            Debug.LogError($"Already created user {username}");
            return;
        }

        users[username] = user;
        
        ES3.Save(USERS_KEY, users, SAVE_FILE_NAME);
    }

    public static Dictionary<string, User> GetUsers()
    {
        return ES3.Load(USERS_KEY, SAVE_FILE_NAME, new Dictionary<string, User>());
    }

    public static User GetUser(string username)
    {
        Dictionary<string, User> users = GetUsers();

        if (!users.ContainsKey(username))
        {
            User newUser = new User
            {
                username = username
            };
            return newUser;
        }
        return users[username];
    }

    public static void UpdateUser(User newUserData)
    {
        AddUser(newUserData, true);
    }

    public static void AddPet(string username, Pet newPet)
    {
        User user = GetUser(username);
        user.pets.Add(newPet);
        UpdateUser(user);
    }

    public static List<Pet> GetPets(string username)
    {
        return GetUser(username).pets;
    }
}
