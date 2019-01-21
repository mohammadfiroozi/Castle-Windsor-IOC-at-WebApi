# Castle Windsor IOC with Asp.net Web Api Sample Project

This is a sample Project written in ASP.NET Web Api that uses the Windsor Castle IOC Container.
Castle Windsor is a Inversion of Control (IOC) container available for .NET and Silverlight.
# What is IOC?
IoC is a design principle which recommends inversion of different kinds of controls in object oriented design to achieve loose coupling between the application classes. Here, the control means any additional responsibilities a class has other than its main responsibility, such as control over the flow of an application, control over the dependent object creation and binding (Remember SRP-Single Responsibility Principle). If you want to do TDD (Test Driven Development) then you must use IoC principle without which TDD is not possible. Learn about IoC in detail in the next chapter.(rfrnc:tutorialsteacher)

# What is used in this project?
- Asp.net Web Api
- EF - Code First (for build this project : first change the connection string then execute add-migration and update-database commands at nuget package manager console)
- Consume web api with Ajax
- and our main purpose : Castle Windsor IOC

# How to use Castle Windsor container?

**1.Add Windsor Library Reference**

The easiest way to reference windsor library is using Nuget package installer :

install-package Castle.Windsor

**2.CastleConfig Class**

create a class to configure the dependency into app_start folder (same the sample)

**3.Implement the Customize ControllerActivator**

create a customize ControllerActivator class that driven from IHttpControllerActivator into app_start folder

**4.Introduce the ControllerActivator in Global.Asax**


:+1:Good luck / Mohammad firoozi (http://firoozi.info)



