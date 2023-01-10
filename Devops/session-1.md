# Session 1

## Introduction
* Quick introduction from both sides
* Some practical guidelines for this lessons:
  * session of 2h: 50min + 10min (break) + 50min + 10min (retro)
  * this lesson is open-source, which means: contribute to it
  * no slides (or a few), all the notes can be found in this repository: you can still send a pull/merge request if something is missing for the next gen (or if you find a typo)
  * harassment in any form will not be tolerated
  * https://discord.gg/h276VmY4
  * raise your hand if something is unclear:
> If you ask a question, you might be dumb for maybe 2 minutes, if you don't ask question you'll be dump your all life

### Evaluation

Small project on what you want as long as it's devops related:
  * a one-pager
  * 5 minutes presentation + 3 minutes question (might be changed following the group size)
  * minimum 2 pers.
  * topics:
    * technical project (deployment of a server in the cloud, deployment pipeline, design, ...)
    * reading and summary about a techno

## Open-discussion

### Devops
* Is it a job? Is it a mindset? Is it a set of tools? Is it some processes?
* Question is: I developed my website on http://localhost, what do I do from now?
* You'll find a lot of definition and even more of opinions: find your own definition.
* Companies that rely on devops

### Tools
* Many, _many_ tools -> be the nightwatch
* Find the right tool(s) for the right issue(s) (see that like a toolbox)
* The idea is to understand the concept before the tools -> tools are the implementation of the concept

## Requirements

#### Linux

* SSH
* edit a file
* basic understanding of Linux tree (/etc, /usr, /tmp)
* basic understanding of network debugging
* basic understanding of systemd
* (container?)

#### Git

* One of the most useful tools (not only for DevOps!)
* Context: "I work on a codebase with other software engineers: how do we sync?"
* This lesson is versioned with `git`
* Some projects that use `git`: "linux", "android", actually many of the software you're using every day

##### Hands-On

The goal of this lab is to get the sources of this repository, create a file in it and merge the changes into the codebase.
It's like working with actual source files in a company.

_NOTE_: if `git` is ez pz for you, go help your teammates.

1. On your Linux machine, try to identify if `git` is installed.
2. Create a folder `ul-devops` and into this folder clone the repository: https://gitlab.com/ul-devops/lessons.git. Nice, you now have the lessons content locally on your workstation.
3. With Git: one `main` with other branches around. Create a branch and work with it[^1]: `git checkout -b $RANDOM-add-new-file` (TIPS: branch are often features or bugfix, try to keep an explicit name)
4. Create a file named after your name (`john-doe.md`) in the `students` folder.
5. In this file, add some content (a short "hello" and your git version)
6. `git status`: what do you see? What's the goal of this command?
7. `git add` / `git commit`: add the file to the tree, commit -> message (basically what you've done)
8. `git push -u origin <insert here your branch name>`
9. Create a GitLab account with your address (perso or student)
10. Open a Merge Request (what's a merge request?) https://gitlab.com/ul-devops/lessons/-/merge_requests/1

(11. If you don't have time, here's an example: https://asciinema.org/a/rE8MSLrMqKMGlSbS5joUtoS60)

Exemple of actual request: https://github.com/flatcar/update_engine/pull/18

## Open-discussion

* what did you learn?
* gitops

[^1]: https://git-scm.com/docs/git-branch
