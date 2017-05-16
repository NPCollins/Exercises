

defmodule Powers do
import Kernel, except: [raise: 2]
	
	def raise(x, n)

	def raise(_, 0) do
		1
	end
	def raise(x, n) when n < 0 do
		1 / raise(x, -n)
	end
	def raise(x, n) when n > 0 do
		raise(x, n, 1)
	end

	defp raise(x, n, accumulator)

	defp raise(_x, 0, accumulator) do
		accumulator
	end
	defp raise(x, n, accumulator) do
		raise(x, n - 1, x * accumulator)
	end
end


