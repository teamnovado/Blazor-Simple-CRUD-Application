# Blazor-Simple-CRUD-Application

A simple CRUD application written in Blazor for the first edition of the Novado Innovationlab.
The application is kept simple while trying to still portray a 'real' application as much as possible.

The application is structured as followed:
* A businesslayer containing mapper and service classes
* A datalayer using Entity framework core, which automatically seeds data.
* A 'shared' library for Blazor, so both front-end and back-end can safely used shared models and validation 
* A Blazor server-side application built on top of the previous

## Blazor
Specific to Blazor the application includes samples of the following features:
* Routing / Dynamic routing
* Navigation
* Form validation
* Pages and Components
* Passing data and delegates between components and pages
* Sample templating syntax
* Lifecycle hooks
* Dependency injection

## How to run
Everything you need is included in the repository. The data is stored in an SQLite DB, which is also included. Simply clone and run to get started.
