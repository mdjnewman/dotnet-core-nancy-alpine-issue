#!/usr/bin/env bash

set -o errexit
set -o pipefail
set -o noglob
set -o nounset

docker build -t demo        --build-arg VARIANT=        .
docker build -t demo-alpine --build-arg VARIANT=-alpine .

docker run -d -p 8080:80 demo
docker run -d -p 8081:80 demo-alpine

echo "Waiting for containers to start ..."

sleep 1

echo -e "Output from curl:\n"

curl localhost:8080 || true
echo
curl localhost:8081 || true

sleep 1

echo -e "\ndocker ps:\n"

docker ps -a | grep demo
