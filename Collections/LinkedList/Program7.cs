using System;

class FriendNode
{
    public int FriendID;
    public FriendNode Next;

    public FriendNode(int id)
    {
        FriendID = id;
    }
}

class User
{
    public int UserID;
    public string Name;
    public int Age;

    public FriendNode Friends;
    public User Next;

    public User(int id, string name, int age)
    {
        UserID = id;
        Name = name;
        Age = age;
    }
}

class SocialMedia
{
    private User head;

    public void AddUser(int id, string name, int age)
    {
        User u = new User(id, name, age);
        u.Next = head;
        head = u;
    }

    public User SearchUser(int id)
    {
        User temp = head;

        while (temp != null)
        {
            if (temp.UserID == id)
                return temp;

            temp = temp.Next;
        }

        return null;
    }

    public User SearchUser(string name)
    {
        User temp = head;

        while (temp != null)
        {
            if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return temp;

            temp = temp.Next;
        }

        return null;
    }

    public void AddFriend(int user1, int user2)
    {
        User a = SearchUser(user1);
        User b = SearchUser(user2);

        if (a == null || b == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        if (!HasFriend(a, user2))
            AddFriendNode(a, user2);

        if (!HasFriend(b, user1))
            AddFriendNode(b, user1);
    }

    private void AddFriendNode(User user, int friendID)
    {
        FriendNode n = new FriendNode(friendID);

        if (user.Friends == null)
        {
            user.Friends = n;
            return;
        }

        FriendNode temp = user.Friends;

        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = n;
    }

    private bool HasFriend(User user, int id)
    {
        FriendNode temp = user.Friends;

        while (temp != null)
        {
            if (temp.FriendID == id)
                return true;

            temp = temp.Next;
        }

        return false;
    }

    public void RemoveFriend(int user1, int user2)
    {
        User a = SearchUser(user1);
        User b = SearchUser(user2);

        if (a == null || b == null)
            return;

        RemoveFriendNode(a, user2);
        RemoveFriendNode(b, user1);
    }

    private void RemoveFriendNode(User user, int id)
    {
        if (user.Friends == null)
            return;

        if (user.Friends.FriendID == id)
        {
            user.Friends = user.Friends.Next;
            return;
        }

        FriendNode temp = user.Friends;

        while (temp.Next != null && temp.Next.FriendID != id)
            temp = temp.Next;

        if (temp.Next != null)
            temp.Next = temp.Next.Next;
    }

    public void DisplayFriends(int userID)
    {
        User user = SearchUser(userID);

        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        Console.WriteLine($"Friends of {user.Name}:");

        FriendNode temp = user.Friends;

        while (temp != null)
        {
            User friend = SearchUser(temp.FriendID);

            if (friend != null)
                Console.WriteLine(
                    $"{friend.UserID} - {friend.Name}");

            temp = temp.Next;
        }
    }

    public void MutualFriends(int id1, int id2)
    {
        User a = SearchUser(id1);
        User b = SearchUser(id2);

        if (a == null || b == null)
            return;

        Console.WriteLine("Mutual Friends:");

        FriendNode temp = a.Friends;

        while (temp != null)
        {
            if (HasFriend(b, temp.FriendID))
            {
                User mutual = SearchUser(temp.FriendID);
                Console.WriteLine(mutual.Name);
            }

            temp = temp.Next;
        }
    }

    public void CountFriends(int userID)
    {
        User user = SearchUser(userID);

        if (user == null)
            return;

        int count = 0;
        FriendNode temp = user.Friends;

        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }

        Console.WriteLine($"{user.Name} has {count} friend(s).");
    }

    public void DisplayUsers()
    {
        User temp = head;

        while (temp != null)
        {
            Console.WriteLine(
                $"ID: {temp.UserID}, Name: {temp.Name}, Age: {temp.Age}");

            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMedia social = new SocialMedia();

        social.AddUser(1, "Rahul", 21);
        social.AddUser(2, "Aman", 22);
        social.AddUser(3, "Priya", 20);
        social.AddUser(4, "Neha", 21);

        social.AddFriend(1, 2);
        social.AddFriend(1, 3);
        social.AddFriend(2, 3);
        social.AddFriend(2, 4);

        social.DisplayFriends(1);

        Console.WriteLine();
        social.MutualFriends(1, 2);

        Console.WriteLine();
        social.CountFriends(1);

        social.RemoveFriend(1, 3);
    }
}