using System;
using System.Diagnostics.Contracts;
using Windows.Foundation;

namespace Windows.UI.Xaml
{
	public partial class RectHelper
	{
		public static Rect Empty { get; } = new Rect(0, 0, 0, 0);
		public static Rect FromCoordinatesAndDimensions(float x, float y, float width, float height)
		{
			return new Rect(x, y, width, height);
		}
		public static Rect FromPoints(Point point1, Point point2)
		{
			return new Rect(point1, point2);
		}
		public static Rect FromLocationAndSize(Point location, Size size)
		{
			return new Rect(location, size);
		}

		public static bool GetIsEmpty(Rect target)
		{
			return target.Equals(Empty);
		}
		public static float GetBottom(Rect target)
		{
			return (float)target.Bottom;
		}
		public static float GetLeft(Rect target)
		{
			return (float)target.Left;
		}
		public static float GetRight(Rect target)
		{
			return (float)target.Right;
		}
		public static float GetTop(Rect target)
		{
			return (float)target.Top;
		}
		public static bool Contains(Rect target, Point point)
		{
			return target.Left <= point.X && target.Top <= point.Y && target.Right >= point.X && target.Bottom >= point.Y;
		}
		public static bool Equals(Rect target, Rect value)
		{
			return target.Equals(value);
		}
		public static Rect Intersect(Rect target, Rect rect)
		{
			var left = Math.Max(target.Left, rect.Left);
			var right = Math.Min(target.Right, rect.Right);
			if (left > right)
			{
				return Empty; // no intersection on the X axis
			}

			var top = Math.Max(target.Top, rect.Top);
			var bottom = Math.Min(target.Bottom, rect.Bottom);
			if (top > bottom)
			{
				return Empty; // no intersection on the Y axis
			}

			return new Rect(left, top, right - left, bottom - top);
		}
		public static Rect Union(Rect target, Point point)
		{
			var left = Math.Min(target.Left, point.X);
			var right = Math.Max(target.Right, point.X);
			var top = Math.Min(target.Top, point.Y);
			var bottom = Math.Max(target.Bottom, point.Y);

			return new Rect(left, top, right - left, bottom - top);
		}
		public static Rect Union(Rect target, Rect rect)
		{
			var left = Math.Min(target.Left, rect.Left);
			var right = Math.Max(target.Right, rect.Right);
			var top = Math.Min(target.Top, rect.Top);
			var bottom = Math.Max(target.Bottom, rect.Bottom);

			return new Rect(left, top, right - left, bottom - top);
		}
	}
}
