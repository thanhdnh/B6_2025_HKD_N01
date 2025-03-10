﻿public class Node
{
    public object element;
    public Node link;
    public Node()
    {
        element = null;
        link = null;
    }
    public Node(object element)
    {
        this.element = element;
        link = null;
    }
}
public class LinkedList
{
    public Node header;
    public LinkedList()
    {
        header = new Node("Header");
    }
    private Node Find(object element)
    {
        Node current = new Node();
        current = header;
        while (current.element != element)
            current = current.link;
        return current;
    }
    public void Insert(object newelement, object afterelement)
    {
        Node current = new Node();
        Node newnode = new Node(newelement);
        current = Find(afterelement);
        newnode.link = current.link;
        current.link = newnode;
    }
    public Node FindPrev(object element)
    {
        Node current = header;
        while (current.link != null && current.link.element != element)
            current = current.link;
        return current;
    }
    public void Remove(object element)
    {
        Node current = FindPrev(element);
        if (current.link != null)
            current.link = current.link.link;
    }
    public void Print()
    {
        Node current = new Node();
        current = header;
        while (current.link != null)
        {
            Console.WriteLine(current.link.element);
            current = current.link;
        }
    }
    public int Count()
    {
        int c = 0;
        Node current = header; // Node current = header.link;
        while (current.link != null) //current != null
        {
            current = current.link;
            c++;
        }
        return c;
    }
    public int Sum(){
        int sum = 0;
        Node current = header.link;
        while (current != null)
        {
            sum += int.Parse(current.element.ToString());
            current = current.link;
        }
        return sum;
    }
    //Bổ sung thêm phương thức Swap và Sort.
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        LinkedList list = new LinkedList();
        list.Insert("1", "Header");
        list.Insert("6", "1");
        list.Insert("4", "6");
        list.Print();
        Console.WriteLine("Count={0}", list.Count());
        Console.WriteLine("Sum={0}", list.Sum());
        //Console.WriteLine("===");
        //list.Remove("Second");
        //list.Print();
        Console.ReadLine();

    }
}