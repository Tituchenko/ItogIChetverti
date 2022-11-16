
string [] test={"dff","43535","-2"};
Console.WriteLine(String.Join(";",GetArratLessSymbol(test,3)));

string [] GetArratLessSymbol (string [] arr,int numSymb){
    string [] temp=new string [arr.Length];
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length<=numSymb) {
            temp[count]=arr[i];
            count++;
        }
        
    }
    string [] ret=new string [count];
    for (int i = 0; i < count; i++)
    {
        ret[i]=temp[i];
    }
    return ret;

}