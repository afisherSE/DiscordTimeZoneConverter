// See https://aka.ms/new-console-template for more information
//TODO: Check that Time is input in correct format
//TODO: Check that Date is input in correct format
void Main()
{
    Console.WriteLine("Enter time of event (HH:MM AM/PM) and make sure to include space between time and AM/PM!: ");
    var inputTime = Console.ReadLine();
    Console.WriteLine("Enter date of event (MM/DD/YYYY): ");
    var inputDate = Console.ReadLine();
    var complete = inputDate + ' ' + inputTime;
    try{
    var dateTime2 = DateTime.Parse(complete);
    var dto2 = new DateTimeOffset(dateTime2).ToUnixTimeSeconds().ToString();
    dto2 = "<t:" + dto2 + ":f>";
    Console.WriteLine(dto2);
    }
    catch(Exception e){
        Console.WriteLine("an error occured");
        Console.WriteLine(e);
    }
    Console.WriteLine("Please Copy with CTRL + C, then press enter");
    Console.ReadLine();
}
Main();
