set -e

key=$(cat .secret)

cd ../src/hubspotdotnet
dotnet build -c Release
dotnet nuget push bin/Release/xtellurian.HubSpot.1.0.3.nupkg -k $key -s https://api.nuget.org/v3/index.json
