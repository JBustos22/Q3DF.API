FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src

ENV DOCKER_BUILD 1
ARG CI_BUILD
ENV CI_BUILD CI_BUILD

COPY Api/*.csproj ./Api/
# remove existent non csproj files (if there are external references)
RUN find . ! -name '*.csproj' -type f -delete && find . -depth -empty -delete

RUN dotnet restore ./Api

COPY Api ./Api

ARG VERSION=0-unknown
ARG COMMIT_HASH
RUN dotnet publish ./Api --no-restore -c release -o /app -p:Version=$VERSION -p:SourceRevisionId=$COMMIT_HASH

FROM build as test
WORKDIR /src
# [TODO] add tests

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app

COPY --from=build /app ./

ENTRYPOINT ["./Api"]