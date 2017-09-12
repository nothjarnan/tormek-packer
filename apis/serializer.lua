local serializer = {}


function serializer:serialize(table)
  if type(table) ~= "table" then
    error("Expected table, got "..type(table))
  else
    -- serialize to JSON or Lua Table?
  end

end

return serializer
