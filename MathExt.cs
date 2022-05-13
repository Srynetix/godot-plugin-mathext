using Godot;
using System.Globalization;

namespace SxGD
{
    public static class MathExt
    {
        public static Vector3 LerpVector3(Vector3 from, Vector3 to, float weight)
        {
            return new Vector3(
                Mathf.Lerp(from.x, to.x, weight),
                Mathf.Lerp(from.y, to.y, weight),
                Mathf.Lerp(from.z, to.z, weight)
            );
        }

        public static Transform AlignWithY(Transform transform, Vector3 newY)
        {
            transform.basis.y = newY;
            transform.basis.x = -transform.basis.z.Cross(newY);
            transform.basis = transform.basis.Orthonormalized();
            return transform;
        }

        public static Transform InterpolateAlignWithY(Transform transform, Vector3 newY, float weight)
        {
            var aligned = AlignWithY(transform, newY);
            return transform.InterpolateWith(aligned, weight);
        }

        public static float RandRange(float from, float to)
        {
            return (float)GD.RandRange(from, to);
        }

        public static Vector2 RandRange(Vector2 from, Vector2 to)
        {
            return new Vector2(
                MathExt.RandRange(from.x, to.x),
                MathExt.RandRange(from.y, to.y)
            );
        }

        public static float Map(float value, float istart, float istop, float ostart, float ostop)
        {
            return ostart + ((ostop - ostart) * ((value - istart) / (istop - istart)));
        }

        public static string FloatToString(float value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
