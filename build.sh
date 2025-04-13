# dotnet nuget locals all -c
# git clean -fdx

mkdir -p nuget
dotnet tool restore
pushd .
cd src/Feliz.Shadcn
dotnet pack -o ../../nuget -c Release

cd ../Docs
dotnet tool restore
npm install
dotnet elmish-land restore
npm run build
popd
