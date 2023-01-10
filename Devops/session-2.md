# Session 2

In Session 1, we seen a devops overview and a useful tool for managing codebases. Now, let's see the playground of a devops: the cloud providers.

## Cloud providers

* What is a cloud provider?
* Cloud provider public / private?
* Some cloud providers:
    public: AWS (Amazon), Azure (Microsoft), Google Cloud Platform (Google), Scaleway, Hetzner, OVH~
    private: OpenStack (originally from NASA), VMWare

It's like programming languages: they all serve the same purposes but have some differences in the implementation.

__NOTE__:
  * show some examples of Cloud Providers interfaces.
  * mention the students pack

> DevOps can help to create the infrastructure where the application will be deployed.

How?
- design
- deploying (as code)
- provisioning (as code)

NOTE: Deploying is like providing the shell while provisioning is filling the shell.

## Design

Designing an infrastructure relies on a good knowledge of the involved components -> communications between teams.

It also requires to understand the needs and the spec of the infra to deploy:

example:
  * the application is divided between services and services are implemented in various languages: should I deploy everything on the same machine? Pro / cons ?
  * the application needs a database but this one must not be exposed on the internet, how do I segment my networks?
  * the application must be automatically deployed on 30% of the infra each time a new version is pushed

## Deploying

-> We deploy the components of the infra (server, database, networks, etc.): we're building the foundation of the application

Once we have a clear vision of the components to deploy and the cloud providers involved, we can start to create the infra.

Let's suppose we have a virtual machine to deploy:
  * manual deployment
  * deployment as code (infra as code (IaC))

Why IaC?

* manual deployment is OK to quickly test something but not for larger deployments
* "code" means versioning (with git) so if something breaks we can easily revert, identify the failure
* reviewed by the pair
* everything at the same place


## Provisioning

The infra is in place, we need to fill it with business logic.

With provisioning, we create on the instances:
* required users
* configuration files into /etc
* firewall rules on the server
* systemd unit files
* (everything required to run the application)

__NOTE__: Show an actual example of Ansible

### Hands-on

In the repo: ul-devops/ansible-101, try to run the playbook `examples/ansible-hello-world/playbook.yml`

```
git clone https://gitlab.com/ul-devops/ansible-101
cd ansible-101/examples/ansible-hello-world
ansible-playbook playbook.yml
```

question: why the host is 127.0.0.1

1. Try to create a directory in the `/tmp` folder of your machine via ansible. (https://docs.ansible.com/ansible/latest/collections/ansible/builtin/file_module.html)
2. In this folder, try to create a file. The content of the file must be the name of the Linux distribution
