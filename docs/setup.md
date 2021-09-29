# Setup

Multiple ways to get this sample code running on your box


### Prerequisites
Need ```dotnet``` installed on local system. Visit the [.NET](https://dotnet.microsoft.com/) website for getting started


### **Clone this repo from [GitHub]** with CLI

```bash
git clone https://github.com/schemburkar/demo-pipelines
```

### **Clone in GitHub Desktop**

Open this link in [GitHub Desktop](x-github-client://openRepo/https://github.com/schemburkar/demo-pipelines)

### **Creating this repo stucture from Scratch**


Once installed, we can get started with project creation with your favorite terminal

- Create a folder on your local drive

    ```bash
    mkdir demo-pipelines
    ```

- Create a new class library project named ```Core```

    This represents a common base functions for your project, like helpers, models etc.

    ```bash
    dotnet new classlib --name Core
    ```
- Create a new class library project named ```Business```

    This represents all the business logic that the project would need, usually validations and error handling.

    ```bash
    dotnet new classlib --name Business
    ```
- Create a new Web project named ```Web```

    This represents the actual Web project serving requests.

    ```bash
    dotnet new web --name Web
    ```
- Create a new test project named ```Tests```

    This represents the unit testing of your business logic

    ```bash
    dotnet new xunit --name Tests
    ```
                

    ```bash
    git clone https://github.com/schemburkar/demo-pipelines
    ```

- There are other steps like setting up references, nuget and more covered in other documents
