
local ui = {
  testObject = {
    type = "window",
    position = {
      x = 30,
      y = 4
    },
    size = {
      width = 500,
      height = 350,
    }
    color = "FFFFFFFF" -- uck
    content = {
      testPanel = {
        type = "panel",
        position = {
          x = 0,
          y = 0,
        },
        size = {
          width = 300,
          height = 250,
        },
        color = "4A3784BA",
      }
    }
  }
}


return ui



function ui:createObject(obj)

end
