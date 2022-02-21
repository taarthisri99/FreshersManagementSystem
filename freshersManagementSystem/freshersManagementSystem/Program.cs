using System;

namespace FreshersManagementSystem
{
    /* <summary> FreshersManagementSystem implements the application 
       to create, view and search trainees */
    public class FreshersManagementSystem
    {

        /* <summary> Displays choices and selects respective operations to create,
           view , search trainees and exit the application */
        private void ManageFreshers()
        {
            int userChoice = 0;
            string options = "Enter your choice\n1.Create trainee/trainees\t 2.View all trainees\t\t " +
                "3.Search a particular trainee\t\t 4.Exit";
            do
            {
                Console.WriteLine(options);

                userChoice = GetValidChoice();

                switch (userChoice)
                {
                    case 1:
                        CreateTrainee();
                        break;
                    case 2:
                        ViewTrainees();
                        break;
                    case 3:
                        SearchTrainees();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("\nInvalid input !!!");
                        break;
                }
            } while (4 != userChoice);
        }

        /* <summary> Gets a valid choice from the user 
           <returns> the user choice */
        private int GetValidChoice()
        {
            int userChoice = 0;
            Boolean isValidChoice = false;

            do
            {
                try
                {
                    userChoice = Convert.ToInt16(Console.ReadLine());
                    isValidChoice = true;
                }
                catch (Exception exception)
                {
                    Console.WriteLine("\nEnter valid input !!!");
                }

            } while (!isValidChoice);

            return userChoice;
        }

        /* <summary> Creates one or more trainees by saving the trainee details 
           in text file */
        private void CreateTrainee()
        {
            List<Trainee> trainees = GetTraineesDetails();

            FileStream fileStream = new FileStream(@"c:\.net training\trainees.txt", FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream);            

            foreach (var trainee in trainees)
            {
                streamWriter.WriteLine(trainee);
            }

            streamWriter.Close();
            fileStream.Close();
            Console.WriteLine("Trainees created successfully");
        }

        /* <summary> Gets the details namely name, mobile number, date of birth, address
           in text file 
           <returns> A list of trainees */
        private List<Trainee> GetTraineesDetails()
        {
            int lastTraineeID = 0;
            int noOfTrainees;
            int count = 0;
            string name;
            DateOnly dateOfBirth;
            string address;
            long mobileNumber;
            List<Trainee> trainees = new List<Trainee>();

            try
            {
                String lastLine = File.ReadLines(@"c:\.net training\trainees.txt").Last();
                string[] lastLineAttributes = lastLine.Split(", ");
                lastTraineeID = Convert.ToInt32(lastLineAttributes[0]);
            }
            catch(Exception exception){}

            Console.WriteLine("Enter the number of trainees : ");
            noOfTrainees = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("\nTrainee number : " + ++lastTraineeID + "\nEnter trainee details + \nName : ");
                name = Console.ReadLine();

                Console.WriteLine("Mobile Number : ");
                mobileNumber = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Date of Birth : ");
                dateOfBirth = DateOnly.Parse(Console.ReadLine());

                Console.WriteLine("Address : ");
                address = Console.ReadLine();

                Trainee trainee = new Trainee(lastTraineeID, name, mobileNumber, dateOfBirth, address);
                trainees.Add(trainee);
                count++;

            } while (count != noOfTrainees);

            return trainees;
        }

        /* <summary> Displays the trainees details namely name, mobile number,
           date of birth, address */
        private void ViewTrainees()
        {
            FileStream fileStream = new FileStream("c:\\.net training\\trainees.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);

            string datum = "";
            while (null != (datum = streamReader.ReadLine()))
            {
                string[] trainees = datum.Split("\n");
                foreach (string trainee in trainees)
                {
                    string[] traineeAttributes = trainee.Split(", ");
                    int age = CalculateAge(traineeAttributes[3]);

                    Console.WriteLine("\nID : " + traineeAttributes[0] + "\nName : " + traineeAttributes[1] 
                        + "\nMobile Number : " + traineeAttributes[2]
                        + "\nDate Of Birth : " + traineeAttributes[3] 
                        + "\nAge : " + age + "\nAddress : " + traineeAttributes[4] + "\n");
                }
            }
            streamReader.Close();
            fileStream.Close();
        }

        /* <summary> Calculates the age using date of birth of the trainee 
           <param> date of birth of the trainee
           <returns> age of the trainee */
        private int CalculateAge(string dateOfBirthInString)
        {
            int yearOfBirth = DateOnly.Parse(dateOfBirthInString).Year;
            int age = (DateTime.Now.Year - yearOfBirth) - 1;

            return age;
        }

        /* <summary> Displays choices to search the trainees 
           and selects respective operations */
        private void SearchTrainees()
        {
            int choice;
            Console.WriteLine("Enter your choice\n1.Search trainee according to ID" +
                "\n2.Search according to first letter of the name");
            choice = GetValidChoice();
           
            switch(choice)
            {
                case 1:
                    SearchAccordingToId();
                    break;
                case 2:
                    SearchAccordingToName();
                    break;
            }
        }

        /* <summary> Search Trainees according to ID */
        private void SearchAccordingToId()
        {
            Console.WriteLine("Enter the Trainee ID ");
            int id = Convert.ToInt32(Console.ReadLine());

            FileStream fileStream = new FileStream("c:\\.net training\\trainees.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);

            string datum = "";
            Boolean isIdMatches = false;
            while (null != (datum = streamReader.ReadLine()))
            {
                string[] trainees = datum.Split("\n");
                foreach (string trainee in trainees)
                {
                    string[] traineeAttributes = trainee.Split(", ");
  
                    if (Convert.ToInt32(traineeAttributes[0]) == id)
                    {
                        Console.WriteLine("\nName : " + traineeAttributes[1] + "\nMobile Number : " + traineeAttributes[2] + "\n");
                        isIdMatches = true;
                    }
                }
            }
            streamReader.Close();
            fileStream.Close();

            if (!isIdMatches)
            {
                Console.WriteLine("No Trainees available with ID " + id);
            }
        }

        /* <summary> Search Trainees according to name */
        private void SearchAccordingToName()
        {
            Console.WriteLine("Enter the first letter of the name : ");
            string firstLetter = Console.ReadLine();

            FileStream fileStream = new FileStream("c:\\.net training\\trainees.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);

            string datum = "";
            Boolean isLetterMatches = false;
            while (null != (datum = streamReader.ReadLine()))
            {
                string[] trainees = datum.Split("\n");
                foreach (string trainee in trainees)
                {
                    string[] traineeAttributes = trainee.Split(", ");
                    for (int index = 0; index < traineeAttributes.Length; index++)
                    {
                        if (1 == index && traineeAttributes[1].Substring(0, 1) == firstLetter)
                        {
                            Console.WriteLine(traineeAttributes[1]);
                            isLetterMatches = true;
                            break;
                        }
                    }
                }
            }
            streamReader.Close();
            fileStream.Close();

            if (!isLetterMatches)
            {
                Console.WriteLine("No Trainees available with the first letter " + firstLetter);
            }
        }

        public static void Main(string[] args)
        {
            FreshersManagementSystem freshersManagementSystem = new FreshersManagementSystem();
            freshersManagementSystem.ManageFreshers();
        }
    }
}