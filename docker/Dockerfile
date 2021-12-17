FROM mcr.microsoft.com/dotnet/sdk:5.0

# Set working directory
WORKDIR /app

# Copy compiled binaries
COPY ./obj ./bin

# Copy configuration
COPY config/*.* ./config/

# ENV MONGO_ENABLED true
ENV MONGO_SERVICE_URI ""
ENV MONGO_SERVICE_HOST mongo
ENV MONGO_SERVICE_PORT 27017
ENV MONGO_DB app
ENV MONGO_USER ""
ENV MONGO_PASS ""
# ENV HTTP_ENABLED true
ENV HTTP_PORT 8080

EXPOSE 8080

CMD dotnet ./bin/run.dll -c ./config/config.yml