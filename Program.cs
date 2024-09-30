string readFile = @"C:\Users\ASUS\Desktop\New folder\read_file_vcs\read.csv";
using (StreamReader streamReader = new StreamReader(readFile)){
    string line ="";
    while ((line = streamReader.ReadLine())!=null)
    {
        Console.WriteLine(line);

    }

}