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
float RandRange(float from, float to);
/// => var r = MathExt.RandRange(0.0f, 100.0f);

/// Generate a random Vector2 between two values.
Vector2 RandRange(Vector2 from, Vector2 to);
/// => var r = MathExt.RandRange(Vector2.Zero, Vector2.One);

/// Map a value from one set of bounds to another.
float Map(float value, float istart, float istop, float ostart, float ostop);
/// => var v = MathExt.Map(10, 0, 10, 0, 1);

/// Convert a float to string, using a '.' for separator
string FloatToString(float value);
/// => var s = MathExt.FloatToString(3.1415f);
```