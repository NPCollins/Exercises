defmodule Geom do
	def area tuple
	
	def area({shape, x, y}) do
		area(shape, x, y)
	end

	def area(shape, x \\ 1, y \\ 1)
	
	def area(shape, x, y) do
		case shape do
			:rectangle -> x * y
			:triangle -> x * y / 2
			:ellipse -> :math.pi * x * y
		end
	end
end
