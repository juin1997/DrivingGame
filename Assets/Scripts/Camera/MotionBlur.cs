using UnityEngine;
using System.Collections;

public class MotionBlur : PostEffectsBase
{

    public Shader motionBlurShader;
    private Material motionBlurMaterial = null;

    public Material material
    {
        get
        {
            motionBlurMaterial = CheckShaderAndCreateMaterial(motionBlurShader, motionBlurMaterial);
            return motionBlurMaterial;
        }
    }

    // 模糊参数，值越大，运动拖尾的效果越明显
    [Range(0.0f, 0.9f)]
    public float blurAmount = 0.5f;

    // 保存之前图像叠加结果的加速纹理
    private RenderTexture accumulationTexture;

    void OnDisable()
    {
        // 立即销毁，是因为下一次开始应用运动模糊是要重新叠加图像
        DestroyImmediate(accumulationTexture);
    }

    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if (material != null)
        {
            // 判断用于混合图像的加速纹理是否满足条件，不满足，重新创建一个适合当前分辨率的加速纹理
            if (accumulationTexture == null || accumulationTexture.width != src.width || accumulationTexture.height != src.height)
            {
                DestroyImmediate(accumulationTexture);
                accumulationTexture = new RenderTexture(src.width, src.height, 0)
                {
                    // 自己控制该变量的销毁，这个属性让变量不会显示再Hierarchy中，也不会保存再场景中
                    hideFlags = HideFlags.HideAndDontSave
                };
                Graphics.Blit(src, accumulationTexture);
            }

            // 纹理恢复操作，恢复操作发生在渲染到纹理而该纹理又没有被提前清空或侨汇的情况下
            // We are accumulating motion over frames without clear/discard
            // by design, so silence any performance warnings from Unity
            accumulationTexture.MarkRestoreExpected();

            material.SetFloat("_BlurAmount", 1.0f - blurAmount);

            Graphics.Blit(src, accumulationTexture, material);
            Graphics.Blit(accumulationTexture, dest);
        }
        else
        {
            Graphics.Blit(src, dest);
        }
    }
}
