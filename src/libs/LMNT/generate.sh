#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

raw_spec="$(mktemp)"
trap 'rm -f "$raw_spec"' EXIT

curl --fail --silent --show-error --location https://api.lmnt.com/spec -o "$raw_spec"
awk '/^openapi:/ { found = 1 } /^asyncapi:/ { found = 0 } found { print }' "$raw_spec" > openapi.yaml

autosdk generate openapi.yaml \
  --namespace LMNT \
  --clientClassName LmntClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme ApiKey:Header:X-API-Key \
  --exclude-deprecated-operations
