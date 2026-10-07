import json, os, io

G = json.load(open('.gen-guids.json'))
os.makedirs('Assets/Art/Sprites', exist_ok=True)
os.makedirs('Assets/Prefabs/Generated', exist_ok=True)

META = """fileFormatVersion: 2
guid: {guid}
TextureImporter:
  internalIDToNameTable: []
  externalObjects: {{}}
  serializedVersion: 13
  mipmaps:
    mipMapMode: 0
    enableMipMap: 0
    sRGBTexture: 1
    linearTexture: 0
    fadeOut: 0
    borderMipMap: 0
    mipMapsPreserveCoverage: 0
    alphaTestReferenceValue: 0.5
    mipMapFadeDistanceStart: 1
    mipMapFadeDistanceEnd: 3
  bumpmap:
    convertToNormalMap: 0
    externalNormalMap: 0
    heightScale: 0.25
    normalMapFilter: 0
    flipGreenChannel: 0
  isReadable: 0
  streamingMipmaps: 0
  streamingMipmapsPriority: 0
  vTOnly: 0
  ignoreMipmapLimit: 0
  grayScaleToAlpha: 0
  generateCubemap: 6
  cubemapConvolution: 0
  seamlessCubemap: 0
  textureFormat: 1
  maxTextureSize: 2048
  textureSettings:
    serializedVersion: 2
    filterMode: 1
    aniso: 1
    mipBias: 0
    wrapU: 1
    wrapV: 1
    wrapW: 1
  nPOTScale: 0
  lightmap: 0
  compressionQuality: 50
  spriteMode: 1
  spriteExtrude: 1
  spriteMeshType: 0
  alignment: 0
  spritePivot: {{x: 0.5, y: 0.5}}
  spritePixelsToUnits: 100
  spriteBorder: {{x: {bl}, y: {bb}, z: {br}, w: {bt}}}
  spriteGenerateFallbackPhysicsShape: 1
  alphaUsage: 1
  alphaIsTransparency: 1
  spriteTessellationDetail: -1
  textureType: 8
  textureShape: 1
  singleChannelComponent: 0
  flipbookRows: 1
  flipbookColumns: 1
  maxTextureSizeSet: 0
  compressionQualitySet: 0
  textureFormatSet: 0
  ignorePngGamma: 0
  applyGammaDecoding: 0
  swizzle: 50462976
  cookieLightType: 0
  platformSettings:
  - serializedVersion: 4
    buildTarget: DefaultTexturePlatform
    maxTextureSize: 1024
    resizeAlgorithm: 0
    textureFormat: -1
    textureCompression: 0
    compressionQuality: 50
    crunchedCompression: 0
    allowsAlphaSplitting: 0
    overridden: 0
    ignorePlatformSupport: 0
    androidETC2FallbackOverride: 0
    forceMaximumCompressionQuality_BC6H_BC7: 0
  - serializedVersion: 4
    buildTarget: Android
    maxTextureSize: 1024
    resizeAlgorithm: 0
    textureFormat: -1
    textureCompression: 1
    compressionQuality: 50
    crunchedCompression: 0
    allowsAlphaSplitting: 0
    overridden: 0
    ignorePlatformSupport: 0
    androidETC2FallbackOverride: 0
    forceMaximumCompressionQuality_BC6H_BC7: 0
  spriteSheet:
    serializedVersion: 2
    sprites: []
    outline: []
    customData:
    physicsShape: []
    bones: []
    spriteID:
    internalID: 0
    vertices: []
    indices:
    edges: []
    weights: []
    secondaryTextures: []
    spriteCustomMetadata:
      entries: []
    nameFileIdTable: {{}}
  mipmapLimitGroupName:
  pSDRemoveMatte: 0
  userData:
  assetBundleName:
  assetBundleVariant:
"""

SPRITES = {
    'sprite_ball_core':   (0, 0, 0, 0),
    'sprite_orbit_ring':  (0, 0, 0, 0),
    'sprite_magnet_node': (0, 0, 0, 0),
    'sprite_peg_bumper':  (0, 0, 0, 0),
    'sprite_cup_finish':  (0, 0, 0, 0),
    'sprite_board_frame': (64, 64, 64, 64),
    'sprite_glow_dot':    (0, 0, 0, 0),
    'sprite_panel_plate': (48, 48, 48, 48),
    'sprite_brand_mark':  (0, 0, 0, 0),
    'icon_close':         (0, 0, 0, 0),
    'icon_pause':         (0, 0, 0, 0),
    'icon_back':          (0, 0, 0, 0),
}

for name in sorted(SPRITES):
    bl, bb, br, bt = SPRITES[name]
    path = 'Assets/Art/Sprites/%s.png.meta' % name
    io.open(path, 'w', encoding='utf-8', newline='\n').write(
        META.format(guid=G[name], bl=bl, bb=bb, br=br, bt=bt))
    print('meta', path, G[name])

PREFAB = """%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1 &{fid}1
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {{fileID: 0}}
  m_PrefabInstance: {{fileID: 0}}
  m_PrefabAsset: {{fileID: 0}}
  serializedVersion: 6
  m_Component:
  - component: {{fileID: {fid}2}}
  - component: {{fileID: {fid}3}}
  m_Layer: 0
  m_Name: {name}
  m_TagString: Untagged
  m_Icon: {{fileID: 0}}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!4 &{fid}2
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {{fileID: 0}}
  m_PrefabInstance: {{fileID: 0}}
  m_PrefabAsset: {{fileID: 0}}
  m_GameObject: {{fileID: {fid}1}}
  serializedVersion: 2
  m_LocalRotation: {{x: 0, y: 0, z: 0, w: 1}}
  m_LocalPosition: {{x: 0, y: 0, z: 0}}
  m_LocalScale: {{x: 1, y: 1, z: 1}}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {{fileID: 0}}
  m_LocalEulerAnglesHint: {{x: 0, y: 0, z: 0}}
--- !u!212 &{fid}3
SpriteRenderer:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {{fileID: 0}}
  m_PrefabInstance: {{fileID: 0}}
  m_PrefabAsset: {{fileID: 0}}
  m_GameObject: {{fileID: {fid}1}}
  m_Enabled: 1
  m_CastShadows: 0
  m_ReceiveShadows: 0
  m_DynamicOccludee: 1
  m_StaticShadowCaster: 0
  m_MotionVectors: 1
  m_LightProbeUsage: 0
  m_ReflectionProbeUsage: 0
  m_RayTracingMode: 0
  m_RayTraceProcedural: 0
  m_RayTracingAccelStructBuildFlagsOverride: 0
  m_RayTracingAccelStructBuildFlags: 1
  m_SmallMeshCulling: 1
  m_ForceMeshLod: -1
  m_MeshLodSelectionBias: 0
  m_RenderingLayerMask: 1
  m_RendererPriority: 0
  m_Materials:
  - {{fileID: 10754, guid: 0000000000000000f000000000000000, type: 0}}
  m_StaticBatchInfo:
    firstSubMesh: 0
    subMeshCount: 0
  m_StaticBatchRoot: {{fileID: 0}}
  m_ProbeAnchor: {{fileID: 0}}
  m_LightProbeVolumeOverride: {{fileID: 0}}
  m_ScaleInLightmap: 1
  m_ReceiveGI: 1
  m_PreserveUVs: 0
  m_IgnoreNormalsForChartDetection: 0
  m_ImportantGI: 0
  m_StitchLightmapSeams: 1
  m_SelectedEditorRenderState: 0
  m_MinimumChartSize: 4
  m_AutoUVMaxDistance: 0.5
  m_AutoUVMaxAngle: 89
  m_LightmapParameters: {{fileID: 0}}
  m_SortingLayerID: 0
  m_SortingLayer: 0
  m_SortingOrder: {order}
  m_Sprite: {{fileID: 21300000, guid: {sprite}, type: 3}}
  m_Color: {{r: {r}, g: {g}, b: {b}, a: {a}}}
  m_FlipX: 0
  m_FlipY: 0
  m_DrawMode: 1
  m_Size: {{x: {w}, y: {h}}}
  m_AdaptiveModeThreshold: 0.5
  m_SpriteTileMode: 0
  m_WasSpriteAssigned: 1
  m_MaskInteraction: 0
  m_SpriteSortPoint: 0
"""

PREFAB_META = """fileFormatVersion: 2
guid: {guid}
PrefabImporter:
  externalObjects: {{}}
  userData:
  assetBundleName:
  assetBundleVariant:
"""

PREFABS = [
    ('BoardFrame', '9310000', 'sprite_board_frame', -18, 4.06, 5.85, (0.1451, 0.7882, 0.9373, 0.95)),
    ('FinishCup',  '9320000', 'sprite_cup_finish',  -16, 1.28, 0.72, (1, 1, 1, 1)),
    ('Peg',        '9330000', 'sprite_peg_bumper',  -14, 0.27, 0.27, (1, 1, 1, 1)),
    ('OrbitRing',  '9340000', 'sprite_orbit_ring',  -12, 0.75, 0.75, (1, 1, 1, 1)),
    ('TrailDot',   '9350000', 'sprite_glow_dot',     -9, 0.13, 0.13, (0.1451, 0.7882, 0.9373, 0.9)),
    ('MagnetNode', '9360000', 'sprite_magnet_node',  -8, 0.55, 0.55, (1, 1, 1, 1)),
    ('BallCore',   '9370000', 'sprite_ball_core',    -6, 0.35, 0.35, (1, 1, 1, 1)),
    ('SparkDot',   '9380000', 'sprite_glow_dot',     -4, 0.16, 0.16, (0.9608, 0.7686, 0.2706, 1)),
]

for name, fid, sprite, order, w, h, col in PREFABS:
    body = PREFAB.format(fid=fid, name=name, order=order, sprite=G[sprite],
                         w=w, h=h, r=col[0], g=col[1], b=col[2], a=col[3])
    io.open('Assets/Prefabs/Generated/%s.prefab' % name, 'w', encoding='utf-8', newline='\n').write(body)
    io.open('Assets/Prefabs/Generated/%s.prefab.meta' % name, 'w', encoding='utf-8', newline='\n').write(
        PREFAB_META.format(guid=G['PREFAB_' + name]))
    print('prefab', name, 'order', order, 'size', w, h, G['PREFAB_' + name])
