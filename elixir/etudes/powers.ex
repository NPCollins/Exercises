
import Kernel, except: [raise: 2]
defmodule Powers do
	def raise(x, y) do
		cond do
			y == 0 -> 1
			y == 1 -> x
			y > 0 -> x * raise(x, y - 1)
			y < 0 -> 1 / raise(x, -y) 
		end
	end	
end


