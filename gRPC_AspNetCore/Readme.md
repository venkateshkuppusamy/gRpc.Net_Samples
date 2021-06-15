This solution is about creating gRPC sercice using gRPC template and Aspnetcore libraries.
1. Includes Server streaming cancellation by client. 
2. Client and Server Interceptors.
3. Unit test and mocking GRPC client.

Steps to be followed.
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
3. Create a grpc client project(.net core console app). \
    a. Add references - Grpc.Tools, Grpc.Net.Client. Google.Protobuf. \
    b. Add Protos folder - Add the proto files \
    c. Edit project file. - Add Itemgroup as below \
        ```
        <ItemGroup>
            <Protobuf Include="Protos\greet.proto" GrpcServices="GrpcClient" />
        </ItemGroup>
        ```
 4. Create a Blog service in GrpcServer project . Create blog, Read blog and Read blog lines. \
       Read blog lines is grpc stream service implement with client cancellation to cancel the server streaming.

 5. Add Interceptor to all client calls. 
    a. Add ClientIntercetor.cs class and link that to the channel.
    b. ClientInterceptor.cs class had a commonn deadline set for all the grpc calls.
 
 6. Add Interceptor to all Server calls.
    a. Add ServerInterceptor.cs class. Implement the necessary method in our case UnaryServerHandler method.
    b. In the startup file in ConfiguresServices method add the interceptor.



