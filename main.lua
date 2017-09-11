local item = require 'apis.item'
local t4 = nil
-- Multitask using APIs

function love.load()
  -- load files here
  t4 = item:createItem("T4",375,235,290,9.756,"Tormek T-4",0)
end


function love.update()

end


function love.draw()
  love.graphics.draw(t4.image,1,1)
  love.graphics.print(t4.description,1,1)
end
