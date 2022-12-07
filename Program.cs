namespace Day_14PracticeProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //UseCase1
            //Console.WriteLine("Entered Simple LinkedList");
            //UC_1SimpleLinkedList UC_1 = new UC_1SimpleLinkedList();
            //UC_1.Add(56);
            //UC_1.Add(30);
            //UC_1.Add(70);
            //UC_1.Display();
            //Console.ReadKey();
            //Console.WriteLine("----------------------------------------");
            ////UseCase2
            //Console.WriteLine("Entered Adding LInkedList");
            //UC_2AddingLinkedList UC_2 = new UC_2AddingLinkedList();
            //UC_2.add(70);
            //Console.WriteLine("Inserting 30");
            //UC_2.add(30);
            //Console.WriteLine("Inserting 56");
            //UC_2.add(56);
            //UC_2.Display();
            //Console.WriteLine("After Insertion of all values");
            //Console.WriteLine("----------------------------------------");
            ////UseCase3
            //Console.WriteLine("Entered LinkedList by Appending");
            //UC_3Appending UC_3 = new UC_3Appending();
            //UC_3.Append(56);
            //UC_3.Append(30);
            //UC_3.Append(70);
            //UC_3.Display();
            //Console.ReadKey();
            //Console.WriteLine("----------------------------------------");
            ////UseCase4
            //Console.WriteLine("Entered Inserting value in between ");
            //UC_4BetweenInserting UC_4 = new UC_4BetweenInserting();
            //UC_4.Add(56);
            //UC_4.Add(70);
            //UC_4.InsertAtParticularPosition(2, 30);
            //UC_4.Display();
            //Console.ReadKey();
            //Console.WriteLine("----------------------------------------");
            ////UseCase5
            //Console.WriteLine("Displayiny the value after deleting first element");
            //UC_5DeleteFirstElement UC_5 = new UC_5DeleteFirstElement();
            //UC_5.Add(56);
            //UC_5.Add(30);
            //UC_5.Add(70);
            //Console.WriteLine("After deleting the first value");
            //UC_5.RemoveFirstNode();
            //UC_5.Display();
            //Console.ReadKey();
            //Console.WriteLine("----------------------------------------");
            ////UseCase6
            //Console.WriteLine("Displayiny the value after deleting last element");
            //UC_6DeleteLastElement UC_6 = new UC_6DeleteLastElement();
            //UC_6.Add(56);
            //UC_6.Add(30);
            //UC_6.Add(70);
            //Console.WriteLine("After Removal of Last node then linked list is");
            //UC_6.RemovaLastNode();
            //UC_6.Display();
            //Console.ReadKey();
            //Console.WriteLine("----------------------------------------");
            //UseCase7
            Console.WriteLine("Finding the search Node");
            UC_7FindNode UC_7 = new UC_7FindNode();
            UC_7.Add(56);
            UC_7.Add(30);
            UC_7.Add(70);
            UC_7.Search(30);
            UC_7.Display();
            Console.ReadKey();
            Console.WriteLine("----------------------------------------");
            //UseCase8
            Console.WriteLine("Diaplayiny the value after insertion");
            UC_8InsertValue UC_8 = new UC_8InsertValue();
            UC_8.Add(56);
            UC_8.Add(30);
            UC_8.Add(40);
            UC_8.Add(70);
            UC_8.Display();
            Console.ReadKey();
            Console.WriteLine("----------------------------------------");
            //UseCase9
            Console.WriteLine("Displaying the values after deleting");
            UC_9DeleteValue UC_9 = new UC_9DeleteValue();
            UC_9.Add(56);
            UC_9.Add(30);
            UC_9.Add(40);
            UC_9.Add(70);
            UC_9.Display();
            Console.Write("Enter The Element You Have To Delete:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Previous Element Of That Element You Have To Delete:");
            int b = Convert.ToInt32(Console.ReadLine());
            UC_9.Delete(b, a);
            UC_9.Display();
            UC_9.size();


        }
    }
}