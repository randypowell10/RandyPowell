# Randy Powell Resume Website
### Built by: Randy Powell
### URL OF SITE: randypowell.azurewebsites.net

### Description
This app was built to fulfill the Final Project for CT-406 at Capitol Technology University


This app is a resume website for Randy Powell. It displays personal, professional, and education information in a clean
front end user interface. On the home page, a basic UI layout is constructed to link to some of the other major pages of the site
as well as links to various modes of contacting me. The biography page displays my education information as well as a personal bio.
The Projects page lists various projects I have been involved in and different inforrmation about them. The work experiences page displays
all of the various jobs I've ever held and information about what I did for them. The skills page displays my various technical skills broken
up by category.

The app dynamically tracks work experiences, project experiences, and skills. Two basic data models were created and can be seen in the Models folder.
These models are for experiences, which are further broken up into project and work by the type attribute, and skills. The experience model includes 
attributes for Id, Title, Organization, Location, Dates, Type, and Description. The description is stored as a series of sentences separated by semicolons
in order to make it easy to extract each individual sentences as a list item. The skill model includes attributes for Id, Title, and Type.
These data models are linked in
many-to-many relationships by the ExperienceSkill model. Many different skills can be associated with one experience and many different experiences can be
can be associated with one skill. This is done by creating a Experience Skill class with enough information to associate the id of an experience with an id
of a skill. In turn, each of the main class includes an "ICollection" of experience skills associated with it. All of this data is stored in an
Entity Framework Core database defined in the Data/RandyPowellContext class. This data is then used to populate various pages on the site.
This makes it very easy to add new skills and experiences to the site whenever needed and keep the site up to date.


The app was built using ASP.NET Core Razor Pages methodologies. Each individual page in the app is stored as a cshtml file and has an associated cshtml.cs file
containing the logic needed to build the site. All database references and app logic is stored in these cshtml.cs files.
The pages are mostly stored in the Pages folder. The data editing pages associated with each data type is located
in subfolders inside the Pages folder. The UI was built using html and css with the bootstrap and jquery frameworks. Each page uses the bootstrap grid system
to make them responsive on any size of device, including mobile. Elements resize themselves based on the size of screen. This makes for a clean
site that is accessible on any device.


I have created two small APIs, one for each data type. These APIs are stored in the Controllers folder as Controller classes. The ExperienceController contains
an API which can be accessed through the route "/api/Experience". I created two GET functions for this API. The first, GetById(int id), retrieves an experience object
by its integer id. The second, GetAll(), retrieves a list of all experiences. These two routes are not used anywhere in this app but can be accessed by navigating
to their respective URL routes. For example, you can access the getAll() function at randypowell.azurewebsites.net/api/Experience . This will print all database
entries for experiences to the screen with no UI. The second API, defined in SkillController can be accessed through the route "/api/Skill". This API also
has two GET functions. The first, getAll(), is similar to the one in the other API and retreives a list of all skill entries in the database. This function is not
used anywhere in the app but can be accessed at randypowell.azurewebsites.net/api/Skill . The other function, GetByExpId(int id), retrieves a list of
skill titles as strings which are associated to a specific experience, referenced by the ID parameter. It is used to easily gather a list of all skills
that are used in an experience. This function is used in the app in Pages/Experiences/Details.cshtml. In a script at the end of that file, I call the API
GET function using jquery and use it to populate the list of skills associated with the experience. 


To make the app secure, I have implemented a form of identity in the Areas/Identity folder. I have used the default Identity scaffolder to generate all files
required to host accounts on the site. The accounts are also stored in RandyPowellContext. To make the app more secure, I have removed the functionality of
creating more accounts from the common user. All account pages besides the login page are secured by placing [Authorize] at the top of their page classes.
This makes it so there is only ever able to be one user registered with the site, Me. The SeedData class was used to create the only user and has since been
altered to hide the one master password. In addition to the account pages, I have also placed [Authorize] tags on all data editing pages in the Pages/Experiences
and Pages/Skills folders, besides the Experiences Details page, which is linked to from the work and projects pages and links directly back to those pages.
This prevents anyone who is not logged into the system from editing my data and since I am the only user registered with the system, I am the only person 
who is able to edit data. Whenever anyone attempts to access an unauthorized page, they are redirected to the login page, which displays no option for 
registering an account and they cannot log in, unless they are me.