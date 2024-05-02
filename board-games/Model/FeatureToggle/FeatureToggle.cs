namespace board_games.src.FeatureToggle
{
    public class FeatureToggle
    {
        private Dictionary<string, bool> featureStates;

        public FeatureToggle()
        {
            featureStates = new Dictionary<string, bool>();
        }

        public FeatureToggle(Dictionary<string, bool> featureState)
        {
            featureStates = featureState;
        }

        public FeatureToggle(List<string> featureNames)
        {
            featureStates = new Dictionary<string, bool>();
            // add each feature name from the list to the dictionary; set to false as default state
            foreach (var option in featureNames)
            {
                featureStates.Add(option, false);
            }
        }

        public void DefaultSettings()
        {
            foreach (KeyValuePair<string, bool> feature in featureStates)
            {
                featureStates[feature.Key] = false;
            }
        }

        /// <summary>
        /// Get state of feature; if feature does not exist, return false
        /// </summary>
        /// <param name="featureToGetStateOf"></param>
        /// <returns></returns>
        public bool GetFeatureState(string featureToGetStateOf)
        {
            if (string.IsNullOrEmpty(featureToGetStateOf))
            {
                throw new ArgumentNullException("Provided feature name is null!");
            }

            if (featureStates.ContainsKey(featureToGetStateOf))
            {
                return featureStates[featureToGetStateOf];
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Enables given feature if it exists; throws exception otherwise
        /// </summary>
        /// <param name="featureToEnable"></param>
        /// <returns></returns>
        public void EnableFeature(string featureToEnable)
        {
            if (string.IsNullOrEmpty(featureToEnable))
            {
                throw new ArgumentNullException("Provided feature name is null!");
            }

            if (!featureStates.ContainsKey(featureToEnable))
            {
                throw new ArgumentException("Feature does not exist!");
            }
            featureStates[featureToEnable] = true;
        }

        /// <summary>
        /// Disables given feature if it exists; throws exception otherwise
        /// </summary>
        /// <param name="featureToDisable"></param>
        /// <returns></returns>
        public void DisableFeature(string featureToDisable)
        {
            if (string.IsNullOrEmpty(featureToDisable))
            {
                throw new ArgumentNullException("Provided feature name is null!");
            }

            if (!featureStates.ContainsKey(featureToDisable))
            {
                throw new ArgumentException("Feature does not exist!");
            }
            featureStates[featureToDisable] = false;
        }

        public void AddFeature(string featureToAdd)
        {
            if (string.IsNullOrEmpty(featureToAdd))
            {
                throw new ArgumentNullException("Provided feature name is null!");
            }

            featureStates.Add(featureToAdd, false);
        }
        public void RemoveFeature(string featureToRemove)
        {
            if (string.IsNullOrEmpty(featureToRemove))
            {
                throw new ArgumentNullException("Provided feature name is null!");
            }

            if (!featureStates.Remove(featureToRemove))
            {
                throw new ArgumentException("Feature does not exist!");
            }
        }
        public int GetLength()
        {
            return featureStates.Count();
        }
    }
}