# e-Videoteka
An application that functions like Netflix on a LAN level.
It allows user registration, login, movie addition, and user modification. During registration, a service is automatically added to Windows services in the background, which will later check whether it is running or not to determine if the user wants to enable movie viewing for users.
There is a special class called "WorkerService" that allows for the creation of services on computers with the Windows operating system. VLC plugins are installed to enable the playback of specific movies.
