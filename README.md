github-cloudlabsuser-715: create a README.md file the summarizes the ARM templates and the project files

GitHub Copilot: # README.md

```markdown
# Project Title

This project uses Azure Resource Manager (ARM) templates for the deployment of resources in Azure. The ARM templates provide a declarative way to define the deployment.

## ARM Templates

The ARM templates in this project are defined in JSON format. The main components of the templates are:

- `$schema`: The location of the JSON schema file that describes the version of the template language.
- `contentVersion`: The version of the template (in the format 1.0.0.0).
- `parameters`: The parameters for the template. These are values that are provided when deployment is executed to customize resource deployment.

## Project Files

### deploy.parameters.json

This file contains the parameters for the ARM template. These parameters are used during the deployment of the resources. The parameters include:

- `appServicePlanName`: The name of the App Service plan.
- `webAppName`: The name of the Web App.
- `location`: The location where the resources will be deployed (e.g., "canadacentral").

## Deployment

To deploy the resources, you will need to run the ARM template with the parameters file. This can be done using the Azure CLI or PowerShell.

Please replace the parameter values in the `deploy.parameters.json` file with your specific values before running the deployment.

## Contributing

Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
```


github-cloudlabsuser-715: @workspace generate a README.md file that summarizes the arm templates and the github actions workflow

GitHub Copilot: Deciding which workspace information to collect

Collecting workspace information

Filtering to most relevant information

# README.md

## ARM Templates

The ARM templates for this project are defined in two files: [`deploy.json`](command:_github.copilot.openRelativePath?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fc%3A%2FUsers%2Fazureuser%2Fsource%2Frepos%2FContact-Database-Application%2Fdeploy.json%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%5D "c:\Users\azureuser\source\repos\Contact-Database-Application\deploy.json") and [`deploy.parameters.json`](command:_github.copilot.openRelativePath?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fc%3A%2FUsers%2Fazureuser%2Fsource%2Frepos%2FContact-Database-Application%2Fdeploy.parameters.json%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%5D "c:\Users\azureuser\source\repos\Contact-Database-Application\deploy.parameters.json").

The [`deploy.parameters.json`](command:_github.copilot.openRelativePath?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fc%3A%2FUsers%2Fazureuser%2Fsource%2Frepos%2FContact-Database-Application%2Fdeploy.parameters.json%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%5D "c:\Users\azureuser\source\repos\Contact-Database-Application\deploy.parameters.json") file contains the parameters for the deployment, including the app service plan name, web app name, and location. Here is a brief overview of the parameters:

- `appServicePlanName`: The name of the App Service plan. Current value is "righ-ghchack-web-asp".
- `webAppName`: The name of the Web App. Current value is "righ-ghchack-web".
- `location`: The location for the resources. Current value is "canadacentral".

The [`deploy.json`](command:_github.copilot.openRelativePath?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fc%3A%2FUsers%2Fazureuser%2Fsource%2Frepos%2FContact-Database-Application%2Fdeploy.json%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%5D "c:\Users\azureuser\source\repos\Contact-Database-Application\deploy.json") file contains the actual ARM template which uses these parameters to deploy resources.

## GitHub Actions Workflow

The GitHub Actions workflow for this project is defined in [`.github/workflows/master_righ-ghchack-web.yml`](command:_github.copilot.openRelativePath?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fc%3A%2FUsers%2Fazureuser%2Fsource%2Frepos%2FContact-Database-Application%2F.github%2Fworkflows%2Fmaster_righ-ghchack-web.yml%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%5D "c:\Users\azureuser\source\repos\Contact-Database-Application\.github\workflows\master_righ-ghchack-web.yml"). The workflow is triggered on push to the `master` branch or manually via `workflow_dispatch`.

The workflow consists of two jobs: `build` and `deploy`.

### Build Job

The `build` job runs on the latest version of Windows. It sets up MSBuild and NuGet, restores NuGet packages, builds the project, and publishes the output to a folder. The output is then uploaded as an artifact named "ASP-app".

### Deploy Job

