class Readme{

    /*
        Classes and Object Oriented Programming
        Inheritance: Ability to inherit a property from a parent class
        Encapsulation: Is an act of hiding properties of a class from a user
        Abstraction: The art of hiding logical implementations from user
            Achieved through 
            1. Interface : A contract between the solid class and the implementing classes
            2. Abstract classes : A class with one or more abstract method (A default implementation that
                can be overriden).
            
            The difference between an interface and an absrtract class is:
                - An interface contains only method signatures and no implementation of logic
                - Abstract classes can contain implementations of logic

            We achieve abstraction using the interface and abstract method with the override and overload 
            implementation of methods.

            To override is to take-over and declare a prefered implementation of a method
            To overload is to have a method with same name but different signature.

            ===========OVERRIDE=====
            public override string generate(long firstEightDigit){
                return new Nuban(firstEightDigit, 1).ToString();
            }

            ======= OVERLOAD========
            public abstract string generate(long firstEightDigit);

            public string generate(){
                return new Nuban(00000000, 1).ToString();
            }


        =============== Class 7 ==============

        Access Modifiers
            - public : Objects can be accessed from any part of the project and even outside of the project
            - private :
            - protected
            - internal
            - static

        Side Note: DRY -> Do Not Repeat Yourself

        ============ Class 8 ===============

    */
}