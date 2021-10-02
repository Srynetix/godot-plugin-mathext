# Math Extensions for Godot Engine (3.3.3, C#)

Extensions methods and static methods for Godot Engine.

## How to install

Use `git` submodules: open a command prompt in your project folder and then:

```
git submodule add https://github.com/Srynetix/godot-plugin-mathext addons/mathext
```

## How to use

```cs
/// Lerp a Vector3 towards another using weight.
Vector3 LerpVector3(Vector3 from, Vector3 to, float weight);
/// => var vec3 = MathExt.LerpVector3(vec1, vec2, 0.25f);

/// Align a transform with a Y vector.
Transform AlignWithY(Transform transform, Vector3 newY);
/// => var xform = MathExt.AlignWithY(this.transform, Vector2.Left);

/// Align a transform with a Y vector with interpolation.
Transform InterpolateAlignWithY(Transform transform, Vector3 newY, float weight);
/// => var xform = MathExt.AlignWithY(this.transform, Vector2.Left, 0.25f);

/// Generate a random float between two values.
float RandRange(float from, float to)
/// => var r = MathExt.RandRange(0.0f, 100.0f);
```