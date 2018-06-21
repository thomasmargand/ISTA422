# Fundamentals of Azure Chapter 3 Homework
### Thomas Margand
### June 2, 2018

1. What is Azure Virtual Machines and the terminology used in the chapter to reference?

Azure Virtual Machines is one of the central features of Azure’s IaaS capabilities, together with Azure Virtual Networks. Azure Virtual Machines supports the deployment of Windows or Linux virtual machines (VMs) in a Microsoft Azure datacenter. You have total control over the configuration of the VM. You are responsible for all server software installation, configuration, and maintenance and for operating system patches. The terminology used to describe the Azure Virtual Machines feature and a virtual machine instance can be a little confusing. Therefore, throughout this chapter, Azure Virtual Machines will refer to the feature, while virtual machine or VM will refer to an instance of an actual compute node. (pg 70)

2. How do you stop an Azure VM, and give an example?

To stop a VM but keep it provisioned, you would need to use the Stop-AzureRmVM PowerShell cmdlet such as in the following example:

`Stop-AzureRmVM -Name "AzEssentialDev3" -ResourceGroup "AzureEssentials" -StayProvisioned`

For classic VMs, a similar cmdlet, `Stop-AzureVM`, would be used. When using the Azure CLI, there are two commands used to control the stopped state of a VM: `azure vm stop` and `azure vm deallocate`.
Shutting down the VM from the operating system of the VM will also stop the VM but will not deallocate the VM. (pg 71)

3. What are three main resource providers used when working with Azure Virtual Machines, Storage,
and Compute?

The Network resource provider (Microsoft.Network) handles all aspects of network connectivity such as IP addresses, load balancers, NICs, and so on. The Storage resource provider (Microsoft.Storage) handles the storage of the disks for a VM (in the context of Azure Virtual Machines). The Compute resource provider (Microsoft.Compute) handles details related to the VM itself, such as naming, operating system details, and configuration (size, number of disks, and so on). (pg 72)

4. Where are durable disks stored and what are the benefits?

All durable disks (the OS disk and data disks) are backed by page blobs in Azure Storage. Therefore, the disks inherit the benefits of blob storage: high availability, durability, and geo-redundancy options. Blob storage provides a mechanism by which data can be stored safely for use by the VM. The disks can be mounted as drives on the VM. The Azure platform will hold an infinite lease on the page blob to prevent accidental deletion of the page blob containing the VHD, the related container, or the storage account. (pg 73)

5. What is required when creating a VM in Azure using the Resource Manager model?

When working with the Resource Manager model, you have explicit and fine-grained control over nearly all aspects of the Azure VM. You will explicitly add components such as a network interface card (NIC), public IP address, data disks, load balancer, and much more. (pg 72)

6. What is a NIC and what does it what does it do for Azure?

A network interface card (NIC) provides network access to resources in an Azure virtual network. A NIC is a standalone resource, but it must be associated with a VM to provide network access (a NIC by itself is of little value). (pg 77)

7. Why should you deploy at least two instances of the VM? What is provided?

To avoid a single point of failure, it is recommended to deploy at least two instances of the VM. In fact, Azure provides an SLA only when two or more VMs are deployed into an availability set. This is a logical feature used to ensure that a group of related VMs are deployed so that they are not all subject to a single point of failure and not all upgraded at the same time during a host operating system upgrade in the datacenter. The first two VMs deployed in an availability set are allocated to two different fault domains, ensuring that a single point of failure will not affect them both simultaneously. (pg 78)

8. How many ways can you connect to your VM, and what are they?

Connectivity can be done by remotely accessing (for example, logging in remotely to) the VM for an interactive session or by configuring network access to allow other programs or services to communicate with the VM. (pg 84)

9. Who’s responsibility is it to manage the VM?

The user's.

10. What is important when determining the scale-out approach to VMs, and what model is this referred
to?

When determining the scale-out approach for VMs, it is important to determine the maximum number of VMs because that maximum number of VMs must be created, configured, and placed into the availability set. When it comes time to scale out, the VMs within the availability set are used to fulfill the scale-out needs. VMs within an availability set should all be the same size to take advantage of Azure’s autoscale feature.  This model refers to classic virtual machines. (pg 100)
