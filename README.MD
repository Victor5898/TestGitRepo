
# Git Flow Training

## Main objectives for this training:

- Explain about centralized model and distributed model
  
- Explain about VCS: git, SVN(Apache Subversion)
  
- Commands: `add` & `commit` & `reset`
    - Tell about staged changes (what files and changes will be commited)
    - What will happen if I `add` a file in stage, modify it and `commit`)
    - Remove file from stage using `reset`
    - What is .gitignore file and how it can be used inside project folders

- Create, manage and remove branches
    - Tell how can work without branch
    - Demonstrate case when we can lose history

- Jumping between commits using `reset` or `checkout`
    - Tell about HEAD
    - Tell how we can lose history using `reset` 
    <br />
    <img width="400" height="250" src="./docs/headImage.png">
    <br />
    - Explain all `reset` flags: `--mixed`, `--soft` and `--hard`
    <br />
    <img width="400" height="250" src="./docs/resetWithAllFlags.jpg">
    <br />

- Explain `merge` command
<br />
<img width="400" height="250" src="./docs/gitmerge2.png">
<br />

- Explain `revert` command ( IMPORTANT!!! specify difference between `revert` and `reset` )
  
- (Optional) Explain `log` and flags `--all`, `--oneline` and `--graph` -> *Can be used SourceTree or VScode with GitHistory Extension* 

- (Optional) Explain `diff` command -> *Can be used SourceTree or VScode with GitLens Extension* 


## Technical tasks


- Clone or fork this repository and push it to github using your account
- Create branches `task1` and `task2` from the base branch `develop`
- Checkout to `task1`
  - For the class `Credit` write correct logic for `Equals` and `HashCode`
  - For the class `Credit` write wrong logic for `CompareTo` like
    ```cs
    //...
    return 22 + 33 - 10;
    //...
    ```
  - For the class `LinearSearchingAlgorithm` write correct logic for `findElement`