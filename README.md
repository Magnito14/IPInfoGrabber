# IPInfoGrabber
Simple CLI application that requests JSON data from ip-api.com, and displays your IP information to the console.

## Requirements
- Visual Studio
- Newtonsoft.Json

## Installation
To install the `Newtonsoft.Json` package from NuGet in C#, you can use the `dotnet` command-line interface (CLI) or the NuGet Package Manager in Visual Studio.

Here is how to install the package using the `dotnet` CLI:
```
dotnet add package Newtonsoft.Json
```
**To install the package using the NuGet Package Manager in Visual Studio, follow these steps:**
- Open your project in Visual Studio.
- In the Solution Explorer, right-click on the project and select "Manage NuGet Packages..."
- In the NuGet Package Manager window, click on the "Browse" tab and search for "Newtonsoft.Json"
- Select the package from the search results and click the "Install" button.

## How It Works
The `JsonConvert.DeserializeObject` method is used to convert the JSON string into an object of the specified type. In this case, it is converted into a `Dictionary<string, string>` object, which allows you to access the individual properties of the JSON object using their keys.

We then display the values of the key properties. 

## Contributing
### If you have a suggestion that would make this better, please fork the repo and create a pull request.

You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

- Fork the Project
- Create your Feature Branch (`git checkout -b feature/Feature`)
- Commit your Changes (`git commit -m 'Add some features'`)
- Push to the Branch (`git push origin feature/Feature`)
- Open a Pull Request

## Disclaimer
This source is for educational purposes only. Do not use this maliciously. I am not responsible for what you decide to do with this project.

## License
This project is licensed under the GNU General Public License v3.0. See the [LICENSE](https://github.com/Magnito14/IPInfoGrabber/blob/main/LICENSE) file for more information.
