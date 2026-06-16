#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated

raw_spec="$(mktemp)"
trap 'rm -f "$raw_spec"' EXIT

fetch_spec --fail --silent --show-error --location https://api.lmnt.com/spec -o "$raw_spec"
awk '/^openapi:/ { found = 1 } /^asyncapi:/ { found = 0 } found { print }' "$raw_spec" > openapi.yaml

autosdk generate openapi.yaml \
  --namespace LMNT \
  --clientClassName LmntClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme ApiKey:Header:X-API-Key \
  --exclude-deprecated-operations
