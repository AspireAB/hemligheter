[![.NET Build](https://github.com/Nethouse/hemligheter/actions/workflows/build.yml/badge.svg?branch=main)](https://github.com/Nethouse/hemligheter/actions/workflows/build.yml)

# Hemligheter
Password manager backed by Azure Key Vault

## Getting started
Hemligheter works by querying Azure for all Key Vaults that your user has access to. You must have at least the "List" access policy assigned to see the vault in Hemligheter.

## Passwords
Passwords in Hemligheter are stored as secrets in Key Vault. Additional properties such as username, URL and last modified date are stored as metadata on the secret.

## Folders
You can create a virtual folder structure in Hemligheter by adding dashes in the name.

Example passwords:
* `this-password1`
* `this-is-a-folder-password2`
* `this-is-a-folder-password3`
* `this-is-a-folder-subfolder-password4`

Generates the folder structure:
```
this
|-password1
|-is
  |-a
    |-folder
      |-password2
      |-password3
      |-subfolder
        |-password4
```
