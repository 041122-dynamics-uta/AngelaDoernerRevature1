using System;

public static string angryProfessor (int k, List<int> a)
{
    return (a.FindAll(x => x <= 0).Count() >= k) ? "NO" : "YES";
}