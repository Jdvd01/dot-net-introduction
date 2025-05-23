ILogger consoleLogger = new ConsoleLogger();
consoleLogger.Log("This is a log message to the console");

ILogger fileLogger = new FileLogger();
fileLogger.Log("This is a log message to a file");