The `deploy` job also runs on the latest version of Windows and depends on the `build` job. It downloads the "ASP-app" artifact and deploys it to an Azure Web App named "righ-ghchack-web" in the "Production" slot. The publish profile is retrieved from a secret named "AZUREAPPSERVICE_PUBLISHPROFILE_CD1296573E3340D982929157E031CC91".

github-cloudlabsuser-715: @workspace generate a README.md file which will include the ARM template deployment process and GitHub Actions workflow file to deploy the web app to azure

GitHub Copilot: Deciding which workspace information to collect

Collecting workspace information

Filtering to most relevant information

# README.md

## ARM Templates

The ARM templates for this project are defined in two files: [`deploy.json`](command:_github.copilot.openSymbolInFile?%5B%22deploy.json%22%2C%22deploy.json%22%5D "deploy.json") and [`deploy.parameters.json`](command:_github.copilot.openSymbolInFile?%5B%22deploy.parameters.json%22%2C%22deploy.parameters.json%22%5D "deploy.parameters.json").

The [`deploy.json`](command:_github.copilot.openSymbolInFile?%5B%22deploy.json%22%2C%22deploy.json%22%5D "deploy.json") file contains the actual ARM template which uses parameters to deploy resources. It defines the resources to be deployed to Azure, including an App Service Plan and a Web App. The App Service Plan is named according to the `appServicePlanName` parameter, and the Web App is named according to the `webAppName` parameter. Both resources are deployed to the location specified by the `location` parameter.

The [`deploy.parameters.json`](command:_github.copilot.openSymbolInFile?%5B%22deploy.parameters.json%22%2C%22deploy.parameters.json%22%5D "deploy.parameters.json") file contains the parameters for the deployment, including the app service plan name, web app name, and location. Here is a brief overview of the parameters:

- `appServicePlanName`: The name of the App Service plan. Current value is "righ-ghchack-web-asp".
- `webAppName`: The name of the Web App. Current value is "righ-ghchack-web".
- `location`: The location for the resources. Current value is "canadacentral".

## GitHub Actions Workflow

The GitHub Actions workflow for this project is defined in [`.github/workflows/master_righ-ghchack-web.yml`](command:_github.copilot.openSymbolInFile?%5B%22.github%2Fworkflows%2Fmaster_righ-ghchack-web.yml%22%2C%22.github%2Fworkflows%2Fmaster_righ-ghchack-web.yml%22%5D ".github/workflows/master_righ-ghchack-web.yml"). The workflow is triggered on push to the `master` branch or manually via `workflow_dispatch`.

The workflow consists of two jobs: `build` and `deploy`.

### Build Job

The `build` job runs on the latest version of Windows. It sets up MSBuild and NuGet, restores NuGet packages, builds the project, and publishes the output to a folder. The output is then uploaded as an artifact named "ASP-app".

### Deploy Job

The `deploy` job also runs on the latest version of Windows and depends on the `build` job. It downloads the "ASP-app" artifact and deploys it to an Azure Web App named "righ-ghchack-web" in the "Production" slot. The publish profile is retrieved from a secret named "AZUREAPPSERVICE_PUBLISHPROFILE_CD1296573E3340D982929157E031CC91".

## Deployment Process

To deploy the web app to Azure using the ARM templates and GitHub Actions workflow, follow these steps:

1. Update the [`deploy.parameters.json`](command:_github.copilot.openSymbolInFile?%5B%22deploy.parameters.json%22%2C%22deploy.parameters.json%22%5D "deploy.parameters.json") file with the desired values for the `appServicePlanName`, `webAppName`, and `location` parameters.
2. Push the changes to the `master` branch or manually trigger the GitHub Actions workflow.
3. The `build` job will compile the project and upload the output as an artifact.
4. The `deploy` job will download the artifact and deploy it to the Azure Web App specified in the `deploy` job's `app-name` parameter.

Please note that you need to have the publish profile for the Azure Web App saved as a secret in your GitHub repository. The secret should be named "AZUREAPPSERVICE_PUBLISHPROFILE_CD1296573E3340D982929157E031CC91".