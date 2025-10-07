using System;

namespace BasicsDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var task = new TaskItem
            {
                Title = "Start OOPs",
                Description = "Finish the project by the end of the day.",
                DueDate = DateTime.Now.AddDays(1)
            };
            var task2 = new TaskItem
            {
                Title = "Start SOLIDs",
                Description = "Finish the project by next day.",
                DueDate = DateTime.Now.AddDays(2)
            };

            task.PrintDetails();
            task2.PrintDetails();
        }
    }

    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        internal void PrintDetails()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("DueDate: " + DueDate);
        }
    }
}