local item = {
  T8 = {
    dimensions = {
      x = 385,
      y = 295,
      z = 385,
    },
    weight = 18,
    description = "Tormek T-8",
    name = "T-8",
    image = "uh",
  }
}
function item:getItems()
  return item
end
function item:getItem(name)
  if item[name] ~= nil then
    return item[name]
  else
    return false
  end
end
function item:createItem(name, width, height, depth, weight, description, dataValue, imagePath)
  if item[name] == nil then
    item[name] = {}
    item[name].dimensions = {}
    item[name].name = name
    item[name].dimensions.x = width
    item[name].dimensions.y = height
    item[name].dimensions.z = depth
    item[name].weight = weight
    if description then
      item[name].description = description
    else
      item[name].description = "No description provided."
    end
    if dataValue then
      item[name].dataValue = dataValue
    else
      item[name].dataValue = 0
    end
    if image ~= nil then
      item[name].image = love.graphics.newImage(imagePath)
    else
      item[name].image = love.graphics.newImage("/static/images/noImage.png")
    end
  else
    error("Item "..name.." already exists",2)
  end

  return item[name]
end
function item:deleteItem(name)
  if item[name] ~= nil then
    item[name] = nil
    return true
  else
    return false, "Item does not exist"
  end
end

return item
