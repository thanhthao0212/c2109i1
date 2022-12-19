
using OopPolymorphismInterface;

//FileOne f = new();
//f.WriteTextFile();
//f.WriteTextFile();
//f.ReadFile();
//((IBinaryFile)f).showInfo();
//(f as IBinaryFile).showInfo();

//FileTwo f = new();
//f.WriteTextFile();
//f.WriteTextFile();
//f.ReadFile();
//(f as IBinaryFile).ReadFile();
//(f as ITextFile).ReadFile();

ITextFile itext = new FileOne();
itext.ReadFile();
itext= new FileTwo();
itext.ReadFile();