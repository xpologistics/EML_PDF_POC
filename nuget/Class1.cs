////using GroupDocs.Conversion.Options.Convert;
////using System;
////using System.Collections.Generic;
////using System.IO;
////using System.Net.Mail;
////using System.Text;
////using System.Xml.Linq;

////namespace nuget
////{
////    class Class1
////    {
////        public static void Main(string[] args)
////        {
////            // load the file to be converted
////            string sourcePath = @"C:\Users\sthazhekomat\Documents\nuget\nuget\sourcefile\sample.eml";
////            string targetPath = @"C:\Users\sthazhekomat\Documents\nuget\nuget\outputpath";
////            string fileName = Path.Combine(targetPath, "eml-converted-to.pdf-aspose");

////            using (var message = Aspose.Email.MailMessage.Load(sourcePath))

////            {

////                // save in different formats
////                //var options = new PdfConvertOptions();
////                // Save converted PDF file
////                message.Save(fileName, Aspose.Email.SaveOptions.DefaultEml);

////                //message.Save(Aspose.Email.SaveOptions.DefaultEml);

////                //message.Save(dir + "output.html", Aspose.Email.SaveOptions.DefaultHtml);

////                //message.Save(dir + "output.mhtml", Aspose.Email.SaveOptions.DefaultMhtml);

////            }
////        }
////    }
////}
//////            string sourcePath = @"C:\Users\sthazhekomat\Documents\nuget\nuget\sourcefile\sample.eml";
//////            string targetPath = @"C:\Users\sthazhekomat\Documents\nuget\nuget\outputpath";
//////            string fileName = Path.Combine(targetPath, "eml-converted-to.pdf");
//////        }
//////            private static string Convert(string _eml_file)
//////           {
//////               // load the EML file to be converted
//////                    var message = MailMessage.Load(_eml_file);
//////                // save EML as a PDF 
//////                message.Save("Saved File.pdf", SaveOptions.DefaultPdf);
//////                return message;
//////            }

////////            }
////////                Console.WriteLine("\nConversion to pdf completed successfully. \nCheck output in {0}");
////////            }
////////        }
////////    }
/////

//using Aspose.Words;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net.Mail;
//using System.Text;

///*
//This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
//when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
//If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from https://www.nuget.org/packages/Aspose.Email/, 
//install it and then add its reference to this project. For any issues, questions or suggestions 
//please feel free to contact us using https://forum.aspose.com/c/email
//*/

//namespace nuget
//{
//    class Class1
//    {
//        public static void Run()
//        {
//            // ExStart:SaveEmailAsPDF
//            // The path to the File directory
//            string dataDir = @"C:\Users\sthazhekomat\Documents\nuget\nuget\sourcefile\sample.eml";
//            MailMessage mailMsg = MailMessage.Load(dataDir + "message3.msg");
//            MemoryStream ms = new MemoryStream();
//            mailMsg.Save(ms, Aspose.Email.SaveOptions.DefaultMhtml);

//            // create an instance of LoadOptions and set the LoadFormat to Mhtml
//            EmlLoadOptions loadOptions = new EmlLoadOptions();
//            var loadOptions = new Aspose.Words.LoadOptions();
//            loadOptions.LoadFormat = LoadFormat.Mhtml;

//            // create an instance of Document and load the MTHML from MemoryStream
//            var document = new Aspose.Words.Document(ms, loadOptions);

//            // create an instance of HtmlSaveOptions and set the SaveFormat to Html
//            var saveOptions = new Aspose.Words.Saving.PdfSaveOptions();
//            document.Save(dataDir + "SaveEmailAsPDF_out.pdf", saveOptions);
//            // ExEnd:SaveEmailAsPDF
//        }
//    }
//}

