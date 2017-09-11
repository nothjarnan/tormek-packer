windowAPI = {}

local windows = {
  testWindow = {
    title = "Testy window thing, yes.",
    width = 150,
    height = 150,
    x = 50,
    y = 20,
    layer = 0,
    content =  {
      testContent = {
        type = "panel",
        x = 0,
        y = 0,
        width = 150,
        height = 150,

      },
    },
  }
}
function windowAPI:drawWindows()
  local sortedWindows = {}
  for k,v in pairs(windows) do
    -- Sort windows based on layer, where layer 0 is top
    for i, val in pairs(windows) do
      if windows[k].layer > windows[i].layer then

      end
    end
  end

end

return windowAPI
