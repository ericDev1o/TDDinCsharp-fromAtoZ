git config --get user.name
git config --get user.email
# git config --global user.name 'first last'
# git config --global user.email '@'
# local repository
git config --global init.defaultBranch main
  git config --global core.fsmonitor true
mkdir <new project directory>
cd <new project directory>
git init
touch readme.md
echo "#project name and usage" >> readme.md
git add *.cs readme.md
git status
git commit -m "description du contenu commit�"
git log --stat
git checkout -b <branchName>
git branch
#modifier
git checkout main
git merge <branchName>
git log --graph --oneline
git remote add origin git@git12345
git pull origin main --allow-unrelated-histories
git push -u origin main