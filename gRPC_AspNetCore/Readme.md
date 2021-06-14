This solution is about creating gRPC sercice using gRPC template and Aspnetcore libraries.

1. Create a blank solution.
2. Create a gRPC Service project. The project structure includes\
	a. Reference to Grpc.AspNetCore nuget package.\
	b. Protos folder with sample proto file (greet.proto)\
	c. Services folder with implementation of greet.proto file.\
	d. Startup.cs file with changes to ConfigureServices and Configure method.\
		```
		public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<GreeterService>();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                });
            });
        }
		```
3. Create a grpc client project(.net core console app).
    a. Add references - Grpc.Tools, Grpc.Net.Client. Google.Protobuf.
    b. Add Protos folder - Add the proto files 
    c. Edit project file. - Add Itemgroup as below
        ```
        <ItemGroup>
            <Protobuf Include="Protos\greet.proto" GrpcServices="GrpcClient" />
        </ItemGroup>
        ```
     