# Plugin Pattern

Using this technique, we will use the standard GOF State Pattern by having a host application expose a piece of functionality as interface. The host will then load different implementations based on some criteria that we'll be choosing. Once we have a class that implements this interface, it can be "plugged" into the host application by dropping the containing dll into a specified folder which provides the host application with a "pluggable" implementation of the exposed interface.
<br/>
<br/>
![alt](https://process.filestackapi.com/cache=expiry:max/resize=width:1050/6B5KZWSSvmwriEa9VJyg)
