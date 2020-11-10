Shader "Hidden/GrayImageEffectShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
       _LuminosityAmount("GrayScale Amount",Range(0.0,1)) = 1.0
    }
SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex vert_img
            #pragma fragment frag
            #pragma fragmentoption ARB_precision_hint_fastest

            #include "UnityCG.cginc"

            sampler2D _MainTex;
            fixed _LuminosityAmount;

            fixed4 frag (v2f_img i) : SV_Target
            {
                fixed4 renderTex = tex2D(_MainTex, i.uv);

                float luminosity = 0.299 * renderTex.r + 0.587 * renderTex.g + 0.114 * renderTex.b;

                fixed4 col = lerp(renderTex, luminosity,_LuminosityAmount);

                return col;
            }
            ENDCG
        }
    }
}
