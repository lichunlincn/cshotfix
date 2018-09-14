using UnityEngine;
using System.Collections;
using System.IO;
namespace LCL
{
    public class CoroutineCom : MonoBehaviour
    {
        public Coroutine OnStartCoroutine(IEnumerator func)
        {
            return StartCoroutine(func);
        }
        public IEnumerator OnIEnumeratorFunc(params IEnumerator[] func)
        {
            for (int i = 0; i < func.Length; ++i)
            {
                yield return OnStartCoroutine(func[i]);
                Debug.Log("Test Ienumerator" + i.ToString());
            }
        }
    }
}