﻿// Application Programming NET Programming with C# by Abdullahi Tijjani

// Working with file information


// Make
sure the example file exists

const string filename = "TestFile.txt";


if (IFile.Exists(filename)) {

using (Streamwriter sw - File.CreateText (filename)) 1

Sw.WriteLine("This is a text file.");

}

// TODO: Get some information about the file

Console.WriteLine($"File '{filename) created at {File.GetCreationTime(filename)}");

Console-WriteLine($"File '(filename)' last written at{File.GetCreationTime(filename)}™);

Console WriteLine($"File '{filename}' last accessed at {File.GetCreationTime(filename)}™);

File.SetAttributes(filename, FileAttributes.ReadOnly);

Console-WriteLine($"File '{filename) attributes: {File.GetAttributes(filename)}*);

// TODO: We can also get general information using a FileInfo

tryt

FileInfo fileInfo - new(filename);

Console.WriteLine($"Length of {fileInfo.Length}");

｝

catch(Exception e)

Console WriteLine($"Exception: {e}");

throw;


//
TODO: File information can also be manipulatated
DateTime datetime = DateTime.Now;
File.SetCreationTime(filename, dateTime);
Console.Writeline($"File {filename}' Created at {File.GetCreationTime(filename)}'");