# Devious-Bulk-Launcher
![image](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/11d3d3c0-5bc6-46ea-9ce9-b7c31a77e983)
![Screenshot 2023-09-03 222900](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/d696a419-c3d7-4d09-8d4f-6c1b207332bd)


# About The Project

This is a 3rd party utility written in C# to manage accounts when using the Devious Client.
It will store the Account Username, Account password, Proxy IP, Proxy Port, Proxy Username, Proxy Password, and Notes for each account.

When an account is selected within the Bulk Launcher it will launch a new instance of the Devious client passing the account/proxy/world parameters allowing it to automatically login.

This utility was created to simplify account management in a manner that is very similar to TriBot's Bulk Account Launcher.

This project by no means has any association with the Devious Client or it's creator jbx5. This project's intentions are to help individuals manage a vast number of accounts in an efficient manner.

# Getting Started

In order to use this utility successfully you will need to modify the RuneLite.java file within the existing Devious Client.

You will also need to install the "unethical-autologin" plugin located here: https://github.com/melxin/devious-plugins-extended/tree/master/unethical-autologin - credit to Melxin

The code changes to the RuneLite.java file should be as follows below:

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

Lastly I would highly recommend disabling the "Stretched Mode" plugin as it seems to conflict with the "unethical-autologin" plugin.

![image](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/1d60f381-f894-4046-923b-496a71862a48)


# Usage
Point the application to the client's .jar file and enjoy!

![image](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/8fc724c0-ad17-4960-938d-2e135e0b9ab5)
![Screenshot 2023-09-03 222431](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/1b056b5d-2372-413f-a19f-ba77949b851c)


# Contact

Discord: ICSharperNow

