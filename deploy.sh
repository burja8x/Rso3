#!/bin/bash
set -ev

TAG=$1
DOCKER_USERNAME=$2
DOCKER_PASSWORD=$3

# Create publish artifact
dotnet publish -c Release -o app/publish

# Build the Docker images
docker build -t burja8x/rso1:$TAG RsoSem1/.
docker tag burja8x/rso1:$TAG burja8x/rsosem1:latest

# Login to Docker Hub and upload images
docker login -u="$DOCKER_USERNAME" -p="$DOCKER_PASSWORD"
docker push burja8x/rso1:$TAG
docker push burja8x/rso1:latest