using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Line : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCol;

    private List<Vector2> _points;

    public void UpdateLine(Vector2 mousePos)
    {
        if (_points == null)
        {
            _points = new List<Vector2>();
            SetPoint(mousePos);
            return;
        }
        
        if (Vector2.Distance(_points.Last(), mousePos) > .1f)
        {
            SetPoint(mousePos);
        }
    }
    void SetPoint(Vector2 point)
    {
        _points.Add(point);

        lineRenderer.positionCount = _points.Count;
        lineRenderer.SetPosition(_points.Count - 1, point);

        if (_points.Count > 1)
        {
            edgeCol.points = _points.ToArray();
        }
    } 
}
