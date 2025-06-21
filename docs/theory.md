# 📘 Theoretical

**Author:** `bhalut`  
**Date:** 2025  
**Project:** `Assessment`

This document addresses the theoretical component of the technical assessment. Each response is written with modern AWS best practices, use-case clarity, and production-ready perspectives.

## 1. 📊 Compare Amazon RDS and Amazon DynamoDB

> **Question:**  
> Describe the differences between Amazon RDS and Amazon DynamoDB. Provide use cases where each service would be more appropriate from a developer's perspective.

### ✅ Amazon RDS (Relational Database Service)

- Fully managed **SQL-based database** (e.g., MySQL, PostgreSQL, Oracle)
- Supports transactions, joins, complex queries
- Ideal for structured, normalized data
- Vertical scaling with **read replicas** for performance
- Includes **Aurora Serverless v2** for autoscaling at millisecond granularity

### ✅ Amazon DynamoDB

- Fully managed **NoSQL database**
- Key-value and document model
- **Schema-less**, horizontally scalable
- Ultra-low latency (single-digit ms)
- Deep AWS integration: Lambda, Streams, DAX, etc.

| Feature         | Amazon RDS               | Amazon DynamoDB              |
| --------------- | ------------------------ | ---------------------------- |
| Data Model      | Relational (SQL)         | NoSQL (Key-Value / Document) |
| Schema          | Rigid (fixed schema)     | Flexible (schema-less)       |
| Scaling         | Vertical + Read Replicas | Horizontal (Auto Sharding)   |
| Transactions    | Full ACID                | Limited (transaction API)    |
| Latency         | ms to seconds            | Single-digit ms              |
| Serverless Mode | Aurora Serverless v2     | Built-in                     |

### 🛠 Use Case Fit

- **Use RDS** for: ERP, finance systems, analytics, apps needing JOINs
- **Use DynamoDB** for: real-time dashboards, mobile apps, IoT, session storage

## 2. ⚙️ What is AWS Lambda and Serverless?

> **Question:**  
> What is AWS Lambda and how does it support serverless computing? Provide an example of a serverless application using AWS Lambda with code snippets.

### ✅ What is AWS Lambda?

**AWS Lambda** is a compute service that runs your code **without provisioning or managing servers**.

**Key Benefits:**

- ⚡ Auto-scaling and instant execution
- 💰 Pay-per-execution (millisecond granularity)
- 🔌 Native integration with AWS (S3, API Gateway, DynamoDB)
- ✅ Supports Python, Node.js, Java, Go, and more

### 📌 Lambda Example: Python + API Gateway

```python
def lambda_handler(event, context):
    name = event.get("queryStringParameters", {}).get("name", "world")
    return {
        "statusCode": 200,
        "body": f"Hello, {name}!"
    }
```

**Flow:**

1. API Gateway receives HTTP request
2. Triggers Lambda function
3. Lambda processes and responds (serverless REST API)

## 3. 🔁 What is DevOps and Why is it Important?

> **Question:**
> Explain the concept of DevOps and its importance in modern software development. Discuss the key practices and tools used in DevOps, focusing on AWS services.

### ✅ DevOps Defined

DevOps combines **cultural principles**, **automation**, and **continuous delivery** to shorten development cycles and improve reliability.

### 🔑 Practices

- Continuous Integration / Continuous Delivery (CI/CD)
- Infrastructure as Code (IaC)
- Monitoring and Observability
- Security Automation (DevSecOps)

### 🧰 AWS DevOps Tools

| Tool           | Purpose                            |
| -------------- | ---------------------------------- |
| CodeCommit     | Source control (Git)               |
| CodeBuild      | Build, test, and package           |
| CodeDeploy     | Deploy apps to EC2, Lambda, or ECS |
| CodePipeline   | CI/CD orchestration                |
| CloudFormation | IaC with YAML/JSON                 |
| CloudWatch     | Logging and metrics                |

### 🚀 Value Proposition

- Fast, safe, and repeatable deployments
- Error reduction via automation
- Rapid feedback and rollback
- Developer empowerment through pipelines

## 4. 🚀 Setting up CI/CD with AWS CodePipeline and CodeBuild

> **Question:**
> Describe the process of setting up a CI/CD pipeline using AWS CodePipeline and AWS CodeBuild. Provide an example of how to deploy a web application using these services.

### ✅ CI/CD Flow Overview

1. Developer pushes code to Git repo (CodeCommit, GitHub)
2. CodePipeline triggers automatically
3. CodeBuild installs dependencies and runs tests
4. CodeDeploy (or Lambda) deploys artifacts

### 📄 Sample `buildspec.yml`

```yaml
version: 0.2

phases:
  install:
    runtime-versions:
      python: 3.11
  build:
    commands:
      - pip install -r requirements.txt
      - pytest --cov
artifacts:
  files:
    - "**/*"
reports:
  coverage:
    files:
      - htmlcov/index.html
```

> This pipeline installs dependencies, runs tests, and collects test coverage.

## 5. ☁️ Amazon S3 and Common Use Cases

> **Question:**
> Explain the concept of Amazon S3 and its common use cases in cloud applications. Provide an example of how to upload and retrieve files from S3 using code snippets.

### ✅ What is S3?

Amazon S3 (Simple Storage Service) is a **durable, secure, and scalable** object storage system.

### 🌍 Use Cases

- Host static websites
- Store logs, images, backups
- Integrate with Athena for big data
- Source of truth for ML data pipelines

### 🧪 Code Example (Python + boto3)

```python
import boto3

s3 = boto3.client("s3")

# Upload a file
s3.upload_file("local.txt", "my-bucket", "folder/remote.txt")

# Download a file
s3.download_file("my-bucket", "folder/remote.txt", "local_copy.txt")
```

> Ensure `aws configure` is run to set up credentials.

## 🧠 Summary

- ✅ RDS is great for relational workloads; DynamoDB is perfect for fast, scalable NoSQL
- ✅ Lambda powers event-driven serverless architecture with zero admin overhead
- ✅ DevOps is a cultural + technical shift toward automation and fast delivery
- ✅ CI/CD with CodePipeline and CodeBuild simplifies secure, automated deployments
- ✅ S3 is a cornerstone for cloud storage, static sites, data lakes, and more

**📁 File location:** `docs/theory.md`

**📄 License:** MIT

**✍️ Author:** `bhalut`
