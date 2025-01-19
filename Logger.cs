using System;

//Hohoho
namespace CustomLogger
{
    public static class Logger
    {
        public static void LogMessage (string message, LoggingType logType){
            switch (logType){
                case LoggingType.Normal:
                    Normal(message);
                    break;
                case LoggingType.Warning:
                    Warning (message);
                    break;
                case LoggingType.Error:
                    Error (message);
                    break;
            }
        }

        private static void Normal (string msg){
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine (msg);
        }

        private static void Warning (string msg){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine ("Warning" + msg);
        }

        private static void Error (string msg){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine ("Error" + msg);
        }
    }

    public enum LoggingType {
        Normal, Warning, Error
    }
}
