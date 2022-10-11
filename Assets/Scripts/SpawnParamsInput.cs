using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class SpawnParamsInput : MonoBehaviour
{
    [SerializeField] private InputField SpawnTimeInputField;
    [SerializeField] private InputField SpeedInputField;
    [SerializeField] private InputField HideDistanceInputField;

    private void Start()
    {
        SpawnTimeInputField.SetTextWithoutNotify(CubeSpawner.SpawnTime.ToString());
        SpeedInputField.SetTextWithoutNotify(CubeSpawner.CubeSpeed.ToString());
        HideDistanceInputField.SetTextWithoutNotify(CubeSpawner.CubeHideDistance.ToString());
    }

    public void SpawnTimeChanged()
    {
        float newValue = float.Parse(SpawnTimeInputField.text, NumberStyles.Any, CultureInfo.InvariantCulture.NumberFormat);

        if (newValue <= 0)
        {
            SpawnTimeInputField.SetTextWithoutNotify(CubeSpawner.SpawnTime.ToString());
        }
        else
        {
            CubeSpawner.SpawnTime = newValue;
        }
    }

    public void SpeedChanged()
    {
        float newValue = float.Parse(SpeedInputField.text, NumberStyles.Any, CultureInfo.InvariantCulture.NumberFormat);

        if (newValue <= 0)
        {
            SpeedInputField.SetTextWithoutNotify(CubeSpawner.CubeSpeed.ToString());
        }
        else
        {
            CubeSpawner.CubeSpeed = newValue;
        }
    }

    public void HideDistanceChanged()
    {
        float newValue = float.Parse(HideDistanceInputField.text, NumberStyles.Any, CultureInfo.InvariantCulture.NumberFormat);

        if (newValue <= 0)
        {
            HideDistanceInputField.SetTextWithoutNotify(CubeSpawner.CubeHideDistance.ToString());
        }
        else
        {
            CubeSpawner.CubeHideDistance = newValue;
        }
    }
}
