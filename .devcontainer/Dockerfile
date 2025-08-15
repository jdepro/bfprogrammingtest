# See here for image contents:
# https://github.com/microsoft/vscode-dev-containers/tree/v0.205.2/containers/dotnet/.devcontainer/base.Dockerfile

ARG VARIANT="8.0-bookworm"
FROM mcr.microsoft.com/vscode/devcontainers/dotnet:${VARIANT}

RUN export DEBIAN_FRONTEND=noninteractive \
    && apt-get update \
    && apt-get -y install --no-install-recommends \
        git \
        neovim \
        stow \
        tmux;
