FROM microsoft/dotnet:sdk
WORKDIR /app
COPY ./ /app

RUN dotnet build
RUN dotnet test
RUN dotnet publish -o ../Publish DevOpsToday/DevOpsToday.csproj

WORKDIR /app/Publish

EXPOSE 80
CMD [ "dotnet", "DevOpsToday.dll" ]
