# Session 3

In previous sessions, we seen how to deploy and provision infrastructures on cloud providers using Git and IaC. Let's bring some automation.

Bringing automation is part of the devops methodology.

## Why?

* single source of trust
* less human error
* more time for other tasks (:warning: https://imgs.xkcd.com/comics/automation.png)
* think about the cost of the automation (https://en.wikipedia.org/wiki/Ostrich_algorithm)
* release more often
* get clear status of the release
* improve the bus factor (https://en.wikipedia.org/wiki/Bus_factor)

## How?

* CI/CD Engine (Github Actions, Jenkins, Gitlab, Circle CI,... ) 
* Pipeline
* CI/CD (Continuous Integration / Continous Delivery)

## Example of pipeline

### Application

https://gitlab.com/ul-devops/simple-app/-/pipelines/736385103 (show notif)
https://github.com/flatcar/scripts/actions/runs/3827935258/jobs/6512973246

When a developer pushes some code on a branch:
1. Test the code (unittests, e2e, integrations, etc.)
2. Build the assets (npm package, python wheel, docker image, etc.)
3. Deploy the assets (registry, etc.)
4. (extra tests once deployed)

### Infra

When an ops pushes some code on a branch:
1. Terraform plan
1.1 (validation against policy: https://www.openpolicyagent.org/docs/latest/terraform/)
2. Manual terraform apply
3. Ansible deployment

## Hands-on

Write a simple pipeline that is going to deploy a simple static webpage on the webserver.
* The static webpage must be named after your name (john-doe.html)
* The pipeline must be in three steps:
1. Test your ansible (run it without actually applying the change, it's called a "dry run" in IT) - it's useful to be sure of what you're deploying
2. Apply your ansible

Note:
* Server public IP is 35.184.171.226
* SSH key is available under ${SSH_DEPLOYMENT_KEY}
* Content must be deployed under `/home/devops/content/`
