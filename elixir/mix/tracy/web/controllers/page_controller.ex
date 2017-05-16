defmodule Tracy.PageController do
  use Tracy.Web, :controller

  def index(conn, _params) do
    render conn, "index.html"
  end
end
