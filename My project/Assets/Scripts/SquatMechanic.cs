    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class SquatMechanic : MonoBehaviour
    {
        private int currentKey = 0;
        public KeyCode[] squatSequence = {KeyCode.LeftArrow, KeyCode.DownArrow, KeyCode.RightArrow, KeyCode.DownArrow};
        private float gameTimer = 15f;
        private SquatScore squatScore;


        public Transform leftPoint;
        public Transform downPoint;
        public Transform rightPoint;

        // Start is called before the first frame update
        void Start()
        {
            squatScore = FindObjectOfType<SquatScore>();            
        }

        // Update is called once per frame
        void Update()
        {
            if(gameTimer > 0f){
                if(Input.GetKeyDown(squatSequence[currentKey])){
                    
                    if (currentKey == 0)
                    {
                        transform.position = leftPoint.position;
                    }
                    else if (currentKey == 1)
                    {
                        transform.position = downPoint.position;
                    }
                    else if (currentKey == 2)
                    {
                        transform.position = rightPoint.position;
                    }
                    else if (currentKey == 3 && squatSequence[currentKey] == KeyCode.DownArrow) // Special case for going down from the right
                    {
                        transform.position = downPoint.position;
                    }

                    currentKey++;
                    squatScore.IncrementScore();

                    if (currentKey == squatSequence.Length)
                    {
                        currentKey = 0;
                    }


                }
            }
            
        }
    }
