//using GroupDocs.Conversion;
//using GroupDocs.Conversion.Options.Convert;
//using Microsoft.VisualBasic;
//using System;
//using System.IO;
////using System.Linq;
////using System.Text;

//namespace nuget
//{
//    class Program
//    //    //    {
//    //    //        static void Main(string[] args)
//    //    //        {
//    //    //            string _eml_file = @"";
//    //    //            string message = Convert(_eml_file);

//    //    //            Console.WriteLine("Hello World!");
//    //    //        }

//    //    //        private static string Convert(string _eml_file)
//    //    //        {
//    //    //            // load the EML file to be converted
//    //    //            var message = MailMessage.Load(_eml_file);
//    //    //            // save EML as a PDF 
//    //    //            message.Save("Saved File.pdf", SaveOptions.DefaultPdf);
//    //    //            return message;
//    //    //        }
//    //    //    }
//    //    //}
//    //    {
//    //        public static void Run()
//    //        {
//    //            // ExStart:SaveEmailAsPDF
//    //            // The path to the File directory
//    //            string dataDir = RunExamples.GetDataDir_KnowledgeBase();
//    //            //MailMessage mailMsg = MailMessage.Load(dataDir + "message3.msg");
//    //            MailMessage mailMsg = MailMessage.Load(dataDir + "message3.msg");
//    //            MemoryStream ms = new MemoryStream();
//    //            mailMsg.Save(ms, Aspose.Email.SaveOptions.DefaultMhtml);

//    //            // create an instance of LoadOptions and set the LoadFormat to Mhtml
//    //            var loadOptions = new Aspose.Words.LoadOptions();
//    //            loadOptions.LoadFormat = LoadFormat.Mhtml;

//    //            // create an instance of Document and load the MTHML from MemoryStream
//    //            var document = new Aspose.Words.Document(ms, loadOptions);

//    //            // create an instance of HtmlSaveOptions and set the SaveFormat to Html
//    //            var saveOptions = new Aspose.Words.Saving.PdfSaveOptions();
//    //            document.Save(dataDir + "SaveEmailAsPDF_out.pdf", saveOptions);
//    //            // ExEnd:SaveEmailAsPDF
//    //        }
//    //    }
//    //}

//    //internal static class ConvertEmlToPdf

//    {
//        public static void Main(string[] args)
//        {
//            string sourcePath = @"C:\Users\sthazhekomat\Documents\nuget\nuget\sourcefile\sample.eml";
//            string targetPath = @"C:\Users\sthazhekomat\Documents\nuget\nuget\outputpath";
//            string fileName = Path.Combine(targetPath, "eml-converted-to.pdf");
//            //string outputFolder = Constants.GetOutputDirectoryPath();
//            //string outputFile = Path.Combine(outputFolder, "eml-converted-to.pdf");
//            using (var converter = new GroupDocs.Conversion.Converter(sourcePath))
//            {
//                var options = new PdfConvertOptions();
//                // Save converted PDF file
//                converter.Convert(fileName, options);
//            }
//            Console.WriteLine("\nConversion to pdf completed successfully. \nCheck output in {0}", targetPath);
//        }
//    }
//}






