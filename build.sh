dotnet tool restore
pushd .
cd src/Feliz.Shadcn
dotnet pack -o ../../nuget -c Release
cd ../Docs
npm install
dotnet elmish-land restore
popd
