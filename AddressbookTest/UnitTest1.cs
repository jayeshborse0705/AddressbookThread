using AddressbookThread;

namespace AddressbookTest
{
    public class Tests
    {
        List<AddressBook> AddressList;
        AddressBookOperation addressBookOperations;
        [SetUp]

        public void Setup()
        {
            AddressList = new List<AddressBook>();
            addressBookOperations = new AddressBookOperation();
        }

        [Test]
        public void CheckingTime_For_Inserting_Details()
        {
            AddressList.Add(new AddressBook(Firstname: "john", Lastname: "joy", Address: "Valsad", City: "Ahmadabad", State: "gj", Zip: 401305, PhoneNumber: 9458437543, Email: "rohan@gmail.com"));
            AddressList.Add(new AddressBook(Firstname: "yogi", Lastname: "Jen", Address: "Mg road", City: "Dubai", State: "DU", Zip: 401222, PhoneNumber: 9458452343, Email: "kylie@gmail.com"));
            AddressList.Add(new AddressBook(Firstname: "nneya", Lastname: "ner", Address: "Bels", City: "Sanf", State: "WC", Zip: 401303, PhoneNumber: 9354466543, Email: "kenny@gmail.com"));

            DateTime StartDateTime = DateTime.Now;
            addressBookOperations.AddContacts(AddressList);
            DateTime StopDateTimes = DateTime.Now;
            Console.WriteLine("Duration without threads: " + (StopDateTimes - StartDateTime));
        }
    }
}