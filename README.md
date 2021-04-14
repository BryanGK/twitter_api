# Happy-Tweet | Twitter Showcase App

### A full stack web application made with React JS, C# with ASP.Net Core, and styled using Bootstrap

![html](README_assets/React_Logo.png)
![csharp](README_assets/Csharp_Logo.png)
![dotnet](README_assets/NET_Core_Logo.png)
![css](README_assets/Bootstrap_Logo.png)

### See it [here](https://happy-tweet.azurewebsites.net/)

![Screenshot](README_assets/screenshot.png)

![Screenshot3](README_assets/screenshot1.png)

![Screenshot2](README_assets/screenshot2.png)

## Summary

Before this project I had been building apps exclusively in the front-end, building a full-stack app was
very intimidating. Through many long days of research and asking questions from my mentor and support group,
I was able to come up with an app that shows hard work and determination required to become a professional 
software developer.

Having completed this project from top to bottom I was able to further my knowledge of C#, .NET, React, and 
Bootstrap. From day one of this app I was learning how to create my own custom API and how to connect the back-end 
to the front-end client. I persevered and overcame the many challenges involved with this many moving parts. From
the first time I received data from the Twitter API to when I deployed on Microsoft Azure I have been totally
hooked on the challenges of software development, especially in the back-end. These are only the beginning steps in
my career. I am excited for what projects or additional technologies I may work with in the future.

Specific things I used and learned while building this application:

> Create ASP.Net Core Application

> Create services, controllers, and models to handle recieving API calls and make calls from a back end

> Dependency injection for C# classes

> Parsing data recieved from Twitter to return only what was needed to my front end application

> Building an API from scratch

> Styling React with Bootstrap 5

> Deployment to Microsoft Azure

## Installation

To run this application locally you need to add a file called `appsettings.Development.json` in the `API/` directory. The contents of the file should be the following:

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "Twitter_Key": {
    "BearerToken": "<Insert Twitter Bearer Token Here>"
}

```

You can get a Twitter bearer token from `https://developer.twitter.com/`, signing up for a developer account and creating a twitter web application.

You can then go to the `API/Client/` directory and run

```
npm i
```

Move to the `API/` folder and run

```
dotnet watch run
```

to start the application locally.

## Author

Bryan Krauss - Software Developer - [LinkedIn](https://www.linkedin.com/in/bryan-krauss-556b3a200/) | [Website](https://bryankrauss.ca/)