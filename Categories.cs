using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Organiser
{
    public class Categories
    {
        private int CategoryID;
        private String CategoryName;
        private Color Color;
        public Categories(int categoryID, String categoryName, Color color)
        {
            this.CategoryID = categoryID;
            this.CategoryName = categoryName;
            this.Color = color;
        }

        public int getCategoryID()
        {
            return CategoryID;
        }

        public String getCategoryName()
        {
            return CategoryName;
        }

        public Color getColor()
        {
            return Color;
        }


        public void setCategoryName(String categoryName)
        {
            this.CategoryName = categoryName;
        }

        public void setColor(Color color)
        {
            this.Color = color;
        }
    }
}
