using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class PostEffectsBase : MonoBehaviour
{
    protected void Start()
    {
        CheckResources();
    }

    // 开始时调用
    protected void CheckResources()
    {
        bool isSupported = CheckSupport();
        if (!isSupported) NotSupported();
    }

    // 当平台不支持时调用
    private void NotSupported()
    {
        enabled = false;
    }

    // 检测这个平台是否支持
    protected bool CheckSupport()
    {
        if (SystemInfo.supportsImageEffects == false || SystemInfo.supportsRenderTextures == false)
        {
            return false;
        }
        else return true;
    }

    // 创建用于处理渲染纹理的材质
    protected Material CheckShaderAndCreateMaterial(Shader shader, Material material)
    {
        if (shader == null) return null;
        if (shader.isSupported && material && material.shader == shader) return material;
        if (!shader.isSupported) return null;
        else
        {
            material = new Material(shader)
            {
                hideFlags = HideFlags.DontSave
            };
            if (material) return material;
            else return null;
        }
    }
}
