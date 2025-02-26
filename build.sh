dotnet tool restore
pushd .
cd src/Examples
npm install
dotnet elmish-land restore
popd
pushd .
cd src/Feliz.Shadcn
dotnet pack
popd