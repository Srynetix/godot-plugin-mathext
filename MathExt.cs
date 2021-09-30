using Godot;

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
    }
}