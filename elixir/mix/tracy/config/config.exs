# This file is responsible for configuring your application
# and its dependencies with the aid of the Mix.Config module.
#
# This configuration file is loaded before any dependency and
# is restricted to this project.
use Mix.Config

# General application configuration
config :tracy,
  ecto_repos: [Tracy.Repo]

# Configures the endpoint
config :tracy, Tracy.Endpoint,
  url: [host: "localhost"],
  secret_key_base: "dnxV4zCZbHaAJaILsDyfujrxC2Lx++ITVbKRfl3rht6LVH4hiXT4SJw2VsWvC87Q",
  render_errors: [view: Tracy.ErrorView, accepts: ~w(html json)],
  pubsub: [name: Tracy.PubSub,
           adapter: Phoenix.PubSub.PG2]

# Configures Elixir's Logger
config :logger, :console,
  format: "$time $metadata[$level] $message\n",
  metadata: [:request_id]

# Import environment specific config. This must remain at the bottom
# of this file so it overrides the configuration defined above.
import_config "#{Mix.env}.exs"
