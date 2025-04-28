npx @openapitools/openapi-generator-cli generate -i $PSScriptRoot\sample.yml -g csharp -o $PSScriptRoot\generatorOutput `
  --skip-operation-example --package-name MyNamespace --model-package MySubset `
  --enable-post-process-file -p targetFramework=net8.0 -p library=generichost

