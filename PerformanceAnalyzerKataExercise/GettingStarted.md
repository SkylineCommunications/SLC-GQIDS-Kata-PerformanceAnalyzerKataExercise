# Getting Started with Skyline DataMiner DevOps

Welcome to the Skyline DataMiner DevOps environment!  
This quick-start guide will help you get up and running. It was auto-generated based on the initial project setup during creation.  
For more details and comprehensive instructions, please visit [DataMiner Docs](https://docs.dataminer.services/).

## Creating a DataMiner Application Package

This project was configured to create a `.dmapp` file every time you build the project.  
When you compile or build the project, you will find the generated `.dmapp` in the standard output folder, typically the `bin` folder of your project.

When you publish the project (see Publishing topic below), a corresponding item will be created in the online DataMiner Catalog.

## Migrating to a Multi-Artifact DataMiner Application Package

If you need to combine additional components in your `.dmapp` file, you should:

1. Open the `PerformanceAnalyzerKataExercise.csproj` file and ensure the `<GenerateDataminerPackage>` property is set to `False`.

2. Right-click your solution and select **Add > New Project**.

3. Select the **Skyline DataMiner Package Project** template.

Follow the provided **Getting Started** guide in the new project for further instructions.

## Publishing to the Catalog

This project was created with support for publishing to the DataMiner Catalog.  
You can publish your artifact either manually via the Visual Studio IDE or by setting up a CI/CD workflow.
## Publishing to the Catalog with Complete CI/CD Workflow

This project includes a complete GitHub workflow with quality gates for Catalog publishing.  
Follow these steps to set it up:

1. Create a GitHub repository by going to **Git > Create Git Repository**, selecting GitHub, and filling in the wizard before clicking **Create and Push**.

1. Set up the required variables:

   ### Required Variables
   - `SONAR_NAME`: SonarCloud project ID. For this project, use: `SkylineCommunications_SLC-GQIDS-Kata-PerformanceAnalyzerKataExercise`

1. Add this variable by navigating to **Settings > Secrets and variables > Actions** in your GitHub repository.

1. The workflow will automatically run when you create releases with version tags.

With this setup, creating a release with a version tag will trigger the complete workflow with quality gates, code analysis, and Catalog publishing.

> [!NOTE]
> For internal Skyline Communications repositories, authentication tokens are managed automatically. External organizations may need additional configuration.

### Releasing a Specific Version

1. Navigate to the **<> Code** tab in your GitHub repository.

1. In the menu on the right, select **Releases**.

1. Create a new release, select the desired version as a **tag**, and provide a title and description.

> [!NOTE]
> The description will be visible in the DataMiner Catalog.
