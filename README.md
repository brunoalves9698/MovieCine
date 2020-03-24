# MovieWebApp

Front-end of listing movies with ASP.NET Core MVC 3.

![app](https://github.com/brunoalves9698/moviewebapp/blob/master/moviecine.png)

## About this Project

Front-end of listing movies with ASP.NET Core MVC 3.

## Why?

This project aims to create the list of films using ASP.NET Core MVC and consuming an API.

## Features

- Registration screen
- Login screen
- Movie Listing Screen
  - Filter by genre
  - Filter by release date
  - Movie details
  
## Getting Started

### Prerequisites

To run this project in the development mode, you'll need to have a basic environment to run a .NET Core Application. You can get it [here](https://dotnet.microsoft.com/download).

Also, you'll need to the server running locally on your machine with the mock data. You can find the server and all the instructions to start the server [here](https://github.com/brunoalves9698/MovieServer).

### Connecting the App with the Server

1 - Follow the instructions on the [MovieServer](https://github.com/brunoalves9698/MovieServer) to have the server up and running on your machine.

2 - With the server up and running, go to the /src/movieservice.api/appsettings.Development.json file and edit the 'Server' value into 'connectionString' key for the SqlServer of your machine.

It should looks like this:

"connectionString": "Server=YOUR_SQL_SERVER_PROVIDER\\SQLEXPRESS;DataBase=MovieCine;Trusted_Connection=true;"

### Installing

**Cloning the Repository**

```
$ git clone https://github.com/brunoalves9698/moviewebapp.git

$ cd moviewebapp
```

### Running

Exeutar através do Visual Studio

## Built With

- [.NET Core MVC 3](https://docs.microsoft.com/pt-br/dotnet/core/)
