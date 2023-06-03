# Devious-Bulk-Launcher
![image](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/7e1a5a2d-f027-44fa-857e-b44714599a73)
![image](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/bb5854fd-4f59-4b86-a451-63bb8b932feb)

# About The Project

This is a 3rd party utility written in C# to manage accounts when using the Devious Client.
It will store the Account Username, Account password, Proxy IP, Proxy Port, Proxy Username, Proxy Password, and Notes for each account.

When an account is selected within the Bulk Launcher it will launch a new instance of the Devious client passing the account/proxy/world parameters allowing it to automatically login.

This application was created to simplify account management in a manner that is very similar to TriBot's Bulk Account Launcher.

This project by no means has any associating with the Devious Client or it's creator jbx5. This project's intentions are to help individuals manage a vast number of accounts in an efficient manner.

# Getting Started

In order to use this utility successfully you will need to modify the RuneLite.java file within the existing Devious Client.

You will also need to install the "unethical-autologin" plugin located here: https://github.com/melxin/devious-plugins-extended/tree/master/unethical-autologin - credit to Melxin

The following code changes will need to be made within the RuneLite.java file below:

Under line #169
```
private static Boolean Enable_Auto_Login = false;
private static String Username = "";
private static String Password = "";
```



Under line #193
```
final ArgumentAcceptingOptionSpec<String> loginInfo = parser
		.accepts("login")
		.withRequiredArg().ofType(String.class);
```



Under line #263
```
if (options.has("login"))
{
  	String[] login = options.valueOf(loginInfo).split(":");

	if (login.length >= 2)
	{
		//Enable flag
		Enable_Auto_Login = true;
		
		//Set username
		Username = login[0];

		//Set password
		Password = login[1];
  	}
}
```



Under line #576
```
//Modify config to auto login with passed in parameters
if (Enable_Auto_Login == true)
{
	//Set username
	configManager.setConfiguration("hootautologin", "username", RuneLite.Username);
	System.out.println("Automatic Login Username: " + RuneLite.Username);

	//Set password
	configManager.setConfiguration("hootautologin", "password", RuneLite.Password);

	//Enable UnethicalAutoLoginPlugin
	configManager.setConfiguration("runelite", "unethicalautologinplugin", true);

	//Reset flag
	Enable_Auto_Login = false;
}
```

#Usage
Point the application to the client's .jar file and enjoy!

![image](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/ee334a49-fd03-4a15-9f31-0004b7bc18e9)
![image](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/e0386eb2-bf2f-4a4a-a1b8-dfbc2ed2190e)


# Contact

Discord: ICSharperNow#2771

