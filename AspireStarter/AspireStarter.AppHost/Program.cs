using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<AspireStarter_ApiService>("apiservice");

builder.AddProject<AspireStarter_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.AddProject<Aspire_WorkerService>("workerService");

builder.Build().Run();