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
        Git: Is a version control system for saving a working chunk of a project at 
            differnet point of development

        Git Flow: Git follows the below flow;
            1. Develop your project locally (On your system)
            2. Initialize a local repository on the project folder using command 'git init'
            3. For every new working block of code or project, the following should be done;
                - Use command 'git add' with optional parameter (. -> all, or select different files) to add
                  the new lines of code or files into the git system
                - Once added, use command 'git commit -m {message}' to commit the changes with a commit
                  message to identify every step in the process of project development
            4. Once working tree is commited  and clean and also satisfactory for a push, follow the 
                following steps to push the source to a remote repository.
                - Add a remote repository to tract the local branch using the command
                    'git remote add {name} {url}' which creates a default branch master/main depending 
                    on the setting you have chosen on your version control portal.
                    e.g git remote add oge https://github.com/heightsInnov/GitDemo.git
                - Verify the remote branch added with the command 'git remote -v'
                - Once added, use the command 'git push {optional flag} {remote name} {remote branch}' to push
                  to the remote branch e.g git push -u oge master
                  optional flag examples include;
                    -f -> to force push to the branch
                    -u -> to update current branch
            5. To allow other memebers work on a team project, or as a team member, to use a git project, 
                use the command 'git clone {url}' to fetch the exisiting repository into your local.
            6. For new commits you can decide to create new branches to hold new implementations using the 
                command 'git branch {branch name}'
            7. switch the branch using the command 'git checkout {branch name}'
                Follow the steps again to add, commit and push to remote repository.

            => Assignment
            Write two classes
                1. Loan Request
                2. Customer Details
             with required arguement constructors.
             -- Create a new branch day8_assignment and push to the existing repository.
    */
}