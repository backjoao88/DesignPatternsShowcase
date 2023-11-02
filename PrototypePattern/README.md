#### Prototype Pattern

<p>The prototype was made to solve the problem of cloning objects. Instead of creating a new object and setting all properties each time we need a new object (to not
use the main reference) we can call the Clone method implemented by classes that inherit from the ICloneable interface, which give us a deep copy of the object in that moment. 
The most important thing to note is that the clone is performed INSIDE the class that we want to copy, and not outside of it. This way we can copy all private and protected members of the data.</p>