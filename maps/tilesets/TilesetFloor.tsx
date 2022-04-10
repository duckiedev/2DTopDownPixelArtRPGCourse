<?xml version="1.0" encoding="UTF-8"?>
<tileset version="1.8" tiledversion="1.8.4" name="TilesetFloor" tilewidth="16" tileheight="16" tilecount="572" columns="22">
 <editorsettings>
  <export target="TilesetFloor.tres" format="Godot"/>
 </editorsettings>
 <properties>
  <property name="projectRoot" value="./../../"/>
 </properties>
 <image source="../../gfx/tiles/TilesetFloor.png" width="352" height="417"/>
 <tile id="198">
  <properties>
   <property name="projectRoot" value="./../"/>
  </properties>
 </tile>
 <tile id="242" probability="0.015"/>
 <tile id="243" probability="0.015"/>
 <tile id="245" probability="0.5"/>
 <tile id="264" probability="5"/>
 <tile id="265" probability="0.25"/>
 <tile id="266" probability="0.3"/>
 <tile id="267" probability="0.3"/>
 <tile id="268" probability="0.5"/>
 <wangsets>
  <wangset name="Ground" type="corner" tile="-1">
   <wangcolor name="Dirt" color="#ff0000" tile="-1" probability="1"/>
   <wangcolor name="Grass" color="#00ff00" tile="-1" probability="1"/>
   <wangtile tileid="154" wangid="0,2,0,1,0,2,0,2"/>
   <wangtile tileid="155" wangid="0,2,0,1,0,1,0,2"/>
   <wangtile tileid="156" wangid="0,2,0,2,0,1,0,2"/>
   <wangtile tileid="176" wangid="0,1,0,1,0,2,0,2"/>
   <wangtile tileid="177" wangid="0,1,0,1,0,1,0,1"/>
   <wangtile tileid="178" wangid="0,2,0,2,0,1,0,1"/>
   <wangtile tileid="181" wangid="0,1,0,2,0,1,0,1"/>
   <wangtile tileid="182" wangid="0,1,0,1,0,2,0,1"/>
   <wangtile tileid="198" wangid="0,1,0,2,0,2,0,2"/>
   <wangtile tileid="199" wangid="0,1,0,2,0,2,0,1"/>
   <wangtile tileid="200" wangid="0,2,0,2,0,2,0,1"/>
   <wangtile tileid="203" wangid="0,2,0,1,0,1,0,1"/>
   <wangtile tileid="204" wangid="0,1,0,1,0,1,0,2"/>
   <wangtile tileid="242" wangid="0,1,0,1,0,1,0,1"/>
   <wangtile tileid="243" wangid="0,1,0,1,0,1,0,1"/>
   <wangtile tileid="244" wangid="0,2,0,2,0,2,0,2"/>
   <wangtile tileid="245" wangid="0,2,0,2,0,2,0,2"/>
   <wangtile tileid="264" wangid="0,2,0,2,0,2,0,2"/>
   <wangtile tileid="265" wangid="0,2,0,2,0,2,0,2"/>
   <wangtile tileid="266" wangid="0,2,0,2,0,2,0,2"/>
   <wangtile tileid="267" wangid="0,2,0,2,0,2,0,2"/>
   <wangtile tileid="268" wangid="0,2,0,2,0,2,0,2"/>
  </wangset>
 </wangsets>
</tileset>
