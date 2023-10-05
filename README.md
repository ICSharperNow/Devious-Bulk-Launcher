# Devious-Bulk-Launcher
![Dark Theme Launcher](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/383fab18-99ee-4108-b070-6d35f0b6aa0b)
![Dark Theme Settings](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/55a19709-e894-4d84-9be2-6f9956ab8393)

![Light Theme Launcher](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/fb0923a9-24d3-4691-88ba-19489d32a63a)
![Light Theme Settings](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/eff62d40-4e93-4a83-93a9-4294f1b9883a)

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
![Screenshot 2023-09-03 224047s](https://github.com/ICSharperNow/Devious-Bulk-Launcher/assets/58089967/625fe70a-39e4-44ef-b5ae-1b9c26a6d08f)


# Contact

Discord: ICSharperNow

