#!/bin/sh

# Decrypt the file
mkdir $HOME/secretsthree
# --batch to prevent interactive command
# --yes to assume "yes" for questions
gpg --quiet --batch --yes --decrypt --passphrase="$LARGE_SECRET_PASSPHRASE_3" \
--output $HOME/secretsthree/Program.cs Neoflix/Program.cs.gpg
