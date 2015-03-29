/*
 * LinAlgebr draft
 * Vector operations
 * Eftal GEZER
 * Gebze Institute of Technology
 * Gebze, Kocaeli, Turkey
 * eftalgezer at gmail dot com
 * 2014-05-23 23:44:10 
*/

using System;

namespace LinAlgebr.VectorOp{
	public class Vector{
		public double x, y, z;
		
		public static Vector operator +(Vector v1, Vector v2){
        	return new Vector() { x = v1.x+v2.x, y=v1.y+v2.y, z=v1.z+v2.z };
    	}
		
		public static Vector operator -(Vector v1, Vector v2){
        	return new Vector() { x = v1.x-v2.x, y=v1.y-v2.y, z=v1.z-v2.z };
    	}		
		
		public static Vector operator *(double c, Vector v){
			return new Vector(){x=c*v.x, y=c*v.y, z=c*v.z};
    	}
		
		public static Vector operator *(Vector v, double c){
			return new Vector(){x=c*v.x, y=c*v.y, z=c*v.z};
    	}
		
		public static Vector operator *(Vector v1,Vector v2){
			return new Vector(){x=v1.y*v2.z+v1.z+v2.y,y=v1.x*v2.z+v1.z+v2.x,z=v1.x*v2.y+v1.y+v2.z};
		}
		
		public static double DotProduct(Vector v1, Vector v2){
			return v1.x*v2.x+v1.y*v2.y+v1.z*v2.z;
    	}
		
		public double Length(){
			return Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2));
		}
		
		public Vector Normalise(){
			return new Vector(){x=this.x/this.Length(), y=this.y/this.Length(), z=this.z/this.Length()};
		}
		
		public override string ToString ()
		{
			return string.Format ("({0}, {1}, {2})",this.x,this.y,this.z);
		}
	}
}
