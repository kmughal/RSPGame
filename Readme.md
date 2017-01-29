# Rock, Paper, Scissors Game

## Technology Stack Used:
In order to complete this code example following stack has been used.

### Front End
- ES6
- Angular
- Bootstrap
- SCSS
- Web Pack
- Node

In order to run the front end I suggest following commands:

```
  go to command prompt after installing node
  navigate to > Task.RSP.Web (Folder) then
  npm install (this will install all dependencies)
  npm run build ( this will start the webpack and turn on the --watch flag so if you change the codebase then it will rebuild the js bundle )

```


### Back End
- .Net Framework 4.5.2
- Ninject as Ioc Container
- ASP.NET WEB API 2.0


## Project Structure

Layered architecture is used to build the project which gives ability to extend it in future.

- Task.RSP.Console: this is simple console application.
- Task.RSP.Domain: this contains the actual domain.
- Task.RSP.Service: this contains information about service  and ioc container though ioc container can be moved into another project but in order to have the simplicity it is kept in service layer.
- Task.RSP.Tests: this contains some basic unit tests which are essential for the domain though with more time more tests can be added.

## Run Project

We advice to create two different web site in IIS:
1. Front end
2. Back end ( call it `game` as this has been hardcoded in the angular service url but you can always change this !)


## Screen shots

Below is the image of the actual application.

### Console Application Output

Below is the screenshot taken from console app:
[ ](/images/image2.png)


### Web Application

[ ](/images/image1.png)

when user make selection

[ ](/images/image3.png)







