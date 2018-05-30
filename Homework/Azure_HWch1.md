# Fundamentals of Azure Chapter 1 Homework
### Thomas Margand
### May 29, 2018

1. What are the differences between Iaas, Paas, and Saas?

SaaS is software that is centrally hosted and managed for the end customer. It usually is based on a multitenant architecture—a single version of the application is used for all customers. With PaaS, you deploy your application into an application-hosting environment provided by the cloud service vendor. The developer provides the application, and the PaaS vendor provides the ability to deploy and run it. An IaaS cloud vendor runs and manages server farms running virtualization software, enabling you to create VMs that run on the vendor’s infrastructure. (pg 3)

2. What is the Azure Service Management (ASM) deployment model? What is the Resource Manager
deployment model?

The Azure Service Management (ASM) deployment model has been used to deploy services. In the Azure portal, services managed with ASM are referred to as classic. In 2015, Microsoft introduced the Resource Manager deployment model as a modern, more functional replacement for ASM. The Resource Manager deployment model is recommended for all new Azure workloads. (pg 4)

3. What is the difference between a control plane and a data plane?

These deployment models are often referred to as control planes because they are used to control services, not just to deploy them. This is different from a data plane, which manages the data used by a service. (pg 5)

4. What is Role-Based Access Control?

You can use the new Role-Based Access Control (RBAC) to control access to the resources in the group. For example, you can assign the Owner role to a user, giving that user full administrative privileges to those resources in the group but not to other resources in the subscription. (pg 6)

5. Why would you want to create a custom role for role-based access control?

If your application or file had specific needs that required specific access requirements for different individuals than a custom role would make sense.

6. Consider the Azure portal. What is the dashboard? What is the hub? What is a blade?

The dashboard is component of the portal that lets you easily navigate the between subscriptions. I found various hubs that exist within the different technologies and services on the portal, I did not find one general hub.  I have no idea what a blade is I was unable to find anything on this in the portal.

7. Access the conceptual Azure documentation on Github. Search the documentation and answer this
question: What happens when I reach the spending limit?

Spending limit in Azure exists to prevent spending over your credit amount. All new customers who sign up for the trial or offers that includes credits over multiple months have the spending limit turned on by default. The spending limit is $0. It can’t be changed. The spending limit isn’t available for subscription types such as Pay-As-You-Go subscriptions and commitment plans. When your usage results in charges that exhaust the monthly amounts included with your subscription, the services that you deployed are disabled for the rest of that billing period.
https://docs.microsoft.com/en-us/azure/billing/billing-spending-limit

8. Access the Azure samples on Github. Search for an example that will allow you to download an Azure
invoice. Copy the source code to your discussion. (This is Program.cs.)

https://github.com/Azure-Samples/billing-dotnet-core-invoice-download

9. Access the Azure Resource Manager samples on Github. Search for a quickstart template that will
allow you to set up a free SQL Database for a web application. This template has four files. One file
is a markdown file. What is the type of the other three files?

The other three are json files. 
