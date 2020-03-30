//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
using System.Security.Permissions;

namespace Rextester
{
	
    public class Program
    {
        public static void Main(string[] args)
        {
            int ch;
            //Your code goes here
            Console.WriteLine("This is file operation menu");
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1. Create a file");
	    Console.WriteLine("2. Copy a file");
	    Console.WriteLine("3. Rename a file");
	    Console.WriteLine("4.Concate two files");
	    Console.WriteLine("5.Read a file");
            ch = Convert.ToInt32(Console.ReadLine());
            switch(ch){
                case 1:
                //Creating a file
                                                string path= @"srcfile.txt";
                                                FileStream FS=File.Create(path);{
                                                Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");  
                                                FS.Write(info, 0, info.Length);  
                                                Console.WriteLine("File has been created");  
                                                break;
					}
						       
		case 2:
		//Copying a file	        string sourcepath=@"srcfile.txt";
						string destinationpath=@"desfile.txt";
						File.Copy(sourcepath,destinationpath);
						Console.WriteLine("The file has been copied");
						break;
		case 3:
		//Renaming a file		string srcpath=@"srcfile//lotus.jpg";
					        System.IO.FileInfo FI= new System.IO.FileInfo(srcpath);
					          if(FI.Exists)
					         {
						   FI.MoveTo(@"srcfile//rose.jpg");
						   Console.WriteLine("The file has been renamed");
					         }
					        break;
		case 4:
		//Concatnating two files in 3rd file	
		                                 {
		                                string sFile1=@"srcfile1.txt";
						string sFile2=@"srcfile2.txt";
						string sFile3=@"desfile.txt";
						FileStream fs1=null;
						FileStream fs2=null;
						FileStream fs3=null;
					
						try{
						   fs1=File.Open(sFile1,FileMode.Open);
						   fs2=File.Open(sFile2,FileMode.Open);
						   fs3=File.Open(sFile3,FileMode.Append);
							byte[] fs1Content=new byte [fs2.Length];
							byte[] fs2Content=new byte [fs2.Length];
							fs1.Read(fs1Content, 0, (int)fs1.Length);
							fs2.Read(fs2Content, 0, (int)fs2.Length);
							fs3.Write(fs1Content, 0, (int)fs1.Length);
							fs3.Write(fs2Content, 0, (int)fs2.Length);

                                                       Console.WriteLine("The 2 files are concatnated!");
						   }

						 catch (Exception ex)
                                                  {

                                                      Console.WriteLine("No Such Files");

                                                  }

						 finally 
                                                 {
						      fs1.Close();
						      fs2.Close();
						 }
					       }
						 break;
					 
		case 5:
		//reading a file		{ 
						 string filepath =@"srcfile.txt";
						 using(FileStream fs=File.OpenRead(filepath)){
						 byte[] b = new byte[1024];
						 UTF8Encoding temp = new UTF8Encoding(true);  

					           while (fs.Read(b, 0, b.Length) > 0) {  
                                                   Console.WriteLine(temp.GetString(b));  
                       
					         }
						
						 break;
						
						}
					}
					
                 }
               }
           }      
	}     


	
