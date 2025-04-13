

iPhone iphoneA = new iPhone { Name = "apple" };
iPhone iphoneB = new iPhone { Name = "berry" };
iPhone iphoneC = new iPhone { Name = "cherry" };
iPhone iphoneD = new iPhone { Name = "kiwi" };

Android androidA = new Android { Name = "date" };
Android androidB = new Android { Name = "elderberry" };
Android androidC = new Android { Name = "kiwi" };

Toolbox toolbox = new Toolbox { Name = "ToolboxA" };

bool result = toolbox.ComparePhoneNames(iphoneA, androidA);

Console.WriteLine($"{result}");