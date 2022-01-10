# Hello, Beanstalk!

This is the code project for the [Hello, Beanstalk!](https://davidpallmann.hashnode.dev/hello-beanstalk) blog post. 

This episode: AWS Elastic Beanstalk. In this [Hello, Cloud](https://davidpallmann.hashnode.dev/series/hello-cloud) blog series, we're covering the basics of AWS cloud services for newcomers who are .NET developers. If you love C# but are new to AWS, or to this particular service, this should give you a jumpstart.

In this post we'll introduce AWS Elastic Beanstalk and use it to host a simple .NET "Hello, Cloud" web API project. We'll do this step-by-step, making no assumptions other than familiarity with C# and Visual Studio. In Part 1, we'll deploy to a development environment. In Part 2, we'll deploy to a production environment with a load balancer and auto-scaling

## Our Hello, Beanstalk Project

We’re going to create a default .NET 5 Web API project, see it work locally, then migrate it to Beanstalk—where we’ll run it on Linux. The tutorial is divided into two parts. In Part 1, you’ll create a service and deploy it to Elastic Beanstalk in a single-instance development environment. In Part 2, you’ll create a staging environment and a load-balanced production environment for your service.

See the blog post for the tutorial to create this project and run it on AWS.

