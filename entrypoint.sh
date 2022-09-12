#!/usr/bin/env bash

# Change directories
pushd /app

# Execute Migrations
Update-Database -Verbose

# Run the app
/app/ProjectManagementCMS_Blazor

popd
