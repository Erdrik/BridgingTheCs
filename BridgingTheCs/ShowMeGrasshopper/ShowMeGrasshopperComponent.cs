using System;
using System.Collections.Generic;
using TheBridgeSharp.CPPWrapper;

using Grasshopper.Kernel;
using Rhino.Geometry;

// In order to load the result of this wizard, you will also need to
// add the output bin/ folder of this project to the list of loaded
// folder in Grasshopper.
// You can use the _GrasshopperDeveloperSettings Rhino command for that.

namespace ShowMeGrasshopper
{
    public class ShowMeGrasshopperComponent : GH_Component
    {
        /// <summary>
        /// Each implementation of GH_Component must provide a public 
        /// constructor without any arguments.
        /// Category represents the Tab in which the component will appear, 
        /// Subcategory the panel. If you use non-existing tab or panel names, 
        /// new tabs/panels will automatically be created.
        /// </summary>
        public ShowMeGrasshopperComponent()
          : base("ShowMeGrasshopper_Intersects", "SMG_I",
              "Check that a point exists within a rectangle.",
              "Intersect", "Shape")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddRectangleParameter("Rectangle", "R", "Rectangle for colliding.", GH_ParamAccess.item);
            pManager.AddPointParameter("Point", "P", "Point for colliding.", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Intersects", "I", "If the point intersects the rectangle", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object can be used to retrieve data from input parameters and 
        /// to store data in output parameters.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            var rect = Rectangle3d.Unset;
            var point = Point3d.Origin;

            if (!DA.GetData(0, ref rect)) return;
            if (!DA.GetData(1, ref point)) return;

            Rectangle rectangle = new Rectangle();
            var bottomLeft = rect.Corner(0);
            rectangle.SetPosition((float)bottomLeft.X, (float)bottomLeft.Y);
            rectangle.SetDimensions((float)rect.Width, (float)rect.Height);
            var intersects = rectangle.PointIsInside((float)point.X, (float)point.Y);

            DA.SetData(0, intersects ? "True" : "False");
        }

        /// <summary>
        /// The Exposure property controls where in the panel a component icon 
        /// will appear. There are seven possible locations (primary to septenary), 
        /// each of which can be combined with the GH_Exposure.obscure flag, which 
        /// ensures the component will only be visible on panel dropdowns.
        /// </summary>
        public override GH_Exposure Exposure {
            get { return GH_Exposure.primary; }
        }

        /// <summary>
        /// Provides an Icon for every component that will be visible in the User Interface.
        /// Icons need to be 24x24 pixels.
        /// </summary>
        protected override System.Drawing.Bitmap Icon {
            get {
                // You can add image files to your project resources and access them like this:
                //return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Each component must have a unique Guid to identify it. 
        /// It is vital this Guid doesn't change otherwise old ghx files 
        /// that use the old ID will partially fail during loading.
        /// </summary>
        public override Guid ComponentGuid {
            get { return new Guid("fdd31112-5f42-4cba-8674-64bfff7fee1f"); }
        }
    }
}
