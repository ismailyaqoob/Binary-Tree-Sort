using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSort
{
    class Program
    {
        private BinarySearchTree bst = new BinarySearchTree();
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Implementation();
        }
        public void Implementation()
        {
            Console.WriteLine("Pick out the number which you come down in favour of.");
            Console.WriteLine("1. Insert data");
            Console.WriteLine("2. Delete data");
            Console.WriteLine("3. Print");
            Console.WriteLine("4. Exit");
            //Getting input from user that, which operation user want to perform.
            Console.Write("Infiltrate your choice: ");
            int a = Convert.ToInt16(Console.ReadLine());
            switch (a)
            {
                //if user want to insert data.
                case 1:
                    {
                        Console.Clear();
                        //Getting number of data user want to enter.
                        Console.Write("Infiltrate the quantity of data: ");
                        int numberofdata = Convert.ToInt16(Console.ReadLine());
                        //Obtaining data by user.
                        GetData(numberofdata);
                        Console.WriteLine("Press any key to return to the main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        Implementation();
                        break;
                    }
                //if user want to delete data.
                case 2:
                    {
                        Console.Clear();
                        //Display data to the user so that user can decide what to delete.
                        Console.WriteLine("Your data");
                        bst.Inorder();
                        //Getting data user want to delete.
                        Console.Write("Enter data you want to delete: ");
                        int data = Convert.ToInt16(Console.ReadLine());
                        //if data exist then delete the data if not then show message that data does not exist.
                        if (bst.Search(data) != null)
                        {
                            DeleteData(data);
                            Console.WriteLine("\'{0}\' has been deleted from the list of data", data);
                        }
                        else
                        {
                            Console.WriteLine("\'{0}\' dose not exist in the list of data", data);
                        }
                        Console.WriteLine("Press any key to return to the main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        Implementation();
                        break;
                    }
                //if user want to traverse data.
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Your data");
                        //Get sorted data through traversing.
                        Traverse();
                        Console.WriteLine("Press any key to return to the main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        Implementation();
                        break;
                    }
                //if user want to exit.
                case 4:
                    break;
                //if user select invalid option.  
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                        Console.WriteLine("Press any key to return to the main menu...");
                        Console.ReadKey();
                        Console.Clear();
                        Implementation();
                        break;
                    }
            }
        }
        //Geting data.
        public void GetData(int numberofdata)
        {
            Console.WriteLine("Enter Data:");
            int i = 0;
            int data;
            while (i < numberofdata)
            {
                data = Convert.ToInt16(Console.ReadLine());
                bst.Add(data);
                i++;
            }
        }
        //Deleting the given data if exist.
        public void DeleteData(int data)
        {
            bst.Delete(data);
        }
        //Traverising data in sorted order.
        public void Traverse()
        {
            bst.Inorder();
        }
    }
}
