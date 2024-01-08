using System;

namespace Rectangles;

public static class RectanglesTask
{
    // Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
    public static bool AreIntersected(Rectangle r1, Rectangle r2)
    {
        // так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
        if (r1.Left > r2.Right  || r2.Left > r1.Right)
        {
            return false;
        }
        else if (r1.Top > r2.Bottom || r2.Top > r1.Bottom)
        {
            return false;
        }

        return true;
    }

    // Площадь пересечения прямоугольников
    public static int IntersectionSquare(Rectangle r1, Rectangle r2)
    {
        int left = Math.Max(r1.Left, r2.Left);
        int top = Math.Min(r1.Bottom, r2.Bottom);
        int right = Math.Min(r1.Right, r2.Right);
        int bottom = Math.Max(r1.Top, r2.Top);

        int width = right - left;
        int height = top - bottom;

        if (width < 0 || height < 0)
            return 0;

        return width * height;
    }

    // Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
    // Иначе вернуть -1
    // Если прямоугольники совпадают, можно вернуть номер любого из них.
    public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
    {
        if (r1.Left >= r2.Left && r1.Top >= r2.Top && r1.Right <= r2.Right && r1.Bottom <= r2.Bottom)
        {
            return 0;
        }
        else if (r2.Left >= r1.Left && r2.Top >= r1.Top && r2.Right <= r1.Right && r2.Bottom <= r1.Bottom)
        { 
            return 1; 
        }
        else
        {
            return -1;
        }
    }
}