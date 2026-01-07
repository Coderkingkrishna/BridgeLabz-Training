using System;

// CallLog class
class CallLog{
    public string PhoneNumber;
    public string Message;
    public DateTime TimeStamp;

    public CallLog(string phoneNumber,string message,DateTime timeStamp){
        PhoneNumber=phoneNumber;
        Message=message;
        TimeStamp=timeStamp;
    }

    public void Display(){
        Console.WriteLine("Phone: "+PhoneNumber);
        Console.WriteLine("Message: "+Message);
        Console.WriteLine("Time: "+TimeStamp);
        Console.WriteLine("----------------");
    }
}

// Manager class
class CallLogManager{
    private CallLog[] logs;
    private int count;

    public CallLogManager(int size){
        logs=new CallLog[size];
        count=0;
    }

    // Add call log
    public void AddCallLog(CallLog log){
        if(count<logs.Length){
            logs[count]=log;
            count++;
        }
        else{
            Console.WriteLine("Log storage full");
        }
    }

    // Search logs by keyword
    public void SearchByKeyword(string keyword){
        Console.WriteLine("Searching logs with keyword: "+keyword);
        for(int i=0;i<count;i++){
            if(logs[i].Message.Contains(keyword)){
                logs[i].Display();
            }
        }
    }

    // Filter logs by time range
    public void FilterByTime(DateTime start,DateTime end){
        Console.WriteLine("Filtering logs between "+start+" and "+end);
        for(int i=0;i<count;i++){
            if(logs[i].TimeStamp>=start && logs[i].TimeStamp<=end){
                logs[i].Display();
            }
        }
    }
}

// Main class
class MainClass{
    static void Main(){
        CallLogManager manager=new CallLogManager(5);

        manager.AddCallLog(new CallLog("9876543210","Network issue",DateTime.Now.AddHours(-3)));
        manager.AddCallLog(new CallLog("9123456789","Billing problem",DateTime.Now.AddHours(-2)));
        manager.AddCallLog(new CallLog("9988776655","Internet slow",DateTime.Now.AddHours(-1)));

        // Search by keyword
        manager.SearchByKeyword("Network");

        // Filter by time range
        DateTime startTime=DateTime.Now.AddHours(-2);
        DateTime endTime=DateTime.Now;
        manager.FilterByTime(startTime,endTime);
    }
}
