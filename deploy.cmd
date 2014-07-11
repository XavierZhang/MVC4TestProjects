@echo off
IF "%SITE_FLAVOR%" == "xavierapi" (
  deploy.xavierapi.cmd
) ELSE (
  IF "%SITE_FLAVOR%" == "xaviermvc4" (
    deploy.xaviermvc4.cmd
  ) ELSE (
    echo You have to set SITE_FLAVOR setting to either "nodejs" or "mvc4"
    exit /b 1
  )
)
