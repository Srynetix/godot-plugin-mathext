using Godot;

public static class ColorExt {
    public static Color WithAlphaf(this Color color, float alpha) {
        var output = color;
        output.a = alpha;
        return output;
    }

    public static Color WithAlphai(this Color color, int alpha) {
        return color.WithAlphaf(alpha / 255.0f);
    }
}