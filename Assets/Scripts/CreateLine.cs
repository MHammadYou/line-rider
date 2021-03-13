using UnityEngine;

public class CreateLine : MonoBehaviour
{
    public GameObject line;

    Line activeLine;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newLine = Instantiate(line);
            activeLine = newLine.GetComponent<Line>();
        }

        if (Input.GetMouseButtonUp(0)) { activeLine = null; }

        if (activeLine != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePos);
        }
    }
}
