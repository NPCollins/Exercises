defmodule Dijkstra do

	def gcd(m \\ 1, n \\ 1)

	def gcd(m, n) do
		cond do
			m == n -> m
			m > n -> gcd(m - n, n)
			true -> gcd(m, n - m)
		end
	end

end
