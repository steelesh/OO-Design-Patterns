using FactoryMethodPattern;

// Console Logger
LoggerFactory loggerFactory = new ConsoleLoggerFactory();
ILogger logger = loggerFactory.CreateLogger();
logger.Log("hi there");

// Switching to a file logger
loggerFactory = new FileLoggerFactory();
logger = loggerFactory.CreateLogger();
logger.Log("hi there");