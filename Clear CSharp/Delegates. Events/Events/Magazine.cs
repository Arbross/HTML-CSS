using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    delegate void NewpostAdded(string post);
    class Magazine
    {
        public event NewpostAdded NewPostAddedEvent; // event = safe use delegate check = null(error)
        public string Title { get; set; }
        List<string> posts = new List<string>();
        public void AddPosts(string content)
        {
            posts.Add($"{DateTime.Now}\t{content}");
            NewPostAddedEvent?.Invoke(content); // ініціюємо подію : викликаються методи групового делегату(методи subscriber)
        }
        public override string ToString()
        {
            return $"Magazine : {Title}\n{String.Join("\n\t", posts)}";
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public void Handler(string message) // non static
        {
            Console.WriteLine($"Customer {Name} was notified about : '{message}'");
        }
    }
    class Worker
    {
        public static void Handler(string message) // non static
        {
            Console.WriteLine($"All workers were notified about : '{message}'");
        }
    }
}
