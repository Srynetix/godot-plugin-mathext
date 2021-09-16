# Math Extensions for Godot Engine (3.3.3, C#)

Extensions methods and static methods for Godot Engine.

## How to install

Use `git` submodules: open a command prompt in your project folder and then:

```
git submodule add https://github.com/Srynetix/godot-plugin-mathext addons/mathext
```

## How to use

### MathExt

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
```

### ColorExt

```cs
using ColorExt;

/// Create a color with a floating point alpha value.
Color WithAlphaf(this Color color, float alpha);
/// => var color = Colors.Blue.WithAlphaf(0.25f);

/// Create a color with an integer alpha value.
Color WithAlphai(this Color color, int alpha);
/// => var color = Colors.Blue.WithAlphai(64);
```