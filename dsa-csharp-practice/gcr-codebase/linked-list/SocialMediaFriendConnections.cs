using System;

class FriendNode
{
    public int FriendId;
    public FriendNode Next;

    public FriendNode(int id)
    {
        FriendId = id;
        Next = null;
    }
}

class UserNode
{
    public int UserId;
    public string Name;
    public int Age;
    public FriendNode Friends;
    public UserNode Next;

    public UserNode(int id, string name, int age)
    {
        UserId = id;
        Name = name;
        Age = age;
        Friends = null;
        Next = null;
    }
}

class SocialMediaList
{
    private UserNode head;

    public void AddUser(int id, string name, int age)
    {
        UserNode newUser = new UserNode(id, name, age);
        newUser.Next = head;
        head = newUser;
    }

    private UserNode FindUser(int id)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.UserId == id)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void AddFriend(int userId, int friendId)
    {
        UserNode user = FindUser(userId);
        if (user == null)
            return;

        FriendNode newFriend = new FriendNode(friendId);
        newFriend.Next = user.Friends;
        user.Friends = newFriend;
    }

    public void RemoveFriend(int userId, int friendId)
    {
        UserNode user = FindUser(userId);
        if (user == null || user.Friends == null)
            return;

        if (user.Friends.FriendId == friendId)
        {
            user.Friends = user.Friends.Next;
            return;
        }

        FriendNode temp = user.Friends;
        while (temp.Next != null)
        {
            if (temp.Next.FriendId == friendId)
            {
                temp.Next = temp.Next.Next;
                return;
            }
            temp = temp.Next;
        }
    }

    public void DisplayFriends(int userId)
    {
        UserNode user = FindUser(userId);
        if (user == null)
            return;

        FriendNode temp = user.Friends;
        Console.WriteLine("Friends of " + user.Name + ":");
        while (temp != null)
        {
            Console.WriteLine("Friend ID: " + temp.FriendId);
            temp = temp.Next;
        }
    }

    public void FindMutualFriends(int userId1, int userId2)
    {
        UserNode u1 = FindUser(userId1);
        UserNode u2 = FindUser(userId2);
        if (u1 == null || u2 == null)
            return;

        FriendNode f1 = u1.Friends;
        Console.WriteLine("Mutual Friends:");
        while (f1 != null)
        {
            FriendNode f2 = u2.Friends;
            while (f2 != null)
            {
                if (f1.FriendId == f2.FriendId)
                    Console.WriteLine("Friend ID: " + f1.FriendId);
                f2 = f2.Next;
            }
            f1 = f1.Next;
        }
    }

    public void SearchUserById(int id)
    {
        UserNode user = FindUser(id);
        if (user != null)
            PrintUser(user);
    }

    public void SearchUserByName(string name)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.Name == name)
                PrintUser(temp);
            temp = temp.Next;
        }
    }

    public void CountFriends(int userId)
    {
        UserNode user = FindUser(userId);
        if (user == null)
            return;

        int count = 0;
        FriendNode temp = user.Friends;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        Console.WriteLine("Total Friends of " + user.Name + ": " + count);
    }

    private void PrintUser(UserNode user)
    {
        Console.WriteLine("User ID: " + user.UserId);
        Console.WriteLine("Name   : " + user.Name);
        Console.WriteLine("Age    : " + user.Age);
        Console.WriteLine("---------------------");
    }
}

class Program
{
    static void Main()
    {
        SocialMediaList sm = new SocialMediaList();

        sm.AddUser(1, "Amit", 21);
        sm.AddUser(2, "Ravi", 22);
        sm.AddUser(3, "Neha", 20);

        sm.AddFriend(1, 2);
        sm.AddFriend(1, 3);
        sm.AddFriend(2, 3);

        sm.DisplayFriends(1);
        sm.FindMutualFriends(1, 2);
        sm.CountFriends(1);

        sm.RemoveFriend(1, 3);
        sm.DisplayFriends(1);

        sm.SearchUserByName("Ravi");

        Console.ReadLine();
    }
}
