dotnet tool restore
pushd .
cd src/Examples
npm install
dotnet elmish-land restore
popd
dotnet build