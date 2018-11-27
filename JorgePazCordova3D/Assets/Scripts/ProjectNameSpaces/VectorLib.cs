using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VectorLib {
    public class VectorExt {
        static public Vector3 zeroX { get { return new Vector3(0, 1, 1); } }
        static public Vector3 zeroY { get { return new Vector3(1, 0, 1); } }
        static public Vector3 zeroZ { get { return new Vector3(1, 1, 0); } }

        static public Vector3 OneByOneProduct (Vector3 first, Vector3 second){
            return new Vector3(first.x * second.x, first.y * second.y, first.z * second.z);
        }
    }
}
//braper
//extenciones 