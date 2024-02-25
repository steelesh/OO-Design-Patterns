using SingletonPattern;

var s = Singleton.GetInstance();

s.SetValue("test");

// returns 'test'
Console.WriteLine(s.GetValue());

// same instance, so still returns 'test'
var t = Singleton.GetInstance();
Console.WriteLine(t.GetValue());