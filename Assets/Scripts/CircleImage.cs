
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class CircleImage : Image
{
    /// <summary>
    /// 圆形由多少个三角形组成
    /// </summary>
    private int segement = 100;

    protected override void OnPopulateMesh(VertexHelper vh)
    {
        vh.Clear();

        float width = rectTransform.rect.width;
        float height = rectTransform.rect.height;

        Vector4 uv = overrideSprite != null ? DataUtility.GetOuterUV(overrideSprite) : Vector4.zero;
        float uv_width = uv.z - uv.x;
        float uv_height = uv.w - uv.y;
        Vector2 uvCenter = new Vector2(uv_width * 0.5f, uv_height * 0.5f);
        Vector2 convertRatio = new Vector2(uv_width / width, uv_height / height);

        float radian = 2 * Mathf.PI / segement;
        float radius = width * 0.5f;

        UIVertex origin = new UIVertex();
        origin.color = color;
        origin.position = Vector3.zero;
        origin.uv0 = new Vector2(origin.position.x * convertRatio.x + uvCenter.x, origin.position.y * convertRatio.y + uvCenter.y);
        vh.AddVert(origin);

        int vertexCount = segement + 1;
        float curRadian = 0;
        for (int i = 0; i < vertexCount; i++)
        {
            float x = Mathf.Cos(curRadian) * radius;
            float y = Mathf.Sin(curRadian) * radius;
            curRadian += radian;

            UIVertex vertexTemp = new UIVertex();
            vertexTemp.color = color;
            vertexTemp.position = new Vector2(x, y);
            vertexTemp.uv0 = new Vector2(vertexTemp.position.x * convertRatio.x + uvCenter.x, vertexTemp.position.y * convertRatio.y + uvCenter.y);
            vh.AddVert(vertexTemp);
        }

        int id = 1;
        for (int i = 0; i < segement; i++)
        {
            vh.AddTriangle(id, 0, id + 1);
            id++;
        }
    }
}
