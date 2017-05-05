# Refactoring legacy code
LevelUp 2017 | ThoughtWorks Australia (Brisbane)

## Session pre-requisites

- If you just want to watch:
  - none at all.
  
- If you would like to follow along as we refactor:
    - Visual Studio (Community Edition is fine)
    - ReSharper.

## Our goal
Our goal is to refactor this tiny-yet-terrible app so that it's well-factored,
robust, testable and tested, and all within a brief tutorial session.

# Will you be my friend?
Here's what the app looks like:

    Round 0 of 3
    What is your name?
    Andrew
    Hello, Andrew!
    Isn't it a lovely afternoon?
    Do you like cookies?
    true
    That's great! I like cookies, too!

    Round 1 of 3
    What is your name?
    David
    Hello, David!
    Isn't it a lovely afternoon?
    Do you like cookies?
    true
    That's great! I like cookies, too!

    Round 2 of 3
    What is your name?
    Tony
    Hello, Tony!
    Isn't it a lovely afternoon?
    Do you like cookies?
    true
    That's great! I like cookies, too!

    Round 3 of 3
    What is your name?
    Michael
    Hello, Michael!
    Isn't it a lovely afternoon?
    Do you like cookies?
    false
    Get away from me, you sick person.

    Andrew is my friend
    David is my friend
    Tony is my friend
    Press any key to quit